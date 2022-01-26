
namespace ControleDeEstoque
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.custormerButton1 = new ControleDeEstoque.CustormerButton();
            this.btnUser = new ControleDeEstoque.CustormerButton();
            this.btnInventary = new ControleDeEstoque.CustormerButton();
            this.btnProducts = new ControleDeEstoque.CustormerButton();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custormerButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInventary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnInventary);
            this.panel1.Controls.Add(this.btnProducts);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 108);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(445, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "USUARIOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(560, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "INVENTÁRIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "PRODUTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Gerenciamento de Estoque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sistema de";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 428);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 22);
            this.panel2.TabIndex = 3;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.custormerButton1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 108);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 320);
            this.panelMain.TabIndex = 4;
            // 
            // custormerButton1
            // 
            this.custormerButton1.Image = global::ControleDeEstoque.Properties.Resources.gestao_estoque1;
            this.custormerButton1.ImageHover = null;
            this.custormerButton1.ImageNormal = global::ControleDeEstoque.Properties.Resources.gestao_estoque1;
            this.custormerButton1.Location = new System.Drawing.Point(33, 45);
            this.custormerButton1.Name = "custormerButton1";
            this.custormerButton1.Size = new System.Drawing.Size(727, 219);
            this.custormerButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.custormerButton1.TabIndex = 24;
            this.custormerButton1.TabStop = false;
            // 
            // btnUser
            // 
            this.btnUser.Image = global::ControleDeEstoque.Properties.Resources.profile_icon_black3;
            this.btnUser.ImageHover = global::ControleDeEstoque.Properties.Resources.profile_icon_color;
            this.btnUser.ImageNormal = global::ControleDeEstoque.Properties.Resources.profile_icon_black;
            this.btnUser.Location = new System.Drawing.Point(445, 12);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(67, 63);
            this.btnUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUser.TabIndex = 23;
            this.btnUser.TabStop = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnInventary
            // 
            this.btnInventary.Image = global::ControleDeEstoque.Properties.Resources.inventario_icon_black;
            this.btnInventary.ImageHover = global::ControleDeEstoque.Properties.Resources.inventario_icon_color;
            this.btnInventary.ImageNormal = global::ControleDeEstoque.Properties.Resources.inventario_icon_black;
            this.btnInventary.Location = new System.Drawing.Point(563, 12);
            this.btnInventary.Name = "btnInventary";
            this.btnInventary.Size = new System.Drawing.Size(67, 63);
            this.btnInventary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInventary.TabIndex = 22;
            this.btnInventary.TabStop = false;
            this.btnInventary.Click += new System.EventHandler(this.btnInventary_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Image = global::ControleDeEstoque.Properties.Resources.produto_icon_black;
            this.btnProducts.ImageHover = global::ControleDeEstoque.Properties.Resources.produto_icon_color;
            this.btnProducts.ImageNormal = global::ControleDeEstoque.Properties.Resources.produto_icon_black;
            this.btnProducts.Location = new System.Drawing.Point(315, 12);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(67, 63);
            this.btnProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnProducts.TabIndex = 2;
            this.btnProducts.TabStop = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.custormerButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInventary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private CustormerButton btnUser;
        private CustormerButton btnInventary;
        private CustormerButton btnProducts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMain;
        private CustormerButton custormerButton1;
    }
}