namespace GestionInventario_MySQL_.Views
{
    partial class FormProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducto));
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            textBoxModelo = new TextBox();
            textBoxPrecio = new TextBox();
            textBoxCantidad = new TextBox();
            comboBoxAlmacen = new ComboBox();
            comboBoxProveedor = new ComboBox();
            comboBoxCategoria = new ComboBox();
            comboBoxCondicion = new ComboBox();
            comboBoxMarca = new ComboBox();
            buttonGuardar = new Button();
            buttonModificar = new Button();
            buttonBorrar = new Button();
            pictureBox2 = new PictureBox();
            btnminimizar = new PictureBox();
            btncerrar = new PictureBox();
            pictureBox1 = new PictureBox();
            btnatras = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            buttonNuevo = new Button();
            buttonCancelar = new Button();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listView1.Location = new Point(20, 133);
            listView1.Name = "listView1";
            listView1.Size = new Size(670, 442);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "IDProducto";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "IDUsuario";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Proveedor";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Marca";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Categoria";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Condicion";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Almacen";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Modelo";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Precio Unitario";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Cantidad";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Total";
            // 
            // textBoxModelo
            // 
            textBoxModelo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxModelo.Location = new Point(816, 124);
            textBoxModelo.MaxLength = 15;
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.Size = new Size(211, 27);
            textBoxModelo.TabIndex = 1;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxPrecio.Location = new Point(816, 233);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(211, 27);
            textBoxPrecio.TabIndex = 2;
            textBoxPrecio.KeyPress += textBoxPrecio_KeyPress;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxCantidad.Location = new Point(818, 352);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(209, 27);
            textBoxCantidad.TabIndex = 3;
            textBoxCantidad.KeyPress += textBoxCantidad_KeyPress;
            // 
            // comboBoxAlmacen
            // 
            comboBoxAlmacen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxAlmacen.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAlmacen.FormattingEnabled = true;
            comboBoxAlmacen.Items.AddRange(new object[] { "1", "2", "3" });
            comboBoxAlmacen.Location = new Point(816, 173);
            comboBoxAlmacen.Name = "comboBoxAlmacen";
            comboBoxAlmacen.Size = new Size(69, 28);
            comboBoxAlmacen.TabIndex = 4;
            // 
            // comboBoxProveedor
            // 
            comboBoxProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProveedor.FormattingEnabled = true;
            comboBoxProveedor.Location = new Point(816, 293);
            comboBoxProveedor.Name = "comboBoxProveedor";
            comboBoxProveedor.Size = new Size(211, 28);
            comboBoxProveedor.TabIndex = 5;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(818, 413);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(209, 28);
            comboBoxCategoria.TabIndex = 8;
            // 
            // comboBoxCondicion
            // 
            comboBoxCondicion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxCondicion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCondicion.FormattingEnabled = true;
            comboBoxCondicion.Location = new Point(820, 469);
            comboBoxCondicion.Name = "comboBoxCondicion";
            comboBoxCondicion.Size = new Size(207, 28);
            comboBoxCondicion.TabIndex = 9;
            // 
            // comboBoxMarca
            // 
            comboBoxMarca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMarca.FormattingEnabled = true;
            comboBoxMarca.Location = new Point(820, 526);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(207, 28);
            comboBoxMarca.TabIndex = 10;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonGuardar.Location = new Point(785, 607);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(89, 28);
            buttonGuardar.TabIndex = 11;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonModificar.Location = new Point(832, 573);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(89, 28);
            buttonModificar.TabIndex = 12;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonBorrar
            // 
            buttonBorrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonBorrar.Location = new Point(927, 573);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(89, 28);
            buttonBorrar.TabIndex = 13;
            buttonBorrar.Text = "Eliminar";
            buttonBorrar.UseVisualStyleBackColor = true;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(146, 165, 223);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(959, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnminimizar
            // 
            btnminimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnminimizar.BackColor = Color.FromArgb(146, 165, 223);
            btnminimizar.Image = (Image)resources.GetObject("btnminimizar.Image");
            btnminimizar.Location = new Point(921, 12);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(33, 29);
            btnminimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnminimizar.TabIndex = 16;
            btnminimizar.TabStop = false;
            btnminimizar.Click += btnminimizar_Click;
            // 
            // btncerrar
            // 
            btncerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btncerrar.BackColor = Color.FromArgb(146, 165, 223);
            btncerrar.Image = (Image)resources.GetObject("btncerrar.Image");
            btncerrar.Location = new Point(998, 12);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(33, 29);
            btncerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btncerrar.TabIndex = 15;
            btncerrar.TabStop = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(146, 165, 223);
            pictureBox1.Location = new Point(0, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1044, 50);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.MouseMove += pictureBox1_MouseMove_1;
            // 
            // btnatras
            // 
            btnatras.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnatras.Location = new Point(20, 582);
            btnatras.Name = "btnatras";
            btnatras.Size = new Size(94, 29);
            btnatras.TabIndex = 18;
            btnatras.Text = "Atras";
            btnatras.UseVisualStyleBackColor = true;
            btnatras.Click += btnatras_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(709, 128);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 19;
            label1.Text = "Modelo";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(709, 233);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 20;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(711, 355);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 21;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(711, 416);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 22;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(711, 472);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 23;
            label5.Text = "Condicion";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(709, 293);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 24;
            label6.Text = "Proveedor";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(711, 534);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 25;
            label7.Text = "Marca";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(711, 181);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 26;
            label8.Text = "Almacen";
            // 
            // buttonNuevo
            // 
            buttonNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonNuevo.Location = new Point(737, 573);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(89, 28);
            buttonNuevo.TabIndex = 27;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancelar.Location = new Point(880, 607);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(89, 28);
            buttonCancelar.TabIndex = 28;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(380, 48);
            label9.Name = "label9";
            label9.Size = new Size(299, 70);
            label9.TabIndex = 29;
            label9.Text = "Producto";
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 657);
            Controls.Add(label9);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonNuevo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnminimizar);
            Controls.Add(btncerrar);
            Controls.Add(pictureBox2);
            Controls.Add(btnatras);
            Controls.Add(pictureBox1);
            Controls.Add(buttonBorrar);
            Controls.Add(buttonModificar);
            Controls.Add(buttonGuardar);
            Controls.Add(comboBoxMarca);
            Controls.Add(comboBoxCondicion);
            Controls.Add(comboBoxCategoria);
            Controls.Add(comboBoxProveedor);
            Controls.Add(comboBoxAlmacen);
            Controls.Add(textBoxCantidad);
            Controls.Add(textBoxPrecio);
            Controls.Add(textBoxModelo);
            Controls.Add(listView1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProducto";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private TextBox textBoxModelo;
        private TextBox textBoxPrecio;
        private TextBox textBoxCantidad;
        private ComboBox comboBoxAlmacen;
        private ComboBox comboBoxProveedor;
        private ComboBox comboBoxCategoria;
        private ComboBox comboBoxCondicion;
        private ComboBox comboBoxMarca;
        private Button buttonGuardar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private Button buttonModificar;
        private Button buttonBorrar;
        private PictureBox pictureBox2;
        private PictureBox btnminimizar;
        private PictureBox btncerrar;
        private PictureBox pictureBox1;
        private Button btnatras;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button buttonNuevo;
        private Button buttonCancelar;
        private Label label9;
    }
}