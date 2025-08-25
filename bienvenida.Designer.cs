namespace UTApp_POO
{
    partial class Bienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenida));
            this.background = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.signIn = new System.Windows.Forms.Button();
            this.logIn = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.SeaShell;
            this.background.Controls.Add(this.label1);
            this.background.Controls.Add(this.signIn);
            this.background.Controls.Add(this.logIn);
            this.background.Controls.Add(this.Logo);
            this.background.Location = new System.Drawing.Point(-3, -2);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(340, 615);
            this.background.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(78, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "¡Bienvenido correcaminos!";
            // 
            // signIn
            // 
            this.signIn.BackColor = System.Drawing.Color.SeaGreen;
            this.signIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signIn.Location = new System.Drawing.Point(62, 354);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(225, 50);
            this.signIn.TabIndex = 2;
            this.signIn.Text = "Registrarse";
            this.signIn.UseVisualStyleBackColor = false;
            this.signIn.Click += new System.EventHandler(this.signIn_Click);
            // 
            // logIn
            // 
            this.logIn.BackColor = System.Drawing.Color.SeaGreen;
            this.logIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logIn.Location = new System.Drawing.Point(62, 295);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(225, 50);
            this.logIn.TabIndex = 1;
            this.logIn.Text = "Iniciar sesión";
            this.logIn.UseVisualStyleBackColor = false;
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Enabled = false;
            this.Logo.Image = global::UTApp_POO.Properties.Resources.UTAppLogo;
            this.Logo.Location = new System.Drawing.Point(62, 190);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(225, 70);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 611);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Bienvenida_FormClosed);
            this.Load += new System.EventHandler(this.Bienvenida_Load);
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signIn;
    }
}

