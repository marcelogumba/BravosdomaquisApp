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
    public partial class FotosPane : UserControl
    {
        public FotosPane(string id, string urlImagem, string descricao)
        {
            InitializeComponent();

            try
            {
               // pictureBoxImage.Image = Image.FromFile(urlImagem);
                txtDescriImagem.Text = descricao;
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
            
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnBaixar_MouseHover(object sender, EventArgs e)
        {
        }

        private void btnBaixar_MouseLeave(object sender, EventArgs e)
        {
        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {
            showNotify(1, "Baixada com sucesso!");
        }
    }
}
