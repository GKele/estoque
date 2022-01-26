
namespace ControleDeEstoque
{
    partial class InventoryModuleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureExit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.NumericUpDown();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPId = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.NumericUpDown();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NameProduct = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtSaida = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrada/Saída";
            // 
            // pictureExit
            // 
            this.pictureExit.Image = global::ControleDeEstoque.Properties.Resources.fechar_vemelho;
            this.pictureExit.Location = new System.Drawing.Point(776, 0);
            this.pictureExit.Name = "pictureExit";
            this.pictureExit.Size = new System.Drawing.Size(24, 20);
            this.pictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureExit.TabIndex = 15;
            this.pictureExit.TabStop = false;
            this.pictureExit.Click += new System.EventHandler(this.pictureExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 58);
            this.panel1.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 284);
            this.panel3.TabIndex = 27;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column4,
            this.Column1,
            this.Column2});
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.Size = new System.Drawing.Size(800, 117);
            this.dgvProduct.TabIndex = 28;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick_1);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "No";
            this.ID.Name = "ID";
            this.ID.Width = 48;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "ID Produto";
            this.Column4.Name = "Column4";
            this.Column4.Width = 90;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Cód. Produto";
            this.Column1.Name = "Column1";
            this.Column1.Width = 106;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnClear);
            this.panel5.Controls.Add(this.btnInsert);
            this.panel5.Controls.Add(this.txtInput);
            this.panel5.Controls.Add(this.txtTotal);
            this.panel5.Controls.Add(this.txtPId);
            this.panel5.Controls.Add(this.txtOutput);
            this.panel5.Controls.Add(this.txtProduct);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.NameProduct);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.txtEntrada);
            this.panel5.Controls.Add(this.txtSearch);
            this.panel5.Controls.Add(this.txtSaida);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.dgvProduct);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(0, 58);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 284);
            this.panel5.TabIndex = 28;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Brown;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(704, 219);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 28);
            this.btnClear.TabIndex = 64;
            this.btnClear.Text = "Cancelar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.ForestGreen;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(704, 174);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(74, 29);
            this.btnInsert.TabIndex = 63;
            this.btnInsert.Text = "Salvar";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(552, 160);
            this.txtInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 21);
            this.txtInput.TabIndex = 62;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(552, 243);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 21);
            this.txtTotal.TabIndex = 59;
            // 
            // txtPId
            // 
            this.txtPId.Location = new System.Drawing.Point(53, 203);
            this.txtPId.Name = "txtPId";
            this.txtPId.Size = new System.Drawing.Size(100, 21);
            this.txtPId.TabIndex = 56;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(552, 206);
            this.txtOutput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(100, 21);
            this.txtOutput.TabIndex = 58;
            this.txtOutput.ValueChanged += new System.EventHandler(this.txtOutput_ValueChanged);
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(233, 201);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(100, 21);
            this.txtProduct.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Cod:";
            // 
            // NameProduct
            // 
            this.NameProduct.AutoSize = true;
            this.NameProduct.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameProduct.ForeColor = System.Drawing.Color.Black;
            this.NameProduct.Location = new System.Drawing.Point(169, 205);
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.Size = new System.Drawing.Size(58, 17);
            this.NameProduct.TabIndex = 49;
            this.NameProduct.Text = "Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "PRODUTO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Pesquisar Produto :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(399, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 51;
            this.label9.Text = "ESTOQUE:";
            // 
            // txtEntrada
            // 
            this.txtEntrada.AutoSize = true;
            this.txtEntrada.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.ForeColor = System.Drawing.Color.Black;
            this.txtEntrada.Location = new System.Drawing.Point(489, 165);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(57, 17);
            this.txtEntrada.TabIndex = 52;
            this.txtEntrada.Text = "Entrada:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(129, 122);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(184, 21);
            this.txtSearch.TabIndex = 46;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // txtSaida
            // 
            this.txtSaida.AutoSize = true;
            this.txtSaida.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaida.ForeColor = System.Drawing.Color.Black;
            this.txtSaida.Location = new System.Drawing.Point(501, 207);
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(45, 17);
            this.txtSaida.TabIndex = 53;
            this.txtSaida.Text = "Saída:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(506, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 54;
            this.label8.Text = "Total:";
            // 
            // InventoryModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InventoryModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryModuleForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtPId;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NameProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtEntrada;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label txtSaida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.NumericUpDown txtOutput;
        public System.Windows.Forms.NumericUpDown txtInput;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnInsert;
    }
}