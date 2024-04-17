using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace BravosdomaquisApp
{
    public partial class InfoBanner : Form
    {
        Form form;
        bool modoEscuro;
        public InfoBanner(Form formy, bool darkMode, bool addMode)
        {
            form = formy;
            InitializeComponent();

            if (darkMode)
            {
                modoEscuro = true;
                btnVerAnexo1.BaseColor =
                txtTituloConteudo.BaseColor = txtTituloConteudo.FocusedBaseColor =
                txtConteudo.BaseColor = txtConteudo.FocusedBaseColor =
                txtTituloURL.BaseColor = txtTituloURL.FocusedBaseColor =
                txtURL.BaseColor = txtURL.FocusedBaseColor =
                cbxSelectURL.BaseColor = cbxSelectURL.FocusedColor = 
                panelInfoConteudo.BaseColor = Color.FromArgb(24, 28, 40);
                
                cbxSelectURL.ForeColor =
                lblAnexo1.ForeColor =
                txtAnexo1.ForeColor =
                lblTitulo.ForeColor =
                 Color.Gainsboro;

            }

            if (addMode)
            {
                lblTitulo.Text = "Adicionar conteúdo";
                btnSalvarAlteraçoes.Text = "Salvar";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            PreVeiwImagem preview = new PreVeiwImagem(formModal, modoEscuro, "C:\\Users\\MARCELO CARLOS\\Documents\\Icons\\newsIcon.png");
            preview.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }

        private void InfoBanner_Leave(object sender, EventArgs e)
        {
     
        }
    }
}
