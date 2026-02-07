using System;
using System.Windows.Forms;
using Npgsql;

namespace _2026_gena_bukin
{
    public partial class EditProductForm : Form
    {
        private string _article;
        public EditProductForm(string article) { InitializeComponent(); _article = article; }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_article))
            {
                txtArticle.Text = _article;
                txtArticle.ReadOnly = true;
                LoadData();
            }
        }

        private void LoadData()
        {
            using (var conn = DatabaseService.GetConnection())
            {
                conn.Open();
                string sql = "SELECT ProductCost AS p, ProductDiscountAmount AS d FROM product WHERE ProductArticleNumber = @a";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("a", _article);
                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            txtPrice.Text = rdr["p"].ToString();
                            txtDiscount.Text = rdr["d"].ToString();
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseService.GetConnection())
                {
                    conn.Open();
                    string sql = string.IsNullOrEmpty(_article)
                        ? "INSERT INTO product (ProductArticleNumber, ProductCost, ProductDiscountAmount) VALUES (@a, @p, @d)"
                        : "UPDATE product SET ProductCost=@p, ProductDiscountAmount=@d WHERE ProductArticleNumber=@a";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("a", txtArticle.Text);
                        cmd.Parameters.AddWithValue("p", decimal.Parse(txtPrice.Text));
                        cmd.Parameters.AddWithValue("d", int.Parse(txtDiscount.Text));
                        cmd.ExecuteNonQuery();
                    }
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}