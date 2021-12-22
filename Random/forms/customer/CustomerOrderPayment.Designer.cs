
namespace RandomApp
{
    partial class CustomerOrderPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOrderPayment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.locationInput = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.myOrder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.checkPayment0 = new System.Windows.Forms.CheckBox();
            this.checkPayment1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.subTotal = new System.Windows.Forms.Label();
            this.shippingFee = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myOrder)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(-20, -25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1643, 240);
            this.panel1.TabIndex = 4;
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
            this.label15.Size = new System.Drawing.Size(253, 56);
            this.label15.TabIndex = 2;
            this.label15.Text = "Kiểm tra lại đơn hàng\r\nrồi tiến hành thanh toán";
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
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.locationInput);
            this.panel4.Location = new System.Drawing.Point(46, 227);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1501, 70);
            this.panel4.TabIndex = 5;
            // 
            // locationInput
            // 
            this.locationInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.locationInput.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.locationInput.ForeColor = System.Drawing.Color.DimGray;
            this.locationInput.Location = new System.Drawing.Point(41, 33);
            this.locationInput.MaxLength = 50;
            this.locationInput.Name = "locationInput";
            this.locationInput.PlaceholderText = "Vui lòng nhập địa chỉ nhận hàng...";
            this.locationInput.Size = new System.Drawing.Size(1438, 25);
            this.locationInput.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(26, 320);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(231, 33);
            this.label14.TabIndex = 44;
            this.label14.Text = "Đơn hàng của bạn";
            // 
            // myOrder
            // 
            this.myOrder.AllowUserToAddRows = false;
            this.myOrder.AllowUserToDeleteRows = false;
            this.myOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.myOrder.BackgroundColor = System.Drawing.Color.White;
            this.myOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myOrder.Location = new System.Drawing.Point(31, 359);
            this.myOrder.Name = "myOrder";
            this.myOrder.ReadOnly = true;
            this.myOrder.RowHeadersWidth = 51;
            this.myOrder.RowTemplate.Height = 29;
            this.myOrder.Size = new System.Drawing.Size(1535, 320);
            this.myOrder.TabIndex = 45;
            this.myOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickProductCell);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(36, 692);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 33);
            this.label1.TabIndex = 46;
            this.label1.Text = "Chọn hình thức thanh toán";
            // 
            // checkPayment0
            // 
            this.checkPayment0.BackColor = System.Drawing.Color.Transparent;
            this.checkPayment0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkPayment0.BackgroundImage")));
            this.checkPayment0.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkPayment0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkPayment0.Location = new System.Drawing.Point(46, 732);
            this.checkPayment0.Name = "checkPayment0";
            this.checkPayment0.Size = new System.Drawing.Size(211, 130);
            this.checkPayment0.TabIndex = 47;
            this.checkPayment0.UseVisualStyleBackColor = false;
            // 
            // checkPayment1
            // 
            this.checkPayment1.BackColor = System.Drawing.Color.Transparent;
            this.checkPayment1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkPayment1.BackgroundImage")));
            this.checkPayment1.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkPayment1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkPayment1.Location = new System.Drawing.Point(274, 732);
            this.checkPayment1.Name = "checkPayment1";
            this.checkPayment1.Size = new System.Drawing.Size(211, 130);
            this.checkPayment1.TabIndex = 48;
            this.checkPayment1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1307, 706);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 50;
            this.label3.Text = "Tổng";
            // 
            // subTotal
            // 
            this.subTotal.AutoSize = true;
            this.subTotal.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.subTotal.Location = new System.Drawing.Point(1473, 706);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(93, 23);
            this.subTotal.TabIndex = 51;
            this.subTotal.Text = "200,000đ";
            this.subTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // shippingFee
            // 
            this.shippingFee.AutoSize = true;
            this.shippingFee.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.shippingFee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.shippingFee.Location = new System.Drawing.Point(1489, 735);
            this.shippingFee.Name = "shippingFee";
            this.shippingFee.Size = new System.Drawing.Size(75, 23);
            this.shippingFee.TabIndex = 53;
            this.shippingFee.Text = "20,000đ";
            this.shippingFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1225, 735);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 23);
            this.label6.TabIndex = 52;
            this.label6.Text = "Phí vận chuyển";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.total.ForeColor = System.Drawing.Color.DodgerBlue;
            this.total.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.total.Location = new System.Drawing.Point(1448, 774);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(118, 29);
            this.total.TabIndex = 55;
            this.total.Text = "220,000đ";
            this.total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(1258, 781);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 23);
            this.label8.TabIndex = 54;
            this.label8.Text = "Thành tiền";
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.Controls.Add(this.label9);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel6.Location = new System.Drawing.Point(1243, 819);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(321, 66);
            this.panel6.TabIndex = 51;
            this.panel6.Click += new System.EventHandler(this.clickSubmit);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(112, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 24);
            this.label9.TabIndex = 50;
            this.label9.Text = "Mua hàng";
            this.label9.Click += new System.EventHandler(this.clickSubmit);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(587, 769);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(515, 48);
            this.label10.TabIndex = 56;
            this.label10.Text = "Trước khi xác nhận mua hàng, quý khách hàng vui lòng kiểm tra lại địa chỉ giao hà" +
    "ng, số lượng của sản phẩm và giá tiền hợp lý";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(1342, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 24);
            this.label2.TabIndex = 58;
            this.label2.Text = "Xóa sản phẩm chọn";
            this.label2.Click += new System.EventHandler(this.clickRemove);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1533, 322);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.TabIndex = 57;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.clickRemove);
            // 
            // CustomerOrderPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.shippingFee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.subTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkPayment1);
            this.Controls.Add(this.checkPayment0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myOrder);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerOrderPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerOrderPayment";
            this.Load += new System.EventHandler(this.CustomerOrderPayment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myOrder)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox locationInput;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView myOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkPayment0;
        private System.Windows.Forms.CheckBox checkPayment1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label subTotal;
        private System.Windows.Forms.Label shippingFee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}