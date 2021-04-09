using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CantStopServer;
namespace PI3_Jogo
{
    public partial class Form1 : Form
    {
        public int idPartida { get; set; }

        public int Conta(int n1, int n2)
        {
            int res = n1 + n2;
            return res;
        }
        public Form1()
        {
            InitializeComponent();

            // Exibe a versão do jogo na tela
            lblVersao.Text = "Versão " + Jogo.Versao;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("/r", "");
            string[] linha = retorno.Split('\n');
            List<Partida> partidas = new List<Partida>();

            for(int i = 0; i < linha.Length - 1; i++)
            {
                Partida p = new Partida();
                string[] itens = linha[i].Split(',');
                p.idPartida = Convert.ToInt32(itens[0]);
                p.nome = itens[1];
                p.data = itens[2];
                p.status = itens[3];
                partidas.Add(p);                
            }

            dgvPartidas.DataSource = partidas;
            dgvPartidas.Columns[4].Visible = false;
        }

        private void btnExbJog_Click(object sender, EventArgs e)
        {
            Partida partida = (Partida)dgvPartidas.SelectedRows[0].DataBoundItem;
            this.idPartida = partida.idPartida;
            txtListJog.Text = Jogo.ListarJogadores(idPartida);
        }

        private void btnEntrarPt_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdPt.Text);
            string nome = txtNomeJog.Text;
            string senha = txtSenhaPt.Text;
            string jogador = Jogo.EntrarPartida(id, nome, senha);
            lblRetornoJog.Text = jogador;
            
            if(jogador.Substring(0,4)!= "ERRO")
            {
                string[] x = jogador.Split(',');
                txtIdJog.Text = x[0];
                txtSenhaJog.Text = x[1];
                txtCorJog.Text = x[2];
            }
        }

        private void btnCriarPt_Click(object sender, EventArgs e)
        {
            string nome = txtNomePtCr.Text;
            string senha = txtSenhaPtCr.Text;
            lblRetornoJog.Text = Jogo.CriarPartida(nome, senha);
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            int idJogador = Convert.ToInt32(txtIdJog.Text);
            string senhaJogador = txtSenhaJog.Text;
            lblRetornoJog.Text = Jogo.IniciarPartida(idJogador, senhaJogador);
        }

        private void btnVerVez_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdPt.Text);
            lblRetornoJog.Text = Jogo.VerificarVez(id);
        }

        private void btnRolarDados_Click(object sender, EventArgs e)
        {
            int idJogador = Convert.ToInt32(txtIdJog.Text);
            string senhaJogador = txtSenhaJog.Text;
            lblValorDados.Text = Jogo.RolarDados(idJogador, senhaJogador);
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            int d1 = Convert.ToInt32(txtD1.Text);
            int d2 = Convert.ToInt32(txtD2.Text);
            int d3 = Convert.ToInt32(txtD3.Text);
            int d4 = Convert.ToInt32(txtD4.Text);
            int res1 = Conta(d1, d2);
            int res2 = Conta(d3, d4);
            int res3 = Conta(d1, d3);
            int res4 = Conta(d2, d4);
            int res5 = Conta(d1, d4);
            int res6 = Conta(d2, d3);
            lblR1.Text = res1.ToString();
            lblR2.Text = res2.ToString();
            lblR3.Text = res3.ToString();
            lblR4.Text = res4.ToString();
            lblR5.Text = res5.ToString();
            lblR6.Text = res6.ToString();
        }
    }
}
