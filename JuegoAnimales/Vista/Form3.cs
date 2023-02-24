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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblSaludo.Text = "BIENVENIDO AL NIVEL 3!!";
            btnGallo.Visible = false;
            btnPerro.Visible = false;
            btnVaca.Visible = false;
            lblPregunta.Visible = false;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer sp = new SoundPlayer(@"../../../Sonidos/Gallo.wav");
                sp.Play();

                bool first = true;

                if (first)
                {
                    btnGallo.Visible = true;
                    btnPerro.Visible = true;
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

        private void btnPerro_Click(object sender, EventArgs e)
        {
            btnPerro.BackgroundImage = null;
            btnPerro.BackColor = Color.Red;
            btnPerro.Enabled = false;
        }

        private async void btnGallo_Click(object sender, EventArgs e)
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

                Form4 cuatro = new Form4();
                cuatro.Show();
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
