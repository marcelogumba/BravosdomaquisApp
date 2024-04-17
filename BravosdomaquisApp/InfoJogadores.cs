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
    public partial class InfoJogadores : Form
    {
        Form form;
        bool addmode;

        private void btnFecharInfoMembro_Click(object sender, EventArgs e)
        {

            this.Close();
            form.Close();
        }

        public InfoJogadores(Form formy, bool darkMode, bool AddMode)
        {
          
            addmode = AddMode;
            form = formy;
            InitializeComponent();


            if (AddMode)
            {
                lblTitulo.Text = "Adicionar jogador";
                lblDescrTitulo.Text = "Ao cadastrar um novo jogador, preencha todos os campos!";
                btnAlterarFoto.Text = "Adicionar fotografia";
                btnSalvarAlteraçoes.Text = "Adicionar";
            }

            if (darkMode)
            {
                DarkMode();
            }
        }

        public void DarkMode()
        {
            txtNomeAtletico.BaseColor = txtNomeAtletico.FocusedBaseColor =
               txtCamisa.BaseColor = txtCamisa.FocusedBaseColor =
          txtNome.BaseColor = txtNome.FocusedBaseColor =
            txtLinkouNomeRedes.BaseColor = txtLinkouNomeRedes.FocusedBaseColor =
            cbxSelectPosicao.BaseColor =
            cbxSelectRedesSociais.BaseColor =
            btnAlterarFoto.BaseColor =
            btnSim.BaseColor =
            dtpDataNascimento.BaseColor = dtpDataNascimento.OnHoverBaseColor =
            panelInfoJogadores.BaseColor = Color.FromArgb(14, 18, 30);

            dtpDataNascimento.ForeColor =
            cbxSelectRedesSociais.ForeColor =
            cbxSelectPosicao.ForeColor =
            lblTitulo.ForeColor = Color.Gainsboro;
        }
    }
}
