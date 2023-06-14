namespace _02_01_DTLinhNDThangDPTTien_LTNET
{
    partial class frmSinhVien
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
            this.dgv_sinhvien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_diemrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_quequan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_lop = new System.Windows.Forms.ComboBox();
            this.btn_dau = new System.Windows.Forms.Button();
            this.btn_truoc = new System.Windows.Forms.Button();
            this.btn_sau = new System.Windows.Forms.Button();
            this.btn_cuoi = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_nhaplai = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_sapxep = new System.Windows.Forms.Button();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.rbt_nam = new System.Windows.Forms.RadioButton();
            this.rbt_nu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_sinhvien
            // 
            this.dgv_sinhvien.AllowUserToAddRows = false;
            this.dgv_sinhvien.AllowUserToDeleteRows = false;
            this.dgv_sinhvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sinhvien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_sinhvien.Location = new System.Drawing.Point(0, 414);
            this.dgv_sinhvien.Name = "dgv_sinhvien";
            this.dgv_sinhvien.ReadOnly = true;
            this.dgv_sinhvien.RowHeadersWidth = 51;
            this.dgv_sinhvien.RowTemplate.Height = 24;
            this.dgv_sinhvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sinhvien.Size = new System.Drawing.Size(1006, 248);
            this.dgv_sinhvien.TabIndex = 0;
            this.dgv_sinhvien.SelectionChanged += new System.EventHandler(this.dgv_sinhvien_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã SV";
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(186, 12);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(220, 22);
            this.txt_ma.TabIndex = 2;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(186, 60);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(220, 22);
            this.txt_hoten.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày Sinh";
            // 
            // txt_diemrl
            // 
            this.txt_diemrl.Location = new System.Drawing.Point(186, 254);
            this.txt_diemrl.Name = "txt_diemrl";
            this.txt_diemrl.Size = new System.Drawing.Size(220, 22);
            this.txt_diemrl.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "điểm rèn luyện";
            // 
            // txt_quequan
            // 
            this.txt_quequan.Location = new System.Drawing.Point(186, 204);
            this.txt_quequan.Name = "txt_quequan";
            this.txt_quequan.Size = new System.Drawing.Size(220, 22);
            this.txt_quequan.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "quê quán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Giới Tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Lớp";
            // 
            // cbb_lop
            // 
            this.cbb_lop.FormattingEnabled = true;
            this.cbb_lop.Location = new System.Drawing.Point(186, 305);
            this.cbb_lop.Name = "cbb_lop";
            this.cbb_lop.Size = new System.Drawing.Size(220, 24);
            this.cbb_lop.TabIndex = 14;
            // 
            // btn_dau
            // 
            this.btn_dau.Location = new System.Drawing.Point(13, 357);
            this.btn_dau.Name = "btn_dau";
            this.btn_dau.Size = new System.Drawing.Size(120, 51);
            this.btn_dau.TabIndex = 15;
            this.btn_dau.Text = "Đầu";
            this.btn_dau.UseVisualStyleBackColor = true;
            this.btn_dau.Click += new System.EventHandler(this.btn_dau_Click);
            // 
            // btn_truoc
            // 
            this.btn_truoc.Location = new System.Drawing.Point(178, 357);
            this.btn_truoc.Name = "btn_truoc";
            this.btn_truoc.Size = new System.Drawing.Size(120, 51);
            this.btn_truoc.TabIndex = 16;
            this.btn_truoc.Text = "Trước";
            this.btn_truoc.UseVisualStyleBackColor = true;
            this.btn_truoc.Click += new System.EventHandler(this.btn_truoc_Click);
            // 
            // btn_sau
            // 
            this.btn_sau.Location = new System.Drawing.Point(359, 357);
            this.btn_sau.Name = "btn_sau";
            this.btn_sau.Size = new System.Drawing.Size(120, 51);
            this.btn_sau.TabIndex = 17;
            this.btn_sau.Text = "Sau";
            this.btn_sau.UseVisualStyleBackColor = true;
            this.btn_sau.Click += new System.EventHandler(this.btn_sau_Click);
            // 
            // btn_cuoi
            // 
            this.btn_cuoi.Location = new System.Drawing.Point(524, 357);
            this.btn_cuoi.Name = "btn_cuoi";
            this.btn_cuoi.Size = new System.Drawing.Size(120, 51);
            this.btn_cuoi.TabIndex = 18;
            this.btn_cuoi.Text = "Cuối";
            this.btn_cuoi.UseVisualStyleBackColor = true;
            this.btn_cuoi.Click += new System.EventHandler(this.btn_cuoi_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(509, 12);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(151, 51);
            this.btn_them.TabIndex = 19;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(509, 96);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(151, 51);
            this.btn_sua.TabIndex = 20;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(509, 175);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(151, 51);
            this.btn_xoa.TabIndex = 21;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_nhaplai
            // 
            this.btn_nhaplai.Location = new System.Drawing.Point(782, 12);
            this.btn_nhaplai.Name = "btn_nhaplai";
            this.btn_nhaplai.Size = new System.Drawing.Size(151, 51);
            this.btn_nhaplai.TabIndex = 22;
            this.btn_nhaplai.Text = "nhập lại";
            this.btn_nhaplai.UseVisualStyleBackColor = true;
            this.btn_nhaplai.Click += new System.EventHandler(this.btn_nhaplai_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(843, 344);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(151, 51);
            this.btn_thoat.TabIndex = 23;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(782, 96);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(151, 51);
            this.btn_timkiem.TabIndex = 24;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_sapxep
            // 
            this.btn_sapxep.Location = new System.Drawing.Point(782, 175);
            this.btn_sapxep.Name = "btn_sapxep";
            this.btn_sapxep.Size = new System.Drawing.Size(151, 51);
            this.btn_sapxep.TabIndex = 25;
            this.btn_sapxep.Text = "Sắp Xếp";
            this.btn_sapxep.UseVisualStyleBackColor = true;
            this.btn_sapxep.Click += new System.EventHandler(this.btn_sapxep_Click);
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaysinh.Location = new System.Drawing.Point(186, 108);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(220, 22);
            this.dtp_ngaysinh.TabIndex = 26;
            // 
            // rbt_nam
            // 
            this.rbt_nam.AutoSize = true;
            this.rbt_nam.Checked = true;
            this.rbt_nam.Location = new System.Drawing.Point(186, 160);
            this.rbt_nam.Name = "rbt_nam";
            this.rbt_nam.Size = new System.Drawing.Size(58, 21);
            this.rbt_nam.TabIndex = 27;
            this.rbt_nam.TabStop = true;
            this.rbt_nam.Text = "Nam";
            this.rbt_nam.UseVisualStyleBackColor = true;
            // 
            // rbt_nu
            // 
            this.rbt_nu.AutoSize = true;
            this.rbt_nu.Location = new System.Drawing.Point(359, 158);
            this.rbt_nu.Name = "rbt_nu";
            this.rbt_nu.Size = new System.Drawing.Size(47, 21);
            this.rbt_nu.TabIndex = 28;
            this.rbt_nu.TabStop = true;
            this.rbt_nu.Text = "Nữ";
            this.rbt_nu.UseVisualStyleBackColor = true;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 662);
            this.Controls.Add(this.rbt_nu);
            this.Controls.Add(this.rbt_nam);
            this.Controls.Add(this.dtp_ngaysinh);
            this.Controls.Add(this.btn_sapxep);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_nhaplai);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_cuoi);
            this.Controls.Add(this.btn_sau);
            this.Controls.Add(this.btn_truoc);
            this.Controls.Add(this.btn_dau);
            this.Controls.Add(this.cbb_lop);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_diemrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_quequan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_sinhvien);
            this.Name = "frmSinhVien";
            this.Text = "Quản lý sinh viên QLSV_02_DTLinh_NDThang_DPTTien";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_sinhvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_diemrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_quequan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_lop;
        private System.Windows.Forms.Button btn_dau;
        private System.Windows.Forms.Button btn_truoc;
        private System.Windows.Forms.Button btn_sau;
        private System.Windows.Forms.Button btn_cuoi;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_nhaplai;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_sapxep;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.RadioButton rbt_nam;
        private System.Windows.Forms.RadioButton rbt_nu;
    }
}