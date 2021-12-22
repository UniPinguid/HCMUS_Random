
namespace RandomApp
{
    partial class CustomerOrderProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOrderProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.productAmount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.noBranch = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.representative = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.contactNumber = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.partnerID = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.partnerName = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.listProduct = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.searchProduct = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RandomApp.Properties.Resources.title_bar;
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(-21, -25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1643, 240);
            this.panel1.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(56, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(244, 65);
            this.label16.TabIndex = 15;
            this.label16.Text = "Đặt hàng";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Roboto Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(489, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(397, 56);
            this.label15.TabIndex = 2;
            this.label15.Text = "Xem danh sách các đối tác\r\nrồi tiến hành chọn sản phẩm đặt hàng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(56, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 23);
            this.panel3.TabIndex = 1;
            this.panel3.Click += new System.EventHandler(this.clickBack);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(1558, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 40);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.clickClose);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Controls.Add(this.productAmount);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.type);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.noBranch);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.representative);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel5.Location = new System.Drawing.Point(659, 235);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(670, 156);
            this.panel5.TabIndex = 42;
            // 
            // productAmount
            // 
            this.productAmount.AutoSize = true;
            this.productAmount.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productAmount.ForeColor = System.Drawing.Color.DimGray;
            this.productAmount.Location = new System.Drawing.Point(573, 83);
            this.productAmount.Name = "productAmount";
            this.productAmount.Size = new System.Drawing.Size(30, 22);
            this.productAmount.TabIndex = 7;
            this.productAmount.Text = "33";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(358, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(209, 23);
            this.label13.TabIndex = 6;
            this.label13.Text = "SL Đơn hàng mỗi ngày:";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.type.ForeColor = System.Drawing.Color.DimGray;
            this.type.Location = new System.Drawing.Point(462, 43);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(41, 22);
            this.type.TabIndex = 5;
            this.type.Text = "Sơn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(358, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "Loại hàng:";
            // 
            // noBranch
            // 
            this.noBranch.AutoSize = true;
            this.noBranch.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noBranch.ForeColor = System.Drawing.Color.DimGray;
            this.noBranch.Location = new System.Drawing.Point(170, 84);
            this.noBranch.Name = "noBranch";
            this.noBranch.Size = new System.Drawing.Size(20, 22);
            this.noBranch.TabIndex = 3;
            this.noBranch.Text = "2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(37, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Số chi nhánh:";
            // 
            // representative
            // 
            this.representative.AutoSize = true;
            this.representative.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.representative.ForeColor = System.Drawing.Color.DimGray;
            this.representative.Location = new System.Drawing.Point(181, 44);
            this.representative.Name = "representative";
            this.representative.Size = new System.Drawing.Size(156, 22);
            this.representative.TabIndex = 1;
            this.representative.Text = "Tên người đại diện";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(37, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Người đại diện:";
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Cursor = System.Windows.Forms.Cursors.Default;
            this.location.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.location.ForeColor = System.Drawing.Color.DimGray;
            this.location.Location = new System.Drawing.Point(320, 374);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(258, 20);
            this.location.TabIndex = 41;
            this.location.Text = "Quận Bình Thạnh, TP Hồ Chí Minh";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Cursor = System.Windows.Forms.Cursors.Default;
            this.email.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.ForeColor = System.Drawing.Color.DimGray;
            this.email.Location = new System.Drawing.Point(321, 341);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(184, 20);
            this.email.TabIndex = 40;
            this.email.Text = "something@email.com";
            // 
            // contactNumber
            // 
            this.contactNumber.AutoSize = true;
            this.contactNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.contactNumber.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactNumber.ForeColor = System.Drawing.Color.DimGray;
            this.contactNumber.Location = new System.Drawing.Point(321, 310);
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.Size = new System.Drawing.Size(109, 20);
            this.contactNumber.TabIndex = 39;
            this.contactNumber.Text = "0912347825";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(282, 367);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 32);
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(281, 341);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(281, 306);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // partnerID
            // 
            this.partnerID.AutoSize = true;
            this.partnerID.Cursor = System.Windows.Forms.Cursors.Default;
            this.partnerID.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partnerID.ForeColor = System.Drawing.Color.DimGray;
            this.partnerID.Location = new System.Drawing.Point(257, 274);
            this.partnerID.Name = "partnerID";
            this.partnerID.Size = new System.Drawing.Size(101, 24);
            this.partnerID.TabIndex = 35;
            this.partnerID.Text = "Mã đối tác";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Location = new System.Drawing.Point(56, 236);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 160);
            this.panel4.TabIndex = 33;
            // 
            // partnerName
            // 
            this.partnerName.AutoSize = true;
            this.partnerName.Cursor = System.Windows.Forms.Cursors.Default;
            this.partnerName.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.partnerName.ForeColor = System.Drawing.Color.DimGray;
            this.partnerName.Location = new System.Drawing.Point(251, 236);
            this.partnerName.Name = "partnerName";
            this.partnerName.Size = new System.Drawing.Size(187, 41);
            this.partnerName.TabIndex = 34;
            this.partnerName.Text = "Tên đối tác";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(35, 436);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(446, 37);
            this.label14.TabIndex = 43;
            this.label14.Text = "Các sản phẩm thuộc đối tác này";
            // 
            // listProduct
            // 
            this.listProduct.BackgroundColor = System.Drawing.Color.White;
            this.listProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listProduct.Location = new System.Drawing.Point(35, 482);
            this.listProduct.Name = "listProduct";
            this.listProduct.RowHeadersWidth = 51;
            this.listProduct.RowTemplate.Height = 29;
            this.listProduct.Size = new System.Drawing.Size(961, 406);
            this.listProduct.TabIndex = 44;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Cursor = System.Windows.Forms.Cursors.Default;
            this.label17.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Location = new System.Drawing.Point(1226, 436);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(185, 37);
            this.label17.TabIndex = 45;
            this.label17.Text = "Bạn đã chọn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1050, 482);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(527, 344);
            this.dataGridView2.TabIndex = 46;
            // 
            // searchProduct
            // 
            this.searchProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchProduct.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchProduct.ForeColor = System.Drawing.Color.DimGray;
            this.searchProduct.Location = new System.Drawing.Point(574, 445);
            this.searchProduct.Name = "searchProduct";
            this.searchProduct.PlaceholderText = "Tìm kiếm sản phẩm...";
            this.searchProduct.Size = new System.Drawing.Size(387, 25);
            this.searchProduct.TabIndex = 48;
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.label18.Location = new System.Drawing.Point(563, 474);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(400, 2);
            this.label18.TabIndex = 47;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(967, 445);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.TabIndex = 49;
            this.pictureBox5.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.Controls.Add(this.label19);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel6.Location = new System.Drawing.Point(1154, 830);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(318, 71);
            this.panel6.TabIndex = 50;
            this.panel6.Click += new System.EventHandler(this.clickProceedOrder);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label19.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(116, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 24);
            this.label19.TabIndex = 0;
            this.label19.Text = "Đặt hàng";
            this.label19.Click += new System.EventHandler(this.clickProceedOrder);
            // 
            // CustomerOrderProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.searchProduct);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.listProduct);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.location);
            this.Controls.Add(this.email);
            this.Controls.Add(this.contactNumber);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.partnerID);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.partnerName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerOrderProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerOrderProduct";
            this.Load += new System.EventHandler(this.CustomerOrderProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label productAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label noBranch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label representative;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label contactNumber;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label partnerID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label partnerName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView listProduct;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox searchProduct;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label19;
    }
}