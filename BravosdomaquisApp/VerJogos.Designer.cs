namespace BravosdomaquisApp
{
    partial class VerJogos
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
            this.components = new System.ComponentModel.Container();
            this.panelBack = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancelar = new Guna.UI.WinForms.GunaButton();
            this.panelCard1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.txtCampeonato = new System.Windows.Forms.Label();
            this.txtJornada = new System.Windows.Forms.Label();
            this.lblInfoNotify = new System.Windows.Forms.Label();
            this.txtNuJogos = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelBack.SuspendLayout();
            this.panelCard1.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.Gainsboro;
            this.panelBack.Controls.Add(this.flowLayoutPanel);
            this.panelBack.Controls.Add(this.btnCancelar);
            this.panelBack.Controls.Add(this.panelCard1);
            this.panelBack.Controls.Add(this.pictureBox3);
            this.panelBack.Controls.Add(this.lblInfoNotify);
            this.panelBack.Controls.Add(this.txtNuJogos);
            this.panelBack.Controls.Add(this.lblTitulo);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(752, 740);
            this.panelBack.TabIndex = 0;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(37, 118);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel.Size = new System.Drawing.Size(662, 574);
            this.flowLayoutPanel.TabIndex = 69;
            this.flowLayoutPanel.WrapContents = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AnimationHoverSpeed = 0.07F;
            this.btnCancelar.AnimationSpeed = 0.03F;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BaseColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancelar.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancelar.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = null;
            this.btnCancelar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancelar.Location = new System.Drawing.Point(300, 698);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OnHoverBaseColor = System.Drawing.Color.SlateGray;
            this.btnCancelar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancelar.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.OnHoverImage = null;
            this.btnCancelar.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancelar.Radius = 8;
            this.btnCancelar.Size = new System.Drawing.Size(179, 32);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancelar.Click += new System.EventHandler(this.btnAddJogos_Click);
            // 
            // panelCard1
            // 
            this.panelCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCard1.AutoSize = true;
            this.panelCard1.BackColor = System.Drawing.Color.Transparent;
            this.panelCard1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.panelCard1.Controls.Add(this.gunaShadowPanel1);
            this.panelCard1.Location = new System.Drawing.Point(556, 34);
            this.panelCard1.Name = "panelCard1";
            this.panelCard1.Radius = 5;
            this.panelCard1.ShadowColor = System.Drawing.Color.Black;
            this.panelCard1.ShadowShift = 3;
            this.panelCard1.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.panelCard1.Size = new System.Drawing.Size(143, 72);
            this.panelCard1.TabIndex = 68;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.AutoSize = true;
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.gunaShadowPanel1.Controls.Add(this.txtCampeonato);
            this.gunaShadowPanel1.Controls.Add(this.txtJornada);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 5;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowShift = 3;
            this.gunaShadowPanel1.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(143, 72);
            this.gunaShadowPanel1.TabIndex = 30;
            // 
            // txtCampeonato
            // 
            this.txtCampeonato.AutoSize = true;
            this.txtCampeonato.BackColor = System.Drawing.Color.Transparent;
            this.txtCampeonato.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold);
            this.txtCampeonato.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtCampeonato.Location = new System.Drawing.Point(12, 6);
            this.txtCampeonato.Name = "txtCampeonato";
            this.txtCampeonato.Size = new System.Drawing.Size(121, 33);
            this.txtCampeonato.TabIndex = 7;
            this.txtCampeonato.Text = "Girabola";
            // 
            // txtJornada
            // 
            this.txtJornada.AutoSize = true;
            this.txtJornada.Font = new System.Drawing.Font("Montserrat", 12F);
            this.txtJornada.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtJornada.Location = new System.Drawing.Point(20, 35);
            this.txtJornada.Name = "txtJornada";
            this.txtJornada.Size = new System.Drawing.Size(102, 22);
            this.txtJornada.TabIndex = 8;
            this.txtJornada.Text = "10º Jornada";
            // 
            // lblInfoNotify
            // 
            this.lblInfoNotify.AutoSize = true;
            this.lblInfoNotify.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblInfoNotify.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblInfoNotify.Location = new System.Drawing.Point(34, 77);
            this.lblInfoNotify.Name = "lblInfoNotify";
            this.lblInfoNotify.Size = new System.Drawing.Size(320, 16);
            this.lblInfoNotify.TabIndex = 65;
            this.lblInfoNotify.Text = "Veja os jogos referentes ao campeonato e a jornada!";
            // 
            // txtNuJogos
            // 
            this.txtNuJogos.AutoSize = true;
            this.txtNuJogos.BackColor = System.Drawing.Color.Transparent;
            this.txtNuJogos.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.txtNuJogos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtNuJogos.Location = new System.Drawing.Point(68, 34);
            this.txtNuJogos.Name = "txtNuJogos";
            this.txtNuJogos.Size = new System.Drawing.Size(46, 37);
            this.txtNuJogos.TabIndex = 70;
            this.txtNuJogos.Text = "10";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblTitulo.Location = new System.Drawing.Point(116, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(281, 37);
            this.lblTitulo.TabIndex = 66;
            this.lblTitulo.Text = "- Jogos da jornada";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BravosdomaquisApp.Properties.Resources.jogos;
            this.pictureBox3.Location = new System.Drawing.Point(37, 40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 31);
            this.pictureBox3.TabIndex = 67;
            this.pictureBox3.TabStop = false;
            // 
            // VerJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(752, 740);
            this.Controls.Add(this.panelBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerJogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerJogos";
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.panelCard1.ResumeLayout(false);
            this.panelCard1.PerformLayout();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblInfoNotify;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI.WinForms.GunaShadowPanel panelCard1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Label txtCampeonato;
        private System.Windows.Forms.Label txtJornada;
        private Guna.UI.WinForms.GunaButton btnCancelar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label txtNuJogos;
        private System.Windows.Forms.Timer timer1;
    }
}