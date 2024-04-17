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
    public partial class VerJogos : Form
    {
        Form form;
        bool flag = false;

        public VerJogos(Form formy, bool darkMode)
        {
            
            form = formy;
            InitializeComponent();
            if (darkMode)
            {
                txtNuJogos.ForeColor =
                lblTitulo.ForeColor = Color.Gainsboro;

                flowLayoutPanel.BackColor = Color.FromArgb(28, 38, 50);
                this.BackColor = panelBack.BackColor = Color.FromArgb(18, 28, 40);
            }

            panelCard1.Visible = false;
            txtNuJogos.Visible = false;
            lblTitulo.Location = new Point(77, 34);

            lblTitulo.Text = "Jogos do Bravos do Maquis";
            lblInfoNotify.Text = "Veja abaixo os jogos mais recentes do Bravos do Maquis";

            createJogosPanes(10, 1, 1, 1, "Bravos do Maquis", "", "Petro de Luanda", "", "", 1);
        }
        public VerJogos(Form formy, bool darkMode, string idCampeonato, string numJornada)
        {
            form = formy;
            InitializeComponent();
            if (darkMode)
            {
                lblTitulo.ForeColor = Color.Gainsboro;
                flowLayoutPanel.BackColor = Color.FromArgb(24, 28, 40);

                this.BackColor = panelBack.BackColor = Color.FromArgb(14, 18, 30);
            }
            txtCampeonato.Text = idCampeonato;
            txtJornada.Text = numJornada;

            createJogosPanes(10, 1,1,1, "Bravos do Maquis", "", "Petro de Luanda", "", "", 1);
            txtNuJogos.Text = 10.ToString();
        }
        public void createJogosPanes(int numJogos, int campeonatoID, int jornadaID, int estadioID , string emblemaEqCasa, string EquipaCasa, string emblemaEqVisitante, string EquipaVisitante, string dataHora, int status)
        {
            flowLayoutPanel.HorizontalScroll.Maximum = 0;
            flowLayoutPanel.HorizontalScroll.Visible = false;
            flowLayoutPanel.HorizontalScroll.Enabled = false;
            flowLayoutPanel.AutoScroll = false;
            flowLayoutPanel.VerticalScroll.Visible = false;
            flowLayoutPanel.AutoScroll = true;

            for (int i = 0; i < numJogos; i++)
            {
                JogosPane JogosPane = new JogosPane(txtNuJogos, numJogos, campeonatoID, jornadaID, estadioID, emblemaEqCasa, EquipaCasa, emblemaEqVisitante, EquipaVisitante, dataHora, status);
                flowLayoutPanel.Controls.Add(JogosPane);
            }

        }
        private void btnAddJogos_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
        }
    }
}
