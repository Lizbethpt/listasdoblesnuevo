using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listasdoblementeenlaadas2
{
    public partial class Form1 : Form
    {
        MiLista lista = new MiLista();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo n = new Nodo();
            n.Dato = txtDato.Text;
            lista.Agregar(n);
            MessageBox.Show(lista.ToString());
        }

        private void txtDato_TextChanged(object sender, EventArgs e)
        { }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (lista.Buscar(txtDato.Text))
            {
                MessageBox.Show("Encontrado");
                return;
            }
            MessageBox.Show("No encontrado");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lista.Borrar(txtDato.Text);
            MessageBox.Show(lista.ToString());
        }
    }
}

