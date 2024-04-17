namespace BravosdomaquisApp
{
    partial class Comentarios
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
            this.panelComentario = new System.Windows.Forms.Panel();
            this.panelCard1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblNumComentarios = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new Guna.UI.WinForms.GunaButton();
            this.lblInfoNotify = new System.Windows.Forms.Label();
            this.lblComentario = new System.Windows.Forms.Label();
            this.panelComentario.SuspendLayout();
            this.panelCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelComentario
            // 
            this.panelComentario.BackColor = System.Drawing.Color.Gainsboro;
            this.panelComentario.Controls.Add(this.panelCard1);
            this.panelComentario.Controls.Add(this.flowLayoutPanel);
            this.panelComentario.Controls.Add(this.pictureBox3);
            this.panelComentario.Controls.Add(this.btnFechar);
            this.panelComentario.Controls.Add(this.lblInfoNotify);
            this.panelComentario.Controls.Add(this.lblComentario);
            this.panelComentario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelComentario.Location = new System.Drawing.Point(0, 0);
            this.panelComentario.Name = "panelComentario";
            this.panelComentario.Size = new System.Drawing.Size(716, 750);
            this.panelComentario.TabIndex = 0;
            this.panelComentario.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelCard1
            // 
            this.panelCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCard1.AutoSize = true;
            this.panelCard1.BackColor = System.Drawing.Color.Transparent;
            this.panelCard1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.panelCard1.Controls.Add(this.lblNumComentarios);
            this.panelCard1.Location = new System.Drawing.Point(605, 20);
            this.panelCard1.Name = "panelCard1";
            this.panelCard1.Radius = 5;
            this.panelCard1.ShadowColor = System.Drawing.Color.Black;
            this.panelCard1.ShadowShift = 2;
            this.panelCard1.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.panelCard1.Size = new System.Drawing.Size(71, 69);
            this.panelCard1.TabIndex = 64;
            // 
            // lblNumComentarios
            // 
            this.lblNumComentarios.AutoSize = true;
            this.lblNumComentarios.BackColor = System.Drawing.Color.Transparent;
            this.lblNumComentarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumComentarios.Font = new System.Drawing.Font("Montserrat", 32F, System.Drawing.FontStyle.Bold);
            this.lblNumComentarios.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNumComentarios.Location = new System.Drawing.Point(0, 0);
            this.lblNumComentarios.Name = "lblNumComentarios";
            this.lblNumComentarios.Size = new System.Drawing.Size(71, 60);
            this.lblNumComentarios.TabIndex = 9;
            this.lblNumComentarios.Text = "10";
            this.lblNumComentarios.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel.BackColor = System.Drawing.Color.LightGray;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(35, 99);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.flowLayoutPanel.Size = new System.Drawing.Size(641, 596);
            this.flowLayoutPanel.TabIndex = 58;
            this.flowLayoutPanel.WrapContents = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BravosdomaquisApp.Properties.Resources.comentarios;
            this.pictureBox3.Location = new System.Drawing.Point(35, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 31);
            this.pictureBox3.TabIndex = 57;
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
            this.btnFechar.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = null;
            this.btnFechar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFechar.ImageSize = new System.Drawing.Size(15, 15);
            this.btnFechar.Location = new System.Drawing.Point(252, 708);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(145)))));
            this.btnFechar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFechar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFechar.OnHoverImage = null;
            this.btnFechar.OnPressedColor = System.Drawing.Color.Black;
            this.btnFechar.Radius = 8;
            this.btnFechar.Size = new System.Drawing.Size(208, 30);
            this.btnFechar.TabIndex = 56;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            this.btnFechar.MouseLeave += new System.EventHandler(this.btnFechar_MouseLeave);
            this.btnFechar.MouseHover += new System.EventHandler(this.btnFechar_MouseHover);
            // 
            // lblInfoNotify
            // 
            this.lblInfoNotify.AutoSize = true;
            this.lblInfoNotify.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblInfoNotify.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblInfoNotify.Location = new System.Drawing.Point(32, 63);
            this.lblInfoNotify.Name = "lblInfoNotify";
            this.lblInfoNotify.Size = new System.Drawing.Size(388, 16);
            this.lblInfoNotify.TabIndex = 1;
            this.lblInfoNotify.Text = "Veja a lista de comentários que foram feitos sobre a publicação!";
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.BackColor = System.Drawing.Color.Transparent;
            this.lblComentario.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblComentario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblComentario.Location = new System.Drawing.Point(64, 20);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(408, 37);
            this.lblComentario.TabIndex = 53;
            this.lblComentario.Text = "Comentários da publicação";
            // 
            // Comentarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(716, 750);
            this.Controls.Add(this.panelComentario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Comentarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comentarios";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.panelComentario.ResumeLayout(false);
            this.panelComentario.PerformLayout();
            this.panelCard1.ResumeLayout(false);
            this.panelCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelComentario;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI.WinForms.GunaButton btnFechar;
        private System.Windows.Forms.Label lblInfoNotify;
        private System.Windows.Forms.Label lblComentario;
        private Guna.UI.WinForms.GunaShadowPanel panelCard1;
        private System.Windows.Forms.Label lblNumComentarios;
    }
}