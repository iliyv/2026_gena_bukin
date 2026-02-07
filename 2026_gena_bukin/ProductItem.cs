using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2026_gena_bukin
{
    public partial class ProductItem : UserControl
    {
        // Свойство для доступа к скрытой кнопке извне
        public Button EditButton => btnEdit;

        public ProductItem(string name, string desc, string manf, int price, int discount, string photoPath)
        {
            InitializeComponent();

            lblName.Text = name;
            lblDesc.Text = desc;
            lblManf.Text = "Производитель: " + manf;

            if (discount > 0)
            {
                lblPrice.Text = $"{(price * (100 - discount) / 100)} руб.";
                lblOldPrice.Text = $"{price} руб.";
                lblOldPrice.Font = new Font(lblOldPrice.Font, FontStyle.Strikeout);
                lblDiscount.Text = $"-{discount}%";
                if (discount >= 15) this.BackColor = ColorTranslator.FromHtml("#7FFF00");
            }
            else
            {
                lblPrice.Text = $"{price} руб.";
                lblOldPrice.Visible = false;
                lblDiscount.Visible = false;
            }

            // Загрузка фото
            try
            {
                if (!string.IsNullOrEmpty(photoPath))
                    pbPhoto.Image = Image.FromFile("Resources/" + photoPath);
                else
                    pbPhoto.Image = Image.FromFile("Resources/picture.png");
            }
            catch { pbPhoto.Image = Image.FromFile("Resources/picture.png"); }
        }
    }
}