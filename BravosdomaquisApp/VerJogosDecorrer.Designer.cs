namespace BravosdomaquisApp
{
    partial class VerJogosDecorrer
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
            this.lblInfoNotify = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFechar = new Guna.UI.WinForms.GunaButton();
            this.lblFecharInfoMembro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfoNotify
            // 
            this.lblInfoNotify.AutoSize = true;
            this.lblInfoNotify.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblInfoNotify.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblInfoNotify.Location = new System.Drawing.Point(34, 62);
            this.lblInfoNotify.Name = "lblInfoNotify";
            this.lblInfoNotify.Size = new System.Drawing.Size(320, 16);
            this.lblInfoNotify.TabIndex = 71;
            this.lblInfoNotify.Text = "Veja os jogos referentes ao campeonato e a jornada!";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lblTitulo.Location = new System.Drawing.Point(74, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(257, 37);
            this.lblTitulo.TabIndex = 72;
            this.lblTitulo.Text = "Jogos a decorrer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BravosdomaquisApp.Properties.Resources.aoVivo;
            this.pictureBox1.Location = new System.Drawing.Point(37, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 34);
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.Color.LightGray;
            this.flowLayoutPanel.Location = new System.Drawing.Point(37, 92);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel.Size = new System.Drawing.Size(977, 625);
            this.flowLayoutPanel.TabIndex = 74;
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
            this.btnFechar.Location = new System.Drawing.Point(977, 29);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(145)))));
            this.btnFechar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFechar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFechar.OnHoverImage = null;
            this.btnFechar.OnPressedColor = System.Drawing.Color.Black;
            this.btnFechar.Radius = 8;
            this.btnFechar.Size = new System.Drawing.Size(30, 30);
            this.btnFechar.TabIndex = 78;
            this.btnFechar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            this.btnFechar.MouseLeave += new System.EventHandler(this.btnFechar_MouseLeave);
            this.btnFechar.MouseHover += new System.EventHandler(this.btnFechar_MouseHover);
            // 
            // lblFecharInfoMembro
            // 
            this.lblFecharInfoMembro.AutoSize = true;
            this.lblFecharInfoMembro.Font = new System.Drawing.Font("Montserrat", 8F);
            this.lblFecharInfoMembro.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblFecharInfoMembro.Location = new System.Drawing.Point(966, 61);
            this.lblFecharInfoMembro.Name = "lblFecharInfoMembro";
            this.lblFecharInfoMembro.Size = new System.Drawing.Size(54, 15);
            this.lblFecharInfoMembro.TabIndex = 77;
            this.lblFecharInfoMembro.Text = "Cancelar";
            this.lblFecharInfoMembro.Visible = false;
            // 
            // VerJogosDecorrer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 740);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblFecharInfoMembro);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblInfoNotify);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerJogosDecorrer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerJogosDecorrer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoNotify;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private Guna.UI.WinForms.GunaButton btnFechar;
        private System.Windows.Forms.Label lblFecharInfoMembro;
    }
}