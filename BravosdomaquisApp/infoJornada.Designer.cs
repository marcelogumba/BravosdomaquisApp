namespace BravosdomaquisApp
{
    partial class infoJornada
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
            this.panelJornadas = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new Guna.UI.WinForms.GunaButton();
            this.panelCard1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.txtCampeonato = new System.Windows.Forms.Label();
            this.lblJornadas = new System.Windows.Forms.Label();
            this.lblInfoSelectCampeo = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelJornadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelCard1.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelJornadas
            // 
            this.panelJornadas.BackColor = System.Drawing.Color.Gainsboro;
            this.panelJornadas.Controls.Add(this.pictureBox3);
            this.panelJornadas.Controls.Add(this.btnFechar);
            this.panelJornadas.Controls.Add(this.panelCard1);
            this.panelJornadas.Controls.Add(this.lblJornadas);
            this.panelJornadas.Controls.Add(this.lblInfoSelectCampeo);
            this.panelJornadas.Controls.Add(this.flowLayoutPanel);
            this.panelJornadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelJornadas.Location = new System.Drawing.Point(0, 0);
            this.panelJornadas.Name = "panelJornadas";
            this.panelJornadas.Size = new System.Drawing.Size(867, 740);
            this.panelJornadas.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BravosdomaquisApp.Properties.Resources.jornadas;
            this.pictureBox3.Location = new System.Drawing.Point(32, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 31);
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
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
            this.btnFechar.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = null;
            this.btnFechar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFechar.Location = new System.Drawing.Point(304, 700);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.OnHoverBaseColor = System.Drawing.Color.SteelBlue;
            this.btnFechar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFechar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFechar.OnHoverImage = null;
            this.btnFechar.OnPressedColor = System.Drawing.Color.Black;
            this.btnFechar.Radius = 8;
            this.btnFechar.Size = new System.Drawing.Size(282, 32);
            this.btnFechar.TabIndex = 18;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panelCard1
            // 
            this.panelCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCard1.AutoSize = true;
            this.panelCard1.BackColor = System.Drawing.Color.Transparent;
            this.panelCard1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.panelCard1.Controls.Add(this.gunaShadowPanel1);
            this.panelCard1.Location = new System.Drawing.Point(685, 27);
            this.panelCard1.Name = "panelCard1";
            this.panelCard1.Radius = 5;
            this.panelCard1.ShadowColor = System.Drawing.Color.Black;
            this.panelCard1.ShadowShift = 3;
            this.panelCard1.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.panelCard1.Size = new System.Drawing.Size(140, 61);
            this.panelCard1.TabIndex = 29;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.AutoSize = true;
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.gunaShadowPanel1.Controls.Add(this.txtCampeonato);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 5;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowShift = 3;
            this.gunaShadowPanel1.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(140, 61);
            this.gunaShadowPanel1.TabIndex = 30;
            // 
            // txtCampeonato
            // 
            this.txtCampeonato.AutoSize = true;
            this.txtCampeonato.BackColor = System.Drawing.Color.Transparent;
            this.txtCampeonato.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold);
            this.txtCampeonato.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtCampeonato.Location = new System.Drawing.Point(11, 9);
            this.txtCampeonato.Name = "txtCampeonato";
            this.txtCampeonato.Size = new System.Drawing.Size(121, 33);
            this.txtCampeonato.TabIndex = 7;
            this.txtCampeonato.Text = "Girabola";
            // 
            // lblJornadas
            // 
            this.lblJornadas.AutoSize = true;
            this.lblJornadas.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold);
            this.lblJornadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblJornadas.Location = new System.Drawing.Point(64, 18);
            this.lblJornadas.Name = "lblJornadas";
            this.lblJornadas.Size = new System.Drawing.Size(446, 44);
            this.lblJornadas.TabIndex = 27;
            this.lblJornadas.Text = "Jornadas do campeonato";
            // 
            // lblInfoSelectCampeo
            // 
            this.lblInfoSelectCampeo.AutoSize = true;
            this.lblInfoSelectCampeo.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lblInfoSelectCampeo.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblInfoSelectCampeo.Location = new System.Drawing.Point(28, 61);
            this.lblInfoSelectCampeo.Name = "lblInfoSelectCampeo";
            this.lblInfoSelectCampeo.Size = new System.Drawing.Size(309, 20);
            this.lblInfoSelectCampeo.TabIndex = 28;
            this.lblInfoSelectCampeo.Text = "Veja abaixo as jornadas deste campeonato!";
            this.lblInfoSelectCampeo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.Color.LightGray;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(32, 106);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel.Size = new System.Drawing.Size(793, 584);
            this.flowLayoutPanel.TabIndex = 0;
            this.flowLayoutPanel.WrapContents = false;
            // 
            // infoJornada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 740);
            this.Controls.Add(this.panelJornadas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "infoJornada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "infoJornada";
            this.panelJornadas.ResumeLayout(false);
            this.panelJornadas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelCard1.ResumeLayout(false);
            this.panelCard1.PerformLayout();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelJornadas;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI.WinForms.GunaButton btnFechar;
        private Guna.UI.WinForms.GunaShadowPanel panelCard1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Label txtCampeonato;
        private System.Windows.Forms.Label lblJornadas;
        private System.Windows.Forms.Label lblInfoSelectCampeo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}