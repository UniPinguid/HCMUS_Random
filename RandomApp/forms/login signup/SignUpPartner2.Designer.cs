
namespace RandomApp
{
    partial class SignUpPartner2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpPartner2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.productAmountInput = new System.Windows.Forms.TextBox();
            this.branchIDInput = new System.Windows.Forms.TextBox();
            this.typeInput = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.branchList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.branchList);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.productAmountInput);
            this.panel1.Controls.Add(this.branchIDInput);
            this.panel1.Controls.Add(this.typeInput);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-19, -27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 903);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(632, 448);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 61);
            this.panel3.TabIndex = 13;
            this.panel3.Click += new System.EventHandler(this.clickSubmit);
            // 
            // productAmountInput
            // 
            this.productAmountInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productAmountInput.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productAmountInput.ForeColor = System.Drawing.Color.DimGray;
            this.productAmountInput.Location = new System.Drawing.Point(618, 280);
            this.productAmountInput.Name = "productAmountInput";
            this.productAmountInput.PlaceholderText = "Nhập số lượng...";
            this.productAmountInput.Size = new System.Drawing.Size(133, 22);
            this.productAmountInput.TabIndex = 7;
            // 
            // branchIDInput
            // 
            this.branchIDInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.branchIDInput.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.branchIDInput.ForeColor = System.Drawing.Color.DimGray;
            this.branchIDInput.Location = new System.Drawing.Point(618, 191);
            this.branchIDInput.Name = "branchIDInput";
            this.branchIDInput.PlaceholderText = "Chọn chi nhánh";
            this.branchIDInput.Size = new System.Drawing.Size(133, 22);
            this.branchIDInput.TabIndex = 6;
            // 
            // typeInput
            // 
            this.typeInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typeInput.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeInput.ForeColor = System.Drawing.Color.DimGray;
            this.typeInput.Location = new System.Drawing.Point(618, 378);
            this.typeInput.Name = "typeInput";
            this.typeInput.PlaceholderText = "Nhập loại hàng...";
            this.typeInput.Size = new System.Drawing.Size(383, 22);
            this.typeInput.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(50, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 23);
            this.panel2.TabIndex = 3;
            this.panel2.Click += new System.EventHandler(this.clickBack);
            // 
            // branchList
            // 
            this.branchList.BackgroundColor = System.Drawing.Color.White;
            this.branchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.branchList.Location = new System.Drawing.Point(800, 164);
            this.branchList.Name = "branchList";
            this.branchList.RowHeadersWidth = 51;
            this.branchList.RowTemplate.Height = 29;
            this.branchList.Size = new System.Drawing.Size(221, 161);
            this.branchList.TabIndex = 14;
            this.branchList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClickBranch);
            // 
            // SignUpPartner2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 872);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpPartner2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpPartner2";
            this.Load += new System.EventHandler(this.SignUpPartner2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox productAmountInput;
        private System.Windows.Forms.TextBox branchIDInput;
        private System.Windows.Forms.TextBox typeInput;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView branchList;
    }
}