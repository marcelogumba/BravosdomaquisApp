using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BravosdomaquisApp
{

    public partial class Principal : Form
    {
        bool modoEscuro;
        bool sideMenu = true;
        bool campeonatoExpand = false;
        bool GestClubeExpand = false;
        bool EquipasExpand = false;
        bool informacoesExpand = false;
        bool gerenciaExpand = false;
        int flagTelas = -1;

        Campeaonato campeo = new Campeaonato();
        Jogos jogos = new Jogos();
        Pontuação pontuacao = new Pontuação();
        Socios socios = new Socios();
        Banner banner = new Banner();
        Noticia noticia = new Noticia();
        Estadios estadios = new Estadios();
        Jogadores jogadores = new Jogadores();
        Clubes clubes = new Clubes();
        Memorial memorial = new Memorial();
        Galeria galeria = new Galeria();
        Jornadas jornadas = new Jornadas();
        Bilhete bilhete = new Bilhete();
        Resultados resultados = new Resultados();
        EquipaTecnica equipaTecnica = new EquipaTecnica();
        Parceiro parceiro = new Parceiro();
        MembrosDaDirecao membros = new MembrosDaDirecao();
        Inicio inicio = new Inicio();
        public Principal(bool ModoEscuro)
        {
            InitializeComponent();
            containerGestClube.Height = containerGerencia.Height =
            containerInformacoes.Height = conteinerCampeonato.Height = 40;

            containerGestClube.Width = containerGerencia.Width =
            containerInformacoes.Width = conteinerCampeonato.Width = 252;

            modoEscuro = ModoEscuro;
            if (modoEscuro)
            {
                darMode();
                btnModoEscuro.Checked = true;
                ptGerencia.Image = Properties.Resources.baixoDark;
                ptGestClube.Image = Properties.Resources.baixoDark;
                ptCampeo.Image = Properties.Resources.baixoDark;
                ptInformacoes.Image = Properties.Resources.baixoDark;
                ptEquipas.Image = Properties.Resources.baixoDark;

                if (modoEscuro)
                {
                   darMode();
                }
            }
            addTelas(inicio);
        }
        public void addTelas(UserControl tela)
        {
            tela.Dock = DockStyle.Fill;
            pnlTelas.Controls.Clear();
            pnlTelas.Controls.Add(tela);
            tela.BringToFront();
        }
        private void darMode()
        {
            modoEscuro = true;

            ptGerencia.Image = Properties.Resources.baixoDark;
            ptGestClube.Image = Properties.Resources.baixoDark;
            ptCampeo.Image = Properties.Resources.baixoDark;
            ptInformacoes.Image = Properties.Resources.baixoDark;
            ptEquipas.Image = Properties.Resources.baixoDark;

            btnFechar.BackColor = btnMinimizar.BackColor = btnMaximizar.BackColor = Color.FromArgb(5, 10, 26);
            this.BackColor = Color.FromArgb(14, 18, 30);

            btnGalery.BackColor = btnMemorial.BackColor = btnBilhetes.BackColor =
            btnInfoClube.BackColor = btnJogosMaquis.BackColor = 
            btnBannerr.BackColor = btnClubes.BackColor = 
            btnContactos.BackColor = btnEquipaTec.BackColor = btnEstadios.BackColor =
            btnJogadores.BackColor = btnJogos.BackColor = btnJornadas.BackColor =
            btnMemDaDirecao.BackColor = btnNewslatter.BackColor = btnNoticias.BackColor =
            btnParceiros.BackColor = btnPontuacoes.BackColor = btnResulatdos.BackColor =
            btnSocios.BackColor = btnArquivos.BackColor =

            containerGestClube.BackColor = containerGerencia.BackColor = containerEquipas.BackColor =
            containerInformacoes.BackColor = conteinerCampeonato.BackColor = Color.FromArgb(4, 8, 20);

            btnGalery.ForeColor = btnMemorial.ForeColor = btnBilhetes.ForeColor =
            btnInfoClube.ForeColor = btnJogosMaquis.ForeColor =
            btnBannerr.ForeColor = btnClubes.ForeColor = btnEquipas.ForeColor =
            btnContactos.ForeColor = btnEquipaTec.ForeColor = btnEstadios.ForeColor =
            btnJogadores.ForeColor = btnJogos.ForeColor = btnJornadas.ForeColor =
            btnMemDaDirecao.ForeColor = btnNewslatter.ForeColor = btnNoticias.ForeColor =
            btnParceiros.ForeColor = btnPontuacoes.ForeColor = btnResulatdos.ForeColor =
            btnSocios.ForeColor = btnArquivos.ForeColor = btnCampeonato.ForeColor =
            btnGestClube.ForeColor = btnInformacoes.ForeColor = lblUserLogado.ForeColor =
            btnGerencia.ForeColor = btnLogout.ForeColor = lblMenu.ForeColor = Color.FromArgb(200, 200, 200);

            btnFechar.BackColor = panelMenu1.BackColor = panelMenuCentro.BackColor =
            btnCampeonato.BackColor = btnGestClube.BackColor = btnInformacoes.BackColor =
            btnGerencia.BackColor = btnLogout.BackColor = btnEquipas.BackColor =
            pnlSuperior.BackColor = btnMenu.BackColor = Color.FromArgb(5, 10, 26);

            campeo.darMode();
            jogos.darkMode();
            pontuacao.darkMode();
            socios.darkMode();
            banner.darkMode();
            noticia.darkMode();
            equipaTecnica.darkMode();
            jogadores.darkMode();
            galeria.darkMode();
            memorial.darkMode();
            bilhete.darkMode();
            resultados.darkMode();
            jornadas.darkMode();
            clubes.darkMode();
            estadios.darkMode();
            membros.darkMode();
            parceiro.darkMode();
            inicio.darkMode();
        }
        private void lightMode()
        {
            modoEscuro = false;

            ptGerencia.Image = Properties.Resources.baixoLightt;
            ptGestClube.Image = Properties.Resources.baixoLightt;
            ptCampeo.Image = Properties.Resources.baixoLightt;
            ptInformacoes.Image = Properties.Resources.baixoLightt;
            ptEquipas.Image = Properties.Resources.baixoLightt;


            btnFechar.BackColor = btnMinimizar.BackColor = btnMaximizar.BackColor = Color.FromArgb(27, 87, 165);
            pnlSuperior.BackColor = Color.FromArgb(27, 87, 165);
            this.BackColor = Color.FromArgb(224, 224, 224);

            btnGalery.BackColor = btnMemorial.BackColor = btnBilhetes.BackColor =
            btnInfoClube.BackColor = btnJogosMaquis.BackColor =
            btnBannerr.BackColor = btnClubes.BackColor = 
            btnContactos.BackColor = btnEquipaTec.BackColor = btnEstadios.BackColor =
            btnJogadores.BackColor = btnJogos.BackColor = btnJornadas.BackColor =
            btnMemDaDirecao.BackColor = btnNewslatter.BackColor = btnNoticias.BackColor =
            btnParceiros.BackColor = btnPontuacoes.BackColor = btnResulatdos.BackColor =
            btnSocios.BackColor = btnArquivos.BackColor =

            containerGestClube.BackColor = containerGerencia.BackColor = containerEquipas.BackColor =
            containerInformacoes.BackColor = conteinerCampeonato.BackColor = Color.Gainsboro;

            btnGalery.ForeColor = btnMemorial.ForeColor = btnBilhetes.ForeColor =
            btnInfoClube.ForeColor = btnJogosMaquis.ForeColor =
            btnBannerr.ForeColor = btnClubes.ForeColor = btnEquipas.ForeColor =
            btnContactos.ForeColor = btnEquipaTec.ForeColor = btnEstadios.ForeColor =
            btnJogadores.ForeColor = btnJogos.ForeColor = btnJornadas.ForeColor =
            btnMemDaDirecao.ForeColor = btnNewslatter.ForeColor = btnNoticias.ForeColor =
            btnParceiros.ForeColor = btnPontuacoes.ForeColor = btnResulatdos.ForeColor =
            btnSocios.ForeColor = btnArquivos.ForeColor = btnCampeonato.ForeColor =
            btnGestClube.ForeColor = btnInformacoes.ForeColor = lblUserLogado.ForeColor =
            btnGerencia.ForeColor = btnLogout.ForeColor = lblMenu.ForeColor = Color.FromArgb(27, 87, 165);

            panelMenu1.BackColor = panelMenuCentro.BackColor =
            btnCampeonato.BackColor = btnGestClube.BackColor = btnInformacoes.BackColor =
            btnGerencia.BackColor = btnLogout.BackColor = btnEquipas.BackColor =
            btnLogout.BackColor = btnMenu.BackColor = Color.FromArgb(200, 200, 200);

            campeo.lightMode();
            jogos.lightMode();
            pontuacao.lightMode();
            socios.lightMode();
            banner.lightMode();
            noticia.lightMode();
            equipaTecnica.lightMode();
            jogadores.lightMode();
            galeria.lightMode();
            memorial.lightMode();
            bilhete.lightMode();
            resultados.lightMode();
            jornadas.lightMode();
            clubes.lightMode();
            estadios.lightMode();
            membros.lightMode();
            parceiro.lightMode();
            inicio.lightMode();
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            panelMenuCentro.HorizontalScroll.Maximum = 0;
            panelMenuCentro.HorizontalScroll.Visible = false;
            panelMenuCentro.HorizontalScroll.Enabled = false;
            panelMenuCentro.AutoScroll = false;
            panelMenuCentro.VerticalScroll.Visible = false;
            panelMenuCentro.AutoScroll = true;
        }
        private void timerMenu_Tick(object sender, EventArgs e)
        {
           /*
            if (sideMenu)
            {
                panelMenu1.Width -= 25;
                if(panelMenu1.Width <= 80)
                {
                    sideMenu = false;
                    panelMenuCentro.VerticalScroll.Visible = false;
                    timerMenu.Stop();
                    
                } 
            }
            else
            {
                panelMenu1.Width = 240;
                    sideMenu = true;
                    timerMenu.Stop();
                
            }
            */
        }

        private void buttunUI3_Click(object sender, EventArgs e)
        {
            if (flagTelas != 0)
            {
                flagTelas = 0;
                addTelas(inicio);
                if (modoEscuro)
                {
                    inicio.darkMode();
                }
            }

            /*
            timerMenu.Start();

              if (sideMenu)
              {
                  panelMenu1.Width = panelMenuTop.Width = panelLogout.Width =  70;
                  panelMenuCentro.VerticalScroll.Maximum = 1;
                  panelMenuCentro.VerticalScroll.Visible = false;
                  sideMenu = false;
              }
              else
              {
                  panelMenu1.Width = panelLogout.Width = panelMenuTop.Width = 240;
                  sideMenu = true;
              }
           //   */
        }

        private void toogleButton1_CheckedChanged(object sender, EventArgs e)
        {
            containerGestClube.Height = containerGerencia.Height = containerEquipas.Height =
            containerInformacoes.Height = conteinerCampeonato.Height = 40;

            containerGestClube.Width = containerGerencia.Width = containerEquipas.Width =
            containerInformacoes.Width = conteinerCampeonato.Width = 252;

            campeonatoExpand = EquipasExpand = gerenciaExpand =
            GestClubeExpand = informacoesExpand = false;
            if (btnModoEscuro.Checked == true)
            {
                darMode();
            }
            else
            {
                lightMode();
            }
        }

        private void btnBanner_Click(object sender, EventArgs e)
        {
            timerCampeonato.Start();
            if (modoEscuro)
            {
                if (campeonatoExpand)
                {
                    ptCampeo.Image = Properties.Resources.baixoDark;
                }
                else
                {
                    ptCampeo.Image = Properties.Resources.cimaDark;
                }
            }
            else
            {
                if (campeonatoExpand)
                {
                    ptCampeo.Image = Properties.Resources.baixoLightt;
                }
                else
                {
                    ptCampeo.Image = Properties.Resources.cimaLight;
                }
            }
            if (flagTelas != 1)
            {
                flagTelas = 1;

                addTelas(campeo);
                if (modoEscuro)
                {
                    campeo.darMode();
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerCampeonato_Tick(object sender, EventArgs e)
        {
            if (campeonatoExpand == false)
            {
                conteinerCampeonato.Height += 10;
                if (conteinerCampeonato.Height >= 205)
                {
                    timerCampeonato.Stop();
                    campeonatoExpand = true;
                }
            }
            else
            {
                conteinerCampeonato.Height -= 10;
                if (conteinerCampeonato.Height <= 47)
                {
                    timerCampeonato.Stop();
                    campeonatoExpand = false;
                }
            }
        }

        private void panelMenu1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnEquipa_Click(object sender, EventArgs e)
        {
            
        }

        private void buttunUI5_Click(object sender, EventArgs e)
        {
            timerInformacoes.Start();
            if (modoEscuro)
            {
                if (informacoesExpand)
                {
                    ptInformacoes.Image = Properties.Resources.baixoDark;
                }
                else
                {
                    ptInformacoes.Image = Properties.Resources.cimaDark;
                }
            }
            else
            {
                if (informacoesExpand)
                {
                    ptInformacoes.Image = Properties.Resources.baixoLightt;
                }
                else
                {
                    ptInformacoes.Image = Properties.Resources.cimaLight;
                }
            }
        }

        private void timerInformacoes_Tick(object sender, EventArgs e)
        {
            if (informacoesExpand == false)
            {
                containerInformacoes.Height += 10;
                if (containerInformacoes.Height >= 230)
                {
                    timerInformacoes.Stop();
                    informacoesExpand = true;
                }
            }
            else
            {
                containerInformacoes.Height -= 10;
                if (containerInformacoes.Height <= 47)
                {
                    timerInformacoes.Stop();
                    informacoesExpand = false;
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttunUI15_Click(object sender, EventArgs e)
        {
            timerGerencia.Start();
            if (modoEscuro)
            {
                if (gerenciaExpand)
                {
                    ptGerencia.Image = Properties.Resources.baixoDark;
                }
                else
                {
                    ptGerencia.Image = Properties.Resources.cimaDark;
                }
            }
            else
            {
                if (gerenciaExpand)
                {
                    ptGerencia.Image = Properties.Resources.baixoLightt;
                }
                else
                {
                    ptGerencia.Image = Properties.Resources.cimaLight;
                }
            }
        }

        private void timerGerencia_Tick(object sender, EventArgs e)
        {
            if (gerenciaExpand == false)
            {
                containerGerencia.Height += 10;
                if (containerGerencia.Height >= 170)
                {
                    timerGerencia.Stop();
                    gerenciaExpand = true;
                }
            }
            else
            {
                containerGerencia.Height -= 10;
                if (containerGerencia.Height <= 47)
                {
                    timerGerencia.Stop();
                    gerenciaExpand = false;
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login(this.modoEscuro, false);
            login.Show();

        }

        private void buttunUI11_Click(object sender, EventArgs e)
        {
          FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            Newslatter newslatter = new Newslatter(formModal, modoEscuro);
            newslatter.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnJogos_Click(object sender, EventArgs e)
        {
            if (flagTelas != 5)
            {
                flagTelas = 5;
                addTelas(jogos);
                if (modoEscuro)
                {
                    jogos.darkMode();
                }
            }
        }

        private void btnPontuacoes_Click(object sender, EventArgs e)
        {
            if (flagTelas != 3)
            {
                flagTelas = 3;
                addTelas(pontuacao);
                if (modoEscuro)
                {
                    pontuacao.darkMode();
                }
            }
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            if (flagTelas != 18)
            {
                flagTelas = 18;
                addTelas(socios);
                if (modoEscuro)
                {
                    socios.darkMode();
                }
            }
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            Contacto contato = new Contacto(formModal, modoEscuro);
            contato.ShowDialog();
            
        }

        private void btnNoticias_Click(object sender, EventArgs e)
        {
            if (flagTelas != 13)
            {
                flagTelas = 13;
                addTelas(noticia);
                if (modoEscuro)
                {
                     noticia.darkMode();
                }
            }
            
        }

        private void btnParceiros_Click(object sender, EventArgs e)
        {
            if (flagTelas != 17)
            {
                flagTelas = 17;
                addTelas(parceiro);
                if (modoEscuro)
                {
                   parceiro.darkMode();
                }
            }

        }

        private void btnMemDaDirecao_Click(object sender, EventArgs e)
        {
            if (flagTelas != 16)
            {
                flagTelas = 16;
                addTelas(membros);
                if (modoEscuro)
                {
                   membros.darkMode();
                }
            }
        }

        private void btnBannerr_Click(object sender, EventArgs e)
        {
            if (flagTelas != 11)
            {
                flagTelas = 11;
                addTelas(banner);
                if (modoEscuro)
                {
                    banner.darkMode();
                }
            }
        }

        private void btnEstadios_Click(object sender, EventArgs e)
        {
            if (flagTelas != 10)
            {
                flagTelas = 10;
                addTelas(estadios);
                if (modoEscuro)
                {
                    estadios.darkMode();
                }
            }
        }

        private void btnClubes_Click(object sender, EventArgs e)
        {
            if (flagTelas != 9)
            {
                flagTelas = 9;
                addTelas(clubes);
                if (modoEscuro)
                {
                   clubes.darkMode();
                }
            }
        }

        private void btnJogadores_Click(object sender, EventArgs e)
        {
            if (flagTelas != 8)
            {
                flagTelas = 8;
                addTelas(jogadores);
                if (modoEscuro)
                {
                    jogadores.darkMode();
                }
            }
        }

        private void btnEquipaTec_Click(object sender, EventArgs e)
        {
            if (flagTelas != 7)
            {
                flagTelas = 7;
                addTelas(equipaTecnica);
                if (modoEscuro)
                {
                    equipaTecnica.darkMode();
                }
            }
        }

        private void btnResulatdos_Click(object sender, EventArgs e)
        {
            if (flagTelas != 2)
            {
                flagTelas = 2;
                addTelas(resultados);
                if (modoEscuro)
                {
                    resultados.darkMode();
                }
            }
        }

        private void btnJornadas_Click(object sender, EventArgs e)
        {
            if (flagTelas != 4)
            {
                flagTelas = 4;
                addTelas(jornadas);
                if (modoEscuro)
                {
                    jornadas.darkMode();
                }
            }
        }

        private void btnGestClube_Click(object sender, EventArgs e)
        {
            timerGestClube.Start();
            flagTelas = 2;
            if (modoEscuro)
            {
                if (GestClubeExpand)
                {
                    ptGestClube.Image = Properties.Resources.baixoDark;
                }
                else
                {
                    ptGestClube.Image = Properties.Resources.cimaDark;
                }
            }
            else
            {
                if (GestClubeExpand)
                {
                    ptGestClube.Image = Properties.Resources.baixoLightt;
                }
                else
                {
                    ptGestClube.Image = Properties.Resources.cimaLight;
                }
            }
        }

        private void timerGestClube_Tick(object sender, EventArgs e)
        {

            if (GestClubeExpand == false)
            {
                containerGestClube.Height += 10;
                if (containerGestClube.Height >= 330)
                {
                    timerGestClube.Stop();
                    GestClubeExpand = true;
                }
            }
            else
            {
                containerGestClube.Height -= 10;
                if (containerGestClube.Height <= 47)
                {
                    timerGestClube.Stop();
                    GestClubeExpand = false;
                }
            }
        }

        private void btnEquipas_Click(object sender, EventArgs e)
        {
            timerEquipas.Start();
            flagTelas = 20;
            if (modoEscuro)
            {
                if (EquipasExpand)
                {
                    ptEquipas.Image = Properties.Resources.baixoDark;
                }
                else
                {
                    ptEquipas.Image = Properties.Resources.cimaDark;
                }
            }
            else
            {
                if (EquipasExpand)
                {
                    ptEquipas.Image = Properties.Resources.baixoLightt;
                }
                else
                {
                    ptEquipas.Image = Properties.Resources.cimaLight;
                }
            }
        }

        private void timerEquipas_Tick(object sender, EventArgs e)
        {
            if (EquipasExpand == false)
            {
                containerEquipas.Height += 10;
                if (containerEquipas.Height >= 130)
                {
                    timerEquipas.Stop();
                    EquipasExpand = true;
                }
            }
            else
            {
                containerEquipas.Height -= 10;
                if (containerEquipas.Height <= 47)
                {
                    timerEquipas.Stop();
                    EquipasExpand = false;
                }
            }
        }

        private void btnGalery_Click(object sender, EventArgs e)
        {
            if (flagTelas != 40)
            {
                flagTelas = 40;
                addTelas(galeria);
                if (modoEscuro)
                {
                    galeria.darkMode();
                }
            }
        }

        private void btnMemorial_Click(object sender, EventArgs e)
        {
            if (flagTelas != 41)
            {
                flagTelas = 41;
                addTelas(memorial);
                if (modoEscuro)
                {
                    memorial.darkMode();
                }
            }
        }

        private void btnBilhete_Click(object sender, EventArgs e)
        {
            if (flagTelas != 42)
            {
                flagTelas = 42;
                addTelas(bilhete);
                if (modoEscuro)
                {
                    bilhete.darkMode();
                }
            }
        }

        private void btnInfoClube_Click(object sender, EventArgs e)
        {
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            InfoClubes InfoClubes = new InfoClubes(formModal, modoEscuro, "");
            InfoClubes.ShowDialog();
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            if (flagTelas != 0)
            {
                flagTelas = 0;
                addTelas(inicio);
                if (modoEscuro)
                {
                    //inicio.darMode();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            Contacto contato = new Contacto(formModal, modoEscuro);
            contato.ShowDialog();
        }

        private void btnJogosMaquis_Click(object sender, EventArgs e)
        {
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            VerJogos VerJogos = new VerJogos(formModal, modoEscuro);
            VerJogos.ShowDialog();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                btnMaximizar.Image = Properties.Resources.minizado;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                btnMaximizar.Image = Properties.Resources.Maximizado;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void ptGerencia_Click(object sender, EventArgs e)
        {

            timerGerencia.Start();
            if (modoEscuro)
            {
                if (gerenciaExpand)
                {
                    ptGerencia.Image = Properties.Resources.baixoDark;
                }
                else
                {
                    ptGerencia.Image = Properties.Resources.cimaDark;
                }
            }
            else
            {
                if (gerenciaExpand)
                {
                    ptGerencia.Image = Properties.Resources.baixoLightt;
                }
                else
                {
                    ptGerencia.Image = Properties.Resources.cimaLight;
                }
            }
        }

        private void ptGestClube_Click(object sender, EventArgs e)
        {
            timerGestClube.Start();
            flagTelas = 2;
            if (modoEscuro)
            {
                if (GestClubeExpand)
                {
                    ptGestClube.Image = Properties.Resources.baixoDark;
                }
                else
                {
                    ptGestClube.Image = Properties.Resources.cimaDark;
                }
            }
            else
            {
                if (GestClubeExpand)
                {
                    ptGestClube.Image = Properties.Resources.baixoLightt;
                }
                else
                {
                    ptGestClube.Image = Properties.Resources.cimaLight;
                }
            }
        }

        private void ptCampeo_Click(object sender, EventArgs e)
        {
            timerCampeonato.Start();
            if (modoEscuro)
            {
                if (campeonatoExpand)
                {
                    ptCampeo.Image = Properties.Resources.baixoDark;
                }
                else
                {
                    ptCampeo.Image = Properties.Resources.cimaDark;
                }
            }
            else
            {
                if (campeonatoExpand)
                {
                    ptCampeo.Image = Properties.Resources.baixoLightt;
                }
                else
                {
                    ptCampeo.Image = Properties.Resources.cimaLight;
                }
            }
            if (flagTelas != 1)
            {
                flagTelas = 1;

                addTelas(campeo);
                if (modoEscuro)
                {
                    campeo.darMode();
                }
            }
        }

        private void ptEquipas_Click(object sender, EventArgs e)
        {
            timerEquipas.Start();
            flagTelas = 20;
            if (modoEscuro)
            {
                if (EquipasExpand)
                {
                    ptEquipas.Image = Properties.Resources.baixoDark;
                }
                else
                {
                    ptEquipas.Image = Properties.Resources.cimaDark;
                }
            }
            else
            {
                if (EquipasExpand)
                {
                    ptEquipas.Image = Properties.Resources.baixoLightt;
                }
                else
                {
                    ptEquipas.Image = Properties.Resources.cimaLight;
                }
            }
        }

        private void ptInformacoes_Click(object sender, EventArgs e)
        {
            timerInformacoes.Start();
            if (modoEscuro)
            {
                if (informacoesExpand)
                {
                    ptInformacoes.Image = Properties.Resources.baixoDark;
                }
                else
                {
                    ptInformacoes.Image = Properties.Resources.cimaDark;
                }
            }
            else
            {
                if (informacoesExpand)
                {
                    ptInformacoes.Image = Properties.Resources.baixoLightt;
                }
                else
                {
                    ptInformacoes.Image = Properties.Resources.cimaLight;
                }
            }
        }
    }
}
