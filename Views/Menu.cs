using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInventario_MySQL_.Views
{
    public partial class Menu : Form
    {
        int idusuario, idrol;
        public Menu(int idusuario, int idrol)
        {
            this.idusuario = idusuario;
            this.idrol = idrol;
            InitializeComponent();
        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            FormUsuario usuario = new FormUsuario(idusuario, idrol);
            usuario.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProducto producto = new FormProducto(idusuario, idrol);
            producto.Show();
            this.Close();
        }

        private void buttonProveedor_Click(object sender, EventArgs e)
        {
            FormProveedor proveedor = new FormProveedor(idusuario, idrol);
            proveedor.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //mover ventana sin bordes
        public int xClick = 0, yClick = 0;


        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
