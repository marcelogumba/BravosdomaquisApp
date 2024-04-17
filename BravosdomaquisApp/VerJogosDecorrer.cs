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
    public partial class VerJogosDecorrer : Form
    {
        Form form;
        public VerJogosDecorrer(Form formy, bool darkMode)
        {
            form = formy;
            InitializeComponent();

            if (darkMode)
            {
                //lblTitulo.ForeColor = Color.Gainsboro;
                flowLayoutPanel.BackColor = Color.FromArgb(24, 28, 40);

                this.BackColor = Color.FromArgb(14, 18, 30);
            }
            createJogosDecorrerPanes(10);
        }
        public void createJogosDecorrerPanes(int numJogos)
        {
            flowLayoutPanel.HorizontalScroll.Maximum = 0;
            flowLayoutPanel.HorizontalScroll.Visible = false;
            flowLayoutPanel.HorizontalScroll.Enabled = false;
            flowLayoutPanel.AutoScroll = false;
            flowLayoutPanel.VerticalScroll.Visible = false;
            flowLayoutPanel.AutoScroll = true;

            for (int i = 0; i < numJogos; i++)
            {
                JogosDecrorrerPane JogosPane = new JogosDecrorrerPane();
                flowLayoutPanel.Controls.Add(JogosPane);
            }

        }
        private void btnFechar_MouseHover(object sender, EventArgs e)
        {
            lblFecharInfoMembro.Visible = true;
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            lblFecharInfoMembro.Visible = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }
    }
}
