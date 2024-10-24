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
using GestionInventario_MySQL_.Selects;
using GestionInventario_MySQL_.Controllers;

namespace GestionInventario_MySQL_.Views
{
    public partial class FormProducto : Form
    {
        int idusuario, idrol;
        bool modificar = false;
        bool nuevo = false;
        ProductoSelect select = new ProductoSelect();
        ProductoController ctrl = new ProductoController();
        public FormProducto(int idusuario, int idrol)
        {
            this.idusuario = idusuario;
            this.idrol = idrol;
            InitializeComponent();
            buttonModificar.Enabled = false;
            buttonBorrar.Enabled = false;
            buttonCancelar.Enabled = false;
            textBoxCantidad.TextChanged += TextBox_TextChanged;
            textBoxModelo.TextChanged += TextBox_TextChanged;
            textBoxPrecio.TextChanged += TextBox_TextChanged;
            comboBoxAlmacen.TextChanged += TextBox_TextChanged;
            comboBoxCategoria.TextChanged += TextBox_TextChanged;
            comboBoxCondicion.TextChanged += TextBox_TextChanged;
            comboBoxMarca.TextChanged += TextBox_TextChanged;
            comboBoxProveedor.TextChanged += TextBox_TextChanged;
            CargarProducto();
            CargarProveedor();
            CargarCategoria();
            CargarCondicion();
            CargarMarca();
            buttonGuardar.Enabled = false;
            desactivarCampos();
        }


        public void CargarProveedor()
        {
            MySqlDataReader results;
            results = select.Lista("nombre", "proveedor");
            while (results.Read())
            {
                comboBoxProveedor.Items.Add(results.GetString(0));
            }
        }


        public void CargarMarca()
        {
            MySqlDataReader results;
            results = select.Lista("nombre", "marca");
            while (results.Read())
            {
                comboBoxMarca.Items.Add(results.GetString(0));
            }
        }

        public void CargarCondicion()
        {
            MySqlDataReader results;
            results = select.Lista("descripcion", "condicion");
            while (results.Read())
            {
                comboBoxCondicion.Items.Add(results.GetString(0));
            }
        }

        public void CargarCategoria()
        {
            MySqlDataReader results;
            results = select.Lista("descripcion", "categoria");
            while (results.Read())
            {
                comboBoxCategoria.Items.Add(results.GetString(0));
            }
        }

        public void CargarProducto()
        {
            MySqlDataReader results = select.CargarProveedor();
            listView1.Items.Clear();
            while (results.Read())
            {
                ListViewItem item = new ListViewItem(results.GetInt32(0).ToString());
                if (!results.IsDBNull(results.GetOrdinal("idusuario")))
                {
                    item.SubItems.Add(results.GetInt32(1).ToString());
                }
                else
                {
                    item.SubItems.Add("Nulo");
                }
                item.SubItems.Add(results.GetString(2));
                item.SubItems.Add(results.GetString(3));
                item.SubItems.Add(results.GetString(4));
                item.SubItems.Add(results.GetString(5));
                item.SubItems.Add(results.GetInt32(6).ToString());
                item.SubItems.Add(results.GetString(7));
                item.SubItems.Add(results.GetDouble(8).ToString());
                item.SubItems.Add(results.GetInt32(9).ToString());
                item.SubItems.Add(results.GetDouble(10).ToString());
                listView1.Items.Add(item);
            }
        }



        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            int idproveedor, idmarca, idcategoria, idcondicion, idalmacen, idproducto;
            if (!modificar)
            {
                idproveedor = select.BuscarID("proveedor", "nombre", comboBoxProveedor.Text);
                idmarca = select.BuscarID("marca", "nombre", comboBoxMarca.Text);
                idcategoria = select.BuscarID("categoria", "descripcion", comboBoxCategoria.Text);
                idcondicion = select.BuscarID("condicion", "descripcion", comboBoxCondicion.Text);
                idalmacen = Convert.ToInt32(comboBoxAlmacen.Text);
                ctrl.Agregar(idproveedor, idusuario, idmarca, idcategoria, idcondicion, idalmacen, textBoxModelo.Text, Convert.ToDouble(textBoxPrecio.Text), Convert.ToInt32(textBoxCantidad.Text));
            }
            else
            {
                idproveedor = select.BuscarID("proveedor", "nombre", comboBoxProveedor.Text);
                idmarca = select.BuscarID("marca", "nombre", comboBoxMarca.Text);
                idcategoria = select.BuscarID("categoria", "descripcion", comboBoxCategoria.Text);
                idcondicion = select.BuscarID("condicion", "descripcion", comboBoxCondicion.Text);
                idalmacen = Convert.ToInt32(comboBoxAlmacen.Text);
                idproducto = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
                ctrl.Actualizar(idproducto, idproveedor, idusuario, idmarca, idcategoria, idcondicion, idalmacen, textBoxModelo.Text, Convert.ToDouble(textBoxPrecio.Text), Convert.ToInt32(textBoxCantidad.Text));
            }
            buttonBorrar.Enabled = false;
            buttonModificar.Enabled = false;
            buttonNuevo.Enabled = true;
            listView1.Items.Clear();
            modificar = false;
            nuevo = false;
            buttonGuardar.Enabled = false;
            buttonCancelar.Enabled = false;
            CargarProducto();
            desactivarCampos();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            modificar = true;
            buttonGuardar.Enabled = true;
            buttonModificar.Enabled = false;
            buttonBorrar.Enabled = false;
            buttonNuevo.Enabled = false;
            buttonCancelar.Enabled = true;
            activarCampos();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                textBoxModelo.Text = listView1.SelectedItems[0].SubItems[7].Text;
                textBoxPrecio.Text = listView1.SelectedItems[0].SubItems[8].Text;
                textBoxCantidad.Text = listView1.SelectedItems[0].SubItems[9].Text;
                comboBoxAlmacen.Text = listView1.SelectedItems[0].SubItems[6].Text;
                comboBoxProveedor.Text = listView1.SelectedItems[0].SubItems[2].Text;
                comboBoxMarca.Text = listView1.SelectedItems[0].SubItems[3].Text;
                comboBoxCategoria.Text = listView1.SelectedItems[0].SubItems[4].Text;
                comboBoxCondicion.Text = listView1.SelectedItems[0].SubItems[5].Text;
                buttonBorrar.Enabled = true;
                buttonModificar.Enabled = true;

            }
            else
            {
                buttonBorrar.Enabled = false;
                buttonModificar.Enabled = false;
            }
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            int idproducto = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
            ctrl.Eliminar(idproducto);
            listView1.Items.Clear();
            buttonBorrar.Enabled = false;
            buttonModificar.Enabled = false;
            CargarProducto();
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

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = !string.IsNullOrEmpty(textBoxModelo.Text) &&
                !string.IsNullOrEmpty(textBoxPrecio.Text) &&
                !string.IsNullOrEmpty(textBoxCantidad.Text) &&
                !string.IsNullOrEmpty(comboBoxAlmacen.Text) &&
                !string.IsNullOrEmpty(comboBoxProveedor.Text) &&
                !string.IsNullOrEmpty(comboBoxMarca.Text) &&
                !string.IsNullOrEmpty(comboBoxCategoria.Text) &&
                !string.IsNullOrEmpty(comboBoxCondicion.Text) &&
                (nuevo || modificar);
        }

        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            buttonModificar.Enabled = false;
            buttonBorrar.Enabled = false;
            buttonCancelar.Enabled = true;
            buttonNuevo.Enabled = false;
            nuevo = true;
            textBoxCantidad.Clear();
            textBoxModelo.Clear();
            textBoxPrecio.Clear();
            comboBoxAlmacen.SelectedItem = null;
            comboBoxCategoria.SelectedItem = null;
            comboBoxCondicion.SelectedItem = null;
            comboBoxMarca.SelectedItem = null;
            comboBoxProveedor.SelectedItem = null;
            activarCampos();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxCantidad.Clear();
            textBoxModelo.Clear();
            textBoxPrecio.Clear();
            comboBoxAlmacen.SelectedItem = null;
            comboBoxCategoria.SelectedItem = null;
            comboBoxCondicion.SelectedItem = null;
            comboBoxMarca.SelectedItem = null;
            comboBoxProveedor.SelectedItem = null;
            buttonNuevo.Enabled = true;
            buttonBorrar.Enabled = false;
            buttonModificar.Enabled = false;
            buttonGuardar.Enabled = false;
            buttonCancelar.Enabled = false;
            nuevo = false;
            modificar = false;
            desactivarCampos();
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

        private void desactivarCampos()
        {
            textBoxModelo.Enabled = false;
            textBoxPrecio.Enabled = false;
            textBoxCantidad.Enabled = false;
            comboBoxAlmacen.Enabled = false;
            comboBoxCategoria.Enabled = false;
            comboBoxCondicion.Enabled = false;
            comboBoxProveedor.Enabled = false;
            comboBoxMarca.Enabled = false;
        }

        private void activarCampos()
        {
            textBoxModelo.Enabled = true;
            textBoxPrecio.Enabled = true;
            textBoxCantidad.Enabled = true;
            comboBoxAlmacen.Enabled = true;
            comboBoxCategoria.Enabled = true;
            comboBoxCondicion.Enabled = true;
            comboBoxMarca.Enabled = true;
            comboBoxProveedor.Enabled = true;
        }
    }
}
