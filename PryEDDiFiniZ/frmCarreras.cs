using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDDiFiniZ
{
    public partial class frmCarreras : Form
    {
        public frmCarreras()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NombreArchivo = "Carreras.csv";
            x.Grabar(txtCarrera.Text);
            x.Recorrer(lstCarrera);
            txtCarrera.Text = "";
        }

        private void txtCarrera_TextChanged(object sender, EventArgs e)
        {
            if (txtCarrera.Text == "")
            {
                btnGrabar.Enabled = false;
            }
            else
            {
                btnGrabar.Enabled = true;
            }
        }

        private void frmCarreras_Load(object sender, EventArgs e)
        {
            btnGrabar.Enabled = false;
        }
    }
}
