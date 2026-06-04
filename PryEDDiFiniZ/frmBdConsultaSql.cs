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
    public partial class frmBdConsultaSql : Form
    {
        public frmBdConsultaSql()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos objBaseDeDatos = new clsBaseDeDatos();
            objBaseDeDatos.Listar(dgvConsultaSql, txtConsultaSql.Text);
        }
    }
}
