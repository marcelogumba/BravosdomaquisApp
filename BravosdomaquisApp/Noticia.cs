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
    public partial class Noticia : UserControl
    {
        bool modoEscuro;
        public Noticia()
        {
            InitializeComponent();
            cbxSelectCategoria.DropDownStyle = ComboBoxStyle.DropDown;
            sourceNoticiasBindingSource.Add(new SourceNoticias() { ID = "1", Titulo = "Jogos do Ano", Status = "Postado" });
            sourceNoticiasBindingSource.Add(new SourceNoticias() { ID = "2", Titulo = "Trajetória da equipa", Status = "Em espera" });
            panelDetalhesNoticia.Width = 918;
            panelCadastrarNova.Visible = false;
            panelCadastrarNova.Dock = DockStyle.None;

            panelNoticia.Visible = true;
            panelNoticia.Dock = DockStyle.Fill;

            panelNoticiasInseridas.Visible = false;
            panelNoticiasInseridas.Dock = DockStyle.None;
        }
        public void showNotify(int tipo, string mensagem)
        {
            // tipo : 1 - seucesso, 2 - Info, 3 - Aviso
            Notification notify = new Notification(tipo, mensagem);
            notify.Show();
        }

        public void darkMode()
        {
            this.BackColor = Color.FromArgb(5, 10, 26);
            modoEscuro = true;
            panelCadastrarNova.BaseColor =
            panelNoticiasInseridas.BaseColor =
            panelNoticia.BaseColor = Color.FromArgb(4, 8, 20);

            txtAnexo1.BaseColor = txtAnexo1.FocusedBaseColor =
            txtTags.BaseColor = cbxSelectCategoria.BaseColor =
            txtTags.FocusedBaseColor = cbxSelectCategoria.FocusedColor = 
            txtconteudo.BaseColor = txtTitulo.BaseColor =
            txtconteudo.FocusedBaseColor = txtTitulo.FocusedBaseColor =
            panelCateTags.BaseColor = btnAddAnexo1.BaseColor =
            panelCadastroNoticia.BaseColor = Color.FromArgb(14, 18, 30);

            lblNoticia.ForeColor = lblAdicionarNovaNoticia.ForeColor =
            lblAnexo1.ForeColor = txtTags.ForeColor = txtconteudo.ForeColor =
            txtTitulo.ForeColor = txtconteudo.ForeColor = Color.Gainsboro;

            panelDetalhesNoticia.BaseColor =
            txtAlterarAnexo1.BackColor = txtAlterarAnexo1.FocusedLineColor = txtAlterarAnexo1.LineColor =
            txtDetNotiTags.BaseColor = txtDetNotiCategoria.BaseColor =
            txtDetNotiTags.FocusedBaseColor = txtDetNotiCategoria.FocusedBaseColor =
            txtDetNotiTitulo.BaseColor = txtDetNotiConteudo.BaseColor =
            txtDetNotiConteudo.FocusedBaseColor = txtDetNotiTitulo.FocusedBaseColor =
            panelDetNotTagCategoria.BaseColor = btnAlterarAnexo1.BaseColor =
            panelCadastroNoticia.BaseColor = Color.FromArgb(14, 18, 30);

            lblAlterarAnexo1.ForeColor = lblLinkVideo.ForeColor = cbxSelectCategoria.ForeColor =
            lblDetalhesDaNoti.ForeColor = txtTipoDeConteudo.ForeColor =
            lblAnexo1.ForeColor = txtTags.ForeColor = txtconteudo.ForeColor =
            txtTitulo.ForeColor = txtconteudo.ForeColor = Color.Gainsboro;


        }

        public void lightMode()
        {
            this.BackColor = Color.FromArgb(200, 200, 200);
            modoEscuro = false;
            panelCadastrarNova.BaseColor =
            panelNoticiasInseridas.BaseColor =
            panelNoticia.BaseColor =

            txtAnexo1.BaseColor = txtAnexo1.FocusedBaseColor =
            txtTags.BaseColor = cbxSelectCategoria.BaseColor =
            txtTags.FocusedBaseColor = cbxSelectCategoria.FocusedColor =
            txtconteudo.BaseColor = txtTitulo.BaseColor =
            txtconteudo.FocusedBaseColor = txtTitulo.FocusedBaseColor =
            panelCateTags.BaseColor = btnAddAnexo1.BaseColor =
            panelCadastroNoticia.BaseColor = Color.Gainsboro;

            lblNoticia.ForeColor = lblAdicionarNovaNoticia.ForeColor =
            lblLinkVideo.ForeColor = cbxSelectCategoria.ForeColor =
            lblAnexo1.ForeColor = txtTags.ForeColor = txtconteudo.ForeColor =
            txtTitulo.ForeColor = txtconteudo.ForeColor = Color.FromArgb(27, 87, 165);

            panelDetalhesNoticia.BaseColor =
            txtAlterarAnexo1.BackColor = txtAlterarAnexo1.FocusedLineColor = txtAlterarAnexo1.LineColor =
            txtDetNotiTags.BaseColor = txtDetNotiCategoria.BaseColor =
            txtDetNotiTags.FocusedBaseColor = txtDetNotiCategoria.FocusedBaseColor =
            txtDetNotiTitulo.BaseColor = txtDetNotiConteudo.BaseColor =
            txtDetNotiConteudo.FocusedBaseColor = txtDetNotiTitulo.FocusedBaseColor =
            panelDetNotTagCategoria.BaseColor = btnAlterarAnexo1.BaseColor =
            panelCadastroNoticia.BaseColor  = Color.Gainsboro;


            lblAlterarAnexo1.ForeColor = lblAdicionarNovaNoticia.ForeColor =
            lblDetalhesDaNoti.ForeColor = txtTipoDeConteudo.ForeColor =
            lblAnexo1.ForeColor = txtTags.ForeColor = txtconteudo.ForeColor =
            txtTitulo.ForeColor = txtconteudo.ForeColor = Color.FromArgb(27, 87, 165);


        }
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            txtconteudo.Text =
            txtTags.Text = 
            txtAnexo1.Text = txtTitulo.Text = "";
            cbxSelectCategoria.SelectedIndex = 0;
            showNotify(1, "Cadastro feito com sucesso!");
        }

        private void gunaRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblPanelCapaOuContVideo.Text = "Adicionar imagem de capa";
            lblConteudo.Visible = txtconteudo.Visible =
            panelCateTags.Visible = true;
            lblLinkVideo.Visible = false;
        }

        private void btnVerAnexo1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPD = new OpenFileDialog();
            OPD.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG;*.MP4";
            if (OPD.ShowDialog() == DialogResult.OK)
            {
                //pictureBox1.ImageLocation = OPD.FileName;
                txtAnexo1.Text = OPD.FileName.ToString();
            }

            /*
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Adicionar imagem";
            dlg.Filter = "JPG (*.jpg)|*.jpg"
                + "|All files (*.*)|*.*";
            Image image;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(dlg.OpenFile());
                    pictureBox1.Image = image;
                    txtAnexo1.Text = image.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel carregar a foto: " + ex.Message);
                }
            }

            dlg.Dispose();
            */
        }

        private void gunaRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblPanelCapaOuContVideo.Text = "Adicionar conteudo em vídeo";
            lblLinkVideo.Visible = true;
            lblConteudo.Visible = txtconteudo.Visible =
            panelCateTags.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtconteudo.Text =
            txtTags.Text = "";
            cbxSelectCategoria.SelectedIndex = 0;
            txtAnexo1.Text = txtTitulo.Text = "";
        }

        private void btnVoltar_MouseHover(object sender, EventArgs e)
        {
            lblVoltar.Visible = true;
        }

        private void btnVoltar_MouseLeave(object sender, EventArgs e)
        {
            lblVoltar.Visible = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            panelCadastrarNova.Visible = false;
            panelCadastrarNova.Dock = DockStyle.None;

            panelNoticia.Visible = true;
            panelNoticia.Dock = DockStyle.Fill;

            panelNoticiasInseridas.Visible = false;
            panelNoticiasInseridas.Dock = DockStyle.None;
        }

        private void btnCadastrarNova_Click(object sender, EventArgs e)
        {
            panelCadastrarNova.Visible = true;
            panelCadastrarNova.Dock = DockStyle.Fill;

            panelNoticia.Visible = false;
            panelNoticia.Dock = DockStyle.None;

            panelNoticiasInseridas.Visible = false;
            panelNoticiasInseridas.Dock = DockStyle.None;
        }

        private void btnVerPostes_Click(object sender, EventArgs e)
        {
            panelCadastrarNova.Visible = false;
            panelCadastrarNova.Dock = DockStyle.None;

            panelNoticia.Visible = false;
            panelNoticia.Dock = DockStyle.None;

            panelNoticiasInseridas.Visible = true;
            panelNoticiasInseridas.Dock = DockStyle.Fill;
        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVoltar2_MouseHover(object sender, EventArgs e)
        {
            lblvoltar2.Visible = true;
        }

        private void btnVoltar2_MouseLeave(object sender, EventArgs e)
        {
            lblvoltar2.Visible = false;
        }

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            panelCadastrarNova.Visible = false;
            panelCadastrarNova.Dock = DockStyle.None;

            panelNoticia.Visible = true;
            panelNoticia.Dock = DockStyle.Fill;

            panelNoticiasInseridas.Visible = false;
            panelNoticiasInseridas.Dock = DockStyle.None;
        }

        private void DataGridViewNoticiasInseridas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewNoticiasInseridas.Columns[e.ColumnIndex].Name == "ViewDetail")
            {
                panelDetalhesNoticia.Visible = true;
                DataGridViewNoticiasInseridas.Visible = false;
                // txtDetNotiTitulo.Text = DataGridViewNoticiasInseridas.CurrentRow.Cells[2].Value.ToString();
                txtDetNotiTitulo.Text = DataGridViewNoticiasInseridas.CurrentRow.Cells[1].Value.ToString();
            }
            else if (DataGridViewNoticiasInseridas.Columns[e.ColumnIndex].Name == "Parar")
            {
                showNotify(3, "Exibição foi parada!");
            }
            else if (DataGridViewNoticiasInseridas.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                showNotify(3, "Conteúdo eliminado!");
            }
        }

        private void btnDetNotCancelar_Click(object sender, EventArgs e)
        {
            DataGridViewNoticiasInseridas.Visible = true;
            panelDetalhesNoticia.Visible = false;
            txtDetNotiConteudo.Text =
            txtDetNotiTags.Text = txtDetNotiCategoria.Text =
            txtAlterarAnexo1.Text = txtDetNotiTitulo.Text = "";
        }

        private void btnAlterarAnexo1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPD = new OpenFileDialog();
            OPD.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG;*.MP4";
            if (OPD.ShowDialog() == DialogResult.OK)
            {
                //pictureBox1.ImageLocation = OPD.FileName;
                txtAlterarAnexo1.Text = OPD.FileName.ToString();
            }
        }

        private void lbLinkVerComentarios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            Comentarios comentario = new Comentarios(formModal, modoEscuro);
            comentario.Show();
            
        }
    }
 }

