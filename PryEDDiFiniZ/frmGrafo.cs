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
    public partial class frmGrafo : Form
    {
        public frmGrafo()
        {
            InitializeComponent();
            objGrafoMatricial.MostrarCiudades(cmbOrigen);
            objGrafoMatricial.MostrarCiudades(cmbDestino);
            objGrafoMatricial.MostrarCiudades(cmbConsultaOrigen);
            objGrafoMatricial.MostrarCiudades(cmbConsultaDestino);
        }

        clsGrafoMatricial objGrafoMatricial = new clsGrafoMatricial();
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (cmbOrigen.Text != "" && cmbDestino.Text != "" && txtPrecio.Text != "")
            {
                btnCargar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
            }

            Int32 origen = cmbOrigen.SelectedIndex;
            Int32 destino = cmbDestino.SelectedIndex;
            Decimal precio = Convert.ToDecimal(txtPrecio.Text);

            objGrafoMatricial.Agregar(origen, destino, precio);
            objGrafoMatricial.MostrarTodo(dgvGrafo);

            MessageBox.Show("Agregado");

            cmbOrigen.SelectedIndex = 0;
            cmbDestino.SelectedIndex = 0;
            txtPrecio.Text = "";
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            objGrafoMatricial.BorrarTodo();
            objGrafoMatricial.MostrarTodo(dgvGrafo);

            MessageBox.Show("Datos borrados");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Int32 origen = cmbOrigen.SelectedIndex;
            Int32 destino = cmbDestino.SelectedIndex;

            Decimal precio;

            precio = objGrafoMatricial.Consultar(origen, destino);

            lblPrecio.Text = precio.ToString();
        }
    }
}
