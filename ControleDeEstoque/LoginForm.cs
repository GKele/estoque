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
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GeKel\Documents\dbEstoque.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked == false)
                txtPass.UseSystemPasswordChar = true;
            else
                txtPass.UseSystemPasswordChar = false;
        }

        private void pictureExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("SELECT * FROM tbUser WHERE email=@email AND senha=@senha", con);
                cm.Parameters.AddWithValue("@email", txtEmail.Text);
                cm.Parameters.AddWithValue("@senha", txtPass.Text);
                con.Open();
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("Bem Vindo " + dr["usuario"].ToString() + " | ", "ACESSO PERMITIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm main = new MainForm();
                    this.Hide();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("E-mail ou Senha Inválida!", "ACESSO BLOQUEADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}