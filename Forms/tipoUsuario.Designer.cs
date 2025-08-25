namespace UTApp_POO
{
    partial class tipoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tipoUsuario));
            this.continuarSingIn = new System.Windows.Forms.Button();
            this.Estudiante = new System.Windows.Forms.RadioButton();
            this.Docente = new System.Windows.Forms.RadioButton();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.gbUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // continuarSingIn
            // 
            this.continuarSingIn.BackColor = System.Drawing.Color.SeaGreen;
            this.continuarSingIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continuarSingIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuarSingIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.continuarSingIn.Location = new System.Drawing.Point(55, 371);
            this.continuarSingIn.Name = "continuarSingIn";
            this.continuarSingIn.Size = new System.Drawing.Size(225, 50);
            this.continuarSingIn.TabIndex = 15;
            this.continuarSingIn.Text = "Continuar";
            this.continuarSingIn.UseVisualStyleBackColor = false;
            this.continuarSingIn.Click += new System.EventHandler(this.continuarSingIn_Click);
            // 
            // Estudiante
            // 
            this.Estudiante.AutoSize = true;
            this.Estudiante.Location = new System.Drawing.Point(22, 21);
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.Size = new System.Drawing.Size(83, 19);
            this.Estudiante.TabIndex = 0;
            this.Estudiante.TabStop = true;
            this.Estudiante.Text = "Estudiante";
            this.Estudiante.UseVisualStyleBackColor = true;
            // 
            // Docente
            // 
            this.Docente.AutoSize = true;
            this.Docente.Location = new System.Drawing.Point(22, 58);
            this.Docente.Name = "Docente";
            this.Docente.Size = new System.Drawing.Size(71, 19);
            this.Docente.TabIndex = 1;
            this.Docente.TabStop = true;
            this.Docente.Text = "Docente";
            this.Docente.UseVisualStyleBackColor = true;
            // 
            // gbUsuario
            // 
            this.gbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.gbUsuario.Controls.Add(this.Docente);
            this.gbUsuario.Controls.Add(this.Estudiante);
            this.gbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsuario.Location = new System.Drawing.Point(105, 240);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(125, 100);
            this.gbUsuario.TabIndex = 16;
            this.gbUsuario.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(70, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Selecciona una opción";
            // 
            // back
            // 
            this.back.Image = global::UTApp_POO.Properties.Resources.goBack;
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(30, 30);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back.TabIndex = 19;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Enabled = false;
            this.Logo.Image = global::UTApp_POO.Properties.Resources.UTAppLogo;
            this.Logo.Location = new System.Drawing.Point(55, 114);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(225, 70);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 17;
            this.Logo.TabStop = false;
            // 
            // tipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(334, 611);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.gbUsuario);
            this.Controls.Add(this.continuarSingIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tipoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.tipoUsuario_FormClosed);
            this.Load += new System.EventHandler(this.tipoUsuario_Load_1);
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button continuarSingIn;
        private System.Windows.Forms.RadioButton Estudiante;
        private System.Windows.Forms.RadioButton Docente;
        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox back;
    }
}