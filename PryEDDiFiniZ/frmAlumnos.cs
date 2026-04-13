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
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo objAlumno = new clsArchivo();
            objAlumno.NombreArchivo = "Alumnos.csv";
            objAlumno.Grabar(txtCodigo.Text, txtNombre.Text, cmbCarrera.Text);
            objAlumno.Recorrer(dgvAlumnos);
            txtCodigo.Clear();
            txtNombre.Clear();
            cmbCarrera.Text = "";
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            clsArchivo objCarrera = new clsArchivo();
            objCarrera.NombreArchivo = "Carreras.csv";
            if (File.Exists(objCarrera.NombreArchivo)) objCarrera.Recorrer(cmbCarrera);

            clsArchivo objAlumno = new clsArchivo();
            objAlumno.NombreArchivo = "Alumnos.csv";
            if (File.Exists(objAlumno.NombreArchivo)) objAlumno.Recorrer(dgvAlumnos);
        }

        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
