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
    public partial class Parceiro : UserControl
    {
        bool modoEscuro;
        public Parceiro()
        {
            InitializeComponent();

            panelParceiros.Visible = true;
            panelParceiros.Dock = DockStyle.Fill;

            paneNossosParceiros.Visible = false;
            paneNossosParceiros.Dock = DockStyle.None;


            sourceParceirosBindingSource.Add(new sourceParceiros() { ID = "1", Nome = "Margareth de Souza", Descricao = "Parceira 100%", Tipo = 1, RedesSociais = "Por colocar", Imagem = "por colocar"});
            sourceParceirosBindingSource.Add(new sourceParceiros() { ID = "2", Nome = "Andre de Almeida", Descricao = "Parceira 80%", Tipo = 1, RedesSociais = "Por colocar", Imagem = "por colocar" });
            sourceParceirosBindingSource.Add(new sourceParceiros() { ID = "3", Nome = "Souza Diogo", Descricao = "Parceira 10%", Tipo = 1, RedesSociais = "Por colocar", Imagem = "por colocar" });
            sourceParceirosBindingSource.Add(new sourceParceiros() { ID = "4", Nome = "Armando Vieira", Descricao = "Parceira 50%", Tipo = 1, RedesSociais = "Por colocar", Imagem = "por colocar" });
        }
        public void darkMode()
        {
            modoEscuro = true;
            this.BackColor = Color.FromArgb(5, 10, 26);

            paneNossosParceiros.BaseColor =
            panelParceiros.BaseColor = Color.FromArgb(4, 8, 20);

            panelNParceiros.BaseColor = Color.FromArgb(14, 18, 30);

            lblNParceiros.ForeColor =
            lblParceiros.ForeColor = Color.Gainsboro;

        }
        public void lightMode()
        {
            modoEscuro = false;
            this.BackColor = Color.FromArgb(200, 200, 200);

            paneNossosParceiros.BaseColor =
            panelParceiros.BaseColor = Color.Gainsboro;

            lblNParceiros.ForeColor =
            lblParceiros.ForeColor = Color.FromArgb(27, 87, 165);
        }
        public void showNotify(int tipo, string mensagem)
        {
            // tipo : 1 - seucesso, 2 - Info, 3 - Aviso
            Notification notify = new Notification(tipo, mensagem);
            notify.Show();
        }
        private void btnVerParceiros_Click(object sender, EventArgs e)
        {

            panelParceiros.Visible = false;
            panelParceiros.Dock = DockStyle.None;

            paneNossosParceiros.Visible = true;
            paneNossosParceiros.Dock = DockStyle.Fill;
        }

        private void btnVerParceirosInscritos_Click(object sender, EventArgs e)
        {
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            AddParceiro addParceiro = new AddParceiro(formModal, modoEscuro, true);
            addParceiro.Show();
            
        }
  
        private void btnVoltar_Click(object sender, EventArgs e)
        {

            panelParceiros.Visible = true;
            panelParceiros.Dock = DockStyle.Fill;

            paneNossosParceiros.Visible = false;
            paneNossosParceiros.Dock = DockStyle.None;
        }

        private void btnVoltar_MouseHover(object sender, EventArgs e)
        {
            lblVoltar.Visible = true;
        }

        private void btnVoltar_MouseLeave(object sender, EventArgs e)
        {
            lblVoltar.Visible = false;
        }

        private void DataGridViewNossosParceiros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewNossosParceiros.Columns[e.ColumnIndex].Name == "Detalhes")
            {
                FormBackgroudModal formModal = new FormBackgroudModal();
                formModal.Show();
                AddParceiro addParceiro = new AddParceiro(formModal, modoEscuro, false);
                addParceiro.Show();

                //txtInfoNomeParceiro.Text = DataGridViewNossosParceiros.CurrentRow.Cells[1].Value.ToString();
                //txtInfoTipoParceiro.Text = DataGridViewNossosParceiros.CurrentRow.Cells[3].Value.ToString();

            }
        }

        private void Parceiro_Load(object sender, EventArgs e)
        {

        }
    }
}
