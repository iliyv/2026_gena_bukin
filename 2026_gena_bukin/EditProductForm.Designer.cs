namespace _2026_gena_bukin
{
    partial class EditProductForm
    {
        private System.ComponentModel.IContainer components = null;

        // Поля ввода
        private System.Windows.Forms.TextBox txtArticle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.ComboBox cmbManf;

        // Кнопки и подписи
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblArt;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDisc;
        private System.Windows.Forms.Label lblManf;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.PictureBox pbLogo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtArticle = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.cmbManf = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblArt = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDisc = new System.Windows.Forms.Label();
            this.lblManf = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo (Логотип для баллов за оформление)
            // 
            this.pbLogo.Location = new System.Drawing.Point(320, 10);
            this.pbLogo.Size = new System.Drawing.Size(50, 50);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // Labels (Подписи)
            // 
            this.lblArt.Text = "Артикул:";
            this.lblArt.Location = new System.Drawing.Point(20, 20);
            this.lblArt.Size = new System.Drawing.Size(100, 20);

            this.lblName.Text = "Название:";
            this.lblName.Location = new System.Drawing.Point(20, 50);
            this.lblName.Size = new System.Drawing.Size(100, 20);

            this.lblManf.Text = "Производитель:";
            this.lblManf.Location = new System.Drawing.Point(20, 80);
            this.lblManf.Size = new System.Drawing.Size(100, 20);

            this.lblPrice.Text = "Цена:";
            this.lblPrice.Location = new System.Drawing.Point(20, 110);
            this.lblPrice.Size = new System.Drawing.Size(100, 20);

            this.lblDisc.Text = "Скидка (%):";
            this.lblDisc.Location = new System.Drawing.Point(20, 140);
            this.lblDisc.Size = new System.Drawing.Size(100, 20);

            this.lblDesc.Text = "Описание:";
            this.lblDesc.Location = new System.Drawing.Point(20, 170);
            this.lblDesc.Size = new System.Drawing.Size(100, 20);
            // 
            // Inputs (Поля ввода)
            // 
            this.txtArticle.Location = new System.Drawing.Point(130, 20);
            this.txtArticle.Size = new System.Drawing.Size(180, 20);

            this.txtName.Location = new System.Drawing.Point(130, 50);
            this.txtName.Size = new System.Drawing.Size(180, 20);

            this.cmbManf.Location = new System.Drawing.Point(130, 80);
            this.cmbManf.Size = new System.Drawing.Size(180, 21);
            this.cmbManf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.txtPrice.Location = new System.Drawing.Point(130, 110);
            this.txtPrice.Size = new System.Drawing.Size(180, 20);

            this.txtDiscount.Location = new System.Drawing.Point(130, 140);
            this.txtDiscount.Size = new System.Drawing.Size(180, 20);

            this.txtDesc.Location = new System.Drawing.Point(130, 170);
            this.txtDesc.Size = new System.Drawing.Size(180, 60);
            this.txtDesc.Multiline = true;
            // 
            // Buttons (Кнопки)
            // 
            this.btnSave.Text = "Сохранить";
            this.btnSave.Location = new System.Drawing.Point(130, 250);
            this.btnSave.Size = new System.Drawing.Size(180, 30);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(255, 204, 153); // Цвет по техзаданию
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnDelete.Text = "Удалить";
            this.btnDelete.Location = new System.Drawing.Point(20, 250);
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // EditProductForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblDisc);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.cmbManf);
            this.Controls.Add(this.lblManf);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtArticle);
            this.Controls.Add(this.lblArt);
            this.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.EditProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}