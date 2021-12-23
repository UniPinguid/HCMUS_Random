
namespace RandomApp
{
    partial class CustomerTrackOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerTrackOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.listOrder = new System.Windows.Forms.DataGridView();
            this.dateOrdered = new System.Windows.Forms.Label();
            this.orderID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.partnerID = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.refreshLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOrder)).BeginInit();
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
            this.panel1.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(56, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(480, 65);
            this.label16.TabIndex = 15;
            this.label16.Text = "Theo dõi đơn hàng";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Roboto Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(665, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(440, 56);
            this.label15.TabIndex = 2;
            this.label15.Text = "Xem danh sách các đơn hàng mình đã đặt\r\nvà theo dõi tình trạng đơn hàng";
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(35, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(405, 37);
            this.label14.TabIndex = 44;
            this.label14.Text = "Danh sách đơn hàng của bạn";
            // 
            // listOrder
            // 
            this.listOrder.AllowUserToAddRows = false;
            this.listOrder.AllowUserToDeleteRows = false;
            this.listOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listOrder.BackgroundColor = System.Drawing.Color.White;
            this.listOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOrder.Location = new System.Drawing.Point(35, 270);
            this.listOrder.Name = "listOrder";
            this.listOrder.ReadOnly = true;
            this.listOrder.RowHeadersWidth = 51;
            this.listOrder.RowTemplate.Height = 29;
            this.listOrder.Size = new System.Drawing.Size(913, 608);
            this.listOrder.TabIndex = 45;
            this.listOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickCellOrder);
            // 
            // dateOrdered
            // 
            this.dateOrdered.AutoSize = true;
            this.dateOrdered.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateOrdered.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateOrdered.ForeColor = System.Drawing.Color.DimGray;
            this.dateOrdered.Location = new System.Drawing.Point(1147, 310);
            this.dateOrdered.Name = "dateOrdered";
            this.dateOrdered.Size = new System.Drawing.Size(103, 20);
            this.dateOrdered.TabIndex = 54;
            this.dateOrdered.Text = "01/01/1999";
            // 
            // orderID
            // 
            this.orderID.AutoSize = true;
            this.orderID.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderID.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderID.ForeColor = System.Drawing.Color.DimGray;
            this.orderID.Location = new System.Drawing.Point(986, 228);
            this.orderID.Name = "orderID";
            this.orderID.Size = new System.Drawing.Size(217, 41);
            this.orderID.TabIndex = 49;
            this.orderID.Text = "Mã đơn hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(1015, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 57;
            this.label7.Text = "Ngày đặt hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(1015, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "Địa chỉ giao hàng:";
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Cursor = System.Windows.Forms.Cursors.Default;
            this.location.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.location.ForeColor = System.Drawing.Color.DimGray;
            this.location.Location = new System.Drawing.Point(1033, 371);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(441, 20);
            this.location.TabIndex = 58;
            this.location.Text = "Đường Hàm Nghi, huyện Trần Phú, quận 9, TP Hồ Chí Minh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(1017, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 20);
            this.label9.TabIndex = 62;
            this.label9.Text = "Hình thức thanh toán:";
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Cursor = System.Windows.Forms.Cursors.Default;
            this.payment.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.payment.ForeColor = System.Drawing.Color.DimGray;
            this.payment.Location = new System.Drawing.Point(1196, 413);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(75, 20);
            this.payment.TabIndex = 61;
            this.payment.Text = "Tiền mặt";
            // 
            // status
            // 
            this.status.Cursor = System.Windows.Forms.Cursors.Default;
            this.status.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.status.ForeColor = System.Drawing.Color.DimGray;
            this.status.Location = new System.Drawing.Point(1306, 262);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(266, 20);
            this.status.TabIndex = 63;
            this.status.Text = "Đang vận chuyển";
            this.status.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.Controls.Add(this.label23);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel6.Location = new System.Drawing.Point(1127, 466);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(331, 72);
            this.panel6.TabIndex = 112;
            this.panel6.Click += new System.EventHandler(this.clickDetails);
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
            this.label23.Click += new System.EventHandler(this.clickDetails);
            // 
            // partnerID
            // 
            this.partnerID.AutoSize = true;
            this.partnerID.Cursor = System.Windows.Forms.Cursors.Default;
            this.partnerID.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partnerID.ForeColor = System.Drawing.Color.DimGray;
            this.partnerID.Location = new System.Drawing.Point(991, 266);
            this.partnerID.Name = "partnerID";
            this.partnerID.Size = new System.Drawing.Size(88, 20);
            this.partnerID.TabIndex = 113;
            this.partnerID.Text = "Mã đối tác";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(845, 231);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(32, 32);
            this.panel4.TabIndex = 114;
            this.panel4.Click += new System.EventHandler(this.clickRefresh);
            // 
            // refreshLabel
            // 
            this.refreshLabel.AutoSize = true;
            this.refreshLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refreshLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.refreshLabel.Location = new System.Drawing.Point(885, 236);
            this.refreshLabel.Name = "refreshLabel";
            this.refreshLabel.Size = new System.Drawing.Size(63, 24);
            this.refreshLabel.TabIndex = 115;
            this.refreshLabel.Text = "Tải lại";
            this.refreshLabel.Click += new System.EventHandler(this.clickRefresh);
            // 
            // CustomerTrackOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.refreshLabel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.partnerID);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.location);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateOrdered);
            this.Controls.Add(this.orderID);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerTrackOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerTrackOrder";
            this.Load += new System.EventHandler(this.CustomerTrackOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOrder)).EndInit();
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
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView listOrder;
        private System.Windows.Forms.Label dateOrdered;
        private System.Windows.Forms.Label orderID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label payment;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label partnerID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label refreshLabel;
    }
}