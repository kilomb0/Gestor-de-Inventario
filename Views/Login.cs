using GestionInventario_MySQL_.Controllers;
using GestionInventario_MySQL_.Selects;
using GestionInventario_MySQL_.Views;

namespace GestionInventario_MySQL_
{
    public partial class Login : Form
    {
        UsuarioSelect select = new UsuarioSelect();
        public Login()
        {
            InitializeComponent();
            labelHora.Text = DateTime.Now.ToString();
            buttonIngresar.Enabled = false;
            textBoxContra.TextChanged += TextBox_TextChanged;
            textBoxNombre.TextChanged += TextBox_TextChanged;

        }

        private void TextBox_TextChanged(object? sender, EventArgs e)
        {
            buttonIngresar.Enabled = !string.IsNullOrEmpty(textBoxContra.Text) &&
                                     !string.IsNullOrEmpty(textBoxNombre.Text);
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            int idusuario = select.Autenticar(textBoxNombre.Text, textBoxContra.Text);
            if (idusuario != -1)
            {
                MessageBox.Show("Se ha autenticado correctamente");
                int idrol = select.BuscarRol(idusuario);
                Menu menu = new Menu(idusuario, idrol);
                menu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Alguno de los datos es incorrecto");
            }
        }

        private void textBoxContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            //icon ocultar al frente
            Pbocultar.BringToFront();
            //mostrar contraseña
            textBoxContra.PasswordChar = '\0';
        }

        private void Pbocultar_Click(object sender, EventArgs e)
        {
            //icon mostrar al frente
            pbMostrar.BringToFront();
            //ocultar contraseña
            textBoxContra.PasswordChar = '*';
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}