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
    public partial class Jogadores : UserControl
    {
        bool modoEscuro;
        public Jogadores()
        {
            InitializeComponent();

            sourceJogadoresBindingSource.Add(new sourceJogadores() { ID = "1", NomeCompleto = "Tiago Santos", NomeAtletico = "Tiaginho", NumeroCamisa = 10, Posicao = "Meio Campo", DataNascimento = "1988/02/08", RedesSociais = "Por colocar" });
            sourceJogadoresBindingSource.Add(new sourceJogadores() { ID = "2", NomeCompleto = "Sergio Oliveira", NomeAtletico = "Sergão", NumeroCamisa = 11, Posicao = "Avançcado", DataNascimento = "1998/09/28", RedesSociais = "Por colocar" });
            sourceJogadoresBindingSource.Add(new sourceJogadores() { ID = "3", NomeCompleto = "Raul Antonio", NomeAtletico = "Rolha", NumeroCamisa = 05, Posicao = "Defesa", DataNascimento = "1999/05/20", RedesSociais = "Por colocar" });
            sourceJogadoresBindingSource.Add(new sourceJogadores() { ID = "4", NomeCompleto = "Flavio André", NomeAtletico = "Flavinho", NumeroCamisa = 0, Posicao = "L. Direito", DataNascimento = "2000/09/28", RedesSociais = "Por colocar" });

            lblNumAdicionados.Text = 4.ToString();
        }

        public void darkMode()
        {
            modoEscuro = true;
            this.BackColor = Color.FromArgb(5, 10, 26);

            panelSuperior.BaseColor =
            panelViewAll.BaseColor = Color.FromArgb(4, 8, 20);

            //panelViewAllContacto.BaseColor = Color.FromArgb(14, 18, 30);

            lblTitulo.ForeColor =
            lblVerListaJogadores.ForeColor = Color.Gainsboro;
        }
        public void lightMode()
        {
            modoEscuro = false;
            this.BackColor = Color.FromArgb(200, 200, 200);

            panelSuperior.BaseColor =
            panelViewAll.BaseColor = Color.Gainsboro;

            // panelViewAllContacto.BaseColor = Color.Gainsboro;

            lblTitulo.ForeColor =
            lblVerListaJogadores.ForeColor = Color.FromArgb(27, 87, 165);
        }
        private void DataGridViewListaJogadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewListaJogadores.Columns[e.ColumnIndex].Name == "Detalhes")
            {
                string id = DataGridViewListaJogadores.CurrentRow.Cells[0].Value.ToString();
                string nomeCompleto = DataGridViewListaJogadores.CurrentRow.Cells[1].Value.ToString();
                string nomeAtletico = DataGridViewListaJogadores.CurrentRow.Cells[2].Value.ToString();
                string camisa = DataGridViewListaJogadores.CurrentRow.Cells[3].Value.ToString();
                string posicao = DataGridViewListaJogadores.CurrentRow.Cells[4].Value.ToString();
                string data = DataGridViewListaJogadores.CurrentRow.Cells[5].Value.ToString();
                string redes = DataGridViewListaJogadores.CurrentRow.Cells[6].Value.ToString();

                FormBackgroudModal formModal = new FormBackgroudModal();
                formModal.Show();
                if (modoEscuro)
                {
                    InfoJogadores InfoJogadores = new InfoJogadores(formModal, true, false);
                    InfoJogadores.ShowDialog();
                }
                else
                {
                    InfoJogadores InfoJogadores = new InfoJogadores(formModal, false, false);
                    InfoJogadores.ShowDialog();
                }

                //txtInfoNomeParceiro.Text = DataGridViewNossosMembros.CurrentRow.Cells[1].Value.ToString();
                //txtInfoTipoParceiro.Text = DataGridViewNossosMembros.CurrentRow.Cells[3].Value.ToString();

            }
        }
        private void btnAddJogadores_Click(object sender, EventArgs e)
        {
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            if (modoEscuro)
            {
                InfoJogadores InfoJogadores = new InfoJogadores(formModal, true, true);
                InfoJogadores.ShowDialog();
            }
            else
            {
                InfoJogadores InfoJogadores = new InfoJogadores(formModal, false, true);
                InfoJogadores.ShowDialog();
            }
        }
    }
}
