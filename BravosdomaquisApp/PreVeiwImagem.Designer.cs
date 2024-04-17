namespace BravosdomaquisApp
{
    partial class PreVeiwImagem
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
            this.panelInfoMembro = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnFechar = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDescrTitulo = new System.Windows.Forms.Label();
            this.panelInfoMembro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfoMembro
            // 
            this.panelInfoMembro.BackColor = System.Drawing.Color.Transparent;
            this.panelInfoMembro.BaseColor = System.Drawing.Color.Gainsboro;
            this.panelInfoMembro.Controls.Add(this.lblDescrTitulo);
            this.panelInfoMembro.Controls.Add(this.pictureBox1);
            this.panelInfoMembro.Controls.Add(this.btnFechar);
            this.panelInfoMembro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfoMembro.Location = new System.Drawing.Point(0, 0);
            this.panelInfoMembro.Name = "panelInfoMembro";
            this.panelInfoMembro.Radius = 10;
            this.panelInfoMembro.ShadowColor = System.Drawing.Color.Black;
            this.panelInfoMembro.Size = new System.Drawing.Size(884, 700);
            this.panelInfoMembro.TabIndex = 41;
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
            this.btnFechar.Image = global::BravosdomaquisApp.Properties.Resources.x;
            this.btnFechar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFechar.ImageSize = new System.Drawing.Size(15, 15);
            this.btnFechar.Location = new System.Drawing.Point(838, 19);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(145)))));
            this.btnFechar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFechar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFechar.OnHoverImage = null;
            this.btnFechar.OnPressedColor = System.Drawing.Color.Black;
            this.btnFechar.Radius = 8;
            this.btnFechar.Size = new System.Drawing.Size(30, 30);
            this.btnFechar.TabIndex = 41;
            this.btnFechar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(850, 625);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // lblDescrTitulo
            // 
            this.lblDescrTitulo.AutoSize = true;
            this.lblDescrTitulo.Font = new System.Drawing.Font("Montserrat", 11F);
            this.lblDescrTitulo.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblDescrTitulo.Location = new System.Drawing.Point(16, 21);
            this.lblDescrTitulo.Name = "lblDescrTitulo";
            this.lblDescrTitulo.Size = new System.Drawing.Size(222, 21);
            this.lblDescrTitulo.TabIndex = 43;
            this.lblDescrTitulo.Text = "Pre-visualização de imagem";
            // 
            // PreVeiwImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 700);
            this.Controls.Add(this.panelInfoMembro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PreVeiwImagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PreVeiwImagem";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.panelInfoMembro.ResumeLayout(false);
            this.panelInfoMembro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel panelInfoMembro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton btnFechar;
        private System.Windows.Forms.Label lblDescrTitulo;
    }
}