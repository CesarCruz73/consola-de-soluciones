using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Números_Par_Impar_Y_Primos
{
    public partial class Funciones2 : Form
    {
        public Funciones2()
        {
            InitializeComponent();
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            Numero1TextBox.Clear();
            ResultadoLabel.Text = String.Empty;
        }

        private void NumeroPar()
        {
            int num;
            num = int.Parse(Numero1TextBox.Text);

            if (num % 2 == 0)
            {
                ResultadoLabel.Text = "Es Un Número Par.";
            }
            else
            {
                ResultadoLabel.Text = "No Es Un Número Par.";
            }    
        }

        private void NumeroPrimo()
        {
            int num, i, c;
            c = 0;
            num = int.Parse(Numero1TextBox.Text);
            
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    c = c + 1;
                }
            }
            if (c > 2)
            {
                ResultadoLabel.Text = "El Número Ingresado No Es Primo.";
            }
            else
            {
                ResultadoLabel.Text = "El Número Ingresado Es Primo.";
            }

        }
        private void NumeroParButton_Click(object sender, EventArgs e)
        {
            NumeroPar();
        }

        private void NumeroPrimoButton_Click(object sender, EventArgs e)
        {
            NumeroPrimo();
        }
    }
}
