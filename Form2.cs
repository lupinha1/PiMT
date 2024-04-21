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
    public partial class Form2 : Form
    {
        string[] maos;
        int idJogador;
        string senhaJogador;
            
        public Form2(string[] maos, int idJogador, string senhaJogador)
        {
            InitializeComponent();
            this.maos = maos;
            this.idJogador = idJogador;
            this.senhaJogador = senhaJogador;
            ExibirMaos();
        }

        private void ExibirMaos()
        {
            Array.Resize(ref maos, maos.Length - 1);

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(maos.Length);
                string nomePictureBox = "pictureBoxJogador1" + i;
                PictureBox p = Controls.Find(nomePictureBox, true).FirstOrDefault() as PictureBox;
                string[] dados = maos[i].Split(',');
                string carta = dados[2];
                if (carta == "C")
                {
                    p.Image = Properties.Resources.Copas1;
                }
                if (carta == "E")
                {
                    p.Image = Properties.Resources.Espadas1;
                }
                if (carta == "L")
                {
                    p.Image = Properties.Resources.Lua1;
                }
                if (carta == "O")
                {
                    p.Image = Properties.Resources.Ouros1;
                }
                if (carta == "P")
                {
                    p.Image = Properties.Resources.Paus1;
                }
                if (carta == "S")
                {
                    p.Image = Properties.Resources.Estrela1;
                }
                if (carta == "T")
                {
                    p.Image = Properties.Resources.Triângulo1;
                }
            }
            //for (int i = 12; i <= maos.Length; i++)
            //{
            //    Console.WriteLine(maos.Length);
            //    string nomePictureBox = "pictureBoxJogador1" + i;
            //    PictureBox p = Controls.Find(nomePictureBox, true).FirstOrDefault() as PictureBox;
            //    string[] dados = maos[i].Split(',');
            //    string carta = dados[2];
            //    if (carta == "C")
            //    {
            //        p.Image = Properties.Resources.Copas1;
            //    }
            //    if (carta == "E")
            //    {
            //        p.Image = Properties.Resources.Espadas1;
            //    }
            //    if (carta == "L")
            //    {
            //        p.Image = Properties.Resources.Lua1;
            //    }
            //    if (carta == "O")
            //    {
            //        p.Image = Properties.Resources.Ouros1;
            //    }
            //    if (carta == "P")
            //    {
            //        p.Image = Properties.Resources.Paus1;
            //    }
            //    if (carta == "S")
            //    {
            //        p.Image = Properties.Resources.Estrela1;
            //    }
            //    if (carta == "T")
            //    {
            //        p.Image = Properties.Resources.Triângulo1;
            //    }
            //}
        }
        

    }
}
