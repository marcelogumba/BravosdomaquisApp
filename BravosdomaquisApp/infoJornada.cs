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
    public partial class infoJornada : Form
    {
        Form form;
        public infoJornada(Form formy, bool darkMode, string idCampeonato)
        {
            form = formy;
            InitializeComponent();


            if (darkMode)
            {
                DarkMode();
            }

            txtCampeonato.Text = idCampeonato;
            createJornadasPanes(10, "1","ª Jornada", "18", "23", false);
            
            
        }

        public void DarkMode()
        {
            panelJornadas.BackColor = Color.FromArgb(14, 18, 30);
            flowLayoutPanel.BackColor = Color.FromArgb(24, 28, 40);
            lblJornadas.ForeColor = Color.Gainsboro;
        }
        public void createJornadasPanes(int numJornadasCampeonato, string id, string NumJornada, string JogosDisputados, string TotalJogos, bool Status)
        {
            flowLayoutPanel.HorizontalScroll.Maximum = 0;
            flowLayoutPanel.HorizontalScroll.Visible = false;
            flowLayoutPanel.HorizontalScroll.Enabled = false;
            flowLayoutPanel.AutoScroll = false;
            flowLayoutPanel.VerticalScroll.Visible = false;
            flowLayoutPanel.AutoScroll = true;

            for (int i = 1; i <= numJornadasCampeonato; i++)
            {
                JornadasPane jorn = new JornadasPane(id, i.ToString() + NumJornada, JogosDisputados, TotalJogos, false);
                flowLayoutPanel.Controls.Add(jorn);
            }

        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }
    }
}
