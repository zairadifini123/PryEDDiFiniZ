using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PryEDDiFiniZ
{
    internal class clsArchivo
    {
        public string NombreArchivo = "";

        public void Grabar ()
        {
            StreamWriter AD = new StreamWriter(NombreArchivo);
            AD.WriteLine("Hola");
            AD.Close(); 
        }
        public void Grabar(String Dato)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            AD.WriteLine(Dato);
            AD.Close();
        }

        public void Grabar(String dato, String dato2, String dato3)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            AD.Write(dato);
            AD.Write(";");
            AD.Write(dato2);
            AD.Write(";");
            AD.WriteLine(dato3);
            AD.Close();
        }

        public void Recorrer(ListBox lstDatos)
        {
            lstDatos.Items.Clear();
            String DatoLeido = "";
            StreamReader AD = new StreamReader(NombreArchivo);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                lstDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }

        public void Recorrer(ComboBox cmbDatos)
        {
            String DatoLeido = "";
            cmbDatos.Items.Clear();
            StreamReader AD = new StreamReader(NombreArchivo);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                cmbDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            cmbDatos.SelectedIndex = 0;
            AD.Close();
        }

        public void Recorrer(DataGridView dgvDatos)
        {
            String DatoLeido;
            dgvDatos.Rows.Clear();
            StreamReader AD = new StreamReader(NombreArchivo);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                dgvDatos.Rows.Add(DatoLeido.Split(';'));
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }

        public void LimpiarTodo()
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, false);
            AD.Close();
        }
    }
}
