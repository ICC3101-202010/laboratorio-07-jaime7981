using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        List<string> hist = new List<string>();
        Double value = 0;
        Double lastvalue = 0;
        string operador = "";
        bool operadorActivo = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)   
        {
            if (CajaDeNumeros.Text == "0")
            {
                CajaDeNumeros.Clear();
            }
            Button boton = (Button)sender;
            CajaDeNumeros.Text = CajaDeNumeros.Text + boton.Text;
        }

        private void Operador_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operador = boton.Text;
            try
            {
                value = Double.Parse(CajaDeNumeros.Text);
            }
            catch
            {

            }
            CajaDeNumeros.Clear();
            CajaResultadoAnterior.Clear();
            lastvalue = value;
            CajaResultadoAnterior.Text = lastvalue.ToString();
            operadorActivo = true;
        }

        private void BotonIgual_Click(object sender, EventArgs e)
        {
            if (operador == "+")
            {
                CajaDeNumeros.Text = (value + Double.Parse(CajaDeNumeros.Text)).ToString();
            }
            else if (operador == "-")
            {
                CajaDeNumeros.Text = (value - Double.Parse(CajaDeNumeros.Text)).ToString();
            }
            else if (operador == "*")
            {
                CajaDeNumeros.Text = (value * Double.Parse(CajaDeNumeros.Text)).ToString();
            }
            else if (operador == "/")
            {
                CajaDeNumeros.Text = (value / Double.Parse(CajaDeNumeros.Text)).ToString();
            }
            if (value != 0)
            {
                if (lastvalue != 0)
                {
                    hist.Add(lastvalue.ToString() + " " + operador + " " + value.ToString() + " = " + CajaDeNumeros.Text);
                }
                else
                {
                    hist.Add(value.ToString());
                }
            }
            operadorActivo = false;
        }

        private void BotonClear_Click(object sender, EventArgs e)
        {
            CajaDeNumeros.Text = "0";
            CajaResultadoAnterior.Clear();
            value = 0;
            lastvalue = 0;
            operador = "";
            operadorActivo = false;
        }

        private void BotonHistorial_Click(object sender, EventArgs e)
        {
            ListaHistorial.Items.Clear();
            BotonVoler.Visible = true;
            ListaHistorial.Visible = true;
            foreach (string resultados in hist)
            {
                ListaHistorial.Items.Add(resultados);
            }
        }

        private void BotonVoler_Click(object sender, EventArgs e)
        {
            ListaHistorial.Visible = false;
            BotonVoler.Visible = false;
            CajaDeNumeros.Text = "0";
        }

        private void BotonBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> list = new List<string>();
                foreach (char numero in CajaDeNumeros.Text)
                {
                    list.Add(numero.ToString());
                }
                list.RemoveAt(list.Count - 1);
                CajaDeNumeros.Text = String.Join("", list);
            }
            catch
            {
                CajaDeNumeros.Text = "0";
            }
        }
    }
}
