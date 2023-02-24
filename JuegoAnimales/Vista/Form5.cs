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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            lblSaludo.Text = "BIENVENIDO AL NIVEL 5!!";
            btnPerro.Visible = false;
            btnOveja.Visible = false;
            btnVaca.Visible = false;
            lblPregunta.Visible = false;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer sp = new SoundPlayer(@"../../../Sonidos/perro.wav");
                sp.Play();

                bool first = true;

                if (first)
                {
                    btnPerro.Visible = true;
                    btnOveja.Visible = true;
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

        private async void btnPerro_Click(object sender, EventArgs e)
        {
            try
            {
                FormExito exito = new FormExito(0);
                this.Hide();
                Interactor.MostrarCargando(exito);
                Task gitCarga = new Task(Interactor.EsperaLoad);
                gitCarga.Start();
                await gitCarga;
                Interactor.OcultarCargando(exito);
                FormInicio inicio = new();
                inicio.Show();
            }
            catch
            {
                MessageBox.Show("Error el FormExito");
            }
        }

        private void btnOveja_Click(object sender, EventArgs e)
        {
            btnOveja.BackgroundImage = null;
            btnOveja.BackColor = Color.Red;
            btnOveja.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInicio inicio = new();
            inicio.Show();
        }
    }
}
