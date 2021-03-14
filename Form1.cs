using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        bool secuencia=true;
        string operacion,borrado;
        double numero1, numero2, resultado;

        private void num1_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                pantalla.Text = "";
                pantalla.Text = "1";
                secuencia = false;
            }
            else {
                pantalla.Text =pantalla.Text + "1";
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                pantalla.Text = "";
                pantalla.Text = "2";
                secuencia = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "2";
            }

        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                pantalla.Text = "";
                pantalla.Text = "3";
                secuencia = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "3";
            }

        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                pantalla.Text = "";
                pantalla.Text = "4";
                secuencia = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "4";
            }

        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                pantalla.Text = "";
                pantalla.Text = "5";
                secuencia = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "5";
            }

        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                pantalla.Text = "";
                pantalla.Text = "6";
                secuencia = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "6";
            }

        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                pantalla.Text = "";
                pantalla.Text = "7";
                secuencia = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "7";
            }

        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                pantalla.Text = "";
                pantalla.Text = "8";
                secuencia = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "8";
            }

        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                pantalla.Text = "";
                pantalla.Text = "9";
                secuencia = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "9";
            }

        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "0")
            {
                return;
            }
            else
            {
                pantalla.Text = pantalla.Text + "0";
            }
        }
         

        //Fin botones num

        private void suma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            numero1 = Double.Parse(pantalla.Text);
            secuencia = true;
        }

        private void resta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            numero1 = Double.Parse(pantalla.Text);
            secuencia = true;
        }

        private void div_Click(object sender, EventArgs e)
        {
            operacion = "/";
            numero1 = Double.Parse(pantalla.Text);
            secuencia = true;
        }

        private void mul_Click(object sender, EventArgs e)
        {
            operacion = "*";
            numero1 = Double.Parse(pantalla.Text);
            secuencia = true;
        }
        
        private void raiz_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(pantalla.Text);
            resultado = Math.Sqrt(numero1);
            pantalla.Text = resultado.ToString();
            secuencia = true;
        }
       
        private void cuadrado_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(pantalla.Text);
            resultado = numero1 * numero1;
            pantalla.Text = resultado.ToString();
            secuencia = true;
        }             

        private void igual_Click(object sender, EventArgs e)
        {
            numero2 = double.Parse(pantalla.Text);
            if (operacion == "+") {
                resultado = numero1 + numero2;
                pantalla.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "-")
            {
                resultado = numero1 - numero2;
                pantalla.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "/")
            {
                resultado = numero1 / numero2;
                pantalla.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "*")
            {
                resultado = numero1 * numero2;
                pantalla.Text = resultado.ToString();
                secuencia = true;
            }
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            int x = 0;
            borrado = pantalla.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0,x);
            pantalla.Text = borrado;

            if (pantalla.Text=="") {
                pantalla.Text = "0";
                secuencia = true;
            }
            if (pantalla.Text == "-")
            {
                pantalla.Text = "0";
                secuencia = true;
            }

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            pantalla.Text = "0";
            numero1 = 0;
            numero2 = 0;
            secuencia = true;
        }

    }
}
