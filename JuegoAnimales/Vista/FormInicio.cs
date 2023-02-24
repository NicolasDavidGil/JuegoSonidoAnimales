namespace Vista
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            bool chequeo = VerificarIngreso(txtNombre.Text);
            if(!chequeo)
            {
                lblError.Visible = true;
            }else
            {
                string nombre = txtNombre.Text;
                Form1 uno = new(nombre);
                this.Hide();
                uno.Show();
            }
        }

        public bool VerificarIngreso(string nombre)
        {
            bool verificado = false;

            if(!String.IsNullOrEmpty(nombre))
            {
                for(int i = 0; i < nombre.Length; i++)
                {
                    if(Char.IsLetter(nombre[i]))
                    {
                        verificado = true;
                    }
                    else
                    {
                        verificado = false;
                        break;
                    }
                }
            }
            return verificado;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}