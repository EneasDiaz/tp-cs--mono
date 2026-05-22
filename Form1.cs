using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Figuras
{
    public partial class Form1 : Form
    {
        Figura[] figuras;

        public Form1()
        {
            InitializeComponent();
            figuras = new Figura[3] 
            {
                new Circulo(60) { ColorTrazo = Color.Blue },
                new Rectangulo(30,50) { ColorTrazo = Color.Green },
                new Cuadrado(45) { ColorTrazo = Color.Red },
            };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            for (int i = 0; i < figuras.Length; i++)
            {
                Pen pen = new Pen(figuras[i].ColorTrazo);
                figuras[i].Dibujar(pen,gr,i * 100, 50);
            }

        }
    }
}
