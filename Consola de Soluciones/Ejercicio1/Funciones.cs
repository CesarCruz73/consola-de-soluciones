using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Funciones : Form
    {
        public Funciones()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            NumeroTextBox1.Clear();
            NumeroTextBox2.Clear();
            ResultadoLabel.Text = String.Empty;
        }

        private int Sumar(int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        private int Resta(int valor1, int valor2) 
        {
            int Resta = valor1 - valor2;
            return Resta;
        }

        private int Multiplicar(int valor1, int valor2)
        {
            return valor1 * valor2;
        }

        private int Dividir(int valor1, int valor2)
        {
            return valor1 / valor2;
        }

        private void SumaButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = Sumar(Convert.ToInt32(NumeroTextBox1.Text), Convert.ToInt32(NumeroTextBox2.Text)).ToString();
        }

        private void RestaButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = Resta(Convert.ToInt32(NumeroTextBox1.Text), Convert.ToInt32(NumeroTextBox2.Text)).ToString();
        }

        private void MultiplicarButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = Multiplicar(Convert.ToInt32(NumeroTextBox1.Text), Convert.ToInt32(NumeroTextBox2.Text)).ToString();
        }

        private void DividirButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = Dividir(Convert.ToInt32(NumeroTextBox1.Text), Convert.ToInt32(NumeroTextBox2.Text)).ToString();
        }
    }
}
