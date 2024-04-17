namespace BravosdomaquisApp
{
    partial class Contacto
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
            this.panelContacto = new System.Windows.Forms.Panel();
            this.panelCard1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblNumEnviadas = new System.Windows.Forms.Label();
            this.gg = new Guna.UI.WinForms.GunaShadowPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnFechar = new Guna.UI.WinForms.GunaButton();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblDescriNewslatter = new System.Windows.Forms.Label();
            this.lblContactos = new System.Windows.Forms.Label();
            this.panelContacto.SuspendLayout();
            this.panelCard1.SuspendLayout();
            this.gg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContacto
            // 
            this.panelContacto.BackColor = System.Drawing.Color.Gainsboro;
            this.panelContacto.Controls.Add(this.panelCard1);
            this.panelContacto.Controls.Add(this.btnFechar);
            this.panelContacto.Controls.Add(this.flowLayoutPanel);
            this.panelContacto.Controls.Add(this.pictureBox3);
            this.panelContacto.Controls.Add(this.lblDescriNewslatter);
            this.panelContacto.Controls.Add(this.lblContactos);
            this.panelContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContacto.Location = new System.Drawing.Point(0, 0);
            this.panelContacto.Name = "panelContacto";
            this.panelContacto.Size = new System.Drawing.Size(697, 721);
            this.panelContacto.TabIndex = 0;
            // 
            // panelCard1
            // 
            this.panelCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCard1.AutoSize = true;
            this.panelCard1.BackColor = System.Drawing.Color.Transparent;
            this.panelCard1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.panelCard1.Controls.Add(this.lblNumEnviadas);
            this.panelCard1.Controls.Add(this.gg);
            this.panelCard1.Location = new System.Drawing.Point(450, 25);
            this.panelCard1.Name = "panelCard1";
            this.panelCard1.Radius = 5;
            this.panelCard1.ShadowColor = System.Drawing.Color.Black;
            this.panelCard1.ShadowShift = 0;
            this.panelCard1.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.panelCard1.Size = new System.Drawing.Size(197, 63);
            this.panelCard1.TabIndex = 64;
            // 
            // lblNumEnviadas
            // 
            this.lblNumEnviadas.AutoSize = true;
            this.lblNumEnviadas.BackColor = System.Drawing.Color.Transparent;
            this.lblNumEnviadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumEnviadas.Font = new System.Drawing.Font("Montserrat", 32F, System.Drawing.FontStyle.Bold);
            this.lblNumEnviadas.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNumEnviadas.Location = new System.Drawing.Point(126, 0);
            this.lblNumEnviadas.Name = "lblNumEnviadas";
            this.lblNumEnviadas.Size = new System.Drawing.Size(71, 60);
            this.lblNumEnviadas.TabIndex = 9;
            this.lblNumEnviadas.Text = "10";
            // 
            // gg
            // 
            this.gg.AutoSize = true;
            this.gg.BackColor = System.Drawing.Color.Transparent;
            this.gg.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.gg.Controls.Add(this.label4);
            this.gg.Controls.Add(this.label11);
            this.gg.Dock = System.Windows.Forms.DockStyle.Left;
            this.gg.Location = new System.Drawing.Point(0, 0);
            this.gg.Name = "gg";
            this.gg.Radius = 5;
            this.gg.ShadowColor = System.Drawing.Color.Black;
            this.gg.ShadowShift = 0;
            this.gg.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.gg.Size = new System.Drawing.Size(126, 63);
            this.gg.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 8F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nº de recebidas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(8, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 26);
            this.label11.TabIndex = 7;
            this.label11.Text = "Recebidas";
            // 
            // btnFechar
            // 
            this.btnFechar.AnimationHoverSpeed = 0.07F;
            this.btnFechar.AnimationSpeed = 0.03F;
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BaseColor = System.Drawing.Color.LightSlateGray;
            this.btnFechar.BorderColor = System.Drawing.Color.Black;
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFechar.FocusedColor = System.Drawing.Color.Empty;
            this.btnFechar.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = null;
            this.btnFechar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFechar.ImageSize = new System.Drawing.Size(15, 15);
            this.btnFechar.Location = new System.Drawing.Point(259, 679);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(145)))));
            this.btnFechar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFechar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFechar.OnHoverImage = null;
            this.btnFechar.OnPressedColor = System.Drawing.Color.Black;
            this.btnFechar.Radius = 8;
            this.btnFechar.Size = new System.Drawing.Size(167, 30);
            this.btnFechar.TabIndex = 65;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.Color.LightGray;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(44, 103);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel.Size = new System.Drawing.Size(603, 557);
            this.flowLayoutPanel.TabIndex = 64;
            this.flowLayoutPanel.WrapContents = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BravosdomaquisApp.Properties.Resources.iconSMS;
            this.pictureBox3.Location = new System.Drawing.Point(44, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 31);
            this.pictureBox3.TabIndex = 62;
            this.pictureBox3.TabStop = false;
            // 
            // lblDescriNewslatter
            // 
            this.lblDescriNewslatter.AutoSize = true;
            this.lblDescriNewslatter.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblDescriNewslatter.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblDescriNewslatter.Location = new System.Drawing.Point(41, 70);
            this.lblDescriNewslatter.Name = "lblDescriNewslatter";
            this.lblDescriNewslatter.Size = new System.Drawing.Size(287, 16);
            this.lblDescriNewslatter.TabIndex = 60;
            this.lblDescriNewslatter.Text = "Veja abaixo a lista de dos inscritos a Newslatter";
            // 
            // lblContactos
            // 
            this.lblContactos.AutoSize = true;
            this.lblContactos.BackColor = System.Drawing.Color.Transparent;
            this.lblContactos.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold);
            this.lblContactos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblContactos.Location = new System.Drawing.Point(77, 23);
            this.lblContactos.Name = "lblContactos";
            this.lblContactos.Size = new System.Drawing.Size(189, 44);
            this.lblContactos.TabIndex = 61;
            this.lblContactos.Text = "Contactos";
            // 
            // Contacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(697, 721);
            this.Controls.Add(this.panelContacto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Contacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacto";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.panelContacto.ResumeLayout(false);
            this.panelContacto.PerformLayout();
            this.panelCard1.ResumeLayout(false);
            this.panelCard1.PerformLayout();
            this.gg.ResumeLayout(false);
            this.gg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContacto;
        private Guna.UI.WinForms.GunaShadowPanel gg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblDescriNewslatter;
        private System.Windows.Forms.Label lblContactos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private Guna.UI.WinForms.GunaButton btnFechar;
        private Guna.UI.WinForms.GunaShadowPanel panelCard1;
        private System.Windows.Forms.Label lblNumEnviadas;
    }
}