
using System;
using System.Data;
using System.Data.SqlClient;

namespace RandomApp
{
    partial class EmployeeContractList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeContractList));
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.productAmount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.noBranch = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.representative = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.contactNumber = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.partnerID = new System.Windows.Forms.Label();
            this.partnerName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchContract = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.listContract = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.contractLocation = new System.Windows.Forms.Label();
            this.contractPhoneNumber = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.contractID = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.refreshLabel = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.end = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listContract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Roboto Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(635, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(342, 56);
            this.label15.TabIndex = 2;
            this.label15.Text = "Xem danh sách các đối tác\r\nvà kiểm tra hợp đồng của đối tác";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(56, 67);
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
            this.panel2.Location = new System.Drawing.Point(1558, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 40);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.clickClose);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Controls.Add(this.productAmount);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.type);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.noBranch);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.representative);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel5.Location = new System.Drawing.Point(661, 225);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(670, 156);
            this.panel5.TabIndex = 64;
            // 
            // productAmount
            // 
            this.productAmount.AutoSize = true;
            this.productAmount.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productAmount.ForeColor = System.Drawing.Color.DimGray;
            this.productAmount.Location = new System.Drawing.Point(561, 84);
            this.productAmount.Name = "productAmount";
            this.productAmount.Size = new System.Drawing.Size(30, 22);
            this.productAmount.TabIndex = 7;
            this.productAmount.Text = "33";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(365, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(194, 22);
            this.label13.TabIndex = 6;
            this.label13.Text = "SL Đơn hàng mỗi ngày:";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.type.ForeColor = System.Drawing.Color.DimGray;
            this.type.Location = new System.Drawing.Point(458, 42);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(41, 22);
            this.type.TabIndex = 5;
            this.type.Text = "Sơn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(365, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 22);
            this.label11.TabIndex = 4;
            this.label11.Text = "Loại hàng:";
            // 
            // noBranch
            // 
            this.noBranch.AutoSize = true;
            this.noBranch.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noBranch.ForeColor = System.Drawing.Color.DimGray;
            this.noBranch.Location = new System.Drawing.Point(156, 83);
            this.noBranch.Name = "noBranch";
            this.noBranch.Size = new System.Drawing.Size(20, 22);
            this.noBranch.TabIndex = 3;
            this.noBranch.Text = "2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(37, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Số chi nhánh:";
            // 
            // representative
            // 
            this.representative.AutoSize = true;
            this.representative.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.representative.ForeColor = System.Drawing.Color.DimGray;
            this.representative.Location = new System.Drawing.Point(170, 43);
            this.representative.Name = "representative";
            this.representative.Size = new System.Drawing.Size(156, 22);
            this.representative.TabIndex = 1;
            this.representative.Text = "Tên người đại diện";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(37, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Người đại diện:";
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Cursor = System.Windows.Forms.Cursors.Default;
            this.location.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.location.ForeColor = System.Drawing.Color.DimGray;
            this.location.Location = new System.Drawing.Point(322, 373);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(258, 20);
            this.location.TabIndex = 63;
            this.location.Text = "Quận Bình Thạnh, TP Hồ Chí Minh";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Cursor = System.Windows.Forms.Cursors.Default;
            this.email.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.ForeColor = System.Drawing.Color.DimGray;
            this.email.Location = new System.Drawing.Point(323, 340);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(184, 20);
            this.email.TabIndex = 62;
            this.email.Text = "something@email.com";
            // 
            // contactNumber
            // 
            this.contactNumber.AutoSize = true;
            this.contactNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.contactNumber.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactNumber.ForeColor = System.Drawing.Color.DimGray;
            this.contactNumber.Location = new System.Drawing.Point(323, 309);
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.Size = new System.Drawing.Size(109, 20);
            this.contactNumber.TabIndex = 61;
            this.contactNumber.Text = "0912347825";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(283, 365);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 32);
            this.pictureBox4.TabIndex = 60;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(283, 340);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.TabIndex = 59;
            this.pictureBox3.TabStop = false;
            // 
            // partnerID
            // 
            this.partnerID.AutoSize = true;
            this.partnerID.Cursor = System.Windows.Forms.Cursors.Default;
            this.partnerID.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partnerID.ForeColor = System.Drawing.Color.DimGray;
            this.partnerID.Location = new System.Drawing.Point(259, 273);
            this.partnerID.Name = "partnerID";
            this.partnerID.Size = new System.Drawing.Size(104, 24);
            this.partnerID.TabIndex = 57;
            this.partnerID.Text = "Mã đối tác";
            // 
            // partnerName
            // 
            this.partnerName.AutoSize = true;
            this.partnerName.Cursor = System.Windows.Forms.Cursors.Default;
            this.partnerName.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.partnerName.ForeColor = System.Drawing.Color.DimGray;
            this.partnerName.Location = new System.Drawing.Point(253, 235);
            this.partnerName.Name = "partnerName";
            this.partnerName.Size = new System.Drawing.Size(183, 39);
            this.partnerName.TabIndex = 56;
            this.partnerName.Text = "Tên đối tác";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Location = new System.Drawing.Point(58, 235);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 160);
            this.panel4.TabIndex = 55;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(283, 305);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
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
            this.panel1.TabIndex = 50;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Roboto", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(56, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(446, 63);
            this.label16.TabIndex = 15;
            this.label16.Text = "Quản lý hợp đồng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(896, 435);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.clickSearch);
            // 
            // searchContract
            // 
            this.searchContract.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchContract.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchContract.ForeColor = System.Drawing.Color.DimGray;
            this.searchContract.Location = new System.Drawing.Point(502, 435);
            this.searchContract.Name = "searchContract";
            this.searchContract.PlaceholderText = "Tìm kiếm hợp đồng...";
            this.searchContract.Size = new System.Drawing.Size(366, 25);
            this.searchContract.TabIndex = 68;
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.label18.Location = new System.Drawing.Point(490, 463);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(400, 2);
            this.label18.TabIndex = 67;
            // 
            // listContract
            // 
            this.listContract.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listContract.BackgroundColor = System.Drawing.Color.White;
            this.listContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listContract.Location = new System.Drawing.Point(37, 471);
            this.listContract.Name = "listContract";
            this.listContract.RowHeadersVisible = false;
            this.listContract.RowHeadersWidth = 51;
            this.listContract.RowTemplate.Height = 29;
            this.listContract.Size = new System.Drawing.Size(1049, 405);
            this.listContract.TabIndex = 66;
            this.listContract.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClickContract);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(37, 425);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(415, 37);
            this.label14.TabIndex = 65;
            this.label14.Text = "Các hợp đồng của đối tác này";
            // 
            // contractLocation
            // 
            this.contractLocation.AutoSize = true;
            this.contractLocation.Cursor = System.Windows.Forms.Cursors.Default;
            this.contractLocation.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contractLocation.ForeColor = System.Drawing.Color.DimGray;
            this.contractLocation.Location = new System.Drawing.Point(1192, 565);
            this.contractLocation.Name = "contractLocation";
            this.contractLocation.Size = new System.Drawing.Size(258, 20);
            this.contractLocation.TabIndex = 76;
            this.contractLocation.Text = "Quận Bình Thạnh, TP Hồ Chí Minh";
            // 
            // contractPhoneNumber
            // 
            this.contractPhoneNumber.AutoSize = true;
            this.contractPhoneNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.contractPhoneNumber.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contractPhoneNumber.ForeColor = System.Drawing.Color.DimGray;
            this.contractPhoneNumber.Location = new System.Drawing.Point(1193, 499);
            this.contractPhoneNumber.Name = "contractPhoneNumber";
            this.contractPhoneNumber.Size = new System.Drawing.Size(109, 20);
            this.contractPhoneNumber.TabIndex = 74;
            this.contractPhoneNumber.Text = "0912347825";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1154, 560);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(21, 32);
            this.pictureBox5.TabIndex = 73;
            this.pictureBox5.TabStop = false;
            // 
            // contractID
            // 
            this.contractID.AutoSize = true;
            this.contractID.Cursor = System.Windows.Forms.Cursors.Default;
            this.contractID.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contractID.ForeColor = System.Drawing.Color.DimGray;
            this.contractID.Location = new System.Drawing.Point(1123, 435);
            this.contractID.Name = "contractID";
            this.contractID.Size = new System.Drawing.Size(213, 39);
            this.contractID.TabIndex = 70;
            this.contractID.Text = "Mã hợp đồng";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(1153, 493);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(24, 24);
            this.pictureBox7.TabIndex = 71;
            this.pictureBox7.TabStop = false;
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Cursor = System.Windows.Forms.Cursors.Default;
            this.start.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.start.ForeColor = System.Drawing.Color.DimGray;
            this.start.Location = new System.Drawing.Point(1192, 532);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(93, 20);
            this.start.TabIndex = 78;
            this.start.Text = "14/2/2020";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(1153, 528);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(24, 24);
            this.pictureBox8.TabIndex = 77;
            this.pictureBox8.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.Controls.Add(this.label19);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel6.Location = new System.Drawing.Point(1192, 808);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(325, 69);
            this.panel6.TabIndex = 79;
            this.panel6.Click += new System.EventHandler(this.clickExtend);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label19.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(79, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(168, 24);
            this.label19.TabIndex = 80;
            this.label19.Text = "Gia hạn hợp đồng";
            this.label19.Click += new System.EventHandler(this.clickExtend);
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.Controls.Add(this.label23);
            this.panel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel7.Location = new System.Drawing.Point(1192, 747);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(325, 69);
            this.panel7.TabIndex = 81;
            this.panel7.Click += new System.EventHandler(this.clickApprove);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label23.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(86, 21);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(152, 24);
            this.label23.TabIndex = 80;
            this.label23.Text = "Duyệt hợp đồng";
            this.label23.Click += new System.EventHandler(this.clickApprove);
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.Controls.Add(this.label24);
            this.panel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel8.Location = new System.Drawing.Point(1193, 607);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(324, 73);
            this.panel8.TabIndex = 82;
            this.panel8.Click += new System.EventHandler(this.clickViewInfo);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label24.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label24.Location = new System.Drawing.Point(66, 24);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(201, 24);
            this.label24.TabIndex = 80;
            this.label24.Text = "Xem thông tin chi tiết";
            this.label24.Click += new System.EventHandler(this.clickViewInfo);
            // 
            // refreshLabel
            // 
            this.refreshLabel.AutoSize = true;
            this.refreshLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refreshLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.refreshLabel.Location = new System.Drawing.Point(1025, 439);
            this.refreshLabel.Name = "refreshLabel";
            this.refreshLabel.Size = new System.Drawing.Size(63, 24);
            this.refreshLabel.TabIndex = 117;
            this.refreshLabel.Text = "Tải lại";
            this.refreshLabel.Click += new System.EventHandler(this.clickRefresh);
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel9.Location = new System.Drawing.Point(985, 434);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(32, 32);
            this.panel9.TabIndex = 116;
            this.panel9.Click += new System.EventHandler(this.clickRefresh);
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Cursor = System.Windows.Forms.Cursors.Default;
            this.end.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.end.ForeColor = System.Drawing.Color.DimGray;
            this.end.Location = new System.Drawing.Point(1304, 532);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(93, 20);
            this.end.TabIndex = 118;
            this.end.Text = "14/8/2023";
            // 
            // EmployeeContractList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.end);
            this.Controls.Add(this.refreshLabel);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.start);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.contractLocation);
            this.Controls.Add(this.contractPhoneNumber);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.contractID);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchContract);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.listContract);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.location);
            this.Controls.Add(this.email);
            this.Controls.Add(this.contactNumber);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.partnerID);
            this.Controls.Add(this.partnerName);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeContractList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeContractList";
            this.Load += new System.EventHandler(this.EmployeeContractList_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listContract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label productAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label noBranch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label representative;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label contactNumber;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label partnerID;
        private System.Windows.Forms.Label partnerName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox searchContract;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView listContract;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label contractLocation;
        private System.Windows.Forms.Label contractPhoneNumber;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label contractID;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label refreshLabel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label end;
    }
}