using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pregunta6
{
    public partial class Form1 : Form
    {

        private static int cantidadTodos, sumaTodos;
        private static int cantidadPares, sumaPares;
        private static int cantidadImpares, sumaImpares;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            muestraTodos();
            muestraPares();
            muestraImpares();
        }

        public void muestraTodos()
        {
            cantidadTodos = 0;
            sumaTodos = 0;

            for (int i = 1; i <= 20; i++)
            {
                agregaLista1(i);
                cuentaTodos();
                acumulaTodos(i);
            }

            textBox1.Text = cantidadTodos.ToString();
            textBox2.Text = sumaTodos.ToString();
        }

        public void agregaLista1(int numero)
        {
            listBox1.Items.Add(numero.ToString());
        }

        public void cuentaTodos()
        {
            cantidadTodos += 1;
        }

        public void acumulaTodos(int numero)
        {
            sumaTodos += numero;
        }

        public void muestraPares()
        {
            cantidadPares = 0;
            sumaPares = 0;

            for (int i = 2; i <= 20; i+=2)
            {
                agregaLista2(i);
                cuentaPares();
                acumulaPares(i);
            }

            textBox3.Text = cantidadPares.ToString();
            textBox4.Text = sumaPares.ToString();
        }

        public void agregaLista2(int numero)
        {
            listBox2.Items.Add(numero.ToString());
        }

        public void cuentaPares()
        {
            cantidadPares += 1;
        }

        public void acumulaPares(int numero)
        {
            sumaPares += numero;
        }

        public void muestraImpares()
        {
            cantidadImpares = 0;
            sumaImpares = 0;

            for (int i = 1; i <= 19; i += 2)
            {
                agregaLista3(i);
                cuentaImpares();
                acumulaImpares(i);
            }

            textBox5.Text = cantidadImpares.ToString();
            textBox6.Text = sumaImpares.ToString();
        }

        public void agregaLista3(int numero)
        {
            listBox3.Items.Add(numero.ToString());
        }

        public void cuentaImpares()
        {
            cantidadImpares += 1;
        }

        public void acumulaImpares(int numero)
        {
            sumaImpares += numero;
        }

    }
}
