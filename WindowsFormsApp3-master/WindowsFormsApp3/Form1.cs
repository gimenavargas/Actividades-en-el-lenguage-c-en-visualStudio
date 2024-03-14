using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cero_Click(object sender, EventArgs e)
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

        private void Uno_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
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

        private void tres_Click(object sender, EventArgs e)
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

        private void cuatro_Click(object sender, EventArgs e)
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

        private void cinco_Click(object sender, EventArgs e)
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

        private void seis_Click(object sender, EventArgs e)
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

        private void siete_Click(object sender, EventArgs e)
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

        private void ocho_Click(object sender, EventArgs e)
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

        private void nueve_Click(object sender, EventArgs e)
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

        private void punto_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Contains('.') == false)
            {
                this.textBox1.Text = this.textBox1.Text + ".";
            }
        }

        private void igual_Click(object sender, EventArgs e)
        {
            segundo = Convert.ToDouble(this.textBox1.Text);
            switch (operador)
            {
                case "+":
                    this.textBox1.Text = Convert.ToString(primero + segundo);
                    break;

                case "-":
                    this.textBox1.Text = Convert.ToString(primero - segundo);
                    break;

                case "*":
                    this.textBox1.Text = Convert.ToString(primero * segundo);
                    break;

                case "/":
                    this.textBox1.Text = Convert.ToString(primero / segundo);
                    break;
            }
        }

        private void suma_Click(object sender, EventArgs e)
        {
            primero = Convert.ToDouble(this.textBox1.Text);
            operador= "+";
            this.textBox1.Clear();
            this.textBox1.Focus();
        }

        private void resta_Click(object sender, EventArgs e)
        {
            primero = Convert.ToDouble(this.textBox1.Text);
            operador = "-";
            this.textBox1.Clear();
            this.textBox1.Focus();
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            primero = Convert.ToDouble(this.textBox1.Text);
            operador = "*";
            this.textBox1.Clear();
            this.textBox1.Focus();
        }

        private void borrartodo_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void dividir_Click(object sender, EventArgs e)
        {

            primero = Convert.ToDouble(this.textBox1.Text);
            operador = "/";
            this.textBox1.Clear();
            this.textBox1.Focus();
        }

        private void borrarnumero_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void apagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
