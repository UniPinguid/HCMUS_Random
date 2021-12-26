
namespace RandomApp
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkShipper = new System.Windows.Forms.RadioButton();
            this.checkCustomer = new System.Windows.Forms.RadioButton();
            this.checkPartner = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkShipper);
            this.panel1.Controls.Add(this.checkCustomer);
            this.panel1.Controls.Add(this.checkPartner);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-18, -20);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 683);
            this.panel1.TabIndex = 0;
            // 
            // checkShipper
            // 
            this.checkShipper.AutoSize = true;
            this.checkShipper.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkShipper.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkShipper.Location = new System.Drawing.Point(158, 450);
            this.checkShipper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkShipper.Name = "checkShipper";
            this.checkShipper.Size = new System.Drawing.Size(88, 30);
            this.checkShipper.TabIndex = 4;
            this.checkShipper.TabStop = true;
            this.checkShipper.Text = "Tài xế";
            this.checkShipper.UseVisualStyleBackColor = true;
            // 
            // checkCustomer
            // 
            this.checkCustomer.AutoSize = true;
            this.checkCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkCustomer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkCustomer.Location = new System.Drawing.Point(158, 423);
            this.checkCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkCustomer.Name = "checkCustomer";
            this.checkCustomer.Size = new System.Drawing.Size(146, 30);
            this.checkCustomer.TabIndex = 3;
            this.checkCustomer.TabStop = true;
            this.checkCustomer.Text = "Khách hàng";
            this.checkCustomer.UseVisualStyleBackColor = true;
            // 
            // checkPartner
            // 
            this.checkPartner.AutoSize = true;
            this.checkPartner.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkPartner.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkPartner.Location = new System.Drawing.Point(158, 389);
            this.checkPartner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkPartner.Name = "checkPartner";
            this.checkPartner.Size = new System.Drawing.Size(98, 30);
            this.checkPartner.TabIndex = 2;
            this.checkPartner.TabStop = true;
            this.checkPartner.Text = "Đối tác";
            this.checkPartner.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(115, 519);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 61);
            this.panel3.TabIndex = 1;
            //this.panel3.Click += new System.EventHandler(this.clickContinue);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(46, 39);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 17);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.clickBack);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 585);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(331, 59);
            this.button1.TabIndex = 5;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 660);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton checkShipper;
        private System.Windows.Forms.RadioButton checkCustomer;
        private System.Windows.Forms.RadioButton checkPartner;
        private System.Windows.Forms.Button button1;
    }
}