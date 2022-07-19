using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form1 : Form
    {
            //Division de los componentes de las operaciones
            public double op1, op2;
            char op;
           
        //Arreglo necesario para hacer la verificacion de operadores
        private char[] Operadores = new char[] { '+', '-', '*', '/', '±', '%', '√' };
        public Form1()
        {
            InitializeComponent();
            

            
        }

        //Boton Punto
        private void button21_Click(object sender, EventArgs e)
        {
          
                TextBoxResultado.Text = TextBoxResultado.Text + ".";
        }

        private void Button00_Click(object sender, EventArgs e)
        {
            
            if(TextBoxResultado.Text != "0")
            {
                TextBoxResultado.Text = TextBoxResultado.Text + "0";
            }

        }

        private void Button01_Click(object sender, EventArgs e)
        {
            TextBoxResultado.Text = TextBoxResultado.Text + "1";
        }

        private void Button02_Click(object sender, EventArgs e)
        {
            TextBoxResultado.Text = TextBoxResultado.Text + "2";
        }

        private void Button03_Click(object sender, EventArgs e)
        {
            TextBoxResultado.Text = TextBoxResultado.Text + "3";
        }

        private void Button04_Click(object sender, EventArgs e)
        {
            TextBoxResultado.Text = TextBoxResultado.Text + "4";
        }

        private void Button05_Click(object sender, EventArgs e)
        {
            TextBoxResultado.Text = TextBoxResultado.Text + "5";
        }
        //Boton 6
        private void button13_Click(object sender, EventArgs e)
        {
            TextBoxResultado.Text = TextBoxResultado.Text + "6";
        }
        private void Button07_Click(object sender, EventArgs e)
        {
            TextBoxResultado.Text = TextBoxResultado.Text + "7";
        }

        private void Button08_Click(object sender, EventArgs e)
        {
            TextBoxResultado.Text = TextBoxResultado.Text + "8";
        }

        private void Button09_Click(object sender, EventArgs e)
        {
            TextBoxResultado.Text = TextBoxResultado.Text + "9";
        }

        private void ButtonMas_Click(object sender, EventArgs e)
        {
            op = '+';
            op1 = double.Parse(TextBoxResultado.Text);
            TextBoxResultado.Text = "";
         
        }

        private void ButtonMenos_Click(object sender, EventArgs e)
        {

            if (TextBoxResultado.Text == "")
            {
                TextBoxResultado.Text = TextBoxResultado.Text + "-";
            }
            else
            {
                op = '-';
                op1 = double.Parse(TextBoxResultado.Text);
                TextBoxResultado.Text = "";
            }
        }

        private void ButtonMulti_Click(object sender, EventArgs e)
        {
            op = '*';
            op1 = double.Parse(TextBoxResultado.Text);
            TextBoxResultado.Text = "";
      
        }
        //Boton Division
        private void button9_Click(object sender, EventArgs e)
        {
            op = '/';
            op1 = double.Parse(TextBoxResultado.Text);
            TextBoxResultado.Text = "";
    
        }

        private void ButtonRaiz_Click(object sender, EventArgs e)
        {
            op1 = double.Parse(TextBoxResultado.Text);
            op1 = Math.Sqrt(op1);
            TextBoxResultado.Text = op1.ToString();
        }
        
        private void ButtonMod_Click(object sender, EventArgs e)
        {
            op = '%';
            op1 = double.Parse(TextBoxResultado.Text);
            TextBoxResultado.Text = "";

        }

        private void Button1x_Click(object sender, EventArgs e)
        {
            op1 = double.Parse(TextBoxResultado.Text);
            op1 = 1/op1;
            TextBoxResultado.Text = op1.ToString();

        }

        private void ButtonPM_Click(object sender, EventArgs e)
        {
            op1 = double.Parse(TextBoxResultado.Text);
            op1 = op1*-1;
            TextBoxResultado.Text = op1.ToString();
        }
        
        private void ButtonCE_Click(object sender, EventArgs e)
        {
            TextBoxResultado.Text = "";
            op = ' ';
            op1 = 0;
            op2 = 0;
         
        }
        //Boton Atras
        private void button1_Click(object sender, EventArgs e)
        {
            string aux = TextBoxResultado.Text;
            if ((aux.Length) >= 1)
            {   //la funcion remove elimina un caracter en especifico
                TextBoxResultado.Text = aux.Remove(aux.Length - 1);
            }
            
        }
        private void ButtonC_Click(object sender, EventArgs e)
        {
            string aux = TextBoxResultado.Text;
            
            //Se borran las operaciones en pantalla si estan divididos por un operador
            int index = (aux.LastIndexOfAny(Operadores))+1;

            if ((aux.Length) >= (aux.Length - index))
            {
                TextBoxResultado.Text = aux.Remove(aux.Length - index);
            }
        }
   

        //Boton Igual
        private void button25_Click(object sender, EventArgs e)
        {
            double res = 0.0;

            //Todas las opciones disponibles
            switch (op)
            {
                case '+':
                    op2 = double.Parse(TextBoxResultado.Text);
                    res = op1 + op2;
                    TextBoxResultado.Text = res.ToString();
                    op1 = res;
                    op2 = 0;
                    
                    break;

                case '-':
                    op2 = double.Parse(TextBoxResultado.Text);
                    res = op1 - op2;
                    TextBoxResultado.Text = res.ToString();
                    op1 = res;
                    op2 = 0;

                    break;

                case '*':
                    op2 = double.Parse(TextBoxResultado.Text);
                    res = op1 * op2;
                    TextBoxResultado.Text = res.ToString();
                    op1 = res;
                    op2 = 0;

                    break;

                case '/':
                    op2 = double.Parse(TextBoxResultado.Text);
                    
                    res = op1 / op2;
                    if (op2 == 0)
                    {
                        TextBoxResultado.Text = "El Fin se Acerca";
                    }else
                    {
                        TextBoxResultado.Text = res.ToString();
                    }
                    op1 = res;
                    op2 = 0;

                    break;
                case '%':
                    op2 = double.Parse(TextBoxResultado.Text);
                    res = (op1 * op2)/100;
                    TextBoxResultado.Text = res.ToString();
                    op1 = res;
                    op2 = 0;

                    break;
            }
        }

        //Codigo que si borro nukeo todo
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

