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
    public partial class EquipaTecnica : UserControl
    {
        bool modoEscuro;
        public EquipaTecnica()
        {
            InitializeComponent();

            sourceTecnicosBindingSource.Add(new sourceTecnicos() { ID = "1", NomeCompleto = "Santos Gonçalves", Funcao = "Técnico do Clube", DataIngresso = "2008/02/08",Nacionalidade = "Angolana", RedesSociais = "Por colocar" });
            sourceTecnicosBindingSource.Add(new sourceTecnicos() { ID = "2", NomeCompleto = "Sergio Oliveira", Funcao = "Técnico adjunto", DataIngresso = "2018/09/28", Nacionalidade = "Angolana", RedesSociais = "Por colocar" });
            sourceTecnicosBindingSource.Add(new sourceTecnicos() { ID = "3", NomeCompleto = "Raul Antonio", Funcao = "Técnico subjacente", DataIngresso = "2019/05/20", Nacionalidade = "Angolana", RedesSociais = "Por colocar" });
            sourceTecnicosBindingSource.Add(new sourceTecnicos() { ID = "4", NomeCompleto = "Flavio André", Funcao = "Ajudante", DataIngresso = "2021/09/28", Nacionalidade = "Angolana", RedesSociais = "Por colocar" });

            lblNumAdicionados.Text = 4.ToString();
        }

        public void darkMode()
        {
            modoEscuro = true;
            this.BackColor = Color.FromArgb(5, 10, 26);

            panelSuperior.BaseColor =
            panelViewAll.BaseColor = Color.FromArgb(4, 8, 20);

            //panelViewAllContacto.BaseColor = Color.FromArgb(14, 18, 30);

            lblEquipaTecnica.ForeColor =
            lblListaTecnicos.ForeColor = Color.Gainsboro;
        }
        public void lightMode()
        {
            modoEscuro = false;
            this.BackColor = Color.FromArgb(200, 200, 200);

            panelSuperior.BaseColor =
            panelViewAll.BaseColor  = Color.Gainsboro;

           // panelViewAllContacto.BaseColor = Color.Gainsboro;

            lblEquipaTecnica.ForeColor =
            lblListaTecnicos.ForeColor = Color.FromArgb(27, 87, 165);
        }
        private void DataGridViewListaTecnicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = DataGridViewListaTecnicos.CurrentRow.Cells[0].Value.ToString();
            string nomeCompleto = DataGridViewListaTecnicos.CurrentRow.Cells[1].Value.ToString();
            string Funcao = DataGridViewListaTecnicos.CurrentRow.Cells[2].Value.ToString();
            string DataIngresso = DataGridViewListaTecnicos.CurrentRow.Cells[3].Value.ToString();
            string Nacionlidade = DataGridViewListaTecnicos.CurrentRow.Cells[4].Value.ToString();
            string Redes = DataGridViewListaTecnicos.CurrentRow.Cells[5].Value.ToString();

            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            if (modoEscuro)
            {
                infoTecnicos infoTecnicos = new infoTecnicos(formModal, true, false);
                infoTecnicos.ShowDialog();
            }
            else
            {
                infoTecnicos infoTecnicos = new infoTecnicos(formModal, false, false);
                infoTecnicos.ShowDialog();
            }
        }

        private void btnAddTecnico_Click(object sender, EventArgs e)
        {
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            if (modoEscuro)
            {
                infoTecnicos infoTecnicos = new infoTecnicos(formModal, true, true);
                infoTecnicos.ShowDialog();
            }
            else
            {
                infoTecnicos infoTecnicos = new infoTecnicos(formModal, false, true);
                infoTecnicos.ShowDialog();
            }
        }
    }
}
