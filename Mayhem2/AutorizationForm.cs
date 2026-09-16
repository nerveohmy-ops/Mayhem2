using System;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
namespace Mayhem2
{
    public partial class AutorizationForm : Form
    {
        private readonly string connectionString =
    @"Data Source=HOME-PC\SQLEXPRESS;Initial Catalog=RealEstateDB;Integrated Security=True;TrustServerCertificate=True;";
        public AutorizationForm()
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void cuiTextBox2_ContentChanged(object sender, EventArgs e)
        {

        }

        private void cuiTextBox1_ContentChanged(object sender, EventArgs e)
        {

        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {

        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string login = cuiTextBox1.Content.Trim();
            string password = cuiTextBox2.Content.Trim();
            if (string.IsNullOrWhiteSpace(login)) {
                errorProvider1.SetError(cuiTextBox1, "Введите логин");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                errorProvider1.SetError(cuiTextBox2, "Введите пароль");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT u.Id, u.FullName, r.Name as RoleName FROM Users u JOIN Roles r ON u.RoleId = r.Id WHERE u.Login = @Login AND u.Password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@password", password);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int userId = reader.GetInt32(0);
                                string fullName = reader.GetString(1);
                                string role = reader.GetString(2);

                                MessageBox.Show($"Добро пожаловать, {fullName}!", "Успешно.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                errorProvider1.SetError(cuiTextBox1, "Неверный логин или пароль");
                                errorProvider1.SetError(cuiTextBox2, "Неверный логин или пароль");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к БД: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
