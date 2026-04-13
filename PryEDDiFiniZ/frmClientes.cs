using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace PryEDDiFiniZ
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NombreArchivo = "Clientes.csv";
            x.Grabar(txtCodigo.Text, txtNombre.Text, txtDeuda.Text);
            x.Recorrer(dgvClientes);
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDeuda.Clear();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            clsArchivo X = new clsArchivo();
            X.NombreArchivo = "Clientes.CSV";
            if (File.Exists(X.NombreArchivo)) X.Recorrer(dgvClientes); 
        }
    }
}
