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
    public partial class Campeaonato : UserControl
    {
        bool modoEscuro;
        int flagTela = 0;
        public Campeaonato()
        {
            InitializeComponent();
            flagTela = 1;
            if (modoEscuro == false)
            {
                btnAdd.BackColor = Color.LightSteelBlue;
                btnEdit.BackColor = Color.Gainsboro;
                btnPost.BackColor = Color.Gainsboro;
            }
            else
            {
                btnAdd.BackColor = Color.FromArgb(19, 23, 35);
                btnEdit.BackColor = btnPost.BackColor = Color.FromArgb(4, 8, 20);
            }

            panelAdd.Dock = DockStyle.Fill;
            panelEditar.Dock = panelPostar.Dock = DockStyle.None;

            panelAdd.Visible = true;
            panelEditar.Visible = panelPostar.Visible = false;
        }
        public void showNotify(int tipo, string mensagem)
        {
            Notification notify = new Notification(tipo, mensagem);
            notify.Show();
        }
        public void darMode()
        {
            modoEscuro = true;
            btnPostar.BackColor = Color.FromArgb(4, 8, 20);
            DataGridViewListaCampeo.ThemeStyle.RowsStyle.BackColor =
            DataGridViewListaCampeo.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(19, 23, 35);
            DataGridViewListaCampeo.BackgroundColor = Color.FromArgb(19, 23, 35);

            panelSuperior.BaseColor = Color.FromArgb(4, 8, 20);
            panelAdd.BaseColor = panelViewAll.BaseColor =
            panelEditar.BaseColor = panelPostar.BaseColor = Color.FromArgb(4, 8, 20);
            
            txtNomeCamp.FocusedForeColor = txtNomeCamp.ForeColor =
            lblEditarCamp.ForeColor = lblPostarCamp.ForeColor =
            txtTemporada.FocusedForeColor = txtTemporada.ForeColor = Color.Gainsboro;

            lblCampeo.ForeColor = lblDescrCampeo.ForeColor = lblVerListaCamp.ForeColor =
            lblAdicionarCamp.ForeColor = lblVerListaDescrip.ForeColor = Color.FromArgb(200, 200, 200);

            lblVerListaDescrip.BackColor = lblVerListaCamp.BackColor = txtNomeCamp.BaseColor = txtTemporada.BaseColor =
            txtNomeCamp.FocusedBaseColor = txtTemporada.FocusedBaseColor =
            txtTempoEditar.BaseColor = txtNomeCampEditar.BaseColor =
            txtNomeCampPostar.BaseColor = txtTempoPostar.BaseColor = txtJornadasAddCamp.BaseColor =
            txtJornadasEditCamp.BaseColor = txtJornadasPost.BaseColor =


            txtTempoEditar.FocusedBaseColor = txtNomeCampEditar.FocusedBaseColor =
            txtNomeCampPostar.FocusedBaseColor = txtTempoPostar.FocusedBaseColor = txtJornadasAddCamp.FocusedBaseColor =
            txtJornadasEditCamp.FocusedBaseColor = txtJornadasPost.FocusedBaseColor =
            lblDescrCampeo.BackColor = lblCampeo.BackColor = btnAdd.BackColor = btnEdit.BackColor =  Color.FromArgb(4, 8, 20);
            this.BackColor = Color.FromArgb(5, 10, 26);

            btnEliminar.BackColor = Color.FromArgb(4, 8, 20);

            if (flagTela == 1)
            {
                btnAdd.BackColor = Color.FromArgb(19, 23, 35);
                btnEdit.BackColor = btnPost.BackColor = Color.FromArgb(4, 8, 20);
            }
            else if (flagTela == 2)
            {
                btnAdd.BackColor = btnPost.BackColor = Color.FromArgb(4, 8, 20);
                btnEdit.BackColor = Color.FromArgb(19, 23, 35);
            }
            else if (flagTela == 3)
            {
                btnAdd.BackColor = Color.FromArgb(4, 8, 20);
                btnEdit.BackColor = Color.FromArgb(4, 8, 20);
                btnPost.BackColor = Color.FromArgb(19, 23, 35);
            }
            else
            {
                btnAdd.BackColor = Color.FromArgb(4, 8, 20);
                btnEdit.BackColor = Color.FromArgb(4, 8, 20);
                btnPost.BackColor = Color.FromArgb(4, 8, 20);
            }

        }
        public void lightMode()
        {
            modoEscuro = false;
            btnPostar.BackColor = Color.Gainsboro;
            DataGridViewListaCampeo.ThemeStyle.RowsStyle.BackColor =
            DataGridViewListaCampeo.ThemeStyle.AlternatingRowsStyle.BackColor = Color.LightSlateGray;
            DataGridViewListaCampeo.BackgroundColor = Color.LightSlateGray;

            panelSuperior.BaseColor = panelEditar.BaseColor = panelPostar.BaseColor =
            panelAdd.BaseColor = panelViewAll.BaseColor = Color.Gainsboro;

         
            txtNomeCamp.FocusedForeColor = txtNomeCamp.ForeColor =
            txtTemporada.FocusedForeColor = txtTemporada.ForeColor = Color.LightSlateGray;

            lblCampeo.ForeColor = lblDescrCampeo.ForeColor = lblVerListaCamp.ForeColor =
            lblEditarCamp.ForeColor = lblPostarCamp.ForeColor = 
            lblVerListaDescrip.ForeColor = lblAdicionarCamp.ForeColor = Color.FromArgb(27, 87, 165);

            lblVerListaDescrip.BackColor = lblVerListaCamp.BackColor = lblDescrCampeo.BackColor =
            txtNomeCamp.BaseColor = txtTemporada.BaseColor =
            txtNomeCamp.FocusedBaseColor = txtTemporada.FocusedBaseColor =

            txtTempoEditar.BaseColor = txtNomeCampEditar.BaseColor = 
            txtNomeCampPostar.BaseColor = txtTempoPostar.BaseColor = txtJornadasAddCamp.BaseColor =
            txtJornadasEditCamp.BaseColor = txtJornadasPost.BaseColor =

            txtTempoEditar.FocusedBaseColor = txtNomeCampEditar.FocusedBaseColor =
            txtNomeCampPostar.FocusedBaseColor = txtTempoPostar.FocusedBaseColor = txtJornadasAddCamp.FocusedBaseColor =
            txtJornadasEditCamp.FocusedBaseColor = txtJornadasPost.FocusedBaseColor =
            lblCampeo.BackColor = btnAdd.BackColor = btnEdit.BackColor = Color.Gainsboro;


            this.BackColor = Color.FromArgb(200, 200, 200);


            btnEliminar.BackColor = Color.Gainsboro;

            if (flagTela == 1)
            {
                btnAdd.BackColor = Color.LightSteelBlue;
                btnEdit.BackColor = Color.Gainsboro;
                btnPost.BackColor = Color.Gainsboro;
            }
            else if (flagTela == 2)
            {
                btnAdd.BackColor = btnPost.BackColor = Color.Gainsboro;
                btnEdit.BackColor = Color.LightSteelBlue;
            }
            else if (flagTela == 3)
            {
                btnAdd.BackColor = Color.Gainsboro;
                btnEdit.BackColor = Color.Gainsboro;
                btnPost.BackColor = Color.LightSteelBlue;
                
            }
            else
            {
                btnAdd.BackColor = Color.Gainsboro;
                btnEdit.BackColor = Color.Gainsboro;
                btnPost.BackColor = Color.Gainsboro;
            }
        }
        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Campeaonato_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            lblAdd.Visible = true;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            lblAdd.Visible = false;
        }

        private void btnEdit_MouseHover(object sender, EventArgs e)
        {
            lblEdit.Visible = true;
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            lblEdit.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            flagTela = 1;
            if (modoEscuro == false)
            {
                btnAdd.BackColor = Color.LightSteelBlue;
                btnEdit.BackColor = Color.Gainsboro;
                btnPost.BackColor = Color.Gainsboro;
            }
            else
            {
                btnAdd.BackColor = Color.FromArgb(19, 23, 35);
                btnEdit.BackColor = btnPost.BackColor = Color.FromArgb(4, 8, 20);
            }

            panelAdd.Dock = DockStyle.Fill;
            panelEditar.Dock = panelPostar.Dock = DockStyle.None;

            panelAdd.Visible = true;
            panelEditar.Visible = panelPostar.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            flagTela = 2;
            if (modoEscuro == false)
            {
                btnPost.BackColor = Color.Gainsboro;
                btnAdd.BackColor = Color.Gainsboro;
                btnEdit.BackColor = Color.LightSteelBlue;
            }
            else
            {
                btnAdd.BackColor = btnPost.BackColor = Color.FromArgb(4, 8, 20);
                btnEdit.BackColor = Color.FromArgb(19, 23, 35);

            }

            panelEditar.Dock = DockStyle.Fill;
            panelAdd.Dock = panelPostar.Dock = DockStyle.None;

            panelEditar.Visible = true;
            panelAdd.Visible = panelPostar.Visible = false;
        }

        private void panelAdd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            lblEliminar.Visible = true;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {

            lblEliminar.Visible = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelPostar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            flagTela = 3;
            if (modoEscuro == false)
            {
                btnPost.BackColor = Color.LightSteelBlue;
                btnAdd.BackColor = Color.Gainsboro;
                btnEdit.BackColor = Color.Gainsboro;
            }
            else
            {
                btnAdd.BackColor = btnEdit.BackColor = Color.FromArgb(4, 8, 20);
                btnPost.BackColor = Color.FromArgb(19, 23, 35);

            }

            panelPostar.Dock = DockStyle.Fill;
            panelAdd.Dock = panelEditar.Dock = DockStyle.None;

            panelPostar.Visible = true;
            panelAdd.Visible = panelEditar.Visible = false;
        }

        private void btnPost_MouseHover(object sender, EventArgs e)
        {
            lblPostar.Visible = true;
        }

        private void btnPost_MouseLeave(object sender, EventArgs e)
        {
            lblPostar.Visible = false;
        }

        private void btnSalavar_Click(object sender, EventArgs e)
        {
            showNotify(1, "Campeonato adicionado!");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            showNotify(3, "Campeonato eliminado!");
        }

        private void btnPostar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSalvarAlteracoes_Click(object sender, EventArgs e)
        {
            showNotify(1, "Alterações salvas!");
        }

        private void gunaTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar!= (char)8)
            {
                e.Handled = true;

            }
        }

        private void txtTemporada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;

            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;

            }
        }

        private void txtTempoEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;

            }
        }

        private void txtJornadasEditCamp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;

            }
        }

        private void txtTempoPostar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;

            }
        }

        private void txtJornadasPost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;

            }
        }

        private void btnPostar_Click_1(object sender, EventArgs e)
        {
            showNotify(1, "Campeonato foi postado!");
        }

        private void btnPostar_MouseHover(object sender, EventArgs e)
        {
            lblBtnPostar.Visible = true;
        }

        private void btnPostar_MouseLeave(object sender, EventArgs e)
        {
            lblBtnPostar.Visible = false;
        }

        private void txtIDEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;

            }
        }

        private void DataGridViewListaCampeo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnEditarCampeoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //txtNomeCampEditar.Text = DataGridViewListaCampeo.CurrentRow.Cells[2].Value.ToString();
            flagTela = 2;
            if (modoEscuro == false)
            {
                btnPost.BackColor = Color.Gainsboro;
                btnAdd.BackColor = Color.Gainsboro;
                btnEdit.BackColor = Color.LightSteelBlue;
            }
            else
            {
                btnAdd.BackColor = btnPost.BackColor = Color.FromArgb(4, 8, 20);
                btnEdit.BackColor = Color.FromArgb(19, 23, 35);

            }

            panelEditar.Dock = DockStyle.Fill;
            panelAdd.Dock = panelPostar.Dock = DockStyle.None;

            panelEditar.Visible = true;
            panelAdd.Visible = panelPostar.Visible = false;
        }

        private void DataGridViewListaCampeo_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int linhaEmCausa = DataGridViewListaCampeo.HitTest(e.X, e.Y).RowIndex;
                if (linhaEmCausa >= 0)
                {
                    contextMenuDataGrid.Show(DataGridViewListaCampeo, new Point(e.X, e.Y));
                }
            }
        }
    }
}
