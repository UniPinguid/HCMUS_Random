
namespace RandomApp
{
    partial class CreateContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateContract));
            this.panel1 = new System.Windows.Forms.Panel();
            this.branchList = new System.Windows.Forms.DataGridView();
            this.SoChiNhanh = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.UName = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.branchList);
            this.panel1.Controls.Add(this.SoChiNhanh);
            this.panel1.Controls.Add(this.Address);
            this.panel1.Controls.Add(this.UName);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-21, -45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 928);
            this.panel1.TabIndex = 0;
            // 
            // branchList
            // 
            this.branchList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.branchList.BackgroundColor = System.Drawing.Color.White;
            this.branchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.branchList.Location = new System.Drawing.Point(938, 402);
            this.branchList.Name = "branchList";
            this.branchList.RowHeadersVisible = false;
            this.branchList.RowHeadersWidth = 51;
            this.branchList.RowTemplate.Height = 29;
            this.branchList.Size = new System.Drawing.Size(236, 161);
            this.branchList.TabIndex = 15;
            this.branchList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.branchList_CellClick);
            // 
            // SoChiNhanh
            // 
            this.SoChiNhanh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SoChiNhanh.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SoChiNhanh.ForeColor = System.Drawing.Color.DimGray;
            this.SoChiNhanh.Location = new System.Drawing.Point(743, 425);
            this.SoChiNhanh.Name = "SoChiNhanh";
            this.SoChiNhanh.PlaceholderText = "00";
            this.SoChiNhanh.Size = new System.Drawing.Size(145, 25);
            this.SoChiNhanh.TabIndex = 12;
            // 
            // Address
            // 
            this.Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Address.ForeColor = System.Drawing.Color.DimGray;
            this.Address.Location = new System.Drawing.Point(747, 331);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(414, 23);
            this.Address.TabIndex = 10;
            // 
            // UName
            // 
            this.UName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UName.ForeColor = System.Drawing.Color.DimGray;
            this.UName.Location = new System.Drawing.Point(747, 229);
            this.UName.Name = "UName";
            this.UName.Size = new System.Drawing.Size(414, 23);
            this.UName.TabIndex = 9;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.checkBox2.Location = new System.Drawing.Point(732, 643);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(410, 24);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "  Tôi đã đọc mọi quy định về hợp đồng của Random.";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.checkBox1.Location = new System.Drawing.Point(732, 614);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(405, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "  Tôi đồng ý với Điều khoản và Dịch vụ của Random.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(783, 706);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 73);
            this.panel3.TabIndex = 1;
            this.panel3.Click += new System.EventHandler(this.clickCreate);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(1159, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 40);
            this.panel2.TabIndex = 16;
            this.panel2.Click += new System.EventHandler(this.clickClose);
            // 
            // CreateContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 848);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateContract";
            this.Load += new System.EventHandler(this.CreateContract_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox SoChiNhanh;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox UName;
        private System.Windows.Forms.DataGridView branchList;
        private System.Windows.Forms.Panel panel2;
    }
}