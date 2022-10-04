using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listasdoblementeenlaadas2
{
    class MiLista
    {
        private Nodo head;

        public Nodo Head
        {
            get { return head; }
            set { head = value; }
        }

        public MiLista()
        {
            head = null;
        }

        public void Agregar(Nodo n)
        {
            //Si no hay ningun nodo se inserta en head
            if (head == null)
            {
                head = n;
                return;
            }

            //si el nuevo dato es menor que head se inserta en head y se recorre hear
            if (string.Compare(head.Dato, n.Dato) == 1)
            {
                n.Siguiente = head;
                n.Siguiente.Anterior = n;
                head = n;
            }

            Nodo h = head;
            while (h.Siguiente != null)
            {
                // Si la posicion actual es igual al nuevo dato, no se inserta
                if (h.Dato == n.Dato)
                {
                    return;
                }

                // si el dato es mayor a la posicion actual
                // y menor a la siguiente, se inserta entre ellos dos
                if (string.Compare(h.Dato, n.Dato) == -1
                    && string.Compare(h.Siguiente.Dato, n.Dato) == 1)
                {
                    n.Siguiente = h.Siguiente;
                    h.Siguiente = n;
                    n.Siguiente.Anterior = n;
                    n.Anterior = h;
                    return;
                }
                h = h.Siguiente;
            }

            //si el dato es mayor que el ultimo nodo de la lista se agrega al final
            if (string.Compare(h.Dato, n.Dato) == -1)
            {
                h.Siguiente = n;
                h.Siguiente.Anterior = h;
            }
            return;
        }

        public override string ToString()
        {
            Nodo r = head;
            string listadatos = "";
            while (r != null)
            {
                listadatos += r.ToString();
                r = r.Siguiente;
            }
            return listadatos;
        }

        public bool Buscar(string dato)
        {
            if (head.Dato == dato)
            {
                return true;
            }

            Nodo h = head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Dato == dato)
                {
                    return true;
                }
                h = h.Siguiente;
            }
            return false;
        }

        public void Borrar(string dato)
        {
            if (head.Dato == dato)
            {
                head = head.Siguiente;
                head.Anterior = null;
                return;
            }

            Nodo h = head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Dato == dato)
                {
                    h.Siguiente = h.Siguiente.Siguiente;
                    h.Siguiente.Anterior = h;
                    break;
                }
                h = h.Siguiente;
            }
        }

    }
}
