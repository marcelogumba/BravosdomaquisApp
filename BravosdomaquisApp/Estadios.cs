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
    public partial class Estadios : UserControl
    {
        bool modoEscuro;
        public Estadios()
        {
            InitializeComponent();

            sourceEstadiosBindingSource.Add(new sourceEstadios() { ID = "1", Nome = "Estadio 11 de Novembro", DataFundação = "10-10-1990", Historia = "------", Imagens = "Por colocar"});
            sourceEstadiosBindingSource.Add(new sourceEstadios() { ID = "2", Nome = "Outro", DataFundação = "12-11-2021", Historia = "------", Imagens = "Por colocar"});
            sourceEstadiosBindingSource.Add(new sourceEstadios() { ID = "3", Nome = "Outro", DataFundação = "----", Historia = "------", Imagens = "Por colocar"});
            sourceEstadiosBindingSource.Add(new sourceEstadios() { ID = "4", Nome = "Outro", DataFundação = "----", Historia = "------", Imagens = "Por colocar"});

            lblNumAdicionados.Text = 4.ToString();
        }
        public void darkMode()
        {
            modoEscuro = true;

            this.BackColor = Color.FromArgb(5, 10, 26);

            panelSuperior.BaseColor =
            panelViewAll.BaseColor = Color.FromArgb(4, 8, 20);

            lblTitulo.ForeColor = lblVerListaEstadios.ForeColor = Color.Gainsboro;

        }
        public void lightMode()
        {
            modoEscuro = false;

            this.BackColor = Color.FromArgb(200, 200, 200);

            panelSuperior.BaseColor =
            panelViewAll.BaseColor = Color.Gainsboro;

            lblTitulo.ForeColor = lblVerListaEstadios.ForeColor = Color.FromArgb(27, 87, 165);
        }

        private void btnSalvarAlteracoes_Click(object sender, EventArgs e)
        {
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            InfoEstadios estadio = new InfoEstadios(formModal, modoEscuro, true);
            estadio.Show();
        }

        private void DataGridViewListaEstadios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewListaEstadios.Columns[e.ColumnIndex].Name == "Detalhes")
            {

                FormBackgroudModal formModal = new FormBackgroudModal();
                formModal.Show();
                if (modoEscuro)
                {
                    InfoEstadios infoEstadio = new InfoEstadios(formModal, true, false);
                    infoEstadio.Show();
                }
                else
                {
                    InfoEstadios infoEstadio = new InfoEstadios(formModal, false, false);
                    infoEstadio.Show();
                }

                //txtInfoNomeParceiro.Text = DataGridViewNossosMembros.CurrentRow.Cells[1].Value.ToString();
                //txtInfoTipoParceiro.Text = DataGridViewNossosMembros.CurrentRow.Cells[3].Value.ToString();

            }
        }
    }
}
