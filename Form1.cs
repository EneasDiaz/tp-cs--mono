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
        // clase random intanciando un objeto random con el nombre random 
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            figuras = new Figura[3] 
            {
                new Circulo(60) { ColorTrazo = ColorAleatorio() },
                new Rectangulo(30,50) { ColorTrazo = ColorAleatorio() },
                new Cuadrado(45) { ColorTrazo = ColorAleatorio() },
            };

        }
        // Tipo de dato Color viene de la librería System.Drawing de .NET
        private Color ColorAleatorio()
        {// no se contempla el ultimo vavor 0-255 metodo propio de la clase random
            int colorX = random.Next(0, 256);
            int colorY = random.Next(0, 256);
            int colorZ = random.Next(0, 256);

            return Color.FromArgb(colorX, colorY, colorZ);
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
