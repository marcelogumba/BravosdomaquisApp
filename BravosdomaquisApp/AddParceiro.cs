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
    public partial class AddParceiro : Form
    {
        Form form;
        bool addMode;
        public AddParceiro(Form formy, bool darkMode, bool addMode)
        {
            this.addMode = addMode;
            form = formy;
            InitializeComponent();

            if (darkMode)
            {
                btnVerAnexo1.BaseColor = btnVerAnexo2.BaseColor =
                btnAlterarFoto.BaseColor = btnSim.BaseColor =
                txtDescricaoParceiro.BaseColor = txtDescricaoParceiro.FocusedBaseColor =
                txtNomeParceiro.BaseColor = txtNomeParceiro.FocusedBaseColor =
                txtLinkouNomeRedes.BaseColor = txtLinkouNomeRedes.FocusedBaseColor =
                cbxSelectRedesSociais.BaseColor = cbxSelectRedesSociais.FocusedColor =
                cbxSelectTipoParceiria.BaseColor = cbxSelectTipoParceiria.FocusedColor =
                panelAddParceiria.BaseColor = Color.FromArgb(14, 18, 30);

                txtAnexo1.ForeColor = txtAnexo2.ForeColor =
                lblAnexo1.ForeColor = lblAnexo2.ForeColor =
                btnAlterarFoto.ForeColor =
                cbxSelectRedesSociais.ForeColor =
                cbxSelectRedesSociais.ForeColor =
                cbxSelectTipoParceiria.ForeColor =
                lblTitulo.ForeColor = Color.Gainsboro;
            }

            if (addMode == false)
            {
                lblTitulo.Text = "Informações do parceiro";
                lblDescriAddParceiro.Text = "Veja abaixo as informações deste parceiro!";
                btnAddParceiro.Text = "Salvar alterações";
                btnCancelar.Width = 175;
                btnRemove.Visible = true;
            }
        }

        private void panelDetalhesInscricao_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }
    }
}
