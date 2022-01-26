
namespace ControleDeEstoque
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureExit = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxPass = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bntLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.pictureExit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 60);
            this.panel1.TabIndex = 1;
            // 
            // pictureExit
            // 
            this.pictureExit.Image = global::ControleDeEstoque.Properties.Resources.fechar_vemelho;
            this.pictureExit.Location = new System.Drawing.Point(333, -1);
            this.pictureExit.Name = "pictureExit";
            this.pictureExit.Size = new System.Drawing.Size(24, 21);
            this.pictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureExit.TabIndex = 10;
            this.pictureExit.TabStop = false;
            this.pictureExit.Click += new System.EventHandler(this.pictureExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sistema de Gerenciamento de Estoque";
            // 
            // checkBoxPass
            // 
            this.checkBoxPass.AutoSize = true;
            this.checkBoxPass.Location = new System.Drawing.Point(212, 478);
            this.checkBoxPass.Name = "checkBoxPass";
            this.checkBoxPass.Size = new System.Drawing.Size(105, 20);
            this.checkBoxPass.TabIndex = 16;
            this.checkBoxPass.Text = "Mostrar Senha";
            this.checkBoxPass.UseVisualStyleBackColor = true;
            this.checkBoxPass.CheckedChanged += new System.EventHandler(this.checkBoxPass_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(149, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Login";
            // 
            // bntLogin
            // 
            this.bntLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.bntLogin.FlatAppearance.BorderSize = 0;
            this.bntLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLogin.Location = new System.Drawing.Point(45, 402);
            this.bntLogin.Name = "bntLogin";
            this.bntLogin.Size = new System.Drawing.Size(262, 46);
            this.bntLogin.TabIndex = 13;
            this.bntLogin.Text = "Entrar";
            this.bntLogin.UseVisualStyleBackColor = false;
            this.bntLogin.Click += new System.EventHandler(this.bntLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Senha";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(45, 360);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(262, 21);
            this.txtPass.TabIndex = 11;
            this.txtPass.Text = "1254";
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(45, 297);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(262, 21);
            this.txtEmail.TabIndex = 9;
            // 
            // pictureClose
            // 
            this.pictureClose.Image = global::ControleDeEstoque.Properties.Resources.estoque;
            this.pictureClose.Location = new System.Drawing.Point(96, 97);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(160, 150);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureClose.TabIndex = 14;
            this.pictureClose.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 535);
            this.Controls.Add(this.checkBoxPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureClose);
            this.Controls.Add(this.bntLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureExit;
        private System.Windows.Forms.CheckBox checkBoxPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.Button bntLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
    }
}

