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
    public partial class InfoEstadios : Form
    {
        Form form;
        bool addmode;
        public InfoEstadios(Form formy, bool darkMode, bool AddMode)
        {
            form = formy;
            addmode = AddMode;
            InitializeComponent();

            if (darkMode)
            {
                btnAddimagens.BaseColor = 
                txtNomeEstadio.BaseColor = txtNomeEstadio.FocusedBaseColor =
                txtHistoria.BaseColor = txtHistoria.FocusedBaseColor =
                dtpDataFundacao.BaseColor = dtpDataFundacao.FocusedColor = dtpDataFundacao.OnHoverBaseColor =
                this.BackColor= Color.FromArgb(14, 18, 30);

                flowLayoutPanelFotos.BackColor = Color.FromArgb(24, 28, 40);

                btnAddimagens.ForeColor = 
                dtpDataFundacao.ForeColor =
                lblTitulo.ForeColor =
                 Color.Gainsboro;

            }

            if (AddMode)
            {
                lblTitulo.Text = "Adicionar estágio";
                lblDescrTitulo.Text = "Ao cadastrar um novo estádio, preencha todos os campos!";
                btnAddimagens.Text = "Adicionar fotografia";
                btnSalvar.Text = "Adicionar";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }
    }
}
