namespace BravosdomaquisApp
{
    partial class Memorial
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMemorial = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnAddMemorial = new Guna.UI.WinForms.GunaButton();
            this.lblDesciNoticia = new System.Windows.Forms.Label();
            this.btnVerGaleria = new Guna.UI.WinForms.GunaButton();
            this.lblMemorial = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMemorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMemorial
            // 
            this.panelMemorial.BackColor = System.Drawing.Color.Transparent;
            this.panelMemorial.BaseColor = System.Drawing.Color.Gainsboro;
            this.panelMemorial.Controls.Add(this.btnAddMemorial);
            this.panelMemorial.Controls.Add(this.lblDesciNoticia);
            this.panelMemorial.Controls.Add(this.btnVerGaleria);
            this.panelMemorial.Controls.Add(this.lblMemorial);
            this.panelMemorial.Controls.Add(this.pictureBox2);
            this.panelMemorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMemorial.Location = new System.Drawing.Point(10, 10);
            this.panelMemorial.Name = "panelMemorial";
            this.panelMemorial.Radius = 10;
            this.panelMemorial.ShadowColor = System.Drawing.Color.Black;
            this.panelMemorial.ShadowShift = 3;
            this.panelMemorial.Size = new System.Drawing.Size(962, 609);
            this.panelMemorial.TabIndex = 52;
            // 
            // btnAddMemorial
            // 
            this.btnAddMemorial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddMemorial.AnimationHoverSpeed = 0.07F;
            this.btnAddMemorial.AnimationSpeed = 0.03F;
            this.btnAddMemorial.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMemorial.BaseColor = System.Drawing.Color.LightSlateGray;
            this.btnAddMemorial.BorderColor = System.Drawing.Color.Black;
            this.btnAddMemorial.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddMemorial.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddMemorial.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddMemorial.ForeColor = System.Drawing.Color.White;
            this.btnAddMemorial.Image = null;
            this.btnAddMemorial.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddMemorial.Location = new System.Drawing.Point(495, 536);
            this.btnAddMemorial.Name = "btnAddMemorial";
            this.btnAddMemorial.OnHoverBaseColor = System.Drawing.Color.SlateGray;
            this.btnAddMemorial.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddMemorial.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddMemorial.OnHoverImage = null;
            this.btnAddMemorial.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddMemorial.Radius = 8;
            this.btnAddMemorial.Size = new System.Drawing.Size(270, 32);
            this.btnAddMemorial.TabIndex = 27;
            this.btnAddMemorial.Text = "Adicionar memórias";
            this.btnAddMemorial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddMemorial.Click += new System.EventHandler(this.btnAddMemorial_Click);
            // 
            // lblDesciNoticia
            // 
            this.lblDesciNoticia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDesciNoticia.AutoSize = true;
            this.lblDesciNoticia.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lblDesciNoticia.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblDesciNoticia.Location = new System.Drawing.Point(250, 495);
            this.lblDesciNoticia.Name = "lblDesciNoticia";
            this.lblDesciNoticia.Size = new System.Drawing.Size(465, 20);
            this.lblDesciNoticia.TabIndex = 26;
            this.lblDesciNoticia.Text = "Escolha entre visualizar as imagens da geleria ou adicionar fotos!";
            this.lblDesciNoticia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVerGaleria
            // 
            this.btnVerGaleria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerGaleria.AnimationHoverSpeed = 0.07F;
            this.btnVerGaleria.AnimationSpeed = 0.03F;
            this.btnVerGaleria.BackColor = System.Drawing.Color.Transparent;
            this.btnVerGaleria.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.btnVerGaleria.BorderColor = System.Drawing.Color.Black;
            this.btnVerGaleria.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVerGaleria.FocusedColor = System.Drawing.Color.Empty;
            this.btnVerGaleria.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnVerGaleria.ForeColor = System.Drawing.Color.White;
            this.btnVerGaleria.Image = null;
            this.btnVerGaleria.ImageSize = new System.Drawing.Size(20, 20);
            this.btnVerGaleria.Location = new System.Drawing.Point(211, 536);
            this.btnVerGaleria.Name = "btnVerGaleria";
            this.btnVerGaleria.OnHoverBaseColor = System.Drawing.Color.SteelBlue;
            this.btnVerGaleria.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnVerGaleria.OnHoverForeColor = System.Drawing.Color.White;
            this.btnVerGaleria.OnHoverImage = null;
            this.btnVerGaleria.OnPressedColor = System.Drawing.Color.Black;
            this.btnVerGaleria.Radius = 8;
            this.btnVerGaleria.Size = new System.Drawing.Size(273, 32);
            this.btnVerGaleria.TabIndex = 17;
            this.btnVerGaleria.Text = "Ver memórias";
            this.btnVerGaleria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnVerGaleria.Click += new System.EventHandler(this.btnVerGaleria_Click);
            // 
            // lblMemorial
            // 
            this.lblMemorial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMemorial.AutoSize = true;
            this.lblMemorial.Font = new System.Drawing.Font("Montserrat", 26F, System.Drawing.FontStyle.Bold);
            this.lblMemorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblMemorial.Location = new System.Drawing.Point(198, 446);
            this.lblMemorial.Name = "lblMemorial";
            this.lblMemorial.Size = new System.Drawing.Size(595, 48);
            this.lblMemorial.TabIndex = 1;
            this.lblMemorial.Text = "Memórias do Bravos do Maquis";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::BravosdomaquisApp.Properties.Resources.memorialIcon;
            this.pictureBox2.Location = new System.Drawing.Point(282, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 400);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 619);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(962, 10);
            this.flowLayoutPanel1.TabIndex = 51;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(972, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 619);
            this.panel3.TabIndex = 50;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 619);
            this.panel2.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 10);
            this.panel1.TabIndex = 48;
            // 
            // Memorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.panelMemorial);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Memorial";
            this.Size = new System.Drawing.Size(982, 629);
            this.panelMemorial.ResumeLayout(false);
            this.panelMemorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel panelMemorial;
        private Guna.UI.WinForms.GunaButton btnAddMemorial;
        private System.Windows.Forms.Label lblDesciNoticia;
        private Guna.UI.WinForms.GunaButton btnVerGaleria;
        private System.Windows.Forms.Label lblMemorial;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
