namespace GestionInventario_MySQL_.Views
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            buttonUsuario = new Button();
            button1 = new Button();
            buttonProveedor = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            btncerrar = new PictureBox();
            btnminimizar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).BeginInit();
            SuspendLayout();
            // 
            // buttonUsuario
            // 
            buttonUsuario.Location = new Point(56, 66);
            buttonUsuario.Name = "buttonUsuario";
            buttonUsuario.Size = new Size(170, 63);
            buttonUsuario.TabIndex = 0;
            buttonUsuario.Text = "Gestionar Usuarios";
            buttonUsuario.UseVisualStyleBackColor = true;
            buttonUsuario.Click += buttonUsuario_Click;
            // 
            // button1
            // 
            button1.Location = new Point(56, 147);
            button1.Name = "button1";
            button1.Size = new Size(170, 63);
            button1.TabIndex = 1;
            button1.Text = "Gestionar Productos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonProveedor
            // 
            buttonProveedor.Location = new Point(56, 225);
            buttonProveedor.Name = "buttonProveedor";
            buttonProveedor.Size = new Size(170, 63);
            buttonProveedor.TabIndex = 2;
            buttonProveedor.Text = "Gestionar Proveedor";
            buttonProveedor.UseVisualStyleBackColor = true;
            buttonProveedor.Click += buttonProveedor_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 300);
            button2.Name = "button2";
            button2.Size = new Size(104, 29);
            button2.TabIndex = 3;
            button2.Text = "Cerrar Sesion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(146, 165, 223);
            pictureBox1.Location = new Point(-3, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 41);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.MouseMove += pictureBox1_MouseMove_1;
            // 
            // btncerrar
            // 
            btncerrar.BackColor = Color.FromArgb(146, 165, 223);
            btncerrar.Image = (Image)resources.GetObject("btncerrar.Image");
            btncerrar.Location = new Point(257, 11);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(44, 29);
            btncerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btncerrar.TabIndex = 7;
            btncerrar.TabStop = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // btnminimizar
            // 
            btnminimizar.BackColor = Color.FromArgb(146, 165, 223);
            btnminimizar.Image = (Image)resources.GetObject("btnminimizar.Image");
            btnminimizar.Location = new Point(219, 11);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(44, 29);
            btnminimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnminimizar.TabIndex = 8;
            btnminimizar.TabStop = false;
            btnminimizar.Click += btnminimizar_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 336);
            Controls.Add(btnminimizar);
            Controls.Add(btncerrar);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(buttonProveedor);
            Controls.Add(button1);
            Controls.Add(buttonUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonUsuario;
        private Button button1;
        private Button buttonProveedor;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox btncerrar;
        private PictureBox btnminimizar;
    }
}