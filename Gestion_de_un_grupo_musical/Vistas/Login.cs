using Gestion_de_un_grupo_musical.Clases;
using Gestion_de_un_grupo_musical.Vistas;
using System;
using System.Windows.Forms;

namespace Gestion_de_un_grupo_musical
{
    public partial class Login : Form
    {
        private int NumeroIntentos = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Global.ValidarUsuario(textUsuario.Text, textClave.Text))
            {
                Form principal = new Principal();
                this.Close();
                principal.Show();
            }
            else{
                lblError.Visible = true;
                this.NumeroIntentos++;
                if (NumeroIntentos == 3)
                {
                    MessageBox.Show("Demasiados errores");
                    Application.Exit();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Console.WriteLine("cargando Login");
            lblNombreGrupo.Text = Global.NombreGrupo;
            Global.CargarUsuarios();
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void textClave_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
    }
}
