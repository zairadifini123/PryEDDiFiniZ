using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
using System.Windows.Forms; 

namespace PryEDDiFiniZ
{
    internal class clsBaseDeDatos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";
        private string CadenaConexion2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";

        public void Listar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion1;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Libro";

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, "Libro");

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Libros"];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("e.ToString");
            } 
        }

    }
}
