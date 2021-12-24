
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkPartner = new System.Windows.Forms.RadioButton();
            this.checkCustomer = new System.Windows.Forms.RadioButton();
            this.checkShipper = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.checkShipper);
            this.panel1.Controls.Add(this.checkCustomer);
            this.panel1.Controls.Add(this.checkPartner);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-20, -26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 911);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(117, 590);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 56);
            this.panel3.TabIndex = 1;
            this.panel3.Click += new System.EventHandler(this.clickContinue);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(53, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 23);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.clickBack);
            // 
            // checkPartner
            // 
            this.checkPartner.AutoSize = true;
            this.checkPartner.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkPartner.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkPartner.Location = new System.Drawing.Point(187, 415);
            this.checkPartner.Name = "checkPartner";
            this.checkPartner.Size = new System.Drawing.Size(124, 38);
            this.checkPartner.TabIndex = 2;
            this.checkPartner.TabStop = true;
            this.checkPartner.Text = "Đối tác";
            this.checkPartner.UseVisualStyleBackColor = true;
            // 
            // checkCustomer
            // 
            this.checkCustomer.AutoSize = true;
            this.checkCustomer.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkCustomer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkCustomer.Location = new System.Drawing.Point(187, 455);
            this.checkCustomer.Name = "checkCustomer";
            this.checkCustomer.Size = new System.Drawing.Size(182, 38);
            this.checkCustomer.TabIndex = 3;
            this.checkCustomer.TabStop = true;
            this.checkCustomer.Text = "Khách hàng";
            this.checkCustomer.UseVisualStyleBackColor = true;
            // 
            // checkShipper
            // 
            this.checkShipper.AutoSize = true;
            this.checkShipper.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkShipper.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkShipper.Location = new System.Drawing.Point(187, 496);
            this.checkShipper.Name = "checkShipper";
            this.checkShipper.Size = new System.Drawing.Size(109, 38);
            this.checkShipper.TabIndex = 4;
            this.checkShipper.TabStop = true;
            this.checkShipper.Text = "Tài xế";
            this.checkShipper.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 880);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}