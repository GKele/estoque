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
    public partial class InventoryModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GeKel\Documents\dbEstoque.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public InventoryModuleForm()
        {
            InitializeComponent();
            LoadProduct();
        }

        private void pictureExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadProduct()
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            cm = new SqlCommand("SELECT pid, pcod, pname FROM tbProduct WHERE CONCAT(pid, pcod, pname) LIKE '%" + txtSearch.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            con.Close();
        }


        private void dgvProduct_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtPId.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtProduct.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            LoadProduct();
        }


        private void txtOutput_ValueChanged(object sender, EventArgs e)
        {
            int total = (Convert.ToInt16(txtInput.Value) - Convert.ToInt16(txtOutput.Value));
            txtTotal.Text = total.ToString();
        }

        private void dgvProduct_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtPId.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtProduct.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPId.Text == "")
                {
                    MessageBox.Show("Selecione um produto!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Deseja Salvar esta Lista?", "Salvando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbEstoque(estcod,estinput,estoutput,esttotal)VALUES(@estcod,@estinput,@estoutput,@esttotal)", con);
                    cm.Parameters.AddWithValue("@estcod", Convert.ToInt32(txtPId.Text));
                    cm.Parameters.AddWithValue("@estinput", Convert.ToInt32(txtInput.Value));
                    cm.Parameters.AddWithValue("@estoutput", Convert.ToInt32(txtOutput.Value));
                    cm.Parameters.AddWithValue("@esttotal", Convert.ToInt32(txtTotal.Text));
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Lista Salva com Sucesso!");
                    Clear();
                }

            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Clear()
        {
            txtPId.Clear();
            txtProduct.Clear();
            txtInput.Value = 0;
            txtOutput.Value = 0;
            txtTotal.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

    }
}
