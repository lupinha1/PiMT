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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(13, 48);
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
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.Location = new System.Drawing.Point(109, 48);
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
            this.btnListarMao.Location = new System.Drawing.Point(556, 49);
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
            this.lstMaos.Location = new System.Drawing.Point(546, 77);
            this.lstMaos.Name = "lstMaos";
            this.lstMaos.Size = new System.Drawing.Size(120, 186);
            this.lstMaos.TabIndex = 8;
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(556, 20);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(94, 23);
            this.btnIniciarPartida.TabIndex = 9;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            // 
            // txtBoxNomeJogador
            // 
            this.txtBoxNomeJogador.Location = new System.Drawing.Point(227, 204);
            this.txtBoxNomeJogador.Name = "txtBoxNomeJogador";
            this.txtBoxNomeJogador.Size = new System.Drawing.Size(120, 20);
            this.txtBoxNomeJogador.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome do Jogador";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(227, 230);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(120, 23);
            this.btnEntrarPartida.TabIndex = 12;
            this.btnEntrarPartida.Text = "Entrar na partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(227, 335);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(256, 382);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(64, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(297, 335);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(64, 20);
            this.textBox3.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

