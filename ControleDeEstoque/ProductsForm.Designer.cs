
namespace ControleDeEstoque
{
    partial class ProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAdd = new ControleDeEstoque.CustormerButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column4,
            this.Column1,
            this.Column2,
            this.Edit,
            this.Delete});
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(800, 342);
            this.dgvProduct.TabIndex = 3;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 292);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 50);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(226, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pesquisar :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(301, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(384, 22);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gerenciar Produtos";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::ControleDeEstoque.Properties.Resources.lapis_1_;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 5;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::ControleDeEstoque.Properties.Resources.borracha_1_;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::ControleDeEstoque.Properties.Resources.add_icon;
            this.btnAdd.ImageHover = global::ControleDeEstoque.Properties.Resources.add_icon;
            this.btnAdd.ImageNormal = global::ControleDeEstoque.Properties.Resources.add_icon;
            this.btnAdd.Location = new System.Drawing.Point(758, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 31);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 4;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = global::ControleDeEstoque.Properties.Resources.lapis_1_;
            this.Edit.Name = "Edit";
            this.Edit.Width = 5;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::ControleDeEstoque.Properties.Resources.borracha_1_;
            this.Delete.Name = "Delete";
            this.Delete.Width = 5;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.Text = "ProductsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private CustormerButton btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}