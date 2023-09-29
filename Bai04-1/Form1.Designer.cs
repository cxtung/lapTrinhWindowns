namespace Bai04_1
{
    partial class Form1
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.BtnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listThongTIn = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listviewDSDuocChon = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Them1 = new System.Windows.Forms.Button();
            this.themAll = new System.Windows.Forms.Button();
            this.delete1 = new System.Windows.Forms.Button();
            this.deleteAll = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.BtnThem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1332, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm sinh viên";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1156, 35);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 61);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.Location = new System.Drawing.Point(1009, 35);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(128, 61);
            this.BtnThem.TabIndex = 2;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(54, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(188, 52);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(792, 26);
            this.txtHoTen.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listThongTIn);
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 512);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thông tin";
            // 
            // listThongTIn
            // 
            this.listThongTIn.FormattingEnabled = true;
            this.listThongTIn.ItemHeight = 20;
            this.listThongTIn.Items.AddRange(new object[] {
            "Cao Xuân Tùng",
            "Nguyễn Quốc Đạt",
            "Vũ Minh Hiếu",
            "Nguyễn Thế Vinh"});
            this.listThongTIn.Location = new System.Drawing.Point(25, 37);
            this.listThongTIn.Name = "listThongTIn";
            this.listThongTIn.Size = new System.Drawing.Size(423, 464);
            this.listThongTIn.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listviewDSDuocChon);
            this.groupBox3.Location = new System.Drawing.Point(744, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(590, 501);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sinh viên được chọn";
            // 
            // listviewDSDuocChon
            // 
            this.listviewDSDuocChon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listviewDSDuocChon.HideSelection = false;
            this.listviewDSDuocChon.Location = new System.Drawing.Point(6, 45);
            this.listviewDSDuocChon.Name = "listviewDSDuocChon";
            this.listviewDSDuocChon.Size = new System.Drawing.Size(578, 440);
            this.listviewDSDuocChon.TabIndex = 0;
            this.listviewDSDuocChon.UseCompatibleStateImageBehavior = false;
            this.listviewDSDuocChon.View = System.Windows.Forms.View.Details;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.deleteAll);
            this.groupBox4.Controls.Add(this.delete1);
            this.groupBox4.Controls.Add(this.themAll);
            this.groupBox4.Controls.Add(this.Them1);
            this.groupBox4.Controls.Add(this.cbKhoa);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(507, 159);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(231, 501);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Công nghệ ô tô",
            "Chuyên ngành anh"});
            this.cbKhoa.Location = new System.Drawing.Point(31, 61);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(183, 28);
            this.cbKhoa.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Khoa";
            // 
            // Them1
            // 
            this.Them1.Location = new System.Drawing.Point(31, 109);
            this.Them1.Name = "Them1";
            this.Them1.Size = new System.Drawing.Size(183, 48);
            this.Them1.TabIndex = 6;
            this.Them1.Text = ">";
            this.Them1.UseVisualStyleBackColor = true;
            this.Them1.Click += new System.EventHandler(this.Them1_Click);
            // 
            // themAll
            // 
            this.themAll.Location = new System.Drawing.Point(31, 187);
            this.themAll.Name = "themAll";
            this.themAll.Size = new System.Drawing.Size(183, 48);
            this.themAll.TabIndex = 7;
            this.themAll.Text = ">>";
            this.themAll.UseVisualStyleBackColor = true;
            this.themAll.Click += new System.EventHandler(this.themAll_Click);
            // 
            // delete1
            // 
            this.delete1.Location = new System.Drawing.Point(31, 270);
            this.delete1.Name = "delete1";
            this.delete1.Size = new System.Drawing.Size(183, 48);
            this.delete1.TabIndex = 8;
            this.delete1.Text = "<";
            this.delete1.UseVisualStyleBackColor = true;
            this.delete1.Click += new System.EventHandler(this.delete1_Click);
            // 
            // deleteAll
            // 
            this.deleteAll.Location = new System.Drawing.Point(31, 363);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(183, 48);
            this.deleteAll.TabIndex = 9;
            this.deleteAll.Text = "<<";
            this.deleteAll.UseVisualStyleBackColor = true;
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ tên";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Khoa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 672);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ListBox listThongTIn;
        private System.Windows.Forms.ListView listviewDSDuocChon;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteAll;
        private System.Windows.Forms.Button delete1;
        private System.Windows.Forms.Button themAll;
        private System.Windows.Forms.Button Them1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

