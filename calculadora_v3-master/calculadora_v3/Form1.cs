using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_v3
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void but0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }

        }

        private void but1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void but2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void but3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void but4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void but5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void but6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void but7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void but8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void but9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void butpunto_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Contains('.') == false)
            {
                this.textBox1.Text = this.textBox1.Text + ".";
            }
        }

        private void butdividir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double numero))
            {
                primero = numero;
                operador = "/";
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                // Manejar la situación en la que el texto no es un número válido
                textBox1.Text = "¡Error de entrada!";
            }
        }

        private void butmultiplicar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double numero))
            {
                primero = numero;
                operador = "*";
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                // Manejar la situación en la que el texto no es un número válido
                textBox1.Text = "¡Error de entrada!";
            }
        }

        private void butresta_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double numero))
            {
                primero = numero;
                operador = "-";
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                // Manejar la situación en la que el texto no es un número válido
                textBox1.Text = "¡Error de entrada!";
            }
        }

        private void butsuma_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double numero))
            {
                primero = numero;
                operador = "+";
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                // Manejar la situación en la que el texto no es un número válido
                textBox1.Text = "¡Error de entrada!";
            }
        }

        private void butigual_Click(object sender, EventArgs e)
        {
            try
            {
                // Convertir el segundo operando
                if (double.TryParse(textBox1.Text, out double segundo))
                {
                    // Realizar el cálculo basado en el operador
                    switch (operador)
                    {
                        case "+":
                            textBox1.Text = (primero + segundo).ToString();
                            break;

                        case "-":
                            textBox1.Text = (primero - segundo).ToString();
                            break;

                        case "*":
                            textBox1.Text = (primero * segundo).ToString();
                            break;

                        case "/":
                            // Manejar la división por cero
                            if (segundo != 0)
                            {
                                textBox1.Text = (primero / segundo).ToString();
                            }
                            else
                            {
                                textBox1.Text = "No se puede dividir entre cero.";
                            }
                            break;

                        default:
                            textBox1.Text = "Operador no válido.";
                            break;
                    }
                }
                else
                {
                    textBox1.Text = "El segundo operando no es válido.";
                }
            }
            catch
            {
                textBox1.Text = "Se produjo un error al calcular el resultado.";
            }
        }

        private void butborrartodo_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void butborrar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void apagado_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
