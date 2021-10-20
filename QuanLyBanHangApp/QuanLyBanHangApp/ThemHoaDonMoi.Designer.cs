
namespace QuanLyBanHangApp
{
    partial class ThemHoaDonMoi
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tb_maHD = new System.Windows.Forms.TextBox();
            this.tb_maKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_ngaylap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InfoKhachHangThemHD = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoKhachHangThemHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(382, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Hóa Đơn Mới";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.tb_maHD);
            this.groupBox1.Controls.Add(this.tb_maKH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(897, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hóa Đơn Mới";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(320, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "Randomize";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tb_maHD
            // 
            this.tb_maHD.Location = new System.Drawing.Point(147, 39);
            this.tb_maHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_maHD.MaxLength = 6;
            this.tb_maHD.Name = "tb_maHD";
            this.tb_maHD.PlaceholderText = "Nhập Mã tùy ý";
            this.tb_maHD.Size = new System.Drawing.Size(167, 27);
            this.tb_maHD.TabIndex = 1;
            // 
            // tb_maKH
            // 
            this.tb_maKH.Location = new System.Drawing.Point(608, 39);
            this.tb_maKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_maKH.MaxLength = 7;
            this.tb_maKH.Name = "tb_maKH";
            this.tb_maKH.PlaceholderText = "Nhập mã hoặc họ tên khách hàng...";
            this.tb_maKH.Size = new System.Drawing.Size(271, 27);
            this.tb_maKH.TabIndex = 1;
            this.tb_maKH.TextChanged += new System.EventHandler(this.tb_maKH_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Hóa Đơn";
            // 
            // dt_ngaylap
            // 
            this.dt_ngaylap.CustomFormat = "MM/dd/yyyy";
            this.dt_ngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngaylap.Location = new System.Drawing.Point(159, 422);
            this.dt_ngaylap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dt_ngaylap.Name = "dt_ngaylap";
            this.dt_ngaylap.Size = new System.Drawing.Size(128, 27);
            this.dt_ngaylap.TabIndex = 2;
            this.dt_ngaylap.Value = new System.DateTime(2021, 10, 20, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Lập";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(610, 419);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm Hóa Đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(788, 419);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.InfoKhachHangThemHD);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(897, 241);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Khách Hàng";
            // 
            // InfoKhachHangThemHD
            // 
            this.InfoKhachHangThemHD.AllowUserToAddRows = false;
            this.InfoKhachHangThemHD.AllowUserToDeleteRows = false;
            this.InfoKhachHangThemHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfoKhachHangThemHD.Location = new System.Drawing.Point(6, 26);
            this.InfoKhachHangThemHD.Name = "InfoKhachHangThemHD";
            this.InfoKhachHangThemHD.ReadOnly = true;
            this.InfoKhachHangThemHD.RowHeadersWidth = 51;
            this.InfoKhachHangThemHD.RowTemplate.Height = 29;
            this.InfoKhachHangThemHD.Size = new System.Drawing.Size(885, 209);
            this.InfoKhachHangThemHD.TabIndex = 0;
            this.InfoKhachHangThemHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InfoKhachHangThemHD_CellClick);
            // 
            // ThemHoaDonMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 469);
            this.Controls.Add(this.dt_ngaylap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ThemHoaDonMoi";
            this.Text = "Thêm Hóa Đơn Mới";
            this.Load += new System.EventHandler(this.ThemHoaDonMoi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InfoKhachHangThemHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_maHD;
        private System.Windows.Forms.TextBox tb_maKH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dt_ngaylap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView InfoKhachHangThemHD;
        private System.Windows.Forms.Button button3;
    }
}