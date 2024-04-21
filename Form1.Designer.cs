namespace PiMT
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.cboOpcaoListarPartidas = new System.Windows.Forms.ComboBox();
            this.lstListaPartidas = new System.Windows.Forms.ListBox();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.lstListaJogadores = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListarMao = new System.Windows.Forms.Button();
            this.lstMaos = new System.Windows.Forms.ListBox();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.txtBoxNomeJogador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.txtIdJogador = new System.Windows.Forms.TextBox();
            this.txtIdCarta = new System.Windows.Forms.TextBox();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnApostar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeCriarPartida = new System.Windows.Forms.TextBox();
            this.txtSenhaCriarPartida = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lstBoxVez = new System.Windows.Forms.ListBox();
            this.btnVerificarVez = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSenhaEntrarPartida = new System.Windows.Forms.TextBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.lblValorCarta = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(58, 48);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(90, 23);
            this.btnListarPartidas.TabIndex = 0;
            this.btnListarPartidas.Text = "Listar partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // cboOpcaoListarPartidas
            // 
            this.cboOpcaoListarPartidas.FormattingEnabled = true;
            this.cboOpcaoListarPartidas.Items.AddRange(new object[] {
            "Todas",
            "Abertas",
            "Jogando",
            "Finalizadas"});
            this.cboOpcaoListarPartidas.Location = new System.Drawing.Point(13, 20);
            this.cboOpcaoListarPartidas.Name = "cboOpcaoListarPartidas";
            this.cboOpcaoListarPartidas.Size = new System.Drawing.Size(189, 21);
            this.cboOpcaoListarPartidas.TabIndex = 1;
            // 
            // lstListaPartidas
            // 
            this.lstListaPartidas.FormattingEnabled = true;
            this.lstListaPartidas.Location = new System.Drawing.Point(13, 77);
            this.lstListaPartidas.Name = "lstListaPartidas";
            this.lstListaPartidas.Size = new System.Drawing.Size(189, 147);
            this.lstListaPartidas.TabIndex = 2;
            this.lstListaPartidas.SelectedIndexChanged += new System.EventHandler(this.lstListaPartidas_SelectedIndexChanged);
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.Location = new System.Drawing.Point(227, 20);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(93, 23);
            this.btnListarJogadores.TabIndex = 4;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = true;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // lstListaJogadores
            // 
            this.lstListaJogadores.FormattingEnabled = true;
            this.lstListaJogadores.Location = new System.Drawing.Point(227, 77);
            this.lstListaJogadores.Name = "lstListaJogadores";
            this.lstListaJogadores.Size = new System.Drawing.Size(120, 95);
            this.lstListaJogadores.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Jogadores";
            // 
            // btnListarMao
            // 
            this.btnListarMao.Location = new System.Drawing.Point(456, 169);
            this.btnListarMao.Name = "btnListarMao";
            this.btnListarMao.Size = new System.Drawing.Size(94, 23);
            this.btnListarMao.TabIndex = 7;
            this.btnListarMao.Text = "Listar Mão";
            this.btnListarMao.UseVisualStyleBackColor = true;
            this.btnListarMao.Click += new System.EventHandler(this.btnListarMao_Click);
            // 
            // lstMaos
            // 
            this.lstMaos.FormattingEnabled = true;
            this.lstMaos.Location = new System.Drawing.Point(446, 197);
            this.lstMaos.Name = "lstMaos";
            this.lstMaos.Size = new System.Drawing.Size(120, 394);
            this.lstMaos.TabIndex = 8;
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(456, 140);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(94, 23);
            this.btnIniciarPartida.TabIndex = 9;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // txtBoxNomeJogador
            // 
            this.txtBoxNomeJogador.Location = new System.Drawing.Point(245, 264);
            this.txtBoxNomeJogador.Name = "txtBoxNomeJogador";
            this.txtBoxNomeJogador.Size = new System.Drawing.Size(120, 20);
            this.txtBoxNomeJogador.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome do Jogador";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(245, 333);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(120, 23);
            this.btnEntrarPartida.TabIndex = 12;
            this.btnEntrarPartida.Text = "Entrar na partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.Location = new System.Drawing.Point(241, 449);
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.Size = new System.Drawing.Size(64, 20);
            this.txtIdJogador.TabIndex = 13;
            // 
            // txtIdCarta
            // 
            this.txtIdCarta.Location = new System.Drawing.Point(279, 488);
            this.txtIdCarta.Name = "txtIdCarta";
            this.txtIdCarta.Size = new System.Drawing.Size(64, 20);
            this.txtIdCarta.TabIndex = 14;
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Location = new System.Drawing.Point(311, 449);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(64, 20);
            this.txtSenhaJogador.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID jogador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Senha jogador";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "ID carta";
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(241, 514);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(75, 23);
            this.btnJogar.TabIndex = 19;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnApostar
            // 
            this.btnApostar.Location = new System.Drawing.Point(322, 514);
            this.btnApostar.Name = "btnApostar";
            this.btnApostar.Size = new System.Drawing.Size(75, 23);
            this.btnApostar.TabIndex = 20;
            this.btnApostar.Text = "Apostar";
            this.btnApostar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nome partida";
            // 
            // txtNomeCriarPartida
            // 
            this.txtNomeCriarPartida.Location = new System.Drawing.Point(16, 264);
            this.txtNomeCriarPartida.Name = "txtNomeCriarPartida";
            this.txtNomeCriarPartida.Size = new System.Drawing.Size(86, 20);
            this.txtNomeCriarPartida.TabIndex = 22;
            // 
            // txtSenhaCriarPartida
            // 
            this.txtSenhaCriarPartida.Location = new System.Drawing.Point(116, 264);
            this.txtSenhaCriarPartida.Name = "txtSenhaCriarPartida";
            this.txtSenhaCriarPartida.Size = new System.Drawing.Size(86, 20);
            this.txtSenhaCriarPartida.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "senha";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Historico jogadas";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Round";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(124, 346);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(39, 20);
            this.textBox6.TabIndex = 28;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 388);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(186, 195);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lstBoxVez
            // 
            this.lstBoxVez.FormattingEnabled = true;
            this.lstBoxVez.Location = new System.Drawing.Point(616, 197);
            this.lstBoxVez.Name = "lstBoxVez";
            this.lstBoxVez.Size = new System.Drawing.Size(120, 394);
            this.lstBoxVez.TabIndex = 30;
            // 
            // btnVerificarVez
            // 
            this.btnVerificarVez.Location = new System.Drawing.Point(637, 169);
            this.btnVerificarVez.Name = "btnVerificarVez";
            this.btnVerificarVez.Size = new System.Drawing.Size(75, 23);
            this.btnVerificarVez.TabIndex = 31;
            this.btnVerificarVez.Text = "Verificar vez";
            this.btnVerificarVez.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(380, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Id partida";
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.Location = new System.Drawing.Point(385, 264);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(30, 20);
            this.txtIdPartida.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(256, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Senha partida";
            // 
            // txtSenhaEntrarPartida
            // 
            this.txtSenhaEntrarPartida.Location = new System.Drawing.Point(245, 307);
            this.txtSenhaEntrarPartida.Name = "txtSenhaEntrarPartida";
            this.txtSenhaEntrarPartida.Size = new System.Drawing.Size(120, 20);
            this.txtSenhaEntrarPartida.TabIndex = 34;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(16, 291);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(186, 23);
            this.btnCriarPartida.TabIndex = 36;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // lblValorCarta
            // 
            this.lblValorCarta.AutoSize = true;
            this.lblValorCarta.Location = new System.Drawing.Point(238, 555);
            this.lblValorCarta.Name = "lblValorCarta";
            this.lblValorCarta.Size = new System.Drawing.Size(114, 13);
            this.lblValorCarta.TabIndex = 37;
            this.lblValorCarta.Text = "Valor da carta jogada: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblValorCarta);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSenhaEntrarPartida);
            this.Controls.Add(this.txtIdPartida);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnVerificarVez);
            this.Controls.Add(this.lstBoxVez);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSenhaCriarPartida);
            this.Controls.Add(this.txtNomeCriarPartida);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnApostar);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.txtIdCarta);
            this.Controls.Add(this.txtIdJogador);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxNomeJogador);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.lstMaos);
            this.Controls.Add(this.btnListarMao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstListaJogadores);
            this.Controls.Add(this.btnListarJogadores);
            this.Controls.Add(this.lstListaPartidas);
            this.Controls.Add(this.cboOpcaoListarPartidas);
            this.Controls.Add(this.btnListarPartidas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.ComboBox cboOpcaoListarPartidas;
        private System.Windows.Forms.ListBox lstListaPartidas;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.ListBox lstListaJogadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListarMao;
        private System.Windows.Forms.ListBox lstMaos;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.TextBox txtBoxNomeJogador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.TextBox txtIdJogador;
        private System.Windows.Forms.TextBox txtIdCarta;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnApostar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeCriarPartida;
        private System.Windows.Forms.TextBox txtSenhaCriarPartida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListBox lstBoxVez;
        private System.Windows.Forms.Button btnVerificarVez;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdPartida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSenhaEntrarPartida;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label lblValorCarta;
        private System.Windows.Forms.Button button2;
    }
}

