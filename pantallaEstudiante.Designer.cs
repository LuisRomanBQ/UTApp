namespace UTApp_POO
{
    partial class pantallaEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantallaEstudiante));
            this.btnAsignaciones = new System.Windows.Forms.Button();
            this.btnMaterias = new System.Windows.Forms.Button();
            this.btnDocentes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbSettings = new System.Windows.Forms.PictureBox();
            this.pbLogOut = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.labelSaludo = new System.Windows.Forms.Label();
            this.labelPendientes = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAsignaciones
            // 
            this.btnAsignaciones.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAsignaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignaciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAsignaciones.Location = new System.Drawing.Point(53, 192);
            this.btnAsignaciones.Name = "btnAsignaciones";
            this.btnAsignaciones.Size = new System.Drawing.Size(225, 50);
            this.btnAsignaciones.TabIndex = 38;
            this.btnAsignaciones.Text = "Mis asignaciones";
            this.btnAsignaciones.UseVisualStyleBackColor = false;
            this.btnAsignaciones.Click += new System.EventHandler(this.btnAsignaciones_Click);
            // 
            // btnMaterias
            // 
            this.btnMaterias.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMaterias.Location = new System.Drawing.Point(53, 267);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Size = new System.Drawing.Size(225, 50);
            this.btnMaterias.TabIndex = 41;
            this.btnMaterias.Text = "Materias";
            this.btnMaterias.UseVisualStyleBackColor = false;
            // 
            // btnDocentes
            // 
            this.btnDocentes.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocentes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDocentes.Location = new System.Drawing.Point(53, 339);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(225, 50);
            this.btnDocentes.TabIndex = 42;
            this.btnDocentes.Text = "Docentes";
            this.btnDocentes.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.pbSettings);
            this.panel1.Controls.Add(this.pbLogOut);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Location = new System.Drawing.Point(-9, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 75);
            this.panel1.TabIndex = 43;
            // 
            // pbSettings
            // 
            this.pbSettings.Image = ((System.Drawing.Image)(resources.GetObject("pbSettings.Image")));
            this.pbSettings.Location = new System.Drawing.Point(21, 14);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Size = new System.Drawing.Size(30, 30);
            this.pbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSettings.TabIndex = 47;
            this.pbSettings.TabStop = false;
            this.pbSettings.Click += new System.EventHandler(this.pbSettings_Click);
            // 
            // pbLogOut
            // 
            this.pbLogOut.Image = global::UTApp_POO.Properties.Resources.logOut;
            this.pbLogOut.Location = new System.Drawing.Point(301, 14);
            this.pbLogOut.Name = "pbLogOut";
            this.pbLogOut.Size = new System.Drawing.Size(30, 30);
            this.pbLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogOut.TabIndex = 46;
            this.pbLogOut.TabStop = false;
            this.pbLogOut.Click += new System.EventHandler(this.pbLogOut_Click);
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
            // 
            // labelSaludo
            // 
            this.labelSaludo.AutoSize = true;
            this.labelSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaludo.Location = new System.Drawing.Point(50, 113);
            this.labelSaludo.Name = "labelSaludo";
            this.labelSaludo.Size = new System.Drawing.Size(12, 18);
            this.labelSaludo.TabIndex = 44;
            this.labelSaludo.Text = " ";
            // 
            // labelPendientes
            // 
            this.labelPendientes.AutoSize = true;
            this.labelPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPendientes.Location = new System.Drawing.Point(92, 138);
            this.labelPendientes.Name = "labelPendientes";
            this.labelPendientes.Size = new System.Drawing.Size(12, 18);
            this.labelPendientes.TabIndex = 45;
            this.labelPendientes.Text = " ";
            // 
            // pantallaEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(334, 611);
            this.Controls.Add(this.labelPendientes);
            this.Controls.Add(this.labelSaludo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDocentes);
            this.Controls.Add(this.btnMaterias);
            this.Controls.Add(this.btnAsignaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pantallaEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.pantallaEstudiante_FormClosed);
            this.Load += new System.EventHandler(this.pantallaEstudiante_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button btnAsignaciones;
        private System.Windows.Forms.Button btnMaterias;
        private System.Windows.Forms.Button btnDocentes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSaludo;
        private System.Windows.Forms.Label labelPendientes;
        private System.Windows.Forms.PictureBox pbLogOut;
        private System.Windows.Forms.PictureBox pbSettings;
    }
}