using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiMT
{
    public partial class Form3 : Form
    {
        string[] maos;
        int idJogador;
        string senhaJogador;
        public Form3(string[] maos, int idJogador, string senhaJogador)
        {
            InitializeComponent();
            this.maos = maos;
            this.idJogador = idJogador;
            this.senhaJogador = senhaJogador;
            ExibirMaos();
        }
        public void ExibirMaos()
        {
            Array.Resize(ref maos, maos.Length - 1);
                for (int i = 1; i <= maos.Length; i++)
                {
                    string nomePictureBox = "pt" + i;
                    Console.WriteLine(nomePictureBox);
                    PictureBox p = Controls.Find(nomePictureBox, true).FirstOrDefault() as PictureBox;
                    string[] dados = maos[i - 1].Split(',');
                    string carta = dados[2];
                    Console.WriteLine($"Carta: {carta}");
                    if (carta.Contains("C"))
                    {
                        p.Image = Properties.Resources.Copas1;
                    }
                    if (carta.Contains("E"))
                    {
                        p.Image = Properties.Resources.Espadas1;
                    }
                    if (carta.Contains("L"))
                    {
                        p.Image = Properties.Resources.Lua1;
                    }
                    if (carta.Contains("O"))
                    {
                        p.Image = Properties.Resources.Ouros1;
                    }
                    if (carta.Contains("P"))
                    {
                        p.Image = Properties.Resources.Paus1;
                    }
                    if (carta.Contains("S"))
                    {
                        p.Image = Properties.Resources.Estrela1;
                    }
                    if (carta.Contains("T"))
                    {
                        p.Image = Properties.Resources.Triângulo1;
                    }
            }
        }
    }
}
