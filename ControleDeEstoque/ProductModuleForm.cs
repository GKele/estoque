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
    public partial class ProductModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GeKel\Documents\dbEstoque.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();        

        public ProductModuleForm()
        {
            InitializeComponent();
            
        }

        private void pictureExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Cadastrar este Produto?", "Cadastrando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cm = new SqlCommand("INSERT INTO tbProduct(pcod,pname)VALUES(@pcod,@pname)", con);
                    cm.Parameters.AddWithValue("@pcod", txtPCod.Text);
                    cm.Parameters.AddWithValue("@pname", txtPName.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Produto Cadastrado com Sucesso!");
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
            txtPCod.Clear();
            txtPName.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Atualizar este Produto?", "Atualizando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cm = new SqlCommand("UPDATE tbProduct SET pcod=@pcod, pname=@pname WHERE pid LIKE '" + lblPid.Text + "' ", con);
                    
                    cm.Parameters.AddWithValue("@pcod", txtPCod.Text);
                    cm.Parameters.AddWithValue("@pname", txtPName.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Produto Atualizado com Sucesso!");
                    this.Dispose();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    }

}
