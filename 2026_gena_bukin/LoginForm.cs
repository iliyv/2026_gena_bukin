using System;
using System.Windows.Forms;
using Npgsql;

namespace _2026_gena_bukin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLogin.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Введите логин и пароль!");
                return;
            }

            try
            {
                using (var conn = DatabaseService.GetConnection())
                {
                    conn.Open();
                    // Запрос проверяет пользователя и подтягивает название роли
                    string sql = @"SELECT u.*, r.role_name 
                                   FROM ""user"" u 
                                   JOIN role r ON u.role_id = r.id 
                                   WHERE u.login = @l AND u.password = @p";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("l", txtLogin.Text);
                        cmd.Parameters.AddWithValue("p", txtPass.Text);

                        using (var rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                // Сохраняем данные в глобальный класс CurrentUser
                                CurrentUser.RoleId = Convert.ToInt32(rdr["role_id"]);
                                CurrentUser.FullName = rdr["full_name"].ToString();
                                CurrentUser.RoleName = rdr["role_name"].ToString();

                                MessageBox.Show($"Добро пожаловать, {CurrentUser.FullName}!\nВаша роль: {CurrentUser.RoleName}");

                                // Переход на главную форму
                                this.Hide();
                                MainForm main = new MainForm();
                                main.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Неверный логин или пароль!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка авторизации: " + ex.Message);
            }
        }
    }
}