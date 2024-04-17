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
    public partial class VerGaleria : Form
    {
        Form form;
        bool darkmode, flag = false;

        private void btnFecharInfoMembro_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }
        public void createFotosPanes(int numFotos,string id, string urlImagem, string descricao)
        {
            flowLayoutPanel.HorizontalScroll.Maximum = 0;
            flowLayoutPanel.HorizontalScroll.Visible = false;
            flowLayoutPanel.HorizontalScroll.Enabled = false;
            flowLayoutPanel.AutoScroll = false;
            flowLayoutPanel.VerticalScroll.Visible = false;
            flowLayoutPanel.AutoScroll = true;

            for (int i = 0; i < numFotos; i++)
            {
                FotosPane FotosPane = new FotosPane(id, urlImagem, descricao);
                flowLayoutPanel.Controls.Add(FotosPane);
            }
            this.Visible = true;
        }

        private void btnFechar_MouseHover(object sender, EventArgs e)
        {
            lblFecharInfoMembro.Visible = true;
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            lblFecharInfoMembro.Visible = false;
        }

        public VerGaleria(Form formy, bool darkMode)
        {
            form = formy;
            InitializeComponent();
            this.Visible = false;

            if (darkMode)
            {
                this.BackColor = Color.FromArgb(5, 10, 26);
                flowLayoutPanel.BackColor  = Color.FromArgb(14, 18, 30);
                lblTitulo.ForeColor = Color.Gainsboro;
            }
            createFotosPanes(14, "", "C:/Users/MARCELO CARLOS/Documents/Icons/LogoMaquis.png", "Imagem da equipa no jogo contra ...");
        }
    }
}
