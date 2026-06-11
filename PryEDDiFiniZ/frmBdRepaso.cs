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
    public partial class frmBdRepaso : Form
    {
        public frmBdRepaso()
        {
            InitializeComponent();
        }
        clsBaseDeDatos objBaseDeDatos = new clsBaseDeDatos();
        private void btnListar_Click(object sender, EventArgs e)
        {
            String varSQL = "";

            switch (cmbOperaciones.Text)
            {
                case "Proyeccion simple":
                    varSQL = "SELECT TITULO FROM LIBRO ORDER BY 1 DESC";
                    break;

                case "Proyeccion multiatributo":
                    varSQL = "SELECT TITULO, AÑO FROM LIBRO ORDER BY TITULO ASC";
                    break;

                case "Por convolución":
                    varSQL = "SELECT * FROM (SELECT * FROM LIBRO WHERE IDIDIOMA > 1) AS X WHERE IDPAIS = 2";
                    break;

                case "Juntar":
                    varSQL = "SELECT TITULO, NOMBRE FROM LIBRO INNER JOIN PAIS ON LIBRO.IDPAIS = PAIS.IDPAIS";
                    break;

                case "Interseccion":
                    varSQL = "SELECT * FROM LIBRO WHERE IDIDIOMA = 2 AND IDLIBRO IN (SELECT IDLIBRO FROM LIBRO WHERE IDPAIS = 3) ORDER BY 1 ASC";
                    break;

                case "Diferencia":
                    varSQL = "SELECT * FROM LIBRO WHERE IDIDIOMA = 2 AND IDLIBRO NOT IN (SELECT IDLIBRO FROM LIBRO WHERE IDPAIS = 3) ORDER BY 1 ASC";
                    break;

                case "Union":
                    varSQL = "SELECT * FROM LIBRO WHERE IDIDIOMA = 1 UNION SELECT * FROM LIBRO WHERE IDIDIOMA = 2";
                    break;
            }

            lblOperacionARealizar.Text = varSQL;

            objBaseDeDatos.Listar(dgvOperacionARealizar, varSQL);
        }

        private void cmbOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
