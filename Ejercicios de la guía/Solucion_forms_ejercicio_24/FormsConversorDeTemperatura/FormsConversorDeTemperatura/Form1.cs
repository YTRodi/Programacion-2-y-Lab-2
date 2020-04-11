using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormsConversorDeTemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertirCelsius_Click(object sender, EventArgs e)
        {
            double aux = default(double);
            if (double.TryParse(txtCelsius.Text, out aux))
            {
                Celsius auxCelsius = new Celsius(aux);
                txtCelsiusACelsius.Text = auxCelsius.getCantidad().ToString();
                txtCelsiusAFahrenheit.Text = ((Fahrenheit)auxCelsius).getCantidad().ToString();
                txtCelsiusAKelvin.Text = ((Kelvin)auxCelsius).getCantidad().ToString();
            }
        }

        private void btnConvertirFahrenheit_Click(object sender, EventArgs e)
        {
            double aux = default(double);
            if (double.TryParse(txtFahrenheit.Text, out aux))
            {
                Fahrenheit auxFahrenheit = new Fahrenheit(aux);
                txtFahrenheitAFahrenhei.Text = auxFahrenheit.getCantidad().ToString();
                txtFahrenheitACelsius.Text = ((Celsius)auxFahrenheit).getCantidad().ToString();
                txtFahrenheiAKelvin.Text = ((Kelvin)auxFahrenheit).getCantidad().ToString();
            }
        }

        private void btnConvertirKelvin_Click(object sender, EventArgs e)
        {
            double aux = default(double);
            if (double.TryParse(txtKelvin.Text, out aux))
            {
                Kelvin auxKelvin = new Kelvin(aux);
                txtKelvinAKelvin.Text = auxKelvin.getCantidad().ToString();
                txtKelvinACelsius.Text = ((Celsius)auxKelvin).getCantidad().ToString();
                txtKelvinAFahrenheit.Text = ((Fahrenheit)auxKelvin).getCantidad().ToString();
            }
        }
    }
}
