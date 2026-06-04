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
    public partial class frmBdOperaciones : Form
    {
        public frmBdOperaciones()
        {
            InitializeComponent();
        }

        clsBaseDeDatos objBaseDeDatos = new clsBaseDeDatos();
        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO " +
                "FROM LIBRO " +
                "ORDER BY 1 DESC ";
            objBaseDeDatos.Listar(dgvOperaciones, varSQL);
        }

        private void btnProyeccionMultiatributo_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO, AÑO " +
                "FROM LIBRO " +
                "ORDER BY TITULO ASC ";
            objBaseDeDatos.Listar(dgvOperaciones, varSQL);
        }

        private void btnSeleccionConvolucion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * " +
                "FROM (SELECT * FROM LIBRO WHERE IDIDIOMA > 1) AS X " +
                "WHERE IDPAIS= 2 ";
            objBaseDeDatos.Listar(dgvOperaciones, varSQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO, NOMBRE " +
                "FROM LIBRO inner join PAIS " +
                "on LIBRO.IDPAIS = PAIS.IDPAIS ";
            objBaseDeDatos.Listar(dgvOperaciones, varSQL);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            String varSQL = "Select * from libro " +
                "where idIdioma = 2 and " +
                "idLibro in " +
                "(Select idLibro from libro where idPais = 3)" +
                "order by 1 asc ";
            objBaseDeDatos.Listar(dgvOperaciones, varSQL);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            String varSQL = "Select * from libro " +
                "where idIdioma = 2 and " +
                "idLibro not in " +
                "(Select idLibro from libro where idPais = 3)" +
                "order by 1 asc ";
            objBaseDeDatos.Listar(dgvOperaciones, varSQL);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * " +
                "FROM LIBRO " +
                "WHERE IDIDIOMA = 1 " +
                "UNION " +
                "SELECT * " +
                "FROM LIBRO " +
                "WHERE IDIDIOMA = 2"; 
            objBaseDeDatos.Listar(dgvOperaciones, varSQL);
        }
    }
}
