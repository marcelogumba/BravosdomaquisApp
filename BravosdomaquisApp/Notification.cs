using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BravosdomaquisApp
{
    public partial class Notification : Form
    {
        int notifyX, notifyY;
        public Notification(int tipo, string mensagem)
        {
            InitializeComponent();
            messageNotify.Text = mensagem;
            switch (tipo)
            {
                case 1:
                    tipoyNotify.Text = "Sucesso";
                    barraLateral.BackColor = Color.SeaGreen;
                    imgNotify.Image = Properties.Resources.sucess;
                    break;
                case 2:
                    tipoyNotify.Text = "Informação";
                    barraLateral.BackColor = Color.DodgerBlue;
                    imgNotify.Image = Properties.Resources.infoSMS;
                    break;
                case 3:
                    tipoyNotify.Text = "Aviso";
                    barraLateral.BackColor = Color.Goldenrod;
                    imgNotify.Image = Properties.Resources.warning;
                    break;
            }
        }



        private void Notification_Load(object sender, EventArgs e)
        {
            position();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            notifyY -= 4;
            this.Location = new Point(notifyX, notifyY);
            if(notifyY <= (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.90))
            {
                timer1.Stop();
                timer2.Start();
            }
        }
        int y = 100;
        private void timer2_Tick(object sender, EventArgs e)
        {
            y--;
            if (y <= 0)
            {
                notifyY += 3;
                this.Location = new Point(notifyX, notifyY);
                if(notifyY > (int)(Screen.PrimaryScreen.WorkingArea.Height + 50))
                {
                    y = 100;
                    timer2.Stop();
                    this.Close();
                }
            }
            
           
        }

        private void close_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            this.Close();
        }

        private void position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            notifyX = ScreenWidth - (int)(ScreenWidth * 0.30);
            notifyY = ScreenHeight;

            this.Location = new Point(notifyX, notifyY);
        }
    }
}
