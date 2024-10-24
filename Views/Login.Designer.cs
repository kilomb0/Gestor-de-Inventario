namespace GestionInventario_MySQL_
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            textBoxNombre = new TextBox();
            textBoxContra = new TextBox();
            buttonIngresar = new Button();
            pictureBox1 = new PictureBox();
            labelHora = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pbMostrar = new PictureBox();
            Pbocultar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMostrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pbocultar).BeginInit();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(424, 64);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(237, 27);
            textBoxNombre.TabIndex = 0;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // textBoxContra
            // 
            textBoxContra.Location = new Point(424, 152);
            textBoxContra.Name = "textBoxContra";
            textBoxContra.PasswordChar = '*';
            textBoxContra.Size = new Size(196, 27);
            textBoxContra.TabIndex = 1;
            textBoxContra.TextChanged += textBoxContra_TextChanged;
            // 
            // buttonIngresar
            // 
            buttonIngresar.Location = new Point(326, 215);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(128, 53);
            buttonIngresar.TabIndex = 2;
            buttonIngresar.Text = "Ingresar";
            buttonIngresar.UseVisualStyleBackColor = true;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(146, 165, 223);
            pictureBox1.Location = new Point(-1, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 339);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // labelHora
            // 
            labelHora.AutoSize = true;
            labelHora.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelHora.Location = new Point(389, 9);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(0, 38);
            labelHora.TabIndex = 6;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(491, 215);
            button1.Name = "button1";
            button1.Size = new Size(128, 53);
            button1.TabIndex = 7;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(146, 165, 223);
            label3.Font = new Font("Arial Rounded MT Bold", 34.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(50, 64);
            label3.Name = "label3";
            label3.Size = new Size(183, 66);
            label3.TabIndex = 8;
            label3.Text = "Bluey";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(146, 165, 223);
            label4.Font = new Font("Arial Rounded MT Bold", 34.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(-1, 132);
            label4.Name = "label4";
            label4.Size = new Size(289, 66);
            label4.TabIndex = 9;
            label4.Text = "Company";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(302, 44);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(302, 129);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 61);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pbMostrar
            // 
            pbMostrar.Cursor = Cursors.Hand;
            pbMostrar.Image = (Image)resources.GetObject("pbMostrar.Image");
            pbMostrar.Location = new Point(625, 152);
            pbMostrar.Name = "pbMostrar";
            pbMostrar.Size = new Size(36, 27);
            pbMostrar.SizeMode = PictureBoxSizeMode.Zoom;
            pbMostrar.TabIndex = 12;
            pbMostrar.TabStop = false;
            pbMostrar.Click += pbMostrar_Click;
            // 
            // Pbocultar
            // 
            Pbocultar.Cursor = Cursors.Hand;
            Pbocultar.Image = (Image)resources.GetObject("Pbocultar.Image");
            Pbocultar.Location = new Point(625, 152);
            Pbocultar.Name = "Pbocultar";
            Pbocultar.Size = new Size(36, 27);
            Pbocultar.SizeMode = PictureBoxSizeMode.Zoom;
            Pbocultar.TabIndex = 13;
            Pbocultar.TabStop = false;
            Pbocultar.Click += Pbocultar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 280);
            Controls.Add(pbMostrar);
            Controls.Add(Pbocultar);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(labelHora);
            Controls.Add(pictureBox1);
            Controls.Add(buttonIngresar);
            Controls.Add(textBoxContra);
            Controls.Add(textBoxNombre);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMostrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pbocultar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombre;
        private TextBox textBoxContra;
        private Button buttonIngresar;
        private PictureBox pictureBox1;
        private Label labelHora;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pbMostrar;
        private PictureBox Pbocultar;
    }
}