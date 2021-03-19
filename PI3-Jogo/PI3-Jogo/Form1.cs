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
            txtIdPt.Text = Jogo.CriarPartida(nome, senha);
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            int idJog = Convert.ToInt32(txtIdJog.Text);
            txtNomeJog.Text = idJog.ToString();
            string senha = txtSenhaJog.Text;
            txtSenhaJog.Text = Jogo.IniciarPartida(idJog, senha);
        }
    }
}
