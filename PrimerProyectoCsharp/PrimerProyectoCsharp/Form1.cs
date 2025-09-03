using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerProyectoCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {

            }
        }



        private void optSuma_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        String[][] Etiqueta = new String[][]
           {
                new string[] { "Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrado", "Metro Cuadrado","Tareas", "Manzana", "Hectárea" }
           };
        double[] Valor = new double[]
  {
    0.092903,   // Pie Cuadrado
    0.6987,     // Vara Cuadrada
    0.836127,   // Yarda Cuadrada
    1,          // Metro Cuadrado
    437.5,      // Tareas
    7000,       // Manzanas
    10000       // Hectárea
  };

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double CantidadValor = Convert.ToDouble(txtValor.Text);
            int De = cboTipoarea.SelectedIndex;
            int A = cboConvertirarea.SelectedIndex;
            double respuesta = (CantidadValor * Valor[De]) / Valor[A];
            lblTotalArea.Text = CantidadValor + " " + Etiqueta[0][De] + " son " + respuesta + " " + Etiqueta[0][A];
        }
    }
}



