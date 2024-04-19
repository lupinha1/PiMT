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

        private string tratarRetorno(string retorno)
        {
            return retorno.Substring(0, retorno.Length - 1);
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {  
            lstListaPartidas.Items.Clear();
            string status = cboOpcaoListarPartidas.SelectedItem.ToString().Substring(0,1);
            string retorno = Jogo.ListarPartidas(status);
            retorno = retorno.Replace("\r", "");
            retorno = tratarRetorno(retorno);

            string[] partidas = retorno.Split('\n');

            foreach(string partida in partidas) 
            {
                lstListaPartidas.Items.Add(partida);
            }

            lstListaPartidas.SelectedIndex = 0;
            
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            int partidaId = Convert.ToInt32(lstListaPartidas.SelectedItem.ToString().Substring(0, lstListaPartidas.SelectedItem.ToString().IndexOf(',')));
            string retorno = Jogo.ListarJogadores(partidaId);
            retorno = tratarRetorno(retorno);
            string[] jogadores = retorno.Split('\n');
            foreach (string jogador in jogadores)
            {
                lstListaJogadores.Items.Add(jogador);
            }
            
        }

        private void btnListarMao_Click(object sender, EventArgs e)
        {
            int partidaId = Convert.ToInt32(lstListaPartidas.SelectedItem.ToString().Substring(0, lstListaPartidas.SelectedItem.ToString().IndexOf(',')));
            string retorno = Jogo.ConsultarMao(partidaId);
            retorno = tratarRetorno(retorno);
            string[] maos = retorno.Split('\n');

            foreach (string mao in maos)
            {
                lstMaos.Items.Add(mao);
            }
        }

    }
}
