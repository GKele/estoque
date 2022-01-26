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
    public partial class UserModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GeKel\Documents\dbEstoque.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();

        public UserModuleForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != txtRepass.Text)
                {
                    MessageBox.Show("Senhas Diferentes!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Cadastrar este Usuário?", "Salvando Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbUser(usuario,email,senha,telefone)VALUES(@usuario,@email,@senha,@telefone)", con);
                    cm.Parameters.AddWithValue("@usuario", txtUser.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    cm.Parameters.AddWithValue("@senha", txtPassword.Text);
                    cm.Parameters.AddWithValue("@telefone", txtPhone.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Usuário Cadastrado com Sucesso!");
                    Clear();
                }
            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        public void Clear()
        {
            txtUser.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtRepass.Clear();
            txtPhone.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != txtRepass.Text)
                {
                    MessageBox.Show("Senhas Diferentes!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Atualizar este Usuário?", "Atualizando Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbUser SET usuario=@usuario, email=@email, senha=@senha, telefone=@telefone WHERE usuario LIKE '" + txtUser.Text + "' ", con);
                    cm.Parameters.AddWithValue("@usuario", txtUser.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    cm.Parameters.AddWithValue("@senha", txtPassword.Text);
                    cm.Parameters.AddWithValue("@telefone", txtPhone.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Usuário Atualizado com Sucesso!");
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
