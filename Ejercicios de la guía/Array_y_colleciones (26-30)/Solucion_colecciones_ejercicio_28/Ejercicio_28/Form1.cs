using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void MostrarMasRepetidas(Dictionary<string,int> contadorPalabras)
        {
            //List<KeyValuePair<string, int>> lista = contadorPalabras.ToList();
            //StringBuilder sb = new StringBuilder();

            //sb.AppendLine("Palabras repetidas:");

            //for (int i = 0; int j = 0; i < lista.Count; i++)
            //{
            //    for (int j = 0; j < 3; j++)//la cantidad a mostrar.
            //    {
            //        sb.AppendFormat("{0} {1}, {2}", i + 1, lista[i].Key, lista[i].Value);
            //    }
            //}

            //MessageBox.Show(sb.ToString(),"Palabras mas repetidas",MessageBoxButtons.OK);

            //foreach (KeyValuePair<string,int> item in contadorPalabras)
            //{
            //    Console.WriteLine("{0} {1}", item.Key, item.Value);
            //}
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();
            string palabra = string.Empty;
            StringBuilder sb = new StringBuilder();


            foreach (char item in richTxt.Text)
            {
                if(item != ' ')
                {
                    palabra += item;
                }
                else
                {
                    if(palabra != string.Empty)
                    {
                        if(contadorPalabras.ContainsKey(palabra))
                        {
                            //si ya esta la palabra, solamente incremento el contador.
                            contadorPalabras[palabra]++;
                        }
                        else
                        {
                            //si no esta la palabra la agrego.
                            contadorPalabras.Add(palabra, 1);
                        }
                    }

                    palabra = string.Empty;

                }

            }

            int contador = 0;

            contadorPalabras.OrderByDescending(x => x.Value);

            foreach (KeyValuePair<string, int> palabrita in contadorPalabras)
            {
                if(contador<3)
                {
                    sb.AppendLine(palabrita.Key + " " + palabrita.Value);
                    contador++;
                }
            }

            MessageBox.Show(sb.ToString());

        }
    }
}
