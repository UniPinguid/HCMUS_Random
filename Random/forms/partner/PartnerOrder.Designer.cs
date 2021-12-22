
namespace RandomApp
{
    partial class PartnerOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartnerOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listOrder = new System.Windows.Forms.DataGridView();
            this.searchOrder = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.checkStatus1 = new System.Windows.Forms.CheckBox();
            this.checkStatus2 = new System.Windows.Forms.CheckBox();
            this.checkStatus3 = new System.Windows.Forms.CheckBox();
            this.checkStatus4 = new System.Windows.Forms.CheckBox();
            this.checkStatus5 = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateOrdered = new System.Windows.Forms.Label();
            this.customerID = new System.Windows.Forms.Label();
            this.orderID = new System.Windows.Forms.Label();
            this.refreshLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel5.SuspendLayout();
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
            this.panel1.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(56, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(258, 65);
            this.label16.TabIndex = 15;
            this.label16.Text = "Đơn hàng";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Roboto Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(461, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(405, 56);
            this.label15.TabIndex = 2;
            this.label15.Text = "Xem danh sách các đơn hàng\r\nvà cập nhật lại tình trạng của đơn hàng";
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
            // listOrder
            // 
            this.listOrder.AllowUserToAddRows = false;
            this.listOrder.AllowUserToDeleteRows = false;
            this.listOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listOrder.BackgroundColor = System.Drawing.Color.White;
            this.listOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOrder.Location = new System.Drawing.Point(35, 283);
            this.listOrder.Name = "listOrder";
            this.listOrder.ReadOnly = true;
            this.listOrder.RowHeadersWidth = 51;
            this.listOrder.RowTemplate.Height = 29;
            this.listOrder.Size = new System.Drawing.Size(1062, 591);
            this.listOrder.TabIndex = 2;
            this.listOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickCellOrder);
            // 
            // searchOrder
            // 
            this.searchOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchOrder.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchOrder.ForeColor = System.Drawing.Color.DimGray;
            this.searchOrder.Location = new System.Drawing.Point(49, 245);
            this.searchOrder.Name = "searchOrder";
            this.searchOrder.PlaceholderText = "Tìm kiếm đơn hàng...";
            this.searchOrder.Size = new System.Drawing.Size(1007, 25);
            this.searchOrder.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Location = new System.Drawing.Point(36, 274);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(830, 2);
            this.label14.TabIndex = 15;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(874, 244);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.clickSearch);
            // 
            // checkStatus1
            // 
            this.checkStatus1.AutoSize = true;
            this.checkStatus1.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkStatus1.Image = ((System.Drawing.Image)(resources.GetObject("checkStatus1.Image")));
            this.checkStatus1.Location = new System.Drawing.Point(1153, 756);
            this.checkStatus1.Name = "checkStatus1";
            this.checkStatus1.Size = new System.Drawing.Size(72, 53);
            this.checkStatus1.TabIndex = 25;
            this.checkStatus1.UseVisualStyleBackColor = true;
            // 
            // checkStatus2
            // 
            this.checkStatus2.AutoSize = true;
            this.checkStatus2.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkStatus2.Image = ((System.Drawing.Image)(resources.GetObject("checkStatus2.Image")));
            this.checkStatus2.Location = new System.Drawing.Point(1241, 756);
            this.checkStatus2.Name = "checkStatus2";
            this.checkStatus2.Size = new System.Drawing.Size(71, 54);
            this.checkStatus2.TabIndex = 26;
            this.checkStatus2.UseVisualStyleBackColor = true;
            // 
            // checkStatus3
            // 
            this.checkStatus3.AutoSize = true;
            this.checkStatus3.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkStatus3.Image = ((System.Drawing.Image)(resources.GetObject("checkStatus3.Image")));
            this.checkStatus3.Location = new System.Drawing.Point(1335, 756);
            this.checkStatus3.Name = "checkStatus3";
            this.checkStatus3.Size = new System.Drawing.Size(72, 54);
            this.checkStatus3.TabIndex = 27;
            this.checkStatus3.UseVisualStyleBackColor = true;
            // 
            // checkStatus4
            // 
            this.checkStatus4.AutoSize = true;
            this.checkStatus4.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkStatus4.Image = ((System.Drawing.Image)(resources.GetObject("checkStatus4.Image")));
            this.checkStatus4.Location = new System.Drawing.Point(1422, 756);
            this.checkStatus4.Name = "checkStatus4";
            this.checkStatus4.Size = new System.Drawing.Size(71, 53);
            this.checkStatus4.TabIndex = 28;
            this.checkStatus4.UseVisualStyleBackColor = true;
            // 
            // checkStatus5
            // 
            this.checkStatus5.AutoSize = true;
            this.checkStatus5.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkStatus5.Image = ((System.Drawing.Image)(resources.GetObject("checkStatus5.Image")));
            this.checkStatus5.Location = new System.Drawing.Point(1505, 756);
            this.checkStatus5.Name = "checkStatus5";
            this.checkStatus5.Size = new System.Drawing.Size(72, 53);
            this.checkStatus5.TabIndex = 29;
            this.checkStatus5.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Controls.Add(this.label4);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Location = new System.Drawing.Point(1202, 817);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(333, 72);
            this.panel5.TabIndex = 30;
            this.panel5.Click += new System.EventHandler(this.clickUpdateOrder);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cập nhật đơn hàng";
            this.label4.Click += new System.EventHandler(this.clickUpdateOrder);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(1234, 688);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 37);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cập nhật đơn hàng";
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.Controls.Add(this.label23);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel6.Location = new System.Drawing.Point(1197, 535);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(331, 72);
            this.panel6.TabIndex = 113;
            this.panel6.Click += new System.EventHandler(this.clickOrderDetails);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(1153, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 20);
            this.label9.TabIndex = 121;
            this.label9.Text = "Hình thức thanh toán:";
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Cursor = System.Windows.Forms.Cursors.Default;
            this.payment.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.payment.ForeColor = System.Drawing.Color.DimGray;
            this.payment.Location = new System.Drawing.Point(1332, 438);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(75, 20);
            this.payment.TabIndex = 120;
            this.payment.Text = "Tiền mặt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(1151, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 119;
            this.label2.Text = "Địa chỉ giao hàng:";
            // 
            // location
            // 
            this.location.Cursor = System.Windows.Forms.Cursors.Default;
            this.location.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.location.ForeColor = System.Drawing.Color.DimGray;
            this.location.Location = new System.Drawing.Point(1169, 385);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(367, 42);
            this.location.TabIndex = 118;
            this.location.Text = "Đường Hàm Nghi, huyện Trần Phú, quận 9, TP Hồ Chí Minh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(1151, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 117;
            this.label7.Text = "Ngày đặt hàng:";
            // 
            // dateOrdered
            // 
            this.dateOrdered.AutoSize = true;
            this.dateOrdered.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateOrdered.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateOrdered.ForeColor = System.Drawing.Color.DimGray;
            this.dateOrdered.Location = new System.Drawing.Point(1283, 324);
            this.dateOrdered.Name = "dateOrdered";
            this.dateOrdered.Size = new System.Drawing.Size(103, 20);
            this.dateOrdered.TabIndex = 116;
            this.dateOrdered.Text = "01/01/1999";
            // 
            // customerID
            // 
            this.customerID.AutoSize = true;
            this.customerID.Cursor = System.Windows.Forms.Cursors.Default;
            this.customerID.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerID.ForeColor = System.Drawing.Color.DimGray;
            this.customerID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerID.Location = new System.Drawing.Point(1130, 274);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(121, 20);
            this.customerID.TabIndex = 115;
            this.customerID.Text = "Mã khách hàng";
            this.customerID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderID
            // 
            this.orderID.AutoSize = true;
            this.orderID.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderID.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderID.ForeColor = System.Drawing.Color.DimGray;
            this.orderID.Location = new System.Drawing.Point(1124, 235);
            this.orderID.Name = "orderID";
            this.orderID.Size = new System.Drawing.Size(217, 41);
            this.orderID.TabIndex = 114;
            this.orderID.Text = "Mã đơn hàng";
            // 
            // refreshLabel
            // 
            this.refreshLabel.AutoSize = true;
            this.refreshLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refreshLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.refreshLabel.Location = new System.Drawing.Point(1035, 250);
            this.refreshLabel.Name = "refreshLabel";
            this.refreshLabel.Size = new System.Drawing.Size(63, 24);
            this.refreshLabel.TabIndex = 123;
            this.refreshLabel.Text = "Tải lại";
            this.refreshLabel.Click += new System.EventHandler(this.clickRefresh);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(995, 245);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(32, 32);
            this.panel4.TabIndex = 122;
            this.panel4.Click += new System.EventHandler(this.clickRefresh);
            // 
            // PartnerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.refreshLabel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.location);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateOrdered);
            this.Controls.Add(this.customerID);
            this.Controls.Add(this.orderID);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.checkStatus5);
            this.Controls.Add(this.checkStatus4);
            this.Controls.Add(this.checkStatus3);
            this.Controls.Add(this.checkStatus2);
            this.Controls.Add(this.checkStatus1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.searchOrder);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PartnerOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartnerOrder";
            this.Load += new System.EventHandler(this.PartnerOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.DataGridView listOrder;
        private System.Windows.Forms.TextBox searchOrder;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.CheckBox checkStatus1;
        private System.Windows.Forms.CheckBox checkStatus2;
        private System.Windows.Forms.CheckBox checkStatus3;
        private System.Windows.Forms.CheckBox checkStatus4;
        private System.Windows.Forms.CheckBox checkStatus5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label payment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dateOrdered;
        private System.Windows.Forms.Label customerID;
        private System.Windows.Forms.Label orderID;
        private System.Windows.Forms.Label refreshLabel;
        private System.Windows.Forms.Panel panel4;
    }
}