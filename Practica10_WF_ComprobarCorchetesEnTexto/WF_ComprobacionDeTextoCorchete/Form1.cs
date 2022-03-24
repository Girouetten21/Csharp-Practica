using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_ComprobacionDeTextoCorchete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pila pila1;
            pila1 = new Pila();
            string cadena = textBox1.Text;

            for (int f = 0; f < cadena.Length; f++)
            {
                if (cadena.ElementAt(f) == '(' || cadena.ElementAt(f) == '[' || cadena.ElementAt(f) == '{')
                {
                    pila1.Insertar(cadena.ElementAt(f));
                }
                else
                {
                    if (cadena.ElementAt(f) == ')')
                    {
                        if (pila1.Extraer() != '(')
                        {
                            Text = "Incorrecta";
                            return;
                        }
                    }
                    else
                    {
                        if (cadena.ElementAt(f) == ']')
                        {
                            if (pila1.Extraer() != '[')
                            {
                                Text = "Incorrecta";
                                return;
                            }
                        }
                        else
                        {
                            if (cadena.ElementAt(f) == '}')
                            {
                                if (pila1.Extraer() != '{')
                                {
                                    Text = "Incorrecta";
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            if (pila1.Vacia())
            {
                Text = "Correcta";
            }
            else
            {
                Text = "Incorrecta";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
