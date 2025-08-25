namespace UTApp_POO
{
    partial class MisAsignaciones
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbSettings = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Asignaciones = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.pbSettings);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Location = new System.Drawing.Point(-9, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 75);
            this.panel1.TabIndex = 45;
            // 
            // pbSettings
            // 
            this.pbSettings.Image = global::UTApp_POO.Properties.Resources.goBackBlanco;
            this.pbSettings.Location = new System.Drawing.Point(21, 14);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Size = new System.Drawing.Size(30, 39);
            this.pbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSettings.TabIndex = 47;
            this.pbSettings.TabStop = false;
            this.pbSettings.Click += new System.EventHandler(this.pbSettings_Click);
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
            // Asignaciones
            // 
            this.Asignaciones.AutoScroll = true;
            this.Asignaciones.BackColor = System.Drawing.Color.Silver;
            this.Asignaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Asignaciones.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Asignaciones.Location = new System.Drawing.Point(12, 94);
            this.Asignaciones.Name = "Asignaciones";
            this.Asignaciones.Size = new System.Drawing.Size(310, 495);
            this.Asignaciones.TabIndex = 46;
            this.Asignaciones.WrapContents = false;
            this.Asignaciones.Paint += new System.Windows.Forms.PaintEventHandler(this.Asignaciones_Paint);
            // 
            // MisAsignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 611);
            this.Controls.Add(this.Asignaciones);
            this.Controls.Add(this.panel1);
            this.Name = "MisAsignaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MisAsignaciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MisAsignaciones_FormClosed);
            this.Load += new System.EventHandler(this.MisAsignaciones_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbSettings;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.FlowLayoutPanel Asignaciones;
    }
}