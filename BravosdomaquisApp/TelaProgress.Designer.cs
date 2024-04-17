namespace BravosdomaquisApp
{
    partial class TelaProgress
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
            this.progressCircle = new Guna.UI.WinForms.GunaWinCircleProgressIndicator();
            this.SuspendLayout();
            // 
            // progressCircle
            // 
            this.progressCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.progressCircle.Location = new System.Drawing.Point(40, 40);
            this.progressCircle.Name = "progressCircle";
            this.progressCircle.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.progressCircle.Size = new System.Drawing.Size(140, 140);
            this.progressCircle.TabIndex = 0;
            // 
            // TelaProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 220);
            this.Controls.Add(this.progressCircle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaProgress";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaWinCircleProgressIndicator progressCircle;
    }
}