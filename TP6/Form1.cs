using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using calculos;

namespace TP6
{
    public partial class Form1 : Form
    {
        Calculadora calculador = new Calculadora();
        string operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            
                txt_pantalla.Text += "1";
            
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_pantalla.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_pantalla.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_pantalla.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_pantalla.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_pantalla.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_pantalla.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_pantalla.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_pantalla.Text += "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_pantalla.Text += "0";
        }

        private void btn_sumar_Click(object sender, EventArgs e)
        {
            if(txt_pantalla.Text != "")
            {

                calculador.Numero1 = Convert.ToDouble(txt_pantalla.Text);
                txt_pantalla.Clear();
                operador = btn_sumar.Text;
            }
          
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            if (txt_pantalla.Text != "")
            {
                calculador.Numero1 = Convert.ToDouble(txt_pantalla.Text);
                txt_pantalla.Clear();
                operador = btn_resta.Text;
            }
        
        }

        private void btn_multip_Click(object sender, EventArgs e)
        {
            if(txt_pantalla.Text != "")
            {
                calculador.Numero1 = Convert.ToDouble(txt_pantalla.Text);
                txt_pantalla.Clear();
                operador = btn_multip.Text;
            }
    
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            if(txt_pantalla.Text != "")
            {
                calculador.Numero1 = Convert.ToDouble(txt_pantalla.Text);
                txt_pantalla.Clear();
                operador = btn_dividir.Text;
            }
            
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        { 
            txt_pantalla.Clear();
            calculador.Numero1 = 0;
            calculador.Numero2 = 0;
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            if(txt_pantalla.Text != "")
            {
                calculador.Numero2 = Convert.ToDouble(txt_pantalla.Text);
                switch (operador)
                {
                    case "+":
                        txt_pantalla.Text = Convert.ToString(calculador.Suma());
                        break;
                    case "-":
                        txt_pantalla.Text = Convert.ToString(calculador.Resta());
                        break;
                    case "*":
                        txt_pantalla.Text = Convert.ToString(calculador.Multiplicacion());
                        break;
                    case "/":
                        txt_pantalla.Text = Convert.ToString(calculador.Division());
                        break;
                    default:
                        break;
                }
            }
            else
            {
                txt_pantalla.Text = Convert.ToString(calculador.Numero1);
            }
        

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                    btn_0.PerformClick();
                    break;
                case '1':
                    btn_1.PerformClick();
                    break;
                case '2':
                    btn_2.PerformClick();
                    break;
                case '3':
                    btn_3.PerformClick();
                    break;
                case '4':
                    btn_4.PerformClick();
                    break;
                case '5':
                    btn_5.PerformClick();
                    break;
                case '6':
                    btn_6.PerformClick();
                    break;
                case '7':
                    btn_7.PerformClick();
                    break;
                case '8':
                    btn_8.PerformClick();
                    break;
                case '9':
                    btn_9.PerformClick();
                    break;
                case '+':
                    btn_sumar.PerformClick();
                    break;
                case '-':
                    btn_resta.PerformClick();
                    break;
                case '/':
                    btn_dividir.PerformClick();
                    break;
                case '*':
                    btn_multip.PerformClick();
                    break;
                case 'c':
                    btn_borrar.PerformClick();
                    break;
                case 'C':
                    btn_borrar.PerformClick();
                    break;

                default:
                    break;
            }

            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btn_igual.PerformClick();
            }
            if (Convert.ToInt32(e.KeyChar) == 127)
            {
                btn_borrar.PerformClick();
            }

        }


    }

}
