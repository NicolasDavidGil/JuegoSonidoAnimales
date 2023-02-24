using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lblSaludo.Text = "BIENVENIDO AL NIVEL 4!!";
            btnElefante.Visible = false;
            btnLobo.Visible = false;
            btnVaca.Visible = false;
            lblPregunta.Visible = false;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer sp = new SoundPlayer(@"../../../Sonidos/Lobo.wav");
                sp.Play();

                bool first = true;

                if (first)
                {
                    btnLobo.Visible = true;
                    btnElefante.Visible = true;
                    btnVaca.Visible = true;
                    lblPregunta.Visible = true;
                    first = false;
                }
            }
            catch
            {
                MessageBox.Show("fallo en la ruta"); //para control interno
            }
        }

        private void btnVaca_Click(object sender, EventArgs e)
        {
            btnVaca.BackgroundImage = null;
            btnVaca.BackColor = Color.Red;
            btnVaca.Enabled = false;
        }

        private void btnElefante_Click(object sender, EventArgs e)
        {
            btnElefante.BackgroundImage = null;
            btnElefante.BackColor = Color.Red;
            btnElefante.Enabled = false;
        }

        private async void btnLobo_Click(object sender, EventArgs e)
        {
            try
            {
                FormExito exito = new FormExito(1);
                this.Hide();
                Interactor.MostrarCargando(exito);
                Task gitCarga = new Task(Interactor.EsperaLoad);
                gitCarga.Start();
                await gitCarga;
                Interactor.OcultarCargando(exito);

                Form5 cinco = new Form5();
                cinco.Show();
            }
            catch
            {
                MessageBox.Show("Error el FormExito");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInicio inicio = new();
            inicio.Show();
        }
    }
}
