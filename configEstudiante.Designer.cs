namespace UTApp_POO
{
    partial class configEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(configEstudiante));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.btnEditarNombre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditarGrupo = new System.Windows.Forms.Button();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.pbBack);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Location = new System.Drawing.Point(-9, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 75);
            this.panel1.TabIndex = 44;
            // 
            // pbBack
            // 
            this.pbBack.Image = global::UTApp_POO.Properties.Resources.goBackBlanco;
            this.pbBack.Location = new System.Drawing.Point(21, 14);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(30, 30);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 47;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Enabled = false;
            this.Logo.Image = global::UTApp_POO.Properties.Resources.UTAppLogoBlanco;
            this.Logo.Location = new System.Drawing.Point(62, 27);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(225, 37);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // btnEditarNombre
            // 
            this.btnEditarNombre.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEditarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarNombre.Location = new System.Drawing.Point(53, 216);
            this.btnEditarNombre.Name = "btnEditarNombre";
            this.btnEditarNombre.Size = new System.Drawing.Size(225, 50);
            this.btnEditarNombre.TabIndex = 45;
            this.btnEditarNombre.Text = "Editar nombre";
            this.btnEditarNombre.UseVisualStyleBackColor = false;
            this.btnEditarNombre.Click += new System.EventHandler(this.btnEditarNombre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(71, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Configuración de perfil";
            // 
            // btnEditarGrupo
            // 
            this.btnEditarGrupo.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEditarGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarGrupo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarGrupo.Location = new System.Drawing.Point(53, 286);
            this.btnEditarGrupo.Name = "btnEditarGrupo";
            this.btnEditarGrupo.Size = new System.Drawing.Size(225, 50);
            this.btnEditarGrupo.TabIndex = 48;
            this.btnEditarGrupo.Text = "Editar grupo";
            this.btnEditarGrupo.UseVisualStyleBackColor = false;
            this.btnEditarGrupo.Click += new System.EventHandler(this.btnEditarGrupo_Click);
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCambiarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarContraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCambiarContraseña.Location = new System.Drawing.Point(53, 357);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(225, 50);
            this.btnCambiarContraseña.TabIndex = 49;
            this.btnCambiarContraseña.Text = "Cambiar contraseña";
            this.btnCambiarContraseña.UseVisualStyleBackColor = false;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.Red;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(53, 428);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(225, 50);
            this.btnEliminarUsuario.TabIndex = 50;
            this.btnEliminarUsuario.Text = "Eliminar usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // configEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(334, 611);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnCambiarContraseña);
            this.Controls.Add(this.btnEditarGrupo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditarNombre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "configEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.configuracionEstudiante_FormClosed);
            this.Load += new System.EventHandler(this.Plantilla_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button btnEditarNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditarGrupo;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.Button btnEliminarUsuario;
    }
}