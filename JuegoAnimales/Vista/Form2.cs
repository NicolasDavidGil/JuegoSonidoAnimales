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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblSaludo.Text = "BIENVENIDO AL NIVEL 2!!";
            btnCaballo.Visible = false;
            btnGato.Visible = false;
            btnLeon.Visible = false;
            lblPregunta.Visible = false;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer sp = new SoundPlayer(@"../../../Sonidos/LION1.wav");
                sp.Play();

                bool first = true;

                if (first)
                {
                    btnCaballo.Visible = true;
                    btnGato.Visible = true;
                    btnLeon.Visible = true;
                    lblPregunta.Visible = true;
                    first = false;
                }
            }
            catch
            {
                MessageBox.Show("fallo en la ruta"); //para control interno
            }
        }

        private void btnGato_Click(object sender, EventArgs e)
        {
            btnGato.BackgroundImage = null;
            btnGato.BackColor = Color.Red;
            btnGato.Enabled = false;
        }

        private async void btnLeon_Click(object sender, EventArgs e)
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

                Form3 tres = new Form3();
                tres.Show();
            }
            catch
            {
                MessageBox.Show("Error el FormExito");
            }
        }

        private void btnCaballo_Click(object sender, EventArgs e)
        {
            btnCaballo.BackgroundImage = null;
            btnCaballo.BackColor = Color.Red;
            btnCaballo.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInicio inicio = new();
            inicio.Show();
        }
    }
}
