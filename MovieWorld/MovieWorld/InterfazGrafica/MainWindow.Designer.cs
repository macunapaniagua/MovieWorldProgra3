namespace MovieWorld
{
    partial class MainWindow
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCrearCuenta = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgPortada = new System.Windows.Forms.PictureBox();
            this.imgFondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPortada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(263, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(301, 55);
            this.lblTitulo.TabIndex = 27;
            this.lblTitulo.Text = "Movie World";
            // 
            // lblCrearCuenta
            // 
            this.lblCrearCuenta.AutoSize = true;
            this.lblCrearCuenta.BackColor = System.Drawing.Color.Transparent;
            this.lblCrearCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCrearCuenta.Location = new System.Drawing.Point(647, 201);
            this.lblCrearCuenta.Name = "lblCrearCuenta";
            this.lblCrearCuenta.Size = new System.Drawing.Size(68, 13);
            this.lblCrearCuenta.TabIndex = 28;
            this.lblCrearCuenta.Text = "Crear cuenta";
            this.lblCrearCuenta.Click += new System.EventHandler(this.lblCrearCuenta_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.Location = new System.Drawing.Point(553, 332);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(134, 33);
            this.btnIngresar.TabIndex = 33;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(523, 178);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(192, 20);
            this.txtUserName.TabIndex = 30;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUsuario.Location = new System.Drawing.Point(520, 155);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(62, 16);
            this.lblUsuario.TabIndex = 31;
            this.lblUsuario.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MovieWorld.Properties.Resources.Login;
            this.pictureBox1.Location = new System.Drawing.Point(481, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 371);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // imgPortada
            // 
            this.imgPortada.BackColor = System.Drawing.Color.Transparent;
            this.imgPortada.Image = global::MovieWorld.Properties.Resources.Peliculas;
            this.imgPortada.Location = new System.Drawing.Point(43, 146);
            this.imgPortada.Name = "imgPortada";
            this.imgPortada.Size = new System.Drawing.Size(435, 307);
            this.imgPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPortada.TabIndex = 20;
            this.imgPortada.TabStop = false;
            // 
            // imgFondo
            // 
            this.imgFondo.Image = global::MovieWorld.Properties.Resources.Background;
            this.imgFondo.Location = new System.Drawing.Point(0, 0);
            this.imgFondo.Name = "imgFondo";
            this.imgFondo.Size = new System.Drawing.Size(761, 512);
            this.imgFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFondo.TabIndex = 2;
            this.imgFondo.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 512);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblCrearCuenta);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.imgPortada);
            this.Controls.Add(this.imgFondo);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPortada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgFondo;
        private System.Windows.Forms.PictureBox imgPortada;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCrearCuenta;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;


    }
}