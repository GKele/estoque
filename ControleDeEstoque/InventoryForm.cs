using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeEstoque
{
    public partial class dgvUser : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GeKel\Documents\dbEstoque.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public dgvUser()
        {
            InitializeComponent();
            LoadInventory();
        }

        public void LoadInventory()
        {
            double total = 0;
            int i = 0;
            dgvInventory.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbEstoque", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvInventory.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                total += Convert.ToInt32(dr[4].ToString());
            }
            dr.Close();
            con.Close();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            InventoryModuleForm moduleForm = new InventoryModuleForm();
            moduleForm.btnInsert.Enabled = true;
            moduleForm.ShowDialog();
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvInventory.Columns[e.ColumnIndex].Name;

            if (colName == "Delet")
            {
                if (MessageBox.Show("Deseja Deletar esta Lista?", "Deletando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbEstoque WHERE estid LIKE '" + dgvInventory.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Lista Deletada com Sucesso!");
                  
                }
            }
            LoadInventory();
        }
    }
}
