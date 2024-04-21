using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicTrickServer;

namespace PiMT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboOpcaoListarPartidas.SelectedIndex = 0;
        }

        string grupo = "grupoLuisHenrique";
        string[] mao;
        int idJogador;
        string senhaJogador;

        private string tratarRetorno(string retorno)
        {
            if (retorno.StartsWith("ERRO"))
            {
                retorno = retorno.Replace("ERRO:", "");
                MessageBox.Show(retorno);
                return retorno;
            }
            else
            {
                return retorno;
            }
        }

        private void abrirTelaJogo()
        {
            Form2 f2 = new Form2(mao, idJogador, senhaJogador);
            f2.Show();
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            lstListaPartidas.Items.Clear();
            string status = cboOpcaoListarPartidas.SelectedItem.ToString().Substring(0,1);
            string retorno = tratarRetorno(Jogo.ListarPartidas(status));
            retorno = retorno.Replace("\r", "");

            string[] partidas = retorno.Split('\n');

            foreach(string partida in partidas) 
            {
                lstListaPartidas.Items.Add(partida);
            }

            lstListaPartidas.SelectedIndex = 0;
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            int partidaId = Convert.ToInt32(txtIdPartida.Text);
            string retorno = tratarRetorno(Jogo.ListarJogadores(partidaId));
            string[] jogadores = retorno.Split('\n');
            foreach (string jogador in jogadores)
            {
                lstListaJogadores.Items.Add(jogador);
            }
            
        }

        private void btnListarMao_Click(object sender, EventArgs e)
        {
            int partidaId = Convert.ToInt32(txtIdPartida.Text);
            string retorno = tratarRetorno(Jogo.ConsultarMao(partidaId));
            string[] maos = retorno.Split('\n');
            mao = maos;

            foreach (string mao in maos)
            {
                lstMaos.Items.Add(mao);
            }
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            int idPartida = Convert.ToInt32(txtIdPartida.Text);
            string nomeJogador = txtBoxNomeJogador.Text;
            string senha = txtSenhaEntrarPartida.Text;
            string retorno = tratarRetorno(Jogo.EntrarPartida(idPartida, nomeJogador, senha));
            string[] jogador = retorno.Split(',');
            txtSenhaJogador.Text = jogador[1];
            txtIdJogador.Text = jogador[0];
            senhaJogador = jogador[1];
            idJogador = Convert.ToInt32(jogador[0]);

            //abrirTelaJogo();
        }


        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nome = txtNomeCriarPartida.Text;
            string senha = txtSenhaCriarPartida.Text;
            string retorno = tratarRetorno(Jogo.CriarPartida(nome, senha, grupo));
        }

        private void lstListaPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdPartida.Text = lstListaPartidas.SelectedItem.ToString().Substring(0, lstListaPartidas.SelectedItem.ToString().IndexOf(','));
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            string senha = txtSenhaJogador.Text;
            int idJogador = Convert.ToInt32(txtIdJogador.Text);
            int posicao = Convert.ToInt32(txtIdCarta.Text);
            string retorno = tratarRetorno(Jogo.Jogar(idJogador, senha, posicao));
            lblValorCarta.Text = $"Valor dda carta jogadar: {retorno}";
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            int idJogador = Convert.ToInt32(txtIdJogador.Text);
            string senha = txtSenhaJogador.Text;
            string retorno = tratarRetorno(Jogo.IniciarPartida(idJogador, senha));
            lstBoxVez.Items.Add(retorno);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirTelaJogo();
        }
    }
}
