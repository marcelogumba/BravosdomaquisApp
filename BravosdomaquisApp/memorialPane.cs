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
    public partial class memorialPane : UserControl
    {
        public memorialPane(string id, string nome, string funcao, string dataNascimento, string dataMorte,  string urlImagem)
        {
            InitializeComponent();
            try
            {
                txtNome.Text = nome;
                txtFuncao.Text = funcao;
                txtDataNascimento.Text = dataNascimento;
                txtDataMorte.Text = dataMorte;
                //pictureBoxImage.Image = Image.FromFile(urlImagem);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void showNotify(int tipo, string mensagem)
        {
            // tipo : 1 - seucesso, 2 - Info, 3 - Aviso
            Notification notify = new Notification(tipo, mensagem);
            notify.Show();
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            lblEliminar.Visible = true;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            lblEliminar.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnBaixar_MouseHover(object sender, EventArgs e)
        {
            lblPost.Visible = true;
        }

        private void btnBaixar_MouseLeave(object sender, EventArgs e)
        {
            lblPost.Visible = false;
        }
    }
}
