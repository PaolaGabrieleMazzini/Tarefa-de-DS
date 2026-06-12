namespace Estruturas
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlContainer = new Panel();
            btnSair = new Button();
            pnlLogin = new Panel();
            btnLimpar = new Button();
            btnTestar = new Button();
            txtSenha = new TextBox();
            lblSenha = new Label();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            lsbMostra = new ListBox();
            lblRepeticao = new Label();
            pnlRepeticao = new Panel();
            btnContinue = new Button();
            btnFor = new Button();
            btnBreak = new Button();
            btnDoWhile = new Button();
            btnForEach = new Button();
            btnWhile = new Button();
            lblCondicional = new Label();
            pnlContainer.SuspendLayout();
            pnlLogin.SuspendLayout();
            pnlRepeticao.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.Anchor = AnchorStyles.None;
            pnlContainer.BackColor = Color.FromArgb(255, 192, 255);
            pnlContainer.Controls.Add(btnSair);
            pnlContainer.Controls.Add(pnlLogin);
            pnlContainer.Controls.Add(lsbMostra);
            pnlContainer.Controls.Add(lblRepeticao);
            pnlContainer.Controls.Add(pnlRepeticao);
            pnlContainer.Controls.Add(lblCondicional);
            pnlContainer.Location = new Point(44, 45);
            pnlContainer.Margin = new Padding(4, 5, 4, 5);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1159, 830);
            pnlContainer.TabIndex = 0;
            pnlContainer.Paint += pnlContainer_Paint;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(255, 128, 255);
            btnSair.Location = new Point(894, 35);
            btnSair.Margin = new Padding(4, 5, 4, 5);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(147, 63);
            btnSair.TabIndex = 11;
            btnSair.Text = "Sair do sistema";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // pnlLogin
            // 
            pnlLogin.BorderStyle = BorderStyle.Fixed3D;
            pnlLogin.Controls.Add(btnLimpar);
            pnlLogin.Controls.Add(btnTestar);
            pnlLogin.Controls.Add(txtSenha);
            pnlLogin.Controls.Add(lblSenha);
            pnlLogin.Controls.Add(txtUsuario);
            pnlLogin.Controls.Add(lblUsuario);
            pnlLogin.Location = new Point(103, 110);
            pnlLogin.Margin = new Padding(4, 5, 4, 5);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(384, 229);
            pnlLogin.TabIndex = 10;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(255, 128, 255);
            btnLimpar.Location = new Point(227, 148);
            btnLimpar.Margin = new Padding(4, 5, 4, 5);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(130, 38);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnTestar
            // 
            btnTestar.BackColor = Color.FromArgb(255, 128, 255);
            btnTestar.Location = new Point(227, 57);
            btnTestar.Margin = new Padding(4, 5, 4, 5);
            btnTestar.Name = "btnTestar";
            btnTestar.Size = new Size(130, 38);
            btnTestar.TabIndex = 1;
            btnTestar.Text = "Entrar";
            btnTestar.UseVisualStyleBackColor = false;
            btnTestar.Click += btnTestar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(29, 148);
            txtSenha.Margin = new Padding(4, 5, 4, 5);
            txtSenha.MaxLength = 20;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(161, 31);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(29, 117);
            lblSenha.Margin = new Padding(4, 0, 4, 0);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(60, 25);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(29, 57);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.MaxLength = 10;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(161, 31);
            txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(29, 25);
            lblUsuario.Margin = new Padding(4, 0, 4, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(72, 25);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuário";
            // 
            // lsbMostra
            // 
            lsbMostra.BackColor = Color.FromArgb(255, 128, 255);
            lsbMostra.FormattingEnabled = true;
            lsbMostra.ItemHeight = 25;
            lsbMostra.Location = new Point(533, 108);
            lsbMostra.Margin = new Padding(4, 5, 4, 5);
            lsbMostra.Name = "lsbMostra";
            lsbMostra.Size = new Size(507, 629);
            lsbMostra.TabIndex = 9;
            // 
            // lblRepeticao
            // 
            lblRepeticao.AutoSize = true;
            lblRepeticao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRepeticao.Location = new Point(103, 370);
            lblRepeticao.Margin = new Padding(4, 0, 4, 0);
            lblRepeticao.Name = "lblRepeticao";
            lblRepeticao.Size = new Size(279, 32);
            lblRepeticao.TabIndex = 8;
            lblRepeticao.Text = "Estruturas de repetição";
            // 
            // pnlRepeticao
            // 
            pnlRepeticao.BorderStyle = BorderStyle.Fixed3D;
            pnlRepeticao.Controls.Add(btnContinue);
            pnlRepeticao.Controls.Add(btnFor);
            pnlRepeticao.Controls.Add(btnBreak);
            pnlRepeticao.Controls.Add(btnDoWhile);
            pnlRepeticao.Controls.Add(btnForEach);
            pnlRepeticao.Controls.Add(btnWhile);
            pnlRepeticao.Location = new Point(103, 425);
            pnlRepeticao.Margin = new Padding(4, 5, 4, 5);
            pnlRepeticao.Name = "pnlRepeticao";
            pnlRepeticao.Size = new Size(384, 312);
            pnlRepeticao.TabIndex = 7;
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.White;
            btnContinue.Location = new Point(209, 217);
            btnContinue.Margin = new Padding(4, 5, 4, 5);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(130, 67);
            btnContinue.TabIndex = 10;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // btnFor
            // 
            btnFor.BackColor = Color.FromArgb(255, 128, 255);
            btnFor.Location = new Point(46, 217);
            btnFor.Margin = new Padding(4, 5, 4, 5);
            btnFor.Name = "btnFor";
            btnFor.Size = new Size(130, 67);
            btnFor.TabIndex = 9;
            btnFor.Text = "For";
            btnFor.UseVisualStyleBackColor = false;
            btnFor.Click += btnFor_Click;
            // 
            // btnBreak
            // 
            btnBreak.BackColor = Color.White;
            btnBreak.Location = new Point(210, 113);
            btnBreak.Margin = new Padding(4, 5, 4, 5);
            btnBreak.Name = "btnBreak";
            btnBreak.Size = new Size(130, 67);
            btnBreak.TabIndex = 8;
            btnBreak.Text = "Break";
            btnBreak.UseVisualStyleBackColor = false;
            btnBreak.Click += btnBreak_Click;
            // 
            // btnDoWhile
            // 
            btnDoWhile.BackColor = Color.FromArgb(255, 128, 255);
            btnDoWhile.Location = new Point(47, 113);
            btnDoWhile.Margin = new Padding(4, 5, 4, 5);
            btnDoWhile.Name = "btnDoWhile";
            btnDoWhile.Size = new Size(130, 67);
            btnDoWhile.TabIndex = 7;
            btnDoWhile.Text = "Do...While";
            btnDoWhile.UseVisualStyleBackColor = false;
            btnDoWhile.Click += btnDoWhile_Click;
            // 
            // btnForEach
            // 
            btnForEach.BackColor = Color.FromArgb(255, 128, 255);
            btnForEach.Location = new Point(209, 17);
            btnForEach.Margin = new Padding(4, 5, 4, 5);
            btnForEach.Name = "btnForEach";
            btnForEach.Size = new Size(130, 67);
            btnForEach.TabIndex = 6;
            btnForEach.Text = "ForEach";
            btnForEach.UseVisualStyleBackColor = false;
            btnForEach.Click += btnForEach_Click;
            // 
            // btnWhile
            // 
            btnWhile.BackColor = Color.FromArgb(255, 128, 255);
            btnWhile.Location = new Point(46, 17);
            btnWhile.Margin = new Padding(4, 5, 4, 5);
            btnWhile.Name = "btnWhile";
            btnWhile.Size = new Size(130, 67);
            btnWhile.TabIndex = 5;
            btnWhile.Text = "While";
            btnWhile.UseVisualStyleBackColor = false;
            btnWhile.Click += btnWhile_Click;
            // 
            // lblCondicional
            // 
            lblCondicional.AutoSize = true;
            lblCondicional.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCondicional.Location = new Point(103, 67);
            lblCondicional.Margin = new Padding(4, 0, 4, 0);
            lblCondicional.Name = "lblCondicional";
            lblCondicional.Size = new Size(262, 32);
            lblCondicional.TabIndex = 6;
            lblCondicional.Text = "Estrutura Condicional";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 875);
            Controls.Add(pnlContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Principal";
            WindowState = FormWindowState.Maximized;
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlRepeticao.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private ListBox lsbMostra;
        private Label lblRepeticao;
        private Panel pnlRepeticao;
        private Button btnContinue;
        private Button btnFor;
        private Button btnBreak;
        private Button btnDoWhile;
        private Button btnForEach;
        private Button btnWhile;
        private Label lblCondicional;
        private Panel pnlLogin;
        private Button btnLimpar;
        private Button btnTestar;
        private TextBox txtSenha;
        private Label lblSenha;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private Button btnSair;
    }
}
