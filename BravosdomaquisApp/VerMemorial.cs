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
    public partial class VerMemorial : Form
    {
        Form form;

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();

          
        }
        public void createMemorialPanes(int numMemorial, string id, string nome, string funcao, string dataNascimento, string dataMorte, string urlImagem)
        {
            flowLayoutPanel.HorizontalScroll.Maximum = 0;
            flowLayoutPanel.HorizontalScroll.Visible = false;
            flowLayoutPanel.HorizontalScroll.Enabled = false;
            flowLayoutPanel.AutoScroll = false;
            flowLayoutPanel.VerticalScroll.Visible = false;
            flowLayoutPanel.AutoScroll = true;

            for (int i = 0; i < numMemorial; i++)
            {
                memorialPane memorialPane = new memorialPane(id, nome, funcao, dataNascimento, dataMorte, urlImagem);
                flowLayoutPanel.Controls.Add(memorialPane);
            }
            this.Visible = true;
        }
        public VerMemorial(Form formy, bool darkMode)
        {
            form = formy;
            InitializeComponent();

            if (darkMode)
            {
                this.BackColor = Color.FromArgb(5, 10, 26);
                flowLayoutPanel.BackColor = Color.FromArgb(14, 18, 30);
                lblTitulo.ForeColor = Color.Gainsboro;
            }

            createMemorialPanes(5, "", "João Almeida", "Financeiro", "12-12-1998", "19-09-2019", "C:/Users/MARCELO CARLOS/Documents/Icons/123.jpg");
        }
    }
}
