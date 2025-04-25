namespace Formulario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BOTONPASAR = new System.Windows.Forms.Button();
            this.TEXTNOMBRE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TEXTCONTRASEÑA = new System.Windows.Forms.TextBox();
            this.registrase = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BOTONPASAR
            // 
            this.BOTONPASAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOTONPASAR.Location = new System.Drawing.Point(126, 455);
            this.BOTONPASAR.Name = "BOTONPASAR";
            this.BOTONPASAR.Size = new System.Drawing.Size(180, 37);
            this.BOTONPASAR.TabIndex = 0;
            this.BOTONPASAR.Text = "INGRESAR";
            this.BOTONPASAR.UseVisualStyleBackColor = true;
            this.BOTONPASAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // TEXTNOMBRE
            // 
            this.TEXTNOMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXTNOMBRE.Location = new System.Drawing.Point(62, 303);
            this.TEXTNOMBRE.Name = "TEXTNOMBRE";
            this.TEXTNOMBRE.Size = new System.Drawing.Size(308, 29);
            this.TEXTNOMBRE.TabIndex = 3;
            this.TEXTNOMBRE.TextChanged += new System.EventHandler(this.TEXTNOMBRE_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "INGRESE USUARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "INGRESE USUARIO";
            // 
            // TEXTCONTRASEÑA
            // 
            this.TEXTCONTRASEÑA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXTCONTRASEÑA.Location = new System.Drawing.Point(62, 404);
            this.TEXTCONTRASEÑA.Name = "TEXTCONTRASEÑA";
            this.TEXTCONTRASEÑA.Size = new System.Drawing.Size(308, 29);
            this.TEXTCONTRASEÑA.TabIndex = 7;
            this.TEXTCONTRASEÑA.TextChanged += new System.EventHandler(this.TEXTCONTRASEÑA_TextChanged);
            // 
            // registrase
            // 
            this.registrase.AutoSize = true;
            this.registrase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrase.ForeColor = System.Drawing.Color.Blue;
            this.registrase.Location = new System.Drawing.Point(173, 516);
            this.registrase.Name = "registrase";
            this.registrase.Size = new System.Drawing.Size(84, 13);
            this.registrase.TabIndex = 9;
            this.registrase.Text = "REGISTRARSE";
            this.registrase.Click += new System.EventHandler(this.registrase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::Formulario.Properties.Resources._3d_abstract_3d_wallpaper_preview;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN DE USUARIO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Formulario.Properties.Resources.black_and_gray_ok06mdsh02ryv4ig;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Formulario.Properties.Resources.user_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(126, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Formulario.Properties.Resources.black_and_gray_ok06mdsh02ryv4ig;
            this.pictureBox2.Location = new System.Drawing.Point(-49, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(531, 587);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 574);
            this.Controls.Add(this.registrase);
            this.Controls.Add(this.TEXTCONTRASEÑA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TEXTNOMBRE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BOTONPASAR);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BOTONPASAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TEXTNOMBRE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TEXTCONTRASEÑA;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label registrase;
    }
}

