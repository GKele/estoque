
namespace ControleDeEstoque
{
    partial class dgvUser
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAdd = new ControleDeEstoque.CustormerButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delet = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 292);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 50);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gerenciar Inventário";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column4,
            this.Column2,
            this.Column5,
            this.Column1,
            this.Column3,
            this.Delet});
            this.dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventory.EnableHeadersVisualStyles = false;
            this.dgvInventory.Location = new System.Drawing.Point(0, 0);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.Size = new System.Drawing.Size(800, 292);
            this.dgvInventory.TabIndex = 6;
            this.dgvInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellContentClick);
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
            this.ID.Width = 50;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Cod.";
            this.Column4.Name = "Column4";
            this.Column4.Width = 61;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Referência";
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Entrada";
            this.Column5.Name = "Column5";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Saida";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Total";
            this.Column3.Name = "Column3";
            // 
            // Delet
            // 
            this.Delet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delet.HeaderText = "";
            this.Delet.Image = global::ControleDeEstoque.Properties.Resources.borracha_1_;
            this.Delet.Name = "Delet";
            this.Delet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delet.Width = 5;
            // 
            // dgvUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "dgvUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustormerButton btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Delet;
    }
}