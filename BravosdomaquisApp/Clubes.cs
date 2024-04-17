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
    public partial class Clubes : UserControl
    {
        bool modoEscuro;
        public Clubes()
        {
            InitializeComponent();
            
          Image image = Image.FromFile("C:/Users/MARCELO CARLOS/Documents/Icons/emblemaEquipa1.png");

          sourceClubesBindingSource.Add(new sourceClubes() { ID = "1", Nome = "Bravos do Maquis FC", Sigla = "BMQ", RedesSociais = "Por colocar" });
          sourceClubesBindingSource.Add(new sourceClubes() { ID = "2", Nome = "1º D´Agosto", Sigla = "1D", RedesSociais = "Por colocar" });
          sourceClubesBindingSource.Add(new sourceClubes() { ID = "3", Nome = "Petroloes de Luanda FC", Sigla = "PL", RedesSociais = "Por colocar" });
          sourceClubesBindingSource.Add(new sourceClubes() { ID = "4", Nome = "Kabuscorp do Palanca FC", Sigla = "KP", RedesSociais = "Por colocar"});

            lblNumAdicionados.Text = 4.ToString();
        }
        public void darkMode()
        {
            modoEscuro = true;

            this.BackColor = Color.FromArgb(5, 10, 26);

            panelSuperior.BaseColor =
            panelViewAll.BaseColor = Color.FromArgb(4, 8, 20);

            lblTitulo.ForeColor = lblVerListaClube.ForeColor = Color.Gainsboro;

        }
        public void lightMode()
        {
            modoEscuro = false;

            this.BackColor = Color.FromArgb(200, 200, 200);

            panelSuperior.BaseColor =
            panelViewAll.BaseColor = Color.Gainsboro;

            lblTitulo.ForeColor = lblVerListaClube.ForeColor = Color.FromArgb(27, 87, 165);
        }
        private void DataGridViewListaClubes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
          
            if (DataGridViewListaClubes.Columns[e.ColumnIndex].Name == "Emblema")
            {
              
            }
            
        }

        private void DataGridViewListaClubes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewListaClubes.Columns[e.ColumnIndex].Name == "Detalhes")
            {
                string id = DataGridViewListaClubes.CurrentRow.Cells[0].Value.ToString();
                string nomeClube = DataGridViewListaClubes.CurrentRow.Cells[1].Value.ToString();
                string sigla = DataGridViewListaClubes.CurrentRow.Cells[2].Value.ToString();
              //  string historia = DataGridViewListaClubes.CurrentRow.Cells[3].Value.ToString();
                string redes = DataGridViewListaClubes.CurrentRow.Cells[4].Value.ToString();

                FormBackgroudModal formModal = new FormBackgroudModal();
                formModal.Show();
                if (modoEscuro)
                {
                    infoClube infoClube = new infoClube(formModal, true, false, id, nomeClube, sigla, "", "", redes);
                    infoClube.Show();
                }
                else
                {
                    infoClube infoClube = new infoClube(formModal, false, false, id, nomeClube, sigla, "", "", redes);
                    infoClube.Show();
                }

                //txtInfoNomeParceiro.Text = DataGridViewNossosMembros.CurrentRow.Cells[1].Value.ToString();
                //txtInfoTipoParceiro.Text = DataGridViewNossosMembros.CurrentRow.Cells[3].Value.ToString();

            }
        }

        private void btnAddClubes_Click(object sender, EventArgs e)
        {
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            if (modoEscuro)
            {
                infoClube infoClube = new infoClube(formModal, true, true);
                infoClube.Show();
            }
            else
            {
                infoClube infoClube = new infoClube(formModal, false, true);
                infoClube.Show();
            }
        }
    }
}
