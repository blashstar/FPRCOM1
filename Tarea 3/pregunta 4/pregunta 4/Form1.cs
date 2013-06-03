using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pregunta_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarMensajes();
        }


        public void mostrarMensajes()
        {
            for (int i = 1; i <= 10; i++)
            {
                muestraMensaje(i);
            }
        }

        public void muestraMensaje(int Numero)
        {
            listBox1.Items.Add(Numero.ToString() + ".- Hola Guachin");
        }
    }
}
