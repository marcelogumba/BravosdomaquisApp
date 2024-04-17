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
    public partial class VerPontuacoes : Form
    {
        Form form;
        public VerPontuacoes(Form formy, bool darkMode, int idCampeonato)
        {
            form = formy;
            InitializeComponent();

            if (darkMode)
            {
                this.BackColor = Color.FromArgb(14, 18, 30);
                flowLayoutPanel.BackColor = Color.FromArgb(24, 28, 40);
                panel1.BackColor = Color.FromArgb(34, 38, 0);
                lblTitulo.ForeColor = Color.Gainsboro;
            }

            //txtCampeonato.Text = idCampeonato.ToString();

            createPontuacoesPanes(19, 2, 1, 1, "Bravos do MAquis - FC", 10, 6, 12, 2, 7, 1, 32);
        }
        public void createPontuacoesPanes(int numEquipas, int campeonatoId, int clubeId, int lugar, string nomeEquipa, int numeroJogos, int golsMarcados, int golsSofridos, int numerosVitorias, int numeroDerrotas, int numeroEmpates, int pontos)
        {
            flowLayoutPanel.HorizontalScroll.Maximum = 0;
            flowLayoutPanel.HorizontalScroll.Visible = false;
            flowLayoutPanel.HorizontalScroll.Enabled = false;
            flowLayoutPanel.AutoScroll = false;
            flowLayoutPanel.VerticalScroll.Visible = false;
            flowLayoutPanel.AutoScroll = true;

            for (int i = 0; i < numEquipas; i++)
            {
                pontuacaoPane pontuacaoPane = new pontuacaoPane(campeonatoId, clubeId, i+1, nomeEquipa, numeroJogos, golsMarcados, golsSofridos, numerosVitorias, numeroDerrotas, numeroEmpates, pontos);
                flowLayoutPanel.Controls.Add(pontuacaoPane);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }
    }
}
