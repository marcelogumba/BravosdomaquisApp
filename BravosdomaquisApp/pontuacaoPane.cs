using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BravosdomaquisApp
{
    public partial class pontuacaoPane : UserControl
    {
        public pontuacaoPane(int campeonatoId, int clubeId, int Lugar, string nomeClube, int numeroJogos, int golsMarcados, int golsSofridos, int numerosVitorias, int numeroDerrotas, int numeroEmpates, int pontos)
        {
            InitializeComponent();

            LugarEquipa.Text = Lugar + "º";
            NomeEquipa.Text = nomeClube;
            numJogos.Text = numeroJogos.ToString();
            golMarcados.Text = golsMarcados.ToString();
            golSofridos.Text = golsSofridos.ToString();
            numVitorias.Text = numerosVitorias.ToString();
            numDerrotas.Text = numeroDerrotas.ToString();
            numEmpates.Text = numeroEmpates.ToString();
            Pontos.Text = pontos.ToString();
        }

        private void pontuacaoPane_Load(object sender, EventArgs e)
        {

        }
    }
}
