namespace BravosdomaquisApp
{
    partial class infoResultados
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
            this.panelResults = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new Guna.UI.WinForms.GunaButton();
            this.panelCard1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.txtCampeonato = new System.Windows.Forms.Label();
            this.txtJornada = new System.Windows.Forms.Label();
            this.lblResultados = new System.Windows.Forms.Label();
            this.lblInfoSelectCampeo = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelCard1.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResults
            // 
            this.panelResults.BackColor = System.Drawing.Color.Gainsboro;
            this.panelResults.Controls.Add(this.pictureBox3);
            this.panelResults.Controls.Add(this.btnFechar);
            this.panelResults.Controls.Add(this.panelCard1);
            this.panelResults.Controls.Add(this.lblResultados);
            this.panelResults.Controls.Add(this.lblInfoSelectCampeo);
            this.panelResults.Controls.Add(this.flowLayoutPanel);
            this.panelResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResults.Location = new System.Drawing.Point(0, 0);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(867, 740);
            this.panelResults.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BravosdomaquisApp.Properties.Resources.resultado;
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
            this.panelCard1.Location = new System.Drawing.Point(682, 18);
            this.panelCard1.Name = "panelCard1";
            this.panelCard1.Radius = 5;
            this.panelCard1.ShadowColor = System.Drawing.Color.Black;
            this.panelCard1.ShadowShift = 3;
            this.panelCard1.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.panelCard1.Size = new System.Drawing.Size(143, 72);
            this.panelCard1.TabIndex = 29;
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
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold);
            this.lblResultados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblResultados.Location = new System.Drawing.Point(65, 18);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(359, 44);
            this.lblResultados.TabIndex = 27;
            this.lblResultados.Text = "Resultados de jogos";
            // 
            // lblInfoSelectCampeo
            // 
            this.lblInfoSelectCampeo.AutoSize = true;
            this.lblInfoSelectCampeo.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lblInfoSelectCampeo.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblInfoSelectCampeo.Location = new System.Drawing.Point(28, 61);
            this.lblInfoSelectCampeo.Name = "lblInfoSelectCampeo";
            this.lblInfoSelectCampeo.Size = new System.Drawing.Size(355, 20);
            this.lblInfoSelectCampeo.TabIndex = 28;
            this.lblInfoSelectCampeo.Text = "Veja abaixo os resultados dos jogos desta jornada";
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
            // infoResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 740);
            this.Controls.Add(this.panelResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "infoResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "infoResultados";
            this.panelResults.ResumeLayout(false);
            this.panelResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelCard1.ResumeLayout(false);
            this.panelCard1.PerformLayout();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Label lblInfoSelectCampeo;
        private Guna.UI.WinForms.GunaShadowPanel panelCard1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Label txtCampeonato;
        private System.Windows.Forms.Label txtJornada;
        private Guna.UI.WinForms.GunaButton btnFechar;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}