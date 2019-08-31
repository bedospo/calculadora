using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entregar_calculadora
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        double resultado;
        string operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void Bot0_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void Bot1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void Bot2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void Bot3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void Bot4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void Bot5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void Bot6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void Bot7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void Bot8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void Bot9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void Botpunto_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }

        private void Botsuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Botresta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Botmultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Botdivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Botigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(pantalla.Text);
            switch(operacion)
            {
                case "+":
                    resultado = primero + segundo;
                    pantalla.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = primero - segundo;
                    pantalla.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = primero * segundo;
                    pantalla.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = primero / segundo;
                    pantalla.Text = resultado.ToString();
                    break;
            }
  
        }

        private void Boteliminar_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void Botraiz_Click(object sender, EventArgs e)
        {
            operacion = "Raiz";
            primero = double.Parse(pantalla.Text);
            resultado = primero;
            pantalla.Text = Math.Sqrt(primero).ToString();
        }

        private void Botporcentaje_Click(object sender, EventArgs e)
        {
            operacion = "%";
            resultado = double.Parse(pantalla.Text);
            pantalla.Text = Convert.ToString((primero * segundo) / 100);
           
        }
    }
}
