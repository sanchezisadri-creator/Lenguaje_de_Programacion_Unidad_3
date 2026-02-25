using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio2
{
   
    public partial class Form1 : Form
    {
        int tiempoRestante;
        int tiempoInicial;

        public Form1()
        {
            InitializeComponent();
            lblTiempo.Text = "00:00";
            progressBar1.Minimum = 0;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int minutos, segundos;

            if (!int.TryParse(txtMinutos.Text, out minutos) ||
                !int.TryParse(txtSegundos.Text, out segundos))
            {
                MessageBox.Show("Ingrese valores válidos");
                return;
            }

            tiempoRestante = (minutos * 60) + segundos;

            if (tiempoRestante <= 0)
            {
                MessageBox.Show("Ingrese un tiempo mayor que cero");
                return;
            }

            tiempoInicial = tiempoRestante;

            progressBar1.Maximum = tiempoInicial;
            progressBar1.Value = tiempoRestante;

            MostrarTiempo();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiempoRestante > 0)
            {
                tiempoRestante--;
                progressBar1.Value = tiempoRestante;
                MostrarTiempo();
            }
            else
            {
                timer1.Stop();
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("⏰ ¡Tiempo agotado!");
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            tiempoRestante = tiempoInicial;
            progressBar1.Value = tiempoRestante;
            lblTiempo.ForeColor = Color.Black;
            MostrarTiempo();
        }

        private void MostrarTiempo()
        {
            int minutos = tiempoRestante / 60;
            int segundos = tiempoRestante % 60;

            lblTiempo.Text = minutos.ToString("00") + ":" + segundos.ToString("00");

            if (tiempoRestante <= 10)
                lblTiempo.ForeColor = Color.Red;
            else
                lblTiempo.ForeColor = Color.Black;
        }
    }
}