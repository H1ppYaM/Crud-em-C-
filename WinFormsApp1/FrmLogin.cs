using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {

            String User = "A33205";
            String Password = "aval";

            if (TxtUsuario.Text == User & TxtSenha.Text == Password)
            {
                MessageBox.Show("Logado!");
                Form1 FrmMain = new Form1(this);
                FrmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario e Senha incorretos!");
            }


            string connectionString = "Server=localhost;Port=3307;Database=dev;User ID=root;Password=123;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar: " + ex.Message);
                }

            }
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
