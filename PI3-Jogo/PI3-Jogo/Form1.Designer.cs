namespace PI3_Jogo
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnExbJog = new System.Windows.Forms.Button();
            this.txtListJog = new System.Windows.Forms.TextBox();
            this.dgvPartidas = new System.Windows.Forms.DataGridView();
            this.btnEntrarPt = new System.Windows.Forms.Button();
            this.txtIdPt = new System.Windows.Forms.TextBox();
            this.txtNomeJog = new System.Windows.Forms.TextBox();
            this.txtSenhaPt = new System.Windows.Forms.TextBox();
            this.lblRetornoJog = new System.Windows.Forms.Label();
            this.lblIdPt = new System.Windows.Forms.Label();
            this.lblNomeJog = new System.Windows.Forms.Label();
            this.lblSenhaPt = new System.Windows.Forms.Label();
            this.txtIdJog = new System.Windows.Forms.TextBox();
            this.txtSenhaJog = new System.Windows.Forms.TextBox();
            this.txtCorJog = new System.Windows.Forms.TextBox();
            this.lblIdJog = new System.Windows.Forms.Label();
            this.lblSenhaJog = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.btnCriarPt = new System.Windows.Forms.Button();
            this.txtNomePtCr = new System.Windows.Forms.TextBox();
            this.txtSenhaPtCr = new System.Windows.Forms.TextBox();
            this.lblNomePtCr = new System.Windows.Forms.Label();
            this.lblSenhaPtCr = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnVerVez = new System.Windows.Forms.Button();
            this.btnRolarDados = new System.Windows.Forms.Button();
            this.lblValorDados = new System.Windows.Forms.Label();
            this.btnRes = new System.Windows.Forms.Button();
            this.txtD1 = new System.Windows.Forms.TextBox();
            this.txtD2 = new System.Windows.Forms.TextBox();
            this.txtD3 = new System.Windows.Forms.TextBox();
            this.txtD4 = new System.Windows.Forms.TextBox();
            this.lblR2 = new System.Windows.Forms.Label();
            this.lblR3 = new System.Windows.Forms.Label();
            this.lblR4 = new System.Windows.Forms.Label();
            this.lblR5 = new System.Windows.Forms.Label();
            this.lblR1 = new System.Windows.Forms.Label();
            this.lblR6 = new System.Windows.Forms.Label();
            this.txtOrdem = new System.Windows.Forms.TextBox();
            this.txtTrilha = new System.Windows.Forms.TextBox();
            this.lblOrdem = new System.Windows.Forms.Label();
            this.lblTrilha = new System.Windows.Forms.Label();
            this.btnMover = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exibir Partidas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExbJog
            // 
            this.btnExbJog.Location = new System.Drawing.Point(14, 50);
            this.btnExbJog.Name = "btnExbJog";
            this.btnExbJog.Size = new System.Drawing.Size(161, 24);
            this.btnExbJog.TabIndex = 3;
            this.btnExbJog.Text = "Exibir Jogadores";
            this.btnExbJog.UseVisualStyleBackColor = true;
            this.btnExbJog.Click += new System.EventHandler(this.btnExbJog_Click);
            // 
            // txtListJog
            // 
            this.txtListJog.Location = new System.Drawing.Point(12, 80);
            this.txtListJog.Multiline = true;
            this.txtListJog.Name = "txtListJog";
            this.txtListJog.Size = new System.Drawing.Size(163, 149);
            this.txtListJog.TabIndex = 4;
            // 
            // dgvPartidas
            // 
            this.dgvPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPartidas.Location = new System.Drawing.Point(185, 12);
            this.dgvPartidas.MultiSelect = false;
            this.dgvPartidas.Name = "dgvPartidas";
            this.dgvPartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartidas.Size = new System.Drawing.Size(507, 111);
            this.dgvPartidas.TabIndex = 5;
            // 
            // btnEntrarPt
            // 
            this.btnEntrarPt.Location = new System.Drawing.Point(185, 137);
            this.btnEntrarPt.Name = "btnEntrarPt";
            this.btnEntrarPt.Size = new System.Drawing.Size(141, 28);
            this.btnEntrarPt.TabIndex = 6;
            this.btnEntrarPt.Text = "Entrar Partida";
            this.btnEntrarPt.UseVisualStyleBackColor = true;
            this.btnEntrarPt.Click += new System.EventHandler(this.btnEntrarPt_Click);
            // 
            // txtIdPt
            // 
            this.txtIdPt.Location = new System.Drawing.Point(349, 145);
            this.txtIdPt.Name = "txtIdPt";
            this.txtIdPt.Size = new System.Drawing.Size(71, 20);
            this.txtIdPt.TabIndex = 7;
            // 
            // txtNomeJog
            // 
            this.txtNomeJog.Location = new System.Drawing.Point(444, 145);
            this.txtNomeJog.Name = "txtNomeJog";
            this.txtNomeJog.Size = new System.Drawing.Size(71, 20);
            this.txtNomeJog.TabIndex = 8;
            // 
            // txtSenhaPt
            // 
            this.txtSenhaPt.Location = new System.Drawing.Point(538, 145);
            this.txtSenhaPt.Name = "txtSenhaPt";
            this.txtSenhaPt.Size = new System.Drawing.Size(71, 20);
            this.txtSenhaPt.TabIndex = 9;
            // 
            // lblRetornoJog
            // 
            this.lblRetornoJog.AutoSize = true;
            this.lblRetornoJog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetornoJog.ForeColor = System.Drawing.Color.Red;
            this.lblRetornoJog.Location = new System.Drawing.Point(10, 247);
            this.lblRetornoJog.Name = "lblRetornoJog";
            this.lblRetornoJog.Size = new System.Drawing.Size(129, 20);
            this.lblRetornoJog.TabIndex = 10;
            this.lblRetornoJog.Text = "Retorno Jogador";
            // 
            // lblIdPt
            // 
            this.lblIdPt.AutoSize = true;
            this.lblIdPt.Location = new System.Drawing.Point(359, 129);
            this.lblIdPt.Name = "lblIdPt";
            this.lblIdPt.Size = new System.Drawing.Size(52, 13);
            this.lblIdPt.TabIndex = 11;
            this.lblIdPt.Text = "Id Partida";
            // 
            // lblNomeJog
            // 
            this.lblNomeJog.AutoSize = true;
            this.lblNomeJog.Location = new System.Drawing.Point(441, 129);
            this.lblNomeJog.Name = "lblNomeJog";
            this.lblNomeJog.Size = new System.Drawing.Size(76, 13);
            this.lblNomeJog.TabIndex = 12;
            this.lblNomeJog.Text = "Nome Jogador";
            // 
            // lblSenhaPt
            // 
            this.lblSenhaPt.AutoSize = true;
            this.lblSenhaPt.Location = new System.Drawing.Point(555, 129);
            this.lblSenhaPt.Name = "lblSenhaPt";
            this.lblSenhaPt.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaPt.TabIndex = 13;
            this.lblSenhaPt.Text = "Senha";
            // 
            // txtIdJog
            // 
            this.txtIdJog.Location = new System.Drawing.Point(185, 210);
            this.txtIdJog.Name = "txtIdJog";
            this.txtIdJog.Size = new System.Drawing.Size(100, 20);
            this.txtIdJog.TabIndex = 14;
            // 
            // txtSenhaJog
            // 
            this.txtSenhaJog.Location = new System.Drawing.Point(302, 209);
            this.txtSenhaJog.Name = "txtSenhaJog";
            this.txtSenhaJog.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaJog.TabIndex = 15;
            // 
            // txtCorJog
            // 
            this.txtCorJog.Location = new System.Drawing.Point(417, 209);
            this.txtCorJog.Name = "txtCorJog";
            this.txtCorJog.Size = new System.Drawing.Size(100, 20);
            this.txtCorJog.TabIndex = 16;
            // 
            // lblIdJog
            // 
            this.lblIdJog.AutoSize = true;
            this.lblIdJog.Location = new System.Drawing.Point(203, 193);
            this.lblIdJog.Name = "lblIdJog";
            this.lblIdJog.Size = new System.Drawing.Size(57, 13);
            this.lblIdJog.TabIndex = 17;
            this.lblIdJog.Text = "Id Jogador";
            // 
            // lblSenhaJog
            // 
            this.lblSenhaJog.AutoSize = true;
            this.lblSenhaJog.Location = new System.Drawing.Point(314, 193);
            this.lblSenhaJog.Name = "lblSenhaJog";
            this.lblSenhaJog.Size = new System.Drawing.Size(79, 13);
            this.lblSenhaJog.TabIndex = 18;
            this.lblSenhaJog.Text = "Senha Jogador";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(457, 194);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(23, 13);
            this.lblCor.TabIndex = 19;
            this.lblCor.Text = "Cor";
            // 
            // btnCriarPt
            // 
            this.btnCriarPt.Location = new System.Drawing.Point(12, 282);
            this.btnCriarPt.Name = "btnCriarPt";
            this.btnCriarPt.Size = new System.Drawing.Size(110, 41);
            this.btnCriarPt.TabIndex = 20;
            this.btnCriarPt.Text = "Criar Partida";
            this.btnCriarPt.UseVisualStyleBackColor = true;
            this.btnCriarPt.Click += new System.EventHandler(this.btnCriarPt_Click);
            // 
            // txtNomePtCr
            // 
            this.txtNomePtCr.Location = new System.Drawing.Point(160, 300);
            this.txtNomePtCr.Name = "txtNomePtCr";
            this.txtNomePtCr.Size = new System.Drawing.Size(110, 20);
            this.txtNomePtCr.TabIndex = 21;
            // 
            // txtSenhaPtCr
            // 
            this.txtSenhaPtCr.Location = new System.Drawing.Point(293, 300);
            this.txtSenhaPtCr.Name = "txtSenhaPtCr";
            this.txtSenhaPtCr.Size = new System.Drawing.Size(109, 20);
            this.txtSenhaPtCr.TabIndex = 22;
            // 
            // lblNomePtCr
            // 
            this.lblNomePtCr.AutoSize = true;
            this.lblNomePtCr.Location = new System.Drawing.Point(182, 284);
            this.lblNomePtCr.Name = "lblNomePtCr";
            this.lblNomePtCr.Size = new System.Drawing.Size(71, 13);
            this.lblNomePtCr.TabIndex = 23;
            this.lblNomePtCr.Text = "Nome Partida";
            // 
            // lblSenhaPtCr
            // 
            this.lblSenhaPtCr.AutoSize = true;
            this.lblSenhaPtCr.Location = new System.Drawing.Point(314, 282);
            this.lblSenhaPtCr.Name = "lblSenhaPtCr";
            this.lblSenhaPtCr.Size = new System.Drawing.Size(74, 13);
            this.lblSenhaPtCr.TabIndex = 24;
            this.lblSenhaPtCr.Text = "Senha Partida";
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(648, 300);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(40, 13);
            this.lblVersao.TabIndex = 25;
            this.lblVersao.Text = "Versão";
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(538, 193);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(118, 36);
            this.btnJogar.TabIndex = 26;
            this.btnJogar.Text = "Iniciar Partida";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnVerVez
            // 
            this.btnVerVez.Location = new System.Drawing.Point(429, 257);
            this.btnVerVez.Name = "btnVerVez";
            this.btnVerVez.Size = new System.Drawing.Size(75, 23);
            this.btnVerVez.TabIndex = 27;
            this.btnVerVez.Text = "Verificar Vez";
            this.btnVerVez.UseVisualStyleBackColor = true;
            this.btnVerVez.Click += new System.EventHandler(this.btnVerVez_Click);
            // 
            // btnRolarDados
            // 
            this.btnRolarDados.Location = new System.Drawing.Point(429, 295);
            this.btnRolarDados.Name = "btnRolarDados";
            this.btnRolarDados.Size = new System.Drawing.Size(75, 23);
            this.btnRolarDados.TabIndex = 28;
            this.btnRolarDados.Text = "Rolar Dados";
            this.btnRolarDados.UseVisualStyleBackColor = true;
            this.btnRolarDados.Click += new System.EventHandler(this.btnRolarDados_Click);
            // 
            // lblValorDados
            // 
            this.lblValorDados.AutoSize = true;
            this.lblValorDados.Location = new System.Drawing.Point(544, 257);
            this.lblValorDados.Name = "lblValorDados";
            this.lblValorDados.Size = new System.Drawing.Size(65, 13);
            this.lblValorDados.TabIndex = 29;
            this.lblValorDados.Text = "Valor Dados";
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(15, 358);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(106, 35);
            this.btnRes.TabIndex = 30;
            this.btnRes.Text = "Resultados";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // txtD1
            // 
            this.txtD1.Location = new System.Drawing.Point(439, 343);
            this.txtD1.Name = "txtD1";
            this.txtD1.Size = new System.Drawing.Size(65, 20);
            this.txtD1.TabIndex = 31;
            // 
            // txtD2
            // 
            this.txtD2.Location = new System.Drawing.Point(439, 369);
            this.txtD2.Name = "txtD2";
            this.txtD2.Size = new System.Drawing.Size(65, 20);
            this.txtD2.TabIndex = 32;
            // 
            // txtD3
            // 
            this.txtD3.Location = new System.Drawing.Point(439, 395);
            this.txtD3.Name = "txtD3";
            this.txtD3.Size = new System.Drawing.Size(65, 20);
            this.txtD3.TabIndex = 33;
            // 
            // txtD4
            // 
            this.txtD4.Location = new System.Drawing.Point(439, 421);
            this.txtD4.Name = "txtD4";
            this.txtD4.Size = new System.Drawing.Size(65, 20);
            this.txtD4.TabIndex = 34;
            // 
            // lblR2
            // 
            this.lblR2.AutoSize = true;
            this.lblR2.Location = new System.Drawing.Point(157, 358);
            this.lblR2.Name = "lblR2";
            this.lblR2.Size = new System.Drawing.Size(63, 13);
            this.lblR2.TabIndex = 35;
            this.lblR2.Text = "Dado: 3 e 4";
            // 
            // lblR3
            // 
            this.lblR3.AutoSize = true;
            this.lblR3.Location = new System.Drawing.Point(157, 380);
            this.lblR3.Name = "lblR3";
            this.lblR3.Size = new System.Drawing.Size(63, 13);
            this.lblR3.TabIndex = 36;
            this.lblR3.Text = "Dado: 1 e 3";
            // 
            // lblR4
            // 
            this.lblR4.AutoSize = true;
            this.lblR4.Location = new System.Drawing.Point(157, 402);
            this.lblR4.Name = "lblR4";
            this.lblR4.Size = new System.Drawing.Size(63, 13);
            this.lblR4.TabIndex = 37;
            this.lblR4.Text = "Dado: 2 e 4";
            // 
            // lblR5
            // 
            this.lblR5.AutoSize = true;
            this.lblR5.Location = new System.Drawing.Point(157, 424);
            this.lblR5.Name = "lblR5";
            this.lblR5.Size = new System.Drawing.Size(63, 13);
            this.lblR5.TabIndex = 38;
            this.lblR5.Text = "Dado: 1 e 4";
            // 
            // lblR1
            // 
            this.lblR1.AutoSize = true;
            this.lblR1.Location = new System.Drawing.Point(157, 334);
            this.lblR1.Name = "lblR1";
            this.lblR1.Size = new System.Drawing.Size(63, 13);
            this.lblR1.TabIndex = 39;
            this.lblR1.Text = "Dado: 1 e 2";
            // 
            // lblR6
            // 
            this.lblR6.AutoSize = true;
            this.lblR6.Location = new System.Drawing.Point(157, 448);
            this.lblR6.Name = "lblR6";
            this.lblR6.Size = new System.Drawing.Size(63, 13);
            this.lblR6.TabIndex = 40;
            this.lblR6.Text = "Dado: 2 e 3";
            // 
            // txtOrdem
            // 
            this.txtOrdem.Location = new System.Drawing.Point(284, 351);
            this.txtOrdem.Name = "txtOrdem";
            this.txtOrdem.Size = new System.Drawing.Size(85, 20);
            this.txtOrdem.TabIndex = 41;
            // 
            // txtTrilha
            // 
            this.txtTrilha.Location = new System.Drawing.Point(284, 424);
            this.txtTrilha.Name = "txtTrilha";
            this.txtTrilha.Size = new System.Drawing.Size(85, 20);
            this.txtTrilha.TabIndex = 42;
            // 
            // lblOrdem
            // 
            this.lblOrdem.AutoSize = true;
            this.lblOrdem.Location = new System.Drawing.Point(314, 334);
            this.lblOrdem.Name = "lblOrdem";
            this.lblOrdem.Size = new System.Drawing.Size(38, 13);
            this.lblOrdem.TabIndex = 43;
            this.lblOrdem.Text = "Ordem";
            // 
            // lblTrilha
            // 
            this.lblTrilha.AutoSize = true;
            this.lblTrilha.Location = new System.Drawing.Point(314, 408);
            this.lblTrilha.Name = "lblTrilha";
            this.lblTrilha.Size = new System.Drawing.Size(33, 13);
            this.lblTrilha.TabIndex = 44;
            this.lblTrilha.Text = "Trilha";
            // 
            // btnMover
            // 
            this.btnMover.Location = new System.Drawing.Point(15, 415);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(92, 22);
            this.btnMover.TabIndex = 45;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(14, 443);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(92, 22);
            this.btnParar.TabIndex = 46;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "valor dado1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "valor dado2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "valor dado3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "valor dado4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 486);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.lblTrilha);
            this.Controls.Add(this.lblOrdem);
            this.Controls.Add(this.txtTrilha);
            this.Controls.Add(this.txtOrdem);
            this.Controls.Add(this.lblR6);
            this.Controls.Add(this.lblR1);
            this.Controls.Add(this.lblR5);
            this.Controls.Add(this.lblR4);
            this.Controls.Add(this.lblR3);
            this.Controls.Add(this.lblR2);
            this.Controls.Add(this.txtD4);
            this.Controls.Add(this.txtD3);
            this.Controls.Add(this.txtD2);
            this.Controls.Add(this.txtD1);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.lblValorDados);
            this.Controls.Add(this.btnRolarDados);
            this.Controls.Add(this.btnVerVez);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lblSenhaPtCr);
            this.Controls.Add(this.lblNomePtCr);
            this.Controls.Add(this.txtSenhaPtCr);
            this.Controls.Add(this.txtNomePtCr);
            this.Controls.Add(this.btnCriarPt);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblSenhaJog);
            this.Controls.Add(this.lblIdJog);
            this.Controls.Add(this.txtCorJog);
            this.Controls.Add(this.txtSenhaJog);
            this.Controls.Add(this.txtIdJog);
            this.Controls.Add(this.lblSenhaPt);
            this.Controls.Add(this.lblNomeJog);
            this.Controls.Add(this.lblIdPt);
            this.Controls.Add(this.lblRetornoJog);
            this.Controls.Add(this.txtSenhaPt);
            this.Controls.Add(this.txtNomeJog);
            this.Controls.Add(this.txtIdPt);
            this.Controls.Add(this.btnEntrarPt);
            this.Controls.Add(this.dgvPartidas);
            this.Controls.Add(this.txtListJog);
            this.Controls.Add(this.btnExbJog);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExbJog;
        private System.Windows.Forms.TextBox txtListJog;
        private System.Windows.Forms.DataGridView dgvPartidas;
        private System.Windows.Forms.Button btnEntrarPt;
        private System.Windows.Forms.TextBox txtIdPt;
        private System.Windows.Forms.TextBox txtNomeJog;
        private System.Windows.Forms.TextBox txtSenhaPt;
        private System.Windows.Forms.Label lblRetornoJog;
        private System.Windows.Forms.Label lblIdPt;
        private System.Windows.Forms.Label lblNomeJog;
        private System.Windows.Forms.Label lblSenhaPt;
        private System.Windows.Forms.TextBox txtIdJog;
        private System.Windows.Forms.TextBox txtSenhaJog;
        private System.Windows.Forms.TextBox txtCorJog;
        private System.Windows.Forms.Label lblIdJog;
        private System.Windows.Forms.Label lblSenhaJog;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Button btnCriarPt;
        private System.Windows.Forms.TextBox txtNomePtCr;
        private System.Windows.Forms.TextBox txtSenhaPtCr;
        private System.Windows.Forms.Label lblNomePtCr;
        private System.Windows.Forms.Label lblSenhaPtCr;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnVerVez;
        private System.Windows.Forms.Button btnRolarDados;
        private System.Windows.Forms.Label lblValorDados;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.TextBox txtD1;
        private System.Windows.Forms.TextBox txtD2;
        private System.Windows.Forms.TextBox txtD3;
        private System.Windows.Forms.TextBox txtD4;
        private System.Windows.Forms.Label lblR2;
        private System.Windows.Forms.Label lblR3;
        private System.Windows.Forms.Label lblR4;
        private System.Windows.Forms.Label lblR5;
        private System.Windows.Forms.Label lblR1;
        private System.Windows.Forms.Label lblR6;
        private System.Windows.Forms.TextBox txtOrdem;
        private System.Windows.Forms.TextBox txtTrilha;
        private System.Windows.Forms.Label lblOrdem;
        private System.Windows.Forms.Label lblTrilha;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

