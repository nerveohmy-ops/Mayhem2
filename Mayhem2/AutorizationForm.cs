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
            this.Resize += (s, e) => this.Invalidate();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            typeof(Form).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                null, this, new object[] { true });
        }

        //
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.Clear(Color.White);

            Point[] corner =
            {
                new Point(0, ClientSize.Height),
                new Point(0, ClientSize.Height - 260),
                new Point(260, ClientSize.Height)
            };
            using (var blackbrush = new SolidBrush(Color.Black))
            {
                g.FillPolygon(blackbrush, corner);
            }

            using (var pen = new Pen(Color.Black, 2))
            {
                g.DrawLine(pen,
                    ClientSize.Width - 180, 0,
                    ClientSize.Width, 180);
            }
        }
        //

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
