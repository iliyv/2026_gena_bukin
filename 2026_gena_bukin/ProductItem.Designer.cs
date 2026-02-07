namespace _2026_gena_bukin
{
    partial class ProductItem
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblManf;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblOldPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Button btnEdit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblManf = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblOldPrice = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();

            this.pbPhoto.Location = new System.Drawing.Point(10, 10);
            this.pbPhoto.Size = new System.Drawing.Size(130, 130);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(150, 10);
            this.lblName.Size = new System.Drawing.Size(400, 25);

            this.lblDesc.Location = new System.Drawing.Point(150, 40);
            this.lblDesc.Size = new System.Drawing.Size(400, 50);

            this.lblManf.Location = new System.Drawing.Point(150, 90);
            this.lblManf.Size = new System.Drawing.Size(400, 20);

            this.btnEdit.Text = "Редактировать";
            this.btnEdit.Location = new System.Drawing.Point(150, 115);
            this.btnEdit.Size = new System.Drawing.Size(120, 25);
            this.btnEdit.Visible = false; // Скрыта по умолчанию

            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(560, 40);
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblOldPrice.Location = new System.Drawing.Point(560, 15);
            this.lblOldPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblDiscount.Location = new System.Drawing.Point(560, 110);
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblOldPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblManf);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbPhoto);
            this.Size = new System.Drawing.Size(680, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
        }
    }
}