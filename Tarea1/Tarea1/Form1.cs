using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        //Variables globales
        decimal resultado = 0;
        decimal resultado2 = 0;

        private void EjecutarButton_Click(object sender, EventArgs e)
        {

            //Validación del Text Box
            if (NumeroTextBox.Text == "") 
            {
                ErrorProvider.SetError(NumeroTextBox, "Ingrese un valor");
                return;
            }

            ErrorProvider.Clear();

            //Llamado de función Par o impar
            decimal resultado = ParOImpar(Convert.ToDecimal(NumeroTextBox.Text));

            //Llamado de función Positivo o Negativo
            decimal resultado2 = PositivoONegativo(Convert.ToDecimal(NumeroTextBox.Text));
        }

        //Función Par o Impar
        private decimal ParOImpar(decimal num) 
        {
            if (num % 2 == 0) 
            {
                MessageBox.Show("El número es Par", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El número es Impar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return resultado;
        
        }

        //Función Positivo o Negativo
        private decimal PositivoONegativo(decimal num) 
        { 
            if (num > 0)
            {
                MessageBox.Show("El número es Positivo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (num < 0) 
            {
                MessageBox.Show("El número es Negativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return resultado2;

        }
    }
}
