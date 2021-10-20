
namespace QuanLyBanHangApp
{
    partial class XoaHD
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_hd = new System.Windows.Forms.DataGridView();
            this.tb_maHD = new System.Windows.Forms.TextBox();
            this.bt_xacnhan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InfoCTHDXoaHD = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hd)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoCTHDXoaHD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_hd);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(488, 458);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // dgv_hd
            // 
            this.dgv_hd.AllowUserToAddRows = false;
            this.dgv_hd.AllowUserToDeleteRows = false;
            this.dgv_hd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hd.Location = new System.Drawing.Point(6, 26);
            this.dgv_hd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_hd.Name = "dgv_hd";
            this.dgv_hd.ReadOnly = true;
            this.dgv_hd.RowHeadersWidth = 51;
            this.dgv_hd.RowTemplate.Height = 24;
            this.dgv_hd.Size = new System.Drawing.Size(476, 424);
            this.dgv_hd.TabIndex = 0;
            this.dgv_hd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hd_CellClick);
            // 
            // tb_maHD
            // 
            this.tb_maHD.Location = new System.Drawing.Point(339, 481);
            this.tb_maHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_maHD.MaxLength = 6;
            this.tb_maHD.Name = "tb_maHD";
            this.tb_maHD.PlaceholderText = "Nhập Mã hóa đơn hoặc Mã khách hàng";
            this.tb_maHD.Size = new System.Drawing.Size(431, 27);
            this.tb_maHD.TabIndex = 2;
            this.tb_maHD.TextChanged += new System.EventHandler(this.tb_maHD_TextChanged);
            // 
            // bt_xacnhan
            // 
            this.bt_xacnhan.Location = new System.Drawing.Point(776, 477);
            this.bt_xacnhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_xacnhan.Name = "bt_xacnhan";
            this.bt_xacnhan.Size = new System.Drawing.Size(114, 34);
            this.bt_xacnhan.TabIndex = 4;
            this.bt_xacnhan.Text = "Xóa";
            this.bt_xacnhan.UseVisualStyleBackColor = true;
            this.bt_xacnhan.Click += new System.EventHandler(this.bt_xacnhan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.InfoCTHDXoaHD);
            this.groupBox2.Location = new System.Drawing.Point(506, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 459);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết Hóa Đơn";
            // 
            // InfoCTHDXoaHD
            // 
            this.InfoCTHDXoaHD.AllowUserToAddRows = false;
            this.InfoCTHDXoaHD.AllowUserToDeleteRows = false;
            this.InfoCTHDXoaHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfoCTHDXoaHD.Location = new System.Drawing.Point(6, 28);
            this.InfoCTHDXoaHD.Name = "InfoCTHDXoaHD";
            this.InfoCTHDXoaHD.ReadOnly = true;
            this.InfoCTHDXoaHD.RowHeadersWidth = 51;
            this.InfoCTHDXoaHD.RowTemplate.Height = 29;
            this.InfoCTHDXoaHD.Size = new System.Drawing.Size(721, 422);
            this.InfoCTHDXoaHD.TabIndex = 0;
            // 
            // XoaHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 521);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bt_xacnhan);
            this.Controls.Add(this.tb_maHD);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XoaHD";
            this.Text = "Xóa Hóa Đơn";
            this.Load += new System.EventHandler(this.XoaHD_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InfoCTHDXoaHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_hd;
        private System.Windows.Forms.TextBox tb_maHD;
        private System.Windows.Forms.Button bt_xacnhan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView InfoCTHDXoaHD;
    }
}