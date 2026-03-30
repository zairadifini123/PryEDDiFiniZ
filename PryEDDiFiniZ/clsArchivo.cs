using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PryEDDiFiniZ
{
    internal class clsArchivo
    {
        public string NombreArchivo = "Colores.txt";

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
    }
}
