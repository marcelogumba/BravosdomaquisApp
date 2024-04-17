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
    public partial class infoClube : Form
    {
        Form form;
        bool addmode;
        public infoClube(Form formy, bool darkMode, bool AddMode, string id, string nomeClube, string sigla, string emblema, string historia, string redesSociais)
        {
            addmode = AddMode;
            form = formy;
            InitializeComponent();

            if (darkMode)
            {
                btnVerAnexo1.BaseColor = btnSim.BaseColor = 
                txtNomeClube.BaseColor = txtNomeClube.FocusedBaseColor =
                txtSigla.BaseColor = txtSigla.FocusedBaseColor =
                txtHistoria.BaseColor = txtHistoria.FocusedBaseColor =
                txtLinkouNomeRedes.BaseColor = txtLinkouNomeRedes.FocusedBaseColor =
                cbxSelectRedesSociais.BaseColor = cbxSelectRedesSociais.FocusedColor =
                panelInfoClube.BaseColor = Color.FromArgb(14, 18, 30);

                cbxSelectRedesSociais.ForeColor =
                lblTitulo.ForeColor =
                lblAnexo1.ForeColor =
                txtAnexo1.ForeColor =
                 Color.Gainsboro;
            }

            if(addmode == false)
            {
                txtNomeClube.Text = nomeClube;
                txtSigla.Text = sigla;
                txtAnexo1.Text = emblema;
                txtHistoria.Text = historia;
                txtLinkouNomeRedes.Text = redesSociais;
            }
        }
        public infoClube(Form formy, bool darkMode, bool AddMode)
        { 
            addmode = AddMode;
            form = formy;
            InitializeComponent();

            if (darkMode)
            {
                btnVerAnexo1.BaseColor = btnSim.BaseColor =
                txtNomeClube.BaseColor = txtNomeClube.FocusedBaseColor =
                txtSigla.BaseColor = txtSigla.FocusedBaseColor =
                txtHistoria.BaseColor = txtHistoria.FocusedBaseColor =
                txtLinkouNomeRedes.BaseColor = txtLinkouNomeRedes.FocusedBaseColor =
                cbxSelectRedesSociais.BaseColor = cbxSelectRedesSociais.FocusedColor =
                panelInfoClube.BaseColor = Color.FromArgb(14, 18, 30);

                cbxSelectRedesSociais.ForeColor =
                lblTitulo.ForeColor =
                lblAnexo1.ForeColor = 
                txtAnexo1.ForeColor =
                 Color.Gainsboro;

            }

            if (addmode)
            {
                lblTitulo.Text = "Adicionar clube";
                lblDescrTitulo.Text = "Ao cadastrar um novo clube, preencha todos os campos!";
                btnSalvarAlteraçoes.Text = "Adicionar";
            }
           
        }

        private void linkLabelVerImagem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }
    }
}
