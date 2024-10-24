namespace GestionInventario_MySQL_.Views
{
    partial class FormProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProveedor));
            listViewproducto = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label1 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxNombre = new TextBox();
            textBoxCorreo = new TextBox();
            textBoxTelefono = new TextBox();
            textBoxDocumento = new TextBox();
            buttonEliminar = new Button();
            buttonModificar = new Button();
            buttonGuardar = new Button();
            comboBoxDepartamento = new ComboBox();
            comboBoxCiudad = new ComboBox();
            pictureBox2 = new PictureBox();
            btnminimizar = new PictureBox();
            btncerrar = new PictureBox();
            btnatras = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            buttonNuevo = new Button();
            buttonCancelar = new Button();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listViewproducto
            // 
            listViewproducto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewproducto.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewproducto.Location = new Point(12, 132);
            listViewproducto.Name = "listViewproducto";
            listViewproducto.Size = new Size(391, 278);
            listViewproducto.TabIndex = 1;
            listViewproducto.UseCompatibleStateImageBehavior = false;
            listViewproducto.View = View.Details;
            listViewproducto.SelectedIndexChanged += listViewproducto_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "IDProveedor";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ciudad";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Proveedor";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Documento";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Telefono";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Correo";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(421, 135);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(421, 178);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 3;
            label2.Text = "Documento";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(421, 278);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 4;
            label3.Text = "Correo";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(421, 228);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 5;
            label4.Text = "Telefono";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxNombre.Location = new Point(506, 136);
            textBoxNombre.MaxLength = 15;
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(159, 27);
            textBoxNombre.TabIndex = 6;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxCorreo.Location = new Point(506, 275);
            textBoxCorreo.MaxLength = 30;
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(159, 27);
            textBoxCorreo.TabIndex = 7;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxTelefono.Location = new Point(506, 228);
            textBoxTelefono.MaxLength = 15;
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(159, 27);
            textBoxTelefono.TabIndex = 8;
            textBoxTelefono.KeyPress += textBoxTelefono_KeyPress;
            // 
            // textBoxDocumento
            // 
            textBoxDocumento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxDocumento.Location = new Point(506, 178);
            textBoxDocumento.MaxLength = 15;
            textBoxDocumento.Name = "textBoxDocumento";
            textBoxDocumento.Size = new Size(159, 27);
            textBoxDocumento.TabIndex = 9;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEliminar.Location = new Point(636, 330);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(88, 60);
            buttonEliminar.TabIndex = 16;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonBorrar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonModificar.Location = new Point(542, 330);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(88, 60);
            buttonModificar.TabIndex = 15;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonGuardar.Location = new Point(494, 396);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(88, 60);
            buttonGuardar.TabIndex = 14;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // comboBoxDepartamento
            // 
            comboBoxDepartamento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxDepartamento.FormattingEnabled = true;
            comboBoxDepartamento.Location = new Point(784, 132);
            comboBoxDepartamento.Name = "comboBoxDepartamento";
            comboBoxDepartamento.Size = new Size(108, 28);
            comboBoxDepartamento.TabIndex = 17;
            comboBoxDepartamento.SelectedIndexChanged += comboBoxDepartamento_SelectedIndexChanged;
            // 
            // comboBoxCiudad
            // 
            comboBoxCiudad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxCiudad.FormattingEnabled = true;
            comboBoxCiudad.Location = new Point(734, 178);
            comboBoxCiudad.Name = "comboBoxCiudad";
            comboBoxCiudad.Size = new Size(158, 28);
            comboBoxCiudad.TabIndex = 18;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(146, 165, 223);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(859, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnminimizar
            // 
            btnminimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnminimizar.BackColor = Color.FromArgb(146, 165, 223);
            btnminimizar.Image = (Image)resources.GetObject("btnminimizar.Image");
            btnminimizar.Location = new Point(820, 8);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(33, 29);
            btnminimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnminimizar.TabIndex = 21;
            btnminimizar.TabStop = false;
            btnminimizar.Click += btnminimizar_Click;
            // 
            // btncerrar
            // 
            btncerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btncerrar.BackColor = Color.FromArgb(146, 165, 223);
            btncerrar.Image = (Image)resources.GetObject("btncerrar.Image");
            btncerrar.Location = new Point(898, 8);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(33, 29);
            btncerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btncerrar.TabIndex = 20;
            btncerrar.TabStop = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // btnatras
            // 
            btnatras.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnatras.Location = new Point(12, 416);
            btnatras.Name = "btnatras";
            btnatras.Size = new Size(94, 29);
            btnatras.TabIndex = 23;
            btnatras.Text = "Atras";
            btnatras.UseVisualStyleBackColor = true;
            btnatras.Click += btnatras_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(146, 165, 223);
            pictureBox1.Location = new Point(-2, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(955, 50);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.MouseMove += pictureBox1_MouseMove_1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(672, 135);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 24;
            label5.Text = "Departamento";
            // 
            // buttonNuevo
            // 
            buttonNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonNuevo.Location = new Point(448, 330);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(88, 60);
            buttonNuevo.TabIndex = 25;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancelar.Location = new Point(588, 396);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(88, 60);
            buttonCancelar.TabIndex = 26;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(293, 45);
            label6.Name = "label6";
            label6.Size = new Size(337, 70);
            label6.TabIndex = 27;
            label6.Text = "Proveedor";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(672, 181);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 28;
            label7.Text = "Ciudad";
            label7.Click += label7_Click;
            // 
            // FormProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 481);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonNuevo);
            Controls.Add(label5);
            Controls.Add(btnatras);
            Controls.Add(pictureBox2);
            Controls.Add(btnminimizar);
            Controls.Add(btncerrar);
            Controls.Add(pictureBox1);
            Controls.Add(comboBoxCiudad);
            Controls.Add(comboBoxDepartamento);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonModificar);
            Controls.Add(buttonGuardar);
            Controls.Add(textBoxDocumento);
            Controls.Add(textBoxTelefono);
            Controls.Add(textBoxCorreo);
            Controls.Add(textBoxNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listViewproducto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProveedor";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewproducto;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxNombre;
        private TextBox textBoxCorreo;
        private TextBox textBoxTelefono;
        private TextBox textBoxDocumento;
        private Button buttonEliminar;
        private Button buttonModificar;
        private Button buttonGuardar;
        private ComboBox comboBoxDepartamento;
        private ComboBox comboBoxCiudad;
        private ColumnHeader columnHeader6;
        private PictureBox pictureBox2;
        private PictureBox btnminimizar;
        private PictureBox btncerrar;
        private PictureBox pictureBox1;
        private Button btnatras;
        private Label label5;
        private Button buttonNuevo;
        private Button buttonCancelar;
        private Label label6;
        private Label label7;
    }
}