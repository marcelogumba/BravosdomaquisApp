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
    public partial class Banner : UserControl
    {
        bool modoEscuro;
        
        public Banner()
        {
            InitializeComponent();
            sourceBannerBindingSource.Add(new sourceBanner() { ID = "1", Titulo = "Calendário eleitoral", Principal = true, Status = true});
            sourceBannerBindingSource.Add(new sourceBanner() { ID = "2", Titulo = "Outro título", Principal = true, Status = false });
            sourceBannerBindingSource.Add(new sourceBanner() { ID = "3", Titulo = "outro título", Principal = false, Status = false });
        }
        public void darkMode()
        {
            modoEscuro = true;
            this.BackColor = Color.FromArgb(5, 10, 26);
            
            panelContactos.BaseColor = Color.FromArgb(4, 8, 20);
            
            panelViewAllContacto.BaseColor = Color.FromArgb(14, 18, 30);

            lblContactos.ForeColor = 
            lblVerListaContatos.ForeColor = Color.Gainsboro;
        }
        public void lightMode()
        {
            modoEscuro = false;
            this.BackColor = Color.FromArgb(200, 200, 200);

            panelContactos.BaseColor = Color.Gainsboro;
            
            panelViewAllContacto.BaseColor = Color.Gainsboro;

            lblContactos.ForeColor = 
            lblVerListaContatos.ForeColor = Color.FromArgb(27, 87, 165);
        }
        public void showNotify(int tipo, string mensagem)
        {
            // tipo : 1 - seucesso, 2 - Info, 3 - Aviso
            Notification notify = new Notification(tipo, mensagem);
            notify.Show();
        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridViewContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewContactos.Columns[e.ColumnIndex].Name == "Editar")
            {

                FormBackgroudModal formModal = new FormBackgroudModal();
                formModal.Show();
                InfoBanner info = new InfoBanner(formModal, modoEscuro, false);
                info.Show();
            }
            if (DataGridViewContactos.Columns[e.ColumnIndex].Name == "Apagar")
            {
                showNotify(3, "Contacto apagado!");
            }
        }

        private void btnaddConteudo_Click(object sender, EventArgs e)
        {
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            InfoBanner info = new InfoBanner(formModal, modoEscuro, true);
            info.Show();
        }
    }
}
