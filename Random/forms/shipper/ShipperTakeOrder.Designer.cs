
namespace Random
{
    partial class ShipperTakeOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipperTakeOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.searchOrder = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.listPendingOrder = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateOrdered = new System.Windows.Forms.Label();
            this.customerID = new System.Windows.Forms.Label();
            this.orderID = new System.Windows.Forms.Label();
            this.partnerID = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPendingOrder)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Random.Properties.Resources.title_bar;
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(-20, -25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1643, 240);
            this.panel1.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(56, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(396, 65);
            this.label16.TabIndex = 15;
            this.label16.Text = "Nhận đơn hàng";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Roboto Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(544, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(314, 56);
            this.label15.TabIndex = 2;
            this.label15.Text = "Xem danh sách các đơn hàng\r\nvà tiếp nhận đơn hàng";
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
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1079, 232);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.clickSearch);
            // 
            // searchOrder
            // 
            this.searchOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchOrder.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchOrder.ForeColor = System.Drawing.Color.DimGray;
            this.searchOrder.Location = new System.Drawing.Point(44, 232);
            this.searchOrder.Name = "searchOrder";
            this.searchOrder.PlaceholderText = "Tìm kiếm đơn hàng...";
            this.searchOrder.Size = new System.Drawing.Size(1017, 25);
            this.searchOrder.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Location = new System.Drawing.Point(31, 261);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1030, 2);
            this.label14.TabIndex = 19;
            // 
            // listPendingOrder
            // 
            this.listPendingOrder.BackgroundColor = System.Drawing.Color.White;
            this.listPendingOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listPendingOrder.Location = new System.Drawing.Point(30, 270);
            this.listPendingOrder.Name = "listPendingOrder";
            this.listPendingOrder.RowHeadersWidth = 51;
            this.listPendingOrder.RowTemplate.Height = 29;
            this.listPendingOrder.Size = new System.Drawing.Size(1081, 591);
            this.listPendingOrder.TabIndex = 18;
            this.listPendingOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickCellOrder);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(1173, 456);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 20);
            this.label9.TabIndex = 72;
            this.label9.Text = "Hình thức thanh toán:";
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Cursor = System.Windows.Forms.Cursors.Default;
            this.payment.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.payment.ForeColor = System.Drawing.Color.DimGray;
            this.payment.Location = new System.Drawing.Point(1352, 456);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(75, 20);
            this.payment.TabIndex = 71;
            this.payment.Text = "Tiền mặt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(1171, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "Địa chỉ giao hàng:";
            // 
            // location
            // 
            this.location.Cursor = System.Windows.Forms.Cursors.Default;
            this.location.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.location.ForeColor = System.Drawing.Color.DimGray;
            this.location.Location = new System.Drawing.Point(1189, 403);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(367, 42);
            this.location.TabIndex = 68;
            this.location.Text = "Đường Hàm Nghi, huyện Trần Phú, quận 9, TP Hồ Chí Minh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(1171, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 67;
            this.label7.Text = "Ngày đặt hàng:";
            // 
            // dateOrdered
            // 
            this.dateOrdered.AutoSize = true;
            this.dateOrdered.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateOrdered.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateOrdered.ForeColor = System.Drawing.Color.DimGray;
            this.dateOrdered.Location = new System.Drawing.Point(1303, 342);
            this.dateOrdered.Name = "dateOrdered";
            this.dateOrdered.Size = new System.Drawing.Size(103, 20);
            this.dateOrdered.TabIndex = 66;
            this.dateOrdered.Text = "01/01/1999";
            // 
            // customerID
            // 
            this.customerID.AutoSize = true;
            this.customerID.Cursor = System.Windows.Forms.Cursors.Default;
            this.customerID.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerID.ForeColor = System.Drawing.Color.DimGray;
            this.customerID.Location = new System.Drawing.Point(1452, 246);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(121, 20);
            this.customerID.TabIndex = 65;
            this.customerID.Text = "Mã khách hàng";
            // 
            // orderID
            // 
            this.orderID.AutoSize = true;
            this.orderID.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderID.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderID.ForeColor = System.Drawing.Color.DimGray;
            this.orderID.Location = new System.Drawing.Point(1144, 232);
            this.orderID.Name = "orderID";
            this.orderID.Size = new System.Drawing.Size(217, 41);
            this.orderID.TabIndex = 64;
            this.orderID.Text = "Mã đơn hàng";
            // 
            // partnerID
            // 
            this.partnerID.AutoSize = true;
            this.partnerID.Cursor = System.Windows.Forms.Cursors.Default;
            this.partnerID.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partnerID.ForeColor = System.Drawing.Color.DimGray;
            this.partnerID.Location = new System.Drawing.Point(1486, 267);
            this.partnerID.Name = "partnerID";
            this.partnerID.Size = new System.Drawing.Size(88, 20);
            this.partnerID.TabIndex = 79;
            this.partnerID.Text = "Mã đối tác";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Cursor = System.Windows.Forms.Cursors.Default;
            this.label22.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.ForeColor = System.Drawing.Color.DimGray;
            this.label22.Location = new System.Drawing.Point(1147, 270);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(145, 24);
            this.label22.TabIndex = 86;
            this.label22.Text = "Tên người dùng";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.label23);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(1205, 500);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(331, 72);
            this.panel4.TabIndex = 87;
            this.panel4.Click += new System.EventHandler(this.clickOrderDetails);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label23.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label23.Location = new System.Drawing.Point(63, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(207, 24);
            this.label23.TabIndex = 0;
            this.label23.Text = "Xem chi tiết đơn hàng";
            this.label23.Click += new System.EventHandler(this.clickOrderDetails);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Controls.Add(this.label24);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Location = new System.Drawing.Point(1205, 807);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(318, 67);
            this.panel5.TabIndex = 88;
            this.panel5.Click += new System.EventHandler(this.clickTakeOrder);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label24.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(65, 22);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(188, 24);
            this.label24.TabIndex = 0;
            this.label24.Text = "Tiếp nhận đơn hàng";
            this.label24.Click += new System.EventHandler(this.clickTakeOrder);
            // 
            // ShipperTakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.partnerID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.location);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateOrdered);
            this.Controls.Add(this.customerID);
            this.Controls.Add(this.orderID);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.searchOrder);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.listPendingOrder);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShipperTakeOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShipperTakeOrder";
            this.Load += new System.EventHandler(this.ShipperTakeOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPendingOrder)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox searchOrder;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView listPendingOrder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label payment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dateOrdered;
        private System.Windows.Forms.Label customerID;
        private System.Windows.Forms.Label orderID;
        private System.Windows.Forms.Label partnerID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label24;
    }
}