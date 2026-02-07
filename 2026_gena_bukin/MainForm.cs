using System;
using System.Windows.Forms;
using Npgsql;

namespace _2026_gena_bukin
{
    public partial class MainForm : Form
    {
        public MainForm() { InitializeComponent(); }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblUser.Text = $"{CurrentUser.FullName} ({CurrentUser.RoleName})";
            btnAdd.Visible = (CurrentUser.RoleId == 1);
            LoadProducts();
        }

        public void LoadProducts()
        {
            flowLayoutPanel1.Controls.Clear();
            try
            {
                using (var conn = DatabaseService.GetConnection())
                {
                    conn.Open();
                    // Выбираем все поля. Мы НЕ БУДЕМ обращаться к ним по именам.
                    string sql = "SELECT * FROM product";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            // Читаем по ИНДЕКСАМ. 
                            // 0 - обычно артикул, 1 - название, 2 - описание и т.д.
                            // Это спасет от ошибки "Column not found"
                            string art = rdr[0].ToString();
                            string name = rdr[1]?.ToString() ?? "Нет названия";
                            string desc = rdr[2]?.ToString() ?? "";
                            string manf = rdr.FieldCount > 4 ? rdr[4].ToString() : "";

                            int price = 0;
                            if (!rdr.IsDBNull(5)) price = Convert.ToInt32(rdr[5]);

                            int disc = 0;
                            if (rdr.FieldCount > 6 && !rdr.IsDBNull(6)) disc = Convert.ToInt32(rdr[6]);

                            string photo = rdr.FieldCount > 7 ? rdr[7].ToString() : "";

                            var item = new ProductItem(name, desc, manf, price, disc, photo);

                            if (CurrentUser.RoleId == 1)
                            {
                                item.EditButton.Visible = true;
                                item.EditButton.Click += (s, args) => {
                                    var editForm = new EditProductForm(art);
                                    if (editForm.ShowDialog() == DialogResult.OK) LoadProducts();
                                };
                            }
                            flowLayoutPanel1.Controls.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Это окно покажет точное место ошибки
                MessageBox.Show($"Ошибка в LoadProducts: {ex.Message}\nСтек: {ex.StackTrace}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new EditProductForm(null);
            if (addForm.ShowDialog() == DialogResult.OK) LoadProducts();
        }
    }
}