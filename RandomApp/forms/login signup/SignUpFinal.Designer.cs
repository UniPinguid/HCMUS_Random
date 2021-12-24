
namespace RandomApp
{
    partial class SignUpFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpFinal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passwordConfirm = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.usernameInput);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.passwordConfirm);
            this.panel1.Controls.Add(this.passwordInput);
            this.panel1.Location = new System.Drawing.Point(-19, -17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 897);
            this.panel1.TabIndex = 0;
            // 
            // usernameInput
            // 
            this.usernameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameInput.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameInput.ForeColor = System.Drawing.Color.DimGray;
            this.usernameInput.Location = new System.Drawing.Point(88, 395);
            this.usernameInput.MaxLength = 32;
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.PlaceholderText = "Nhập tên đăng nhập...";
            this.usernameInput.Size = new System.Drawing.Size(396, 22);
            this.usernameInput.TabIndex = 1;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.checkBox2.Location = new System.Drawing.Point(70, 659);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(440, 24);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "  Tôi xin cam kết tuân thủ đúng các quy tắc của Random.";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.checkBox1.Location = new System.Drawing.Point(70, 630);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(405, 24);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "  Tôi đồng ý với Điều khoản và Dịch vụ của Random.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(43, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 23);
            this.panel3.TabIndex = 12;
            this.panel3.Click += new System.EventHandler(this.clickBack);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(103, 730);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 64);
            this.panel2.TabIndex = 11;
            this.panel2.Click += new System.EventHandler(this.clickSubmit);
            // 
            // passwordConfirm
            // 
            this.passwordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordConfirm.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordConfirm.ForeColor = System.Drawing.Color.DimGray;
            this.passwordConfirm.Location = new System.Drawing.Point(88, 572);
            this.passwordConfirm.MaxLength = 32;
            this.passwordConfirm.Name = "passwordConfirm";
            this.passwordConfirm.PasswordChar = '•';
            this.passwordConfirm.PlaceholderText = "Nhập lại mật khẩu...";
            this.passwordConfirm.Size = new System.Drawing.Size(396, 22);
            this.passwordConfirm.TabIndex = 8;
            // 
            // passwordInput
            // 
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordInput.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordInput.ForeColor = System.Drawing.Color.DimGray;
            this.passwordInput.Location = new System.Drawing.Point(88, 484);
            this.passwordInput.MaxLength = 32;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '•';
            this.passwordInput.PlaceholderText = "Nhập mật khẩu...";
            this.passwordInput.Size = new System.Drawing.Size(396, 22);
            this.passwordInput.TabIndex = 7;
            // 
            // SignUpFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(522, 872);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpFinal";
            this.Load += new System.EventHandler(this.SignUpFinal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passwordConfirm;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox usernameInput;
    }
}