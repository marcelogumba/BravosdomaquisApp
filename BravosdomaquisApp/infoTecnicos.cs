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
    public partial class infoTecnicos : Form
    {
        Form form;
        bool addmode;
        public infoTecnicos(Form formy, bool darkMode, bool AddMode)
        {

            addmode = AddMode;
            form = formy;
            InitializeComponent();

            if (AddMode)
            {
                lblTitulo.Text = "Cadastrar técnico";
                lblDescrTitulo.Text = "Ao cadastrar um novo técnico, preencha todos os campos!";
                btnAlterarFoto.Text = "Adicionar fotografia";
                btnSalvarAlteraçoes.Text = "Cadastar";
            }

            if (darkMode)
            {
                DarkMode();
            }
            else
            {
                lightMode();
            }
        }
        public void DarkMode()
        {
            txtNome.BaseColor = txtNome.FocusedBaseColor =
            txtNacionalidade.BaseColor = txtNacionalidade.FocusedBaseColor =
            txtLinkouNomeRedes.BaseColor = txtLinkouNomeRedes.FocusedBaseColor =
            cbxSelectFuncao.BaseColor = 
            cbxSelectRedesSociais.BaseColor = 
            btnAlterarFoto.BaseColor =
            btnSim.BaseColor = 
            dtpDataPosse.BaseColor = dtpDataPosse.OnHoverBaseColor = 
            panelInfoTecnico.BaseColor = Color.FromArgb(14, 18, 30);

            dtpDataPosse.ForeColor =
            cbxSelectRedesSociais.ForeColor =
            cbxSelectFuncao.ForeColor =
            lblTitulo.ForeColor = Color.Gainsboro;
        }
        public void lightMode()
        {
            txtNome.BaseColor = txtNome.FocusedBaseColor =
           txtNacionalidade.BaseColor = txtNacionalidade.FocusedBaseColor =
           txtLinkouNomeRedes.BaseColor = txtLinkouNomeRedes.FocusedBaseColor =
           cbxSelectFuncao.BaseColor =
           cbxSelectRedesSociais.BaseColor =
           btnAlterarFoto.BaseColor =
           btnSim.BaseColor =
           dtpDataPosse.BaseColor = dtpDataPosse.OnHoverBaseColor =
            cbxSelectFuncao.BaseColor = Color.Gainsboro;

            // panelViewAllContacto.BaseColor = Color.Gainsboro;
            dtpDataPosse.ForeColor =
            cbxSelectRedesSociais.ForeColor =
         cbxSelectFuncao.ForeColor =
         lblTitulo.ForeColor =  Color.FromArgb(27, 87, 165);
        }
        private void btnFecharInfoTecnico_MouseHover(object sender, EventArgs e)
        {
            lblFecharInfoMembro.Visible = true;
        }

        private void btnFecharInfoTecnico_MouseLeave(object sender, EventArgs e)
        {
            lblFecharInfoMembro.Visible = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

            this.Close();
            form.Close();
        }
    }
}
