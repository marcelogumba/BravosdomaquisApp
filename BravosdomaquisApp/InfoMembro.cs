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
    public partial class InfoMembro : Form
    {
        Form form;
        bool addmode;
        public InfoMembro(Form formy, bool darkMode, bool AddMode)
        {
            addmode = AddMode;
            form = formy;
            InitializeComponent();

            if (darkMode)
            {
                btnAlterarFoto.BaseColor = btnSim.BaseColor =
                txtNomeMembro.BaseColor = txtNomeMembro.FocusedBaseColor =
                txtLinkouNomeRedes.BaseColor = txtLinkouNomeRedes.FocusedBaseColor =
                cbxNivel.BaseColor = cbxNivel.FocusedColor =
                cbxCargo.BaseColor = cbxCargo.FocusedColor = 
                cbxSelectRedesSociais.BaseColor = cbxSelectRedesSociais.FocusedColor =
                dtpDataPosse.BaseColor = dtpDataPosse.FocusedColor = dtpDataPosse.OnHoverBaseColor =
                panelInfoMembro.BaseColor = Color.FromArgb(14, 18, 30);
                
                btnAlterarFoto.ForeColor =
                dtpDataPosse.ForeColor =
                cbxNivel.ForeColor =
                cbxSelectRedesSociais.ForeColor =
                cbxCargo.ForeColor =
                lblTitulo.ForeColor =
                 Color.Gainsboro;
            }

            if (AddMode)
            {
                lblTitulo.Text = "Cadastrar membro";
                lblDescrTitulo.Text = "Ao cadastrar um novo membro, preencha todos os campos!";
                btnAlterarFoto.Text = "Adicionar fotografia";
                btnSalvarAlteraçoes.Text = "Cadastar";
            }
            //gunaDateTimePicker1.
        }

        private void panelInfoMembro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFecharInfoMembro_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }

        private void btnFecharInfoMembro_MouseHover(object sender, EventArgs e)
        {
            lblFecharInfoMembro.Visible = true;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnFecharInfoMembro_MouseLeave(object sender, EventArgs e)
        {
            lblFecharInfoMembro.Visible = false;
        }
    }
}
