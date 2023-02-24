using Grpc.Core;
using Microsoft.VisualBasic.ApplicationServices;
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
using Vista.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class Form1 : Form
    {
        public string ?nombreJug;
        public Form1(string nombre)
        {
            InitializeComponent();
            nombreJug = nombre;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            lblSaludo.Text = "BIENVENIDO AL NIVEL 1 " + nombreJug?.ToUpper() + "!! VAMOS A EMPEZAR...";
            btnCaballo.Visible = false;
            btnPerro.Visible = false;
            btnVaca.Visible = false;
            lblPregunta.Visible = false;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer sp = new SoundPlayer(@"../../../Sonidos/vaca.wav");                
                sp.Play();

                bool first = true;

                if (first)
                {
                    btnCaballo.Visible = true;
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

        private async void btnVaca_Click(object sender, EventArgs e)
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

                Form2 dos = new Form2();
                dos.Show();                               
            }
            catch
            {
                MessageBox.Show("Error el FormExito");                
            }
        }

        private void btnPerro_Click(object sender, EventArgs e)
        {
            btnPerro.BackgroundImage = null;
            btnPerro.BackColor = Color.Red;
            btnPerro.Enabled = false;
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
