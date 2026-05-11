using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PryEDDiFiniZ
{
    internal class clsListaDoble
    {
        private clsNodo pri;
        private clsNodo ult;

        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo < Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero.Anterior = Nuevo;
                    Primero = Nuevo;
                }
                else
                {
                    if (Nuevo.Codigo > Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = Nuevo;
                        Nuevo.Anterior = Ultimo;
                        Ultimo = Nuevo;
                    }
                    else
                    {
                        clsNodo Aux = Primero;
                        clsNodo Ant = Primero;

                        while (Aux != null && Aux.Codigo < Nuevo.Codigo)
                        {
                            Ant = Aux;
                            Aux = Aux.Siguiente;
                        }

                        Ant.Siguiente = Nuevo;
                        Nuevo.Anterior = Ant;
                        Nuevo.Siguiente = Aux;

                        if (Aux != null)
                        {
                            Aux.Anterior = Nuevo;
                        }
                    }
                }
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if (Primero == null)
            {
                return;
            }

            if (Primero.Codigo == Codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if (Primero.Codigo == Codigo)
                {
                    Primero = Primero.Siguiente;

                    if (Primero != null)
                    {
                        Primero.Anterior = null;
                    }
                }
                else
                {
                    if (Ultimo.Codigo == Codigo)
                    {
                        Ultimo = Ultimo.Anterior;

                        if (Ultimo != null)
                        {
                            Ultimo.Siguiente = null;
                        }
                    }
                    else
                    {
                        clsNodo aux = Primero;

                        while (aux != null && aux.Codigo != Codigo)
                        {
                            aux = aux.Siguiente;
                        }

                        if (aux != null)
                        {
                            clsNodo ant = aux.Anterior;
                            clsNodo sig = aux.Siguiente;

                            if (ant != null)
                            {
                                ant.Siguiente = sig;
                            }

                            if (sig != null)
                            {
                                sig.Anterior = ant;
                            }
                        }
                    }
                }
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();

            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void RecorrerDes(DataGridView Grilla)
        {
            clsNodo aux = Ultimo;
            Grilla.Rows.Clear();

            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
            }
        }

        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();

            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }

        public void RecorrerDes(ListBox Lista)
        {
            clsNodo aux = Ultimo;
            Lista.Items.Clear();

            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
                aux = aux.Anterior;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();

            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }

        public void RecorrerDes(ComboBox Combo)
        {
            clsNodo aux = Ultimo;
            Combo.Items.Clear();

            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo);
                aux = aux.Anterior;
            }
        }

        public void Recorrer(string NombreArchivo)
        {
            if (string.IsNullOrWhiteSpace(NombreArchivo))
                return;
            clsNodo aux = Primero;

            StreamWriter AD = new StreamWriter(NombreArchivo, false, Encoding.UTF8);

            AD.WriteLine("Lista de espera");
            AD.WriteLine("Codigo;Nombre;Tramite");

            while (aux != null)
            {
                AD.WriteLine(aux.Codigo + ";" + aux.Nombre + ";" + aux.Tramite);
                aux = aux.Siguiente;
            }

            AD.Close();
        }

        public void RecorrerDes(string NombreArchivo)
        {
            if (string.IsNullOrWhiteSpace(NombreArchivo))
                return;

            clsNodo aux = Ultimo;

            StreamWriter AD = new StreamWriter(NombreArchivo, false, Encoding.UTF8);

            AD.WriteLine("Lista de espera");
            AD.WriteLine("Codigo;Nombre;Tramite");

            while (aux != null)
            {
                AD.WriteLine(aux.Codigo + ";" + aux.Nombre + ";" + aux.Tramite);
                aux = aux.Anterior;
            }

            AD.Close();
        } 
    }
} 