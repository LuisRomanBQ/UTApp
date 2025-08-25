namespace UTApp_POO
{
    partial class iniciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iniciarSesion));
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.reestablecerPass = new System.Windows.Forms.LinkLabel();
            this.registrarse = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(109, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Iniciar sesión";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.SeaGreen;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login.Location = new System.Drawing.Point(57, 400);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(225, 50);
            this.login.TabIndex = 5;
            this.login.Text = "Ingresar";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(57, 256);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(225, 20);
            this.txtId.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Matrícula / No. Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contraseña";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(57, 315);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.Size = new System.Drawing.Size(199, 20);
            this.txtPass.TabIndex = 8;
            // 
            // reestablecerPass
            // 
            this.reestablecerPass.AutoSize = true;
            this.reestablecerPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reestablecerPass.LinkColor = System.Drawing.Color.SeaGreen;
            this.reestablecerPass.Location = new System.Drawing.Point(162, 339);
            this.reestablecerPass.Name = "reestablecerPass";
            this.reestablecerPass.Size = new System.Drawing.Size(106, 13);
            this.reestablecerPass.TabIndex = 10;
            this.reestablecerPass.TabStop = true;
            this.reestablecerPass.Text = "Olvidé mi contraseña";
            this.reestablecerPass.VisitedLinkColor = System.Drawing.Color.LightCoral;
            // 
            // registrarse
            // 
            this.registrarse.AutoSize = true;
            this.registrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarse.LinkColor = System.Drawing.Color.SeaGreen;
            this.registrarse.Location = new System.Drawing.Point(197, 461);
            this.registrarse.Name = "registrarse";
            this.registrarse.Size = new System.Drawing.Size(69, 16);
            this.registrarse.TabIndex = 11;
            this.registrarse.TabStop = true;
            this.registrarse.Text = "Regístrate";
            this.registrarse.VisitedLinkColor = System.Drawing.Color.LightCoral;
            this.registrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registrarse_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "¿No tienes cuenta?";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(57, 256);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(225, 20);
            this.id.TabIndex = 6;
            // 
            // pbPassword
            // 
            this.pbPassword.Image = global::UTApp_POO.Properties.Resources.show;
            this.pbPassword.Location = new System.Drawing.Point(262, 315);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(20, 20);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPassword.TabIndex = 13;
            this.pbPassword.TabStop = false;
            this.pbPassword.Click += new System.EventHandler(this.pbPassword_Click);
            // 
            // pbBack
            // 
            this.pbBack.Image = global::UTApp_POO.Properties.Resources.goBack;
            this.pbBack.Location = new System.Drawing.Point(12, 12);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(30, 30);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 12;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Enabled = false;
            this.Logo.Image = global::UTApp_POO.Properties.Resources.UTAppLogo;
            this.Logo.Location = new System.Drawing.Point(57, 123);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(225, 70);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // iniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(334, 611);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbPassword);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.registrarse);
            this.Controls.Add(this.reestablecerPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "iniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.iniciarSesion_FormClosed);
            this.Load += new System.EventHandler(this.iniciarSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.LinkLabel reestablecerPass;
        private System.Windows.Forms.LinkLabel registrarse;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id;
    }
}