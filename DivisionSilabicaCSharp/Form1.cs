using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DivisionSilabica_CSharp;
using System.Text.RegularExpressions;

namespace DivisionSilabicaCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSeparar_Click(object sender, EventArgs e)
        {
            String texto = tbPalabras.Text;

            //Compruebo que solamente es texto
            if (Verificar(texto))
            {
                //Corto las palabras por espacio y lo guardo en un array de palabras
                String[] palabras = texto.Split(new string[] { " " }, StringSplitOptions.None);
                Divisor divisor = new Divisor();
                tbSilabas.Text = "";

                int i;
                for (i = 0; i < palabras.Length; i++)
                {
                    divisor.setString((String)palabras[i]);
                    tbSilabas.Text = tbSilabas.Text + " " + divisor.silabear();
                }

            }
            else
                tbSilabas.Text = "Palabra no válida";
        }

        public bool Verificar(string cadena)
        {
            return Regex.IsMatch(cadena, "^[a-zA-Z]+$");
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbPalabras.Text = "";
            tbSilabas.Text = "";
        }

    }
}
