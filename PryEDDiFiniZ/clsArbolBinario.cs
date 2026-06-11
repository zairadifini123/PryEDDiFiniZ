using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDDiFiniZ
{
    internal class clsArbolBinario
    {
        private clsNodo Pri;

        public clsNodo Raiz
        {
            get { return Pri; }
            set { Pri = value; }
        }

        clsNodo[] Vec = new clsNodo[100];
        int IND = 0;

        public void Agregar(clsNodo Nuevo)
        {
            Nuevo.Izquierdo = null;
            Nuevo.Derecho = null;

            if (Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {
                clsNodo NodoPadre = Raiz;
                clsNodo Aux = Raiz;

                while (Aux != null)
                {
                    NodoPadre = Aux;

                    if (Nuevo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }

                if (Nuevo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nuevo;
                }
                else
                {
                    NodoPadre.Derecho = Nuevo;
                }
            }
        }

        public void Recorrer(DataGridView Grilla, string Tipo)
        {
            Grilla.Rows.Clear();

            if (Tipo == "InOrden")
            {
                InOrdenAsc(Grilla, Raiz);
            }

            if (Tipo == "PreOrden")
            {
                PreOrden(Grilla, Raiz);
            }

            if (Tipo == "PostOrden")
            {
                PostOrden(Grilla, Raiz);
            }
        }

        private void InOrdenAsc(DataGridView Dgv, clsNodo R)
        {
            if (R != null)
            {
                if (R.Izquierdo != null)
                {
                    InOrdenAsc(Dgv, R.Izquierdo);
                }

                Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);

                if (R.Derecho != null)
                {
                    InOrdenAsc(Dgv, R.Derecho);
                }
            }
        }

        private void PreOrden(DataGridView Dgv, clsNodo R)
        {
            if (R != null)
            {
                Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);

                PreOrden(Dgv, R.Izquierdo);

                PreOrden(Dgv, R.Derecho);
            }
        }

        private void PostOrden(DataGridView Dgv, clsNodo R)
        {
            if (R != null)
            {
                PostOrden(Dgv, R.Izquierdo);

                PostOrden(Dgv, R.Derecho);

                Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenAsc(Combo, Raiz);
        }

        private void InOrdenAsc(ComboBox cmb, clsNodo R)
        {
            if (R != null)
            {
                if (R.Izquierdo != null)
                {
                    InOrdenAsc(cmb, R.Izquierdo);
                }

                cmb.Items.Add(R.Codigo);

                if (R.Derecho != null)
                {
                    InOrdenAsc(cmb, R.Derecho);
                }
            }
        }

        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();

            TreeNode NodoPadre = new TreeNode("Arbol");

            tree.Nodes.Add(NodoPadre);

            PreOrden(Raiz, NodoPadre);

            tree.ExpandAll();
        }

        private void PreOrden(clsNodo R, TreeNode nodoTreeView)
        {
            if (R != null)
            {
                TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());

                nodoTreeView.Nodes.Add(NodoPadre);

                if (R.Izquierdo != null)
                {
                    PreOrden(R.Izquierdo, NodoPadre);
                }

                if (R.Derecho != null)
                {
                    PreOrden(R.Derecho, NodoPadre);
                }
            }
        }

        public void Recorrer()
        {
            IND = 0;
            InOrdenAsc(Raiz);
        }

        private void InOrdenAsc(clsNodo R)
        {
            if (R != null)
            {
                InOrdenAsc(R.Izquierdo);

                Vec[IND] = R;
                IND++;

                InOrdenAsc(R.Derecho);
            }
        }

        public void Eliminar(int codigo)
        {
            Recorrer(); 

            Raiz = null; 

            for (int i = 0; i < IND; i++)
            {
                if (Vec[i].Codigo != codigo)
                {
                    Vec[i].Izquierdo = null;
                    Vec[i].Derecho = null;
                    Agregar(Vec[i]);
                }
            }
        }

        public void Equilibrar()
        {
            Recorrer(); 

            Raiz = null;

            EquilibrarArbol(0, IND - 1);
        }

        private void EquilibrarArbol(int inicio, int fin)
        {
            if (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                Vec[medio].Izquierdo = null;
                Vec[medio].Derecho = null;

                Agregar(Vec[medio]);

                EquilibrarArbol(inicio, medio - 1);
                EquilibrarArbol(medio + 1, fin);
            }
        }
    }
}