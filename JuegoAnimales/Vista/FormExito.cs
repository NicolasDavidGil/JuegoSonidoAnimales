using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Properties;

namespace Vista
{
    public partial class FormExito : Form
    {
        int auxiliar;
        public FormExito(int aux)
        {
            InitializeComponent();
            auxiliar = aux;
        }

        private void FormExito_Load(object sender, EventArgs e)
        {
            ptbExito.Image = Resources.correcto;
            ptbCargando.Image = Resources.cargando;

            if (auxiliar == 1)
                lblCargando.Text = "CARGANDO EL SIGUIENTE NIVEL... POR FAVOR ESPERE...";
            else
                lblCargando.Text = "                ¡¡¡FELICIDADES HAS GANADO!!!";
        }
    }
}
