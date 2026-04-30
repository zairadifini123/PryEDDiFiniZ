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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        clsPila objPila = new clsPila();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            x.Codigo = Convert.ToInt32(txtCodigo.Text);
            x.Nombre = txtNombre.Text;
            x.Tramite = txtTramite.Text;

            objPila.Agregar(x);
            objPila.Recorrer(dgvPila);
            objPila.Recorrer(lstPila);
            objPila.Recorrer("Pila.csv");

            txtCodigo.Text = " ";
            txtNombre.Text = " ";
            txtTramite.Text = " ";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objPila.Primero != null)
            {
                lblCodigo.Text = objPila.Primero.Codigo.ToString();
                lblNombre.Text = objPila.Primero.Nombre;
                lblTramite.Text = objPila.Primero.Tramite;

                objPila.Eliminar();
                objPila.Recorrer(dgvPila);
                objPila.Recorrer(lstPila);
                objPila.Recorrer("Pila.csv");
            }
            else
            {
                lblCodigo.Text = " ";
                lblNombre.Text = " ";
                lblTramite.Text = " ";
            }
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
    }
}
