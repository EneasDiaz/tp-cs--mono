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

            int tamanoBase = 25;

            figuras = new Figura[4] 
            {
                new Circulo(tamanoBase * 1) { ColorTrazo = ColorAleatorio() },
                new Rectangulo(tamanoBase * 3 / 2, tamanoBase * 2) { ColorTrazo = ColorAleatorio() },
                new Cuadrado(tamanoBase * 3) { ColorTrazo = ColorAleatorio() },
                new TrianguloIsosceles(tamanoBase * 4 , tamanoBase *4 ){ ColorTrazo = ColorAleatorio() },
            };

        }
        // Tipo de dato Color viene de la librería System.Drawing de .NET
        private Color ColorAleatorio()
        {// no se contempla el ultimo vavor 0-255 metodo propio de la clase random
        // limito a 151 los valores posibles de rojo verde y azul para no no llegar a valores altos que son los mas claros
            int colorX = random.Next(0, 151);
            int colorY = random.Next(0, 151);
            int colorZ = random.Next(0, 151);

            return Color.FromArgb(colorX, colorY, colorZ);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            for (int i = 0; i < figuras.Length; i++)
            {
                Pen pen = new Pen(figuras[i].ColorTrazo);
                figuras[i].Dibujar(pen,gr, i * 80, 50);
            }

        }
    }
}
