namespace BravosdomaquisApp
{
    partial class Notification
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
            this.barraLateral = new System.Windows.Forms.Panel();
            this.messageNotify = new System.Windows.Forms.Label();
            this.tipoyNotify = new System.Windows.Forms.Label();
            this.imgNotify = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.close = new BravosdomaquisApp.Controls.ButtunUI();
            ((System.ComponentModel.ISupportInitialize)(this.imgNotify)).BeginInit();
            this.SuspendLayout();
            // 
            // barraLateral
            // 
            this.barraLateral.BackColor = System.Drawing.Color.SeaGreen;
            this.barraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.barraLateral.Location = new System.Drawing.Point(0, 0);
            this.barraLateral.Name = "barraLateral";
            this.barraLateral.Size = new System.Drawing.Size(5, 50);
            this.barraLateral.TabIndex = 0;
            // 
            // messageNotify
            // 
            this.messageNotify.AutoSize = true;
            this.messageNotify.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageNotify.Location = new System.Drawing.Point(57, 26);
            this.messageNotify.Margin = new System.Windows.Forms.Padding(4);
            this.messageNotify.Name = "messageNotify";
            this.messageNotify.Size = new System.Drawing.Size(158, 16);
            this.messageNotify.TabIndex = 2;
            this.messageNotify.Text = "Mensagem aparece aqui!";
            this.messageNotify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tipoyNotify
            // 
            this.tipoyNotify.AutoSize = true;
            this.tipoyNotify.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoyNotify.Location = new System.Drawing.Point(56, 4);
            this.tipoyNotify.Margin = new System.Windows.Forms.Padding(4);
            this.tipoyNotify.Name = "tipoyNotify";
            this.tipoyNotify.Size = new System.Drawing.Size(44, 21);
            this.tipoyNotify.TabIndex = 3;
            this.tipoyNotify.Text = "Tipo";
            this.tipoyNotify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgNotify
            // 
            this.imgNotify.Image = global::BravosdomaquisApp.Properties.Resources.sucess;
            this.imgNotify.Location = new System.Drawing.Point(16, 10);
            this.imgNotify.Name = "imgNotify";
            this.imgNotify.Size = new System.Drawing.Size(30, 30);
            this.imgNotify.TabIndex = 1;
            this.imgNotify.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 5;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.WhiteSmoke;
            this.close.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.close.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.close.BorderRadius = 1;
            this.close.BorderSize = 0;
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Montserrat SemiBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.DarkGray;
            this.close.Location = new System.Drawing.Point(335, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(20, 50);
            this.close.TabIndex = 4;
            this.close.Text = "X";
            this.close.TextColor = System.Drawing.Color.DarkGray;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(355, 50);
            this.Controls.Add(this.close);
            this.Controls.Add(this.tipoyNotify);
            this.Controls.Add(this.messageNotify);
            this.Controls.Add(this.imgNotify);
            this.Controls.Add(this.barraLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notification";
            this.Text = "Notification";
            this.Load += new System.EventHandler(this.Notification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgNotify)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel barraLateral;
        private System.Windows.Forms.PictureBox imgNotify;
        private System.Windows.Forms.Label messageNotify;
        private System.Windows.Forms.Label tipoyNotify;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Controls.ButtunUI close;
    }
}