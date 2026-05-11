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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble objLista = new clsListaDoble();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            x.Codigo = Convert.ToInt32(txtCodigo.Text);
            x.Nombre = txtNombre.Text;
            x.Tramite = txtTramite.Text;

            objLista.Agregar(x);
            objLista.Recorrer(dgvListaDoble);
            objLista.Recorrer(lstListaDoble);
            objLista.Recorrer(cmbCodigo);
            objLista.Recorrer("ListaDoble.csv");

            txtCodigo.Text = " ";
            txtNombre.Text = " ";
            txtTramite.Text = " ";
        }

        private void ValidarDatos()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != " " && txtTramite.Text != " ")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void txtTramite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           if (objLista.Primero != null)
            {
                Int32 x = Convert.ToInt32(cmbCodigo.Text);
                objLista.Eliminar(x);
                objLista.Recorrer(dgvListaDoble);
                objLista.Recorrer(lstListaDoble);
                objLista.Recorrer(cmbCodigo);
                objLista.Recorrer("ListaDoble.csv");
            }
           else
            {
                MessageBox.Show("La lista esta vacia");
            }
           btnEliminar.Enabled = false;
        }

        private void rdbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            objLista.Recorrer(dgvListaDoble);
            objLista.Recorrer(lstListaDoble);
            objLista.Recorrer(cmbCodigo.Text); 
        }

        private void rdbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            objLista.RecorrerDes(dgvListaDoble);
            objLista.RecorrerDes(lstListaDoble);
            objLista.RecorrerDes(cmbCodigo.Text);
        }
    }
}


