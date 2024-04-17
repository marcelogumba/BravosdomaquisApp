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
    public partial class InfoClubes : Form
    {
        Form form;
        bool modoEscuro;
        public InfoClubes(Form formy, bool darkMode, string idClube)
        {
            
            form = formy;
            InitializeComponent();

            if (darkMode)
            {
                DarkMode();
            }
        }
        public void DarkMode()
        {
            modoEscuro = true;
            txtLinkVideo.BaseColor = txtLinkVideo.FocusedBaseColor =
            txtHistoria.BaseColor = txtHistoria.FocusedBaseColor =
            cbxSelectCategoria.BaseColor =
            cbxSelectProvincia.BaseColor =
            cbxSelectEstadio.BaseColor =
            btnAlterarFoto.BaseColor =
            dtpSelectDataFundacao.BaseColor = dtpSelectDataFundacao.OnHoverBaseColor =
            panelInfoClube.BaseColor = Color.FromArgb(14, 18, 30);

            btnAlterarFoto.ForeColor = 
            lblAnexo1.ForeColor =
            cbxSelectCategoria.ForeColor =
            cbxSelectEstadio.ForeColor =
            dtpSelectDataFundacao.ForeColor =
            cbxSelectProvincia.ForeColor =
            cbxSelectProvincia.ForeColor = 
            lblTituloPanel.ForeColor = Color.Gainsboro;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }

        private void btnEditarInfoSite_Click(object sender, EventArgs e)
        {
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            EditarInfoSite EditarInfoSite = new EditarInfoSite(formModal, modoEscuro);
            EditarInfoSite.Show();
        }
    }
}
