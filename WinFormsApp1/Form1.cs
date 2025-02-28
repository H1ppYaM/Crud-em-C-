using System;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.ComponentModel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private FrmLogin frmLogin;
        private object textBox4;

        public Form1(FrmLogin frmLogin)
        {
            InitializeComponent();
            this.frmLogin = frmLogin;
            this.FormClosed += Form1_FormClosed;
            CarregarDados();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmLogin != null)
            {
                MessageBox.Show("Deslogado!");
                frmLogin.Show();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Client_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tele_TextChanged(object sender, EventArgs e)
        {

        }

        private void Produto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Valor_TextChanged(object sender, EventArgs e)
        {

        }


        private void BtnIns_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3307;Database=dev;User ID=root;Password=123;";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"
                INSERT INTO Cadastros (Cliente, Telefone, Valor, Produto)
                VALUES (@Cliente, @Telefone, @Valor, @Produto);";

                    using (MySqlCommand command = new MySqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@Cliente", Client.Text);
                        command.Parameters.AddWithValue("@Telefone", Tele.Text);
                        command.Parameters.AddWithValue("@Valor", decimal.Parse(Valor.Text)); // Use decimal.Parse para valores monetários
                        command.Parameters.AddWithValue("@Produto", Produto.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Dados inseridos com sucesso!");
                        CarregarDados();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir dados: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void CarregarDados()
        {
            string connectionString = "Server=localhost;Port=3307;Database=dev;User ID=root;Password=123;";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT id, Cliente, Telefone, Valor, Produto FROM Cadastros;";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarDados(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BtnDlt_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3307;Database=dev;User ID=root;Password=123;";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM Cadastros WHERE id = @Id;";

                    using (MySqlCommand command = new MySqlCommand(query, con))
                    {
                        if (dataGridView1.SelectedRows.Count > 0)
                        {
                            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                            command.Parameters.AddWithValue("@Id", id);
                            command.ExecuteNonQuery();

                            MessageBox.Show("Registro deletado com sucesso!");
                            CarregarDados();
                        }
                        else
                        {
                            MessageBox.Show("Selecione um registro para deletar.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar dados: " + ex.Message);
                }
            }
        }

        private void BtnAtt_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3307;Database=dev;User ID=root;Password=123;";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"
            UPDATE Cadastros 
            SET Cliente = @Cliente, Telefone = @Telefone, Valor = @Valor, Produto = @Produto
            WHERE id = @Id;";

                    using (MySqlCommand command = new MySqlCommand(query, con))
                    {
                        if (dataGridView1.SelectedRows.Count > 0)
                        {
                            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                            command.Parameters.AddWithValue("@Id", id);
                            command.Parameters.AddWithValue("@Cliente", Client.Text);
                            command.Parameters.AddWithValue("@Telefone", Tele.Text);
                            command.Parameters.AddWithValue("@Valor", decimal.Parse(Valor.Text));
                            command.Parameters.AddWithValue("@Produto", Produto.Text);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Registro atualizado com sucesso!");
                            CarregarDados();
                        }
                        else
                        {
                            MessageBox.Show("Selecione um registro para atualizar.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar dados: " + ex.Message);
                }
            }
        }



        private void BtnPes_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3307;Database=dev;User ID=root;Password=123;";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM Cadastros WHERE Cliente LIKE @Cliente;";

                    using (MySqlCommand command = new MySqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@Cliente", "%" + Client.Text + "%");

                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView1.DataSource = table;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao pesquisar: " + ex.Message);
                }
            }
        }
    }
}
