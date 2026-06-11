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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        clsArbolBinario objArbolBinario = new clsArbolBinario();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != null && txtNombre.Text != null && txtTramite.Text != null)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }

            clsNodo x = new clsNodo();
            x.Codigo = Convert.ToInt32(txtCodigo.Text);
            x.Nombre = txtNombre.Text;
            x.Tramite = txtTramite.Text;

            objArbolBinario.Agregar(x);
            objArbolBinario.Recorrer(dgvArbolBinario, "InOrden");
            objArbolBinario.Recorrer(cmbCodigo);
            objArbolBinario.Recorrer(trvArbolBinario);
            MessageBox.Show("Agregado"); 
            

            txtCodigo.Text = " ";
            txtNombre.Text = " ";
            txtTramite.Text = " ";
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

        private void rdbInOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInOrden.Checked == true)
            {
                objArbolBinario.Recorrer(dgvArbolBinario, "InOrden");
            }
        }

        private void rdbPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPreOrden.Checked == true)
            {
                objArbolBinario.Recorrer(dgvArbolBinario, "PreOrden");
            }
        }

        private void rdbPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPostOrden.Checked == true)
            {
                objArbolBinario.Recorrer(dgvArbolBinario, "PostOrden");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 codigo = Convert.ToInt32(cmbCodigo.Text);

            objArbolBinario.Eliminar(codigo);

            objArbolBinario.Recorrer(dgvArbolBinario, "InOrden");
            objArbolBinario.Recorrer(cmbCodigo);
            objArbolBinario.Recorrer(trvArbolBinario);

            MessageBox.Show("Eliminado");
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            objArbolBinario.Equilibrar();

            objArbolBinario.Recorrer(dgvArbolBinario, "InOrden");
            objArbolBinario.Recorrer(cmbCodigo);
            objArbolBinario.Recorrer(trvArbolBinario);

            MessageBox.Show("Árbol equilibrado");
        }
    }
}
