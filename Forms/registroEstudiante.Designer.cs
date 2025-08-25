namespace UTApp_POO
{
    partial class registroEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registroEstudiante));
            this.registrarse = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPass1 = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // registrarse
            // 
            this.registrarse.AutoSize = true;
            this.registrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarse.LinkColor = System.Drawing.Color.SeaGreen;
            this.registrarse.Location = new System.Drawing.Point(190, 559);
            this.registrarse.Name = "registrarse";
            this.registrarse.Size = new System.Drawing.Size(81, 16);
            this.registrarse.TabIndex = 20;
            this.registrarse.TabStop = true;
            this.registrarse.Text = "Inicia sesión";
            this.registrarse.VisitedLinkColor = System.Drawing.Color.LightCoral;
            this.registrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registrarse_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Contraseña";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.SeaGreen;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login.Location = new System.Drawing.Point(55, 499);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(225, 50);
            this.login.TabIndex = 14;
            this.login.Text = "Regístrate";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(82, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Registro estudiante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 559);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "¿Ya tienes cuenta?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Confirma contraseña";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtPass2
            // 
            this.txtPass2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass2.Location = new System.Drawing.Point(55, 416);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.PasswordChar = '•';
            this.txtPass2.Size = new System.Drawing.Size(199, 20);
            this.txtPass2.TabIndex = 22;
            this.txtPass2.TextChanged += new System.EventHandler(this.txtPass2_TextChanged);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(55, 200);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(56, 16);
            this.Nombre.TabIndex = 26;
            this.Nombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(55, 179);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(225, 20);
            this.txtNombre.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Matrícula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(55, 229);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(225, 20);
            this.txtMatricula.TabIndex = 27;
            // 
            // cbGrupo
            // 
            this.cbGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Location = new System.Drawing.Point(55, 319);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(225, 21);
            this.cbGrupo.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Grupo";
            // 
            // txtPass1
            // 
            this.txtPass1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass1.Location = new System.Drawing.Point(55, 365);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.PasswordChar = '•';
            this.txtPass1.Size = new System.Drawing.Size(199, 20);
            this.txtPass1.TabIndex = 35;
            this.txtPass1.TextChanged += new System.EventHandler(this.txtPass1_TextChanged);
            // 
            // back
            // 
            this.back.Image = global::UTApp_POO.Properties.Resources.goBack;
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(30, 30);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back.TabIndex = 55;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pbPassword
            // 
            this.pbPassword.Image = global::UTApp_POO.Properties.Resources.show;
            this.pbPassword.Location = new System.Drawing.Point(260, 365);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(20, 20);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPassword.TabIndex = 54;
            this.pbPassword.TabStop = false;
            this.pbPassword.Click += new System.EventHandler(this.pbPassword_Click);
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Enabled = false;
            this.Logo.Image = global::UTApp_POO.Properties.Resources.UTAppLogo;
            this.Logo.Location = new System.Drawing.Point(55, 33);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(225, 70);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 12;
            this.Logo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(55, 277);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(225, 20);
            this.txtCorreo.TabIndex = 56;
            // 
            // registroEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(334, 611);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pbPassword);
            this.Controls.Add(this.txtPass1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbGrupo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPass2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.registrarse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "registroEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.registroEstudiante_FormClosed);
            this.Load += new System.EventHandler(this.registroEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel registrarse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPass2;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPass1;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreo;
    }
}