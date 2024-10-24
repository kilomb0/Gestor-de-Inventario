using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionInventario_MySQL_.DAO;
using GestionInventario_MySQL_.Selects;
using GestionInventario_MySQL_.Controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionInventario_MySQL_.Views
{
    public partial class FormProveedor : Form
    {
        ProveedorSelect select = new ProveedorSelect();
        ProveedorController ctrl = new ProveedorController();
        int idusuario, rolusuario;
        bool modificar = false;
        bool nuevo = false;
        public FormProveedor(int idusuario, int rolusuario)
        {
            this.rolusuario = rolusuario;
            this.idusuario = idusuario;
            InitializeComponent();
            buttonGuardar.Enabled = false;
            buttonModificar.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonCancelar.Enabled = false;
            textBoxNombre.TextChanged += TextBox_TextChanged;
            textBoxDocumento.TextChanged += TextBox_TextChanged;
            textBoxTelefono.TextChanged += TextBox_TextChanged;
            textBoxCorreo.TextChanged += TextBox_TextChanged;
            comboBoxDepartamento.TextChanged += TextBox_TextChanged;
            comboBoxCiudad.TextChanged += TextBox_TextChanged;
            CargarDepartamento();
            CargarProveedor();
            DesactivarCampos();
        }

        private void TextBox_TextChanged(object? sender, EventArgs e)
        {
            buttonGuardar.Enabled = !string.IsNullOrEmpty(textBoxNombre.Text) &&
                !string.IsNullOrEmpty(textBoxDocumento.Text) &&
                !string.IsNullOrEmpty(textBoxTelefono.Text) &&
                !string.IsNullOrEmpty(textBoxCorreo.Text) &&
                !string.IsNullOrEmpty(comboBoxDepartamento.Text) &&
                !string.IsNullOrEmpty(comboBoxCiudad.Text) &&
                (nuevo || modificar);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            int idciudad;
            if (!modificar)
            {
                idciudad = select.BuscarID("ciudad", "nombre", comboBoxCiudad.Text);
                ctrl.Agregar(textBoxNombre.Text, textBoxDocumento.Text, textBoxTelefono.Text, textBoxCorreo.Text, idciudad);
            }
            else
            {
                int idproveedor = Convert.ToInt32(listViewproducto.SelectedItems[0].SubItems[0].Text);
                idciudad = select.BuscarID("ciudad", "nombre", comboBoxCiudad.Text);
                ctrl.Actualizar(idproveedor, textBoxNombre.Text, textBoxDocumento.Text, textBoxTelefono.Text, textBoxCorreo.Text, idciudad);
            }
            buttonEliminar.Enabled = false;
            buttonModificar.Enabled = false;
            listViewproducto.Items.Clear();
            modificar = false;
            nuevo = false;
            buttonGuardar.Enabled = false;
            buttonNuevo.Enabled = true;
            buttonCancelar.Enabled = false;
            CargarProveedor();
            DesactivarCampos();
        }



        public void CargarDepartamento()
        {
            MySqlDataReader results;
            results = select.ListaDepartamento("nombre", "departamento");
            while (results.Read())
            {
                comboBoxDepartamento.Items.Add(results.GetString(0));
            }
        }
        public void CargarCiudad()
        {
            MySqlDataReader results;
            int iddepartamento = select.BuscarID("departamento", "nombre", comboBoxDepartamento.Text);
            results = select.ListaCiudad(iddepartamento);
            while (results.Read())
            {
                comboBoxCiudad.Items.Add(results.GetString(0));
            }
        }

        public void CargarProveedor()
        {
            listViewproducto.Items.Clear();
            MySqlDataReader results;
            results = select.CargarProveedor();
            while (results.Read())
            {
                ListViewItem item = new ListViewItem(results.GetInt32(0).ToString());
                item.SubItems.Add(results.GetString(1));
                item.SubItems.Add(results.GetString(2));
                item.SubItems.Add(results.GetString(3));
                item.SubItems.Add(results.GetString(4));
                item.SubItems.Add(results.GetString(5));
                listViewproducto.Items.Add(item);
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            modificar = true;
            buttonModificar.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonNuevo.Enabled = false;
            buttonCancelar.Enabled = true;
            ActivarCampos();
        }

        private void comboBoxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCiudad.Items.Clear();
            CargarCiudad();
            comboBoxCiudad.Text = comboBoxCiudad.Items[0].ToString();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            int idproveedor = Convert.ToInt32(listViewproducto.SelectedItems[0].SubItems[0].Text);
            ctrl.Eliminar(idproveedor);
            listViewproducto.Items.Clear();
            buttonEliminar.Enabled = false;
            buttonModificar.Enabled = false;
            CargarProveedor();
        }

        private void listViewproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewproducto.SelectedIndices.Count > 0)
            {
                textBoxNombre.Text = listViewproducto.SelectedItems[0].SubItems[2].Text;
                textBoxDocumento.Text = listViewproducto.SelectedItems[0].SubItems[3].Text;
                textBoxTelefono.Text = listViewproducto.SelectedItems[0].SubItems[4].Text;
                textBoxCorreo.Text = listViewproducto.SelectedItems[0].SubItems[5].Text;
                buttonModificar.Enabled = true;
                buttonEliminar.Enabled = true;
            }
            else
            {
                buttonModificar.Enabled = false;
                buttonEliminar.Enabled = false;
            }
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(idusuario, rolusuario);
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

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            textBoxNombre.Clear();
            textBoxDocumento.Clear();
            textBoxCorreo.Clear();
            textBoxTelefono.Clear();
            comboBoxCiudad.SelectedItem = null;
            nuevo = true;
            buttonModificar.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonCancelar.Enabled = true;
            buttonNuevo.Enabled = false;
            ActivarCampos();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            buttonNuevo.Enabled = true;
            buttonEliminar.Enabled = false;
            buttonModificar.Enabled = false;
            buttonGuardar.Enabled = false;
            buttonCancelar.Enabled = false;
            nuevo = false;
            modificar = false;
            textBoxNombre.Clear();
            textBoxDocumento.Clear();
            textBoxCorreo.Clear();
            textBoxTelefono.Clear();
            comboBoxCiudad.SelectedItem = null;
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
            textBoxDocumento.Enabled = false;
            textBoxCorreo.Enabled = false;
            textBoxTelefono.Enabled = false;
            comboBoxCiudad.Enabled = false;
            comboBoxDepartamento.Enabled = false;
        }

        private void ActivarCampos()
        {
            textBoxNombre.Enabled = true;
            textBoxDocumento.Enabled = true;
            textBoxCorreo.Enabled = true;
            textBoxTelefono.Enabled = true;
            comboBoxCiudad.Enabled = true;
            comboBoxDepartamento.Enabled = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
