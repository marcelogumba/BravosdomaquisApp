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
    public partial class Newslatter : Form
    {
        Form form;
        bool darkmode;
        public Newslatter(Form formy, bool darkMode)
        {
            form = formy;
            InitializeComponent();
            darkmode = darkMode;
            if (darkmode)
            {
                panelNewslatter.BackColor = Color.FromArgb(5, 10, 26);
                lblNewsLatter.ForeColor = Color.Gainsboro;
            }


            sourceEmailBindingSource.Add(new sourceEmail() { ID = "1", Email = "exemploemail@gmail.com"});
            sourceEmailBindingSource.Add(new sourceEmail() { ID = "2", Email = "exemploemail2@gmail.com" });
            sourceEmailBindingSource.Add(new sourceEmail() { ID = "3", Email = "exemploemai3@gmail.com" });
            sourceEmailBindingSource.Add(new sourceEmail() { ID = "4", Email = "exemploemail4@gmail.com" });
            sourceEmailBindingSource.Add(new sourceEmail() { ID = "5", Email = "exemploemai5@gmail.com" });
            sourceEmailBindingSource.Add(new sourceEmail() { ID = "6", Email = "exemploemail6@gmail.com" });
            sourceEmailBindingSource.Add(new sourceEmail() { ID = "7", Email = "exemploemai7@gmail.com" });
            sourceEmailBindingSource.Add(new sourceEmail() { ID = "8", Email = "exemploemail8@gmail.com" });
            sourceEmailBindingSource.Add(new sourceEmail() { ID = "9", Email = "exemploemai9@gmail.com" });
            sourceEmailBindingSource.Add(new sourceEmail() { ID = "10", Email = "exemploemail10@gmail.com" });
            lblNumInscritos.Text = 10.ToString();
        }
        public void showNotify(int tipo, string mensagem)
        {
            // tipo : 1 - seucesso, 2 - Info, 3 - Aviso
            Notification notify = new Notification(tipo, mensagem);
            notify.Show();
        }
    
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }

        private void DataGridViewInscritos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DataGridViewInscritos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                sourceEmailBindingSource.RemoveCurrent();
                showNotify(3, "Eliminado");
                int num; 
                int.TryParse(lblNumInscritos.Text, out num);
                num = num - 1;
                lblNumInscritos.Text = num.ToString();
            }
        }
    }
}
