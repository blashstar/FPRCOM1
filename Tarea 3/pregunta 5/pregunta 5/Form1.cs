using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pregunta_5
{
    public partial class Form1 : Form
    {

        private static int n1, n2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            leerEntradas();
            muestraNumeros();
        }

        public void leerEntradas()
        {
            n1 = Int32.Parse(textBox1.Text);
            n2 = Int32.Parse(textBox2.Text);
        }

        public void muestraNumeros()
        {
            for (int i = n1; i <= n2; i++)
            {
                agregaNumero(i);
            }
        }

        public void agregaNumero(int Numero)
        {
            listBox1.Items.Add(Numero.ToString());
        }
    }
}
