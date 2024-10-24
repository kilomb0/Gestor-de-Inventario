using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionInventario_MySQL_.Selects;
using GestionInventario_MySQL_.Controllers;
using MySql.Data.MySqlClient;

namespace GestionInventario_MySQL_.Views
{
    public partial class FormUsuario : Form
    {
        UsuarioSelect select = new UsuarioSelect();
        UsuarioController ctrl = new UsuarioController();
        bool modificar = false;
        bool nuevo = false;
        int idusuario, idrol;
        MySqlDataReader results;
        public FormUsuario(int idusuario, int idrol)
        {
            this.idrol = idrol;
            this.idusuario = idusuario;
            InitializeComponent();
            buttonGuardar.Enabled = false;
            buttonModificar.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonCancelar.Enabled = false;
            textBoxNombre.TextChanged += TextBox_TextChanged;
            textBoxContra.TextChanged += TextBox_TextChanged;
            textBoxCI.TextChanged += TextBox_TextChanged;
            comboBox1.TextChanged += TextBox_TextChanged;
            CargarLista();
            DesactivarCampos();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            int idrol;
            if (!modificar)
            {
                idrol = select.BuscarID(comboBox1.Text);
                ctrl.Agregar(idrol, textBoxNombre.Text, textBoxContra.Text, textBoxCI.Text);
            }
            else
            {
                idrol = select.BuscarID(comboBox1.Text);
                int idusuario = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
                ctrl.Actualizar(idusuario, idrol, textBoxNombre.Text, textBoxContra.Text, textBoxCI.Text);
            }
            buttonModificar.Enabled = false;
            listView1.Items.Clear();
            modificar = false;
            nuevo = false;
            buttonNuevo.Enabled = true;
            buttonGuardar.Enabled = false;
            buttonCancelar.Enabled = false;
            CargarLista();
            DesactivarCampos();
        }

        private void CargarLista()
        {
            results = select.Lista();
            while (results.Read())
            {
                ListViewItem item = new ListViewItem(results.GetInt32(0).ToString());
                item.SubItems.Add(results.GetString(1));
                item.SubItems.Add(results.GetString(2));
                item.SubItems.Add(results.GetString(3));
                item.SubItems.Add(results.GetString(4));
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                comboBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBoxNombre.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBoxContra.Text = listView1.SelectedItems[0].SubItems[3].Text;
                textBoxCI.Text = listView1.SelectedItems[0].SubItems[4].Text;
                buttonModificar.Enabled = true;
                buttonEliminar.Enabled = true;
            }
            else
            {
                buttonModificar.Enabled = false;
                buttonEliminar.Enabled = false;
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            modificar = true;
            buttonGuardar.Enabled = true;
            buttonNuevo.Enabled = false;
            buttonModificar.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonCancelar.Enabled = true;
            ActivarCampos();

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
            if (id==idusuario)
            {
                MessageBox.Show("No es posible eliminar el usuario. Cierre sesión e intente el borrado desde otro usuario.");
            }
            else
            {
                ctrl.Eliminar(id);
            }
            listView1.Items.Clear();
            buttonEliminar.Enabled = false;
            buttonModificar.Enabled = false;
            CargarLista();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(idusuario, idrol);
            menu.Show();
            this.Close();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = string.Empty;
            textBoxCI.Text = string.Empty;
            textBoxContra.Text = string.Empty;
            comboBox1.SelectedItem = null;
            buttonNuevo.Enabled = false;
            nuevo = true;
            buttonModificar.Enabled = false;
            buttonCancelar.Enabled = true;
            buttonEliminar.Enabled = false;
            ActivarCampos();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = !string.IsNullOrEmpty(textBoxNombre.Text) &&
                                    !string.IsNullOrEmpty(textBoxContra.Text) &&
                                    !string.IsNullOrEmpty(textBoxCI.Text) &&
                                    !string.IsNullOrEmpty(comboBox1.Text) &&
                                    (nuevo || modificar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonNuevo.Enabled = true;
            buttonEliminar.Enabled = false;
            buttonModificar.Enabled = false;
            buttonGuardar.Enabled = false;
            nuevo = false;
            modificar = false;
            textBoxContra.Clear();
            textBoxCI.Clear();
            textBoxNombre.Clear();
            comboBox1.SelectedItem = null;
            buttonCancelar.Enabled = false;
            DesactivarCampos();
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

        private void DesactivarCampos()
        {
            textBoxNombre.Enabled = false;
            textBoxCI.Enabled = false;
            textBoxContra.Enabled = false;
            comboBox1.Enabled = false;
        }
        private void ActivarCampos()
        {
            textBoxNombre.Enabled = true;
            textBoxCI.Enabled = true;
            textBoxContra.Enabled = true;
            comboBox1.Enabled = true;
        }
    }
}
