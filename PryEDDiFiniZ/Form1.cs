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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDesarrollador v = new frmDatosDesarrollador();
            v.ShowDialog();
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColores v = new frmColores();
            v.ShowDialog();
        }

        private void mesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeses v = new frmMeses();
            v.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes v = new frmClientes();
            v.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos v = new frmAlumnos();
            v.ShowDialog();
        }
    }
}
