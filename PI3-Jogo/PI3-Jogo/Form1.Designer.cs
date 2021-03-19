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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exibir Partidas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExbJog
            // 
            this.btnExbJog.Location = new System.Drawing.Point(39, 51);
            this.btnExbJog.Name = "btnExbJog";
            this.btnExbJog.Size = new System.Drawing.Size(95, 23);
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
            this.dgvPartidas.Location = new System.Drawing.Point(181, 12);
            this.dgvPartidas.MultiSelect = false;
            this.dgvPartidas.Name = "dgvPartidas";
            this.dgvPartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartidas.Size = new System.Drawing.Size(507, 111);
            this.dgvPartidas.TabIndex = 5;
            // 
            // btnEntrarPt
            // 
            this.btnEntrarPt.Location = new System.Drawing.Point(219, 137);
            this.btnEntrarPt.Name = "btnEntrarPt";
            this.btnEntrarPt.Size = new System.Drawing.Size(141, 28);
            this.btnEntrarPt.TabIndex = 6;
            this.btnEntrarPt.Text = "Entrar Partida";
            this.btnEntrarPt.UseVisualStyleBackColor = true;
            this.btnEntrarPt.Click += new System.EventHandler(this.btnEntrarPt_Click);
            // 
            // txtIdPt
            // 
            this.txtIdPt.Location = new System.Drawing.Point(388, 142);
            this.txtIdPt.Name = "txtIdPt";
            this.txtIdPt.Size = new System.Drawing.Size(71, 20);
            this.txtIdPt.TabIndex = 7;
            // 
            // txtNomeJog
            // 
            this.txtNomeJog.Location = new System.Drawing.Point(480, 142);
            this.txtNomeJog.Name = "txtNomeJog";
            this.txtNomeJog.Size = new System.Drawing.Size(71, 20);
            this.txtNomeJog.TabIndex = 8;
            // 
            // txtSenhaPt
            // 
            this.txtSenhaPt.Location = new System.Drawing.Point(574, 142);
            this.txtSenhaPt.Name = "txtSenhaPt";
            this.txtSenhaPt.Size = new System.Drawing.Size(71, 20);
            this.txtSenhaPt.TabIndex = 9;
            // 
            // lblRetornoJog
            // 
            this.lblRetornoJog.AutoSize = true;
            this.lblRetornoJog.Location = new System.Drawing.Point(36, 248);
            this.lblRetornoJog.Name = "lblRetornoJog";
            this.lblRetornoJog.Size = new System.Drawing.Size(86, 13);
            this.lblRetornoJog.TabIndex = 10;
            this.lblRetornoJog.Text = "Retorno Jogador";
            // 
            // lblIdPt
            // 
            this.lblIdPt.AutoSize = true;
            this.lblIdPt.Location = new System.Drawing.Point(398, 126);
            this.lblIdPt.Name = "lblIdPt";
            this.lblIdPt.Size = new System.Drawing.Size(52, 13);
            this.lblIdPt.TabIndex = 11;
            this.lblIdPt.Text = "Id Partida";
            // 
            // lblNomeJog
            // 
            this.lblNomeJog.AutoSize = true;
            this.lblNomeJog.Location = new System.Drawing.Point(475, 126);
            this.lblNomeJog.Name = "lblNomeJog";
            this.lblNomeJog.Size = new System.Drawing.Size(76, 13);
            this.lblNomeJog.TabIndex = 12;
            this.lblNomeJog.Text = "Nome Jogador";
            // 
            // lblSenhaPt
            // 
            this.lblSenhaPt.AutoSize = true;
            this.lblSenhaPt.Location = new System.Drawing.Point(589, 126);
            this.lblSenhaPt.Name = "lblSenhaPt";
            this.lblSenhaPt.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaPt.TabIndex = 13;
            this.lblSenhaPt.Text = "Senha";
            // 
            // txtIdJog
            // 
            this.txtIdJog.Location = new System.Drawing.Point(219, 209);
            this.txtIdJog.Name = "txtIdJog";
            this.txtIdJog.Size = new System.Drawing.Size(100, 20);
            this.txtIdJog.TabIndex = 14;
            // 
            // txtSenhaJog
            // 
            this.txtSenhaJog.Location = new System.Drawing.Point(334, 209);
            this.txtSenhaJog.Name = "txtSenhaJog";
            this.txtSenhaJog.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaJog.TabIndex = 15;
            // 
            // txtCorJog
            // 
            this.txtCorJog.Location = new System.Drawing.Point(451, 209);
            this.txtCorJog.Name = "txtCorJog";
            this.txtCorJog.Size = new System.Drawing.Size(100, 20);
            this.txtCorJog.TabIndex = 16;
            // 
            // lblIdJog
            // 
            this.lblIdJog.AutoSize = true;
            this.lblIdJog.Location = new System.Drawing.Point(242, 193);
            this.lblIdJog.Name = "lblIdJog";
            this.lblIdJog.Size = new System.Drawing.Size(57, 13);
            this.lblIdJog.TabIndex = 17;
            this.lblIdJog.Text = "Id Jogador";
            // 
            // lblSenhaJog
            // 
            this.lblSenhaJog.AutoSize = true;
            this.lblSenhaJog.Location = new System.Drawing.Point(346, 193);
            this.lblSenhaJog.Name = "lblSenhaJog";
            this.lblSenhaJog.Size = new System.Drawing.Size(79, 13);
            this.lblSenhaJog.TabIndex = 18;
            this.lblSenhaJog.Text = "Senha Jogador";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(492, 193);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(23, 13);
            this.lblCor.TabIndex = 19;
            this.lblCor.Text = "Cor";
            // 
            // btnCriarPt
            // 
            this.btnCriarPt.Location = new System.Drawing.Point(24, 285);
            this.btnCriarPt.Name = "btnCriarPt";
            this.btnCriarPt.Size = new System.Drawing.Size(110, 28);
            this.btnCriarPt.TabIndex = 20;
            this.btnCriarPt.Text = "Criar Partida";
            this.btnCriarPt.UseVisualStyleBackColor = true;
            this.btnCriarPt.Click += new System.EventHandler(this.btnCriarPt_Click);
            // 
            // txtNomePtCr
            // 
            this.txtNomePtCr.Location = new System.Drawing.Point(160, 290);
            this.txtNomePtCr.Name = "txtNomePtCr";
            this.txtNomePtCr.Size = new System.Drawing.Size(100, 20);
            this.txtNomePtCr.TabIndex = 21;
            // 
            // txtSenhaPtCr
            // 
            this.txtSenhaPtCr.Location = new System.Drawing.Point(284, 290);
            this.txtSenhaPtCr.Name = "txtSenhaPtCr";
            this.txtSenhaPtCr.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaPtCr.TabIndex = 22;
            // 
            // lblNomePtCr
            // 
            this.lblNomePtCr.AutoSize = true;
            this.lblNomePtCr.Location = new System.Drawing.Point(178, 274);
            this.lblNomePtCr.Name = "lblNomePtCr";
            this.lblNomePtCr.Size = new System.Drawing.Size(71, 13);
            this.lblNomePtCr.TabIndex = 23;
            this.lblNomePtCr.Text = "Nome Partida";
            // 
            // lblSenhaPtCr
            // 
            this.lblSenhaPtCr.AutoSize = true;
            this.lblSenhaPtCr.Location = new System.Drawing.Point(299, 274);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 335);
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
    }
}

