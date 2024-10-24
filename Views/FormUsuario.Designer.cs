namespace GestionInventario_MySQL_.Views
{
    partial class FormUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            textBoxNombre = new TextBox();
            textBoxContra = new TextBox();
            textBoxCI = new TextBox();
            comboBox1 = new ComboBox();
            buttonNuevo = new Button();
            buttonGuardar = new Button();
            buttonModificar = new Button();
            buttonEliminar = new Button();
            btnminimizar = new PictureBox();
            btncerrar = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnatras = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonCancelar = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.Location = new Point(24, 125);
            listView1.Name = "listView1";
            listView1.Size = new Size(392, 273);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Rol";
            columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Nombre";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Contraseña";
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "CI";
            columnHeader5.Width = 70;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxNombre.Location = new Point(544, 155);
            textBoxNombre.MaxLength = 15;
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(172, 27);
            textBoxNombre.TabIndex = 1;
            // 
            // textBoxContra
            // 
            textBoxContra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxContra.Location = new Point(544, 324);
            textBoxContra.MaxLength = 15;
            textBoxContra.Name = "textBoxContra";
            textBoxContra.Size = new Size(172, 27);
            textBoxContra.TabIndex = 2;
            // 
            // textBoxCI
            // 
            textBoxCI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxCI.Location = new Point(544, 213);
            textBoxCI.MaxLength = 15;
            textBoxCI.Name = "textBoxCI";
            textBoxCI.Size = new Size(172, 27);
            textBoxCI.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Encargado" });
            comboBox1.Location = new Point(544, 269);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(172, 28);
            comboBox1.TabIndex = 4;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonNuevo.Location = new Point(455, 359);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(100, 52);
            buttonNuevo.TabIndex = 5;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonGuardar.Location = new Point(517, 417);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(96, 52);
            buttonGuardar.TabIndex = 6;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonModificar.Location = new Point(572, 359);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(96, 52);
            buttonModificar.TabIndex = 7;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonEliminar.Location = new Point(683, 359);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(106, 52);
            buttonEliminar.TabIndex = 8;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // btnminimizar
            // 
            btnminimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnminimizar.BackColor = Color.FromArgb(146, 165, 223);
            btnminimizar.Image = (Image)resources.GetObject("btnminimizar.Image");
            btnminimizar.Location = new Point(683, 12);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(33, 29);
            btnminimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnminimizar.TabIndex = 11;
            btnminimizar.TabStop = false;
            btnminimizar.Click += btnminimizar_Click;
            // 
            // btncerrar
            // 
            btncerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btncerrar.BackColor = Color.FromArgb(146, 165, 223);
            btncerrar.Image = (Image)resources.GetObject("btncerrar.Image");
            btncerrar.Location = new Point(760, 12);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(33, 29);
            btncerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btncerrar.TabIndex = 10;
            btncerrar.TabStop = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(146, 165, 223);
            pictureBox1.Location = new Point(-7, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(816, 51);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.MouseMove += pictureBox1_MouseMove_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(146, 165, 223);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(721, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnatras
            // 
            btnatras.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnatras.Location = new Point(24, 404);
            btnatras.Name = "btnatras";
            btnatras.Size = new Size(94, 29);
            btnatras.TabIndex = 13;
            btnatras.Text = "Atras";
            btnatras.UseVisualStyleBackColor = true;
            btnatras.Click += btnatras_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(455, 153);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 14;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(455, 211);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 15;
            label2.Text = "CI";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(455, 275);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 16;
            label3.Text = "Rol";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(455, 327);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 17;
            label4.Text = "Contraseña";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancelar.Location = new Point(631, 417);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(100, 52);
            buttonCancelar.TabIndex = 18;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += button1_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(296, 50);
            label6.Name = "label6";
            label6.Size = new Size(259, 70);
            label6.TabIndex = 28;
            label6.Text = "Usuario";
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 500);
            Controls.Add(label6);
            Controls.Add(buttonCancelar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnatras);
            Controls.Add(pictureBox2);
            Controls.Add(btnminimizar);
            Controls.Add(btncerrar);
            Controls.Add(pictureBox1);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonModificar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonNuevo);
            Controls.Add(comboBox1);
            Controls.Add(textBoxCI);
            Controls.Add(textBoxContra);
            Controls.Add(textBoxNombre);
            Controls.Add(listView1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUsuario";
            Load += FormUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)btnminimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private TextBox textBoxNombre;
        private TextBox textBoxContra;
        private TextBox textBoxCI;
        private ComboBox comboBox1;
        private Button buttonNuevo;
        private Button buttonGuardar;
        private Button buttonModificar;
        private Button buttonEliminar;
        private PictureBox btnminimizar;
        private PictureBox btncerrar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnatras;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonCancelar;
        private Label label6;
    }
}