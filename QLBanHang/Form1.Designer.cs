namespace QLBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureAnh = new System.Windows.Forms.PictureBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.bntAnh = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.bntSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.bntBoQua = new System.Windows.Forms.Button();
            this.bntTimKiem = new System.Windows.Forms.Button();
            this.bntDong = new System.Windows.Forms.Button();
            this.cbbID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(173, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục Hàng Hóa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Hàng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Chất Liệu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 40);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Lượng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 40);
            this.label6.TabIndex = 5;
            this.label6.Text = "Đơn Giá Nhập";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 40);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đơn Giá Bán";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(427, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 40);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ảnh";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(427, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 40);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ghi Chú";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureAnh
            // 
            this.pictureAnh.Location = new System.Drawing.Point(854, 50);
            this.pictureAnh.Name = "pictureAnh";
            this.pictureAnh.Size = new System.Drawing.Size(205, 200);
            this.pictureAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAnh.TabIndex = 9;
            this.pictureAnh.TabStop = false;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(154, 50);
            this.txtMaHang.Multiline = true;
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(298, 40);
            this.txtMaHang.TabIndex = 10;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(154, 100);
            this.txtTenHang.Multiline = true;
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(298, 40);
            this.txtTenHang.TabIndex = 11;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(154, 200);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(298, 40);
            this.txtSoLuong.TabIndex = 13;
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Location = new System.Drawing.Point(154, 250);
            this.txtDonGiaNhap.Multiline = true;
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(298, 40);
            this.txtDonGiaNhap.TabIndex = 14;
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Location = new System.Drawing.Point(154, 300);
            this.txtDonGiaBan.Multiline = true;
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(298, 40);
            this.txtDonGiaBan.TabIndex = 15;
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(538, 50);
            this.txtAnh.Multiline = true;
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(190, 140);
            this.txtAnh.TabIndex = 16;
            this.txtAnh.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(547, 200);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(284, 140);
            this.txtGhiChu.TabIndex = 17;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(42, 346);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1017, 237);
            this.dgv.TabIndex = 18;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // bntAnh
            // 
            this.bntAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAnh.Image = ((System.Drawing.Image)(resources.GetObject("bntAnh.Image")));
            this.bntAnh.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bntAnh.Location = new System.Drawing.Point(743, 56);
            this.bntAnh.Name = "bntAnh";
            this.bntAnh.Size = new System.Drawing.Size(101, 44);
            this.bntAnh.TabIndex = 19;
            this.bntAnh.Text = "     Mở";
            this.bntAnh.UseVisualStyleBackColor = true;
            this.bntAnh.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntThem
            // 
            this.bntThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.bntThem.Image = ((System.Drawing.Image)(resources.GetObject("bntThem.Image")));
            this.bntThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntThem.Location = new System.Drawing.Point(25, 600);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(125, 50);
            this.bntThem.TabIndex = 20;
            this.bntThem.Text = "    Thêm";
            this.bntThem.UseVisualStyleBackColor = true;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.bntXoa.Image = ((System.Drawing.Image)(resources.GetObject("bntXoa.Image")));
            this.bntXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntXoa.Location = new System.Drawing.Point(175, 600);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(125, 50);
            this.bntXoa.TabIndex = 21;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = true;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // bntSua
            // 
            this.bntSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.bntSua.Image = ((System.Drawing.Image)(resources.GetObject("bntSua.Image")));
            this.bntSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntSua.Location = new System.Drawing.Point(325, 600);
            this.bntSua.Name = "bntSua";
            this.bntSua.Size = new System.Drawing.Size(125, 50);
            this.bntSua.TabIndex = 22;
            this.bntSua.Text = "  Sửa";
            this.bntSua.UseVisualStyleBackColor = true;
            this.bntSua.Click += new System.EventHandler(this.bntSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(475, 600);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(125, 50);
            this.btnLuu.TabIndex = 23;
            this.btnLuu.Text = "  Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // bntBoQua
            // 
            this.bntBoQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.bntBoQua.Image = ((System.Drawing.Image)(resources.GetObject("bntBoQua.Image")));
            this.bntBoQua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntBoQua.Location = new System.Drawing.Point(625, 600);
            this.bntBoQua.Name = "bntBoQua";
            this.bntBoQua.Size = new System.Drawing.Size(125, 50);
            this.bntBoQua.TabIndex = 24;
            this.bntBoQua.Text = "    Bỏ Qua";
            this.bntBoQua.UseVisualStyleBackColor = true;
            this.bntBoQua.Click += new System.EventHandler(this.bntBoQua_Click);
            // 
            // bntTimKiem
            // 
            this.bntTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.bntTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("bntTimKiem.Image")));
            this.bntTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntTimKiem.Location = new System.Drawing.Point(775, 600);
            this.bntTimKiem.Name = "bntTimKiem";
            this.bntTimKiem.Size = new System.Drawing.Size(125, 50);
            this.bntTimKiem.TabIndex = 25;
            this.bntTimKiem.Text = " Tìm Kiếm";
            this.bntTimKiem.UseVisualStyleBackColor = true;
            // 
            // bntDong
            // 
            this.bntDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.bntDong.Image = ((System.Drawing.Image)(resources.GetObject("bntDong.Image")));
            this.bntDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntDong.Location = new System.Drawing.Point(934, 600);
            this.bntDong.Name = "bntDong";
            this.bntDong.Size = new System.Drawing.Size(125, 50);
            this.bntDong.TabIndex = 26;
            this.bntDong.Text = "  Đóng";
            this.bntDong.UseVisualStyleBackColor = true;
            this.bntDong.Click += new System.EventHandler(this.bntDong_Click);
            // 
            // cbbID
            // 
            this.cbbID.FormattingEnabled = true;
            this.cbbID.Location = new System.Drawing.Point(154, 160);
            this.cbbID.Name = "cbbID";
            this.cbbID.Size = new System.Drawing.Size(298, 24);
            this.cbbID.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 669);
            this.Controls.Add(this.cbbID);
            this.Controls.Add(this.bntDong);
            this.Controls.Add(this.bntTimKiem);
            this.Controls.Add(this.bntBoQua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.bntSua);
            this.Controls.Add(this.bntXoa);
            this.Controls.Add(this.bntThem);
            this.Controls.Add(this.bntAnh);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtAnh);
            this.Controls.Add(this.txtDonGiaBan);
            this.Controls.Add(this.txtDonGiaNhap);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.pictureAnh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureAnh;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button bntAnh;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button bntSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button bntBoQua;
        private System.Windows.Forms.Button bntTimKiem;
        private System.Windows.Forms.Button bntDong;
        private System.Windows.Forms.ComboBox cbbID;
    }
}

