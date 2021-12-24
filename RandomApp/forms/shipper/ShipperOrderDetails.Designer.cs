
namespace RandomApp
{
    partial class ShipperOrderDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipperOrderDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.total = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.shippingFee = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.subTotal = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.totalAmount = new System.Windows.Forms.Label();
            this.listDetails = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orderIDLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.orderIDLabel);
            this.panel1.Controls.Add(this.total);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.shippingFee);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.subTotal);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.totalAmount);
            this.panel1.Controls.Add(this.listDetails);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-20, -21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 924);
            this.panel1.TabIndex = 0;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.total.ForeColor = System.Drawing.Color.DodgerBlue;
            this.total.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.total.Location = new System.Drawing.Point(637, 743);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(118, 29);
            this.total.TabIndex = 108;
            this.total.Text = "220,000đ";
            this.total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(447, 750);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 23);
            this.label8.TabIndex = 107;
            this.label8.Text = "Thành tiền";
            // 
            // shippingFee
            // 
            this.shippingFee.AutoSize = true;
            this.shippingFee.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.shippingFee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.shippingFee.Location = new System.Drawing.Point(678, 704);
            this.shippingFee.Name = "shippingFee";
            this.shippingFee.Size = new System.Drawing.Size(75, 23);
            this.shippingFee.TabIndex = 106;
            this.shippingFee.Text = "20,000đ";
            this.shippingFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(414, 704);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 23);
            this.label12.TabIndex = 105;
            this.label12.Text = "Phí vận chuyển";
            // 
            // subTotal
            // 
            this.subTotal.AutoSize = true;
            this.subTotal.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.subTotal.Location = new System.Drawing.Point(662, 675);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(93, 23);
            this.subTotal.TabIndex = 104;
            this.subTotal.Text = "200,000đ";
            this.subTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(496, 675);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 23);
            this.label17.TabIndex = 103;
            this.label17.Text = "Tổng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(513, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 20);
            this.label7.TabIndex = 69;
            this.label7.Text = "Tổng số lượng mặt hàng:";
            // 
            // totalAmount
            // 
            this.totalAmount.AutoSize = true;
            this.totalAmount.Cursor = System.Windows.Forms.Cursors.Default;
            this.totalAmount.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalAmount.ForeColor = System.Drawing.Color.DimGray;
            this.totalAmount.Location = new System.Drawing.Point(729, 212);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(29, 20);
            this.totalAmount.TabIndex = 68;
            this.totalAmount.Text = "12";
            this.totalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listDetails
            // 
            this.listDetails.AllowUserToAddRows = false;
            this.listDetails.AllowUserToDeleteRows = false;
            this.listDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listDetails.BackgroundColor = System.Drawing.Color.White;
            this.listDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listDetails.Location = new System.Drawing.Point(46, 243);
            this.listDetails.Name = "listDetails";
            this.listDetails.ReadOnly = true;
            this.listDetails.RowHeadersWidth = 51;
            this.listDetails.RowTemplate.Height = 29;
            this.listDetails.Size = new System.Drawing.Size(709, 418);
            this.listDetails.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(728, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 40);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.clickClose);
            // 
            // orderIDLabel
            // 
            this.orderIDLabel.AutoSize = true;
            this.orderIDLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderIDLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderIDLabel.ForeColor = System.Drawing.Color.DimGray;
            this.orderIDLabel.Location = new System.Drawing.Point(46, 202);
            this.orderIDLabel.Name = "orderIDLabel";
            this.orderIDLabel.Size = new System.Drawing.Size(174, 33);
            this.orderIDLabel.TabIndex = 109;
            this.orderIDLabel.Text = "Mã đơn hàng";
            // 
            // ShipperOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 779);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShipperOrderDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShipperTakeOrderDetails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView listDetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label totalAmount;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label shippingFee;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label subTotal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label orderIDLabel;
    }
}