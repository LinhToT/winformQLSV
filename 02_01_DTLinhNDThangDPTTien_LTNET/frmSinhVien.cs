using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//02_01_DTLinhNDThangDPTTien
//Đinh Tùng Linh 19103100098
//Nguyễn Đức Thắng 19103100106
//Đào Phan Trường Tiến 19103100032
//Tin 13a2

namespace _02_01_DTLinhNDThangDPTTien_LTNET
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=LAPTOP-F171DVDP\LINHTOT;Initial Catalog=qlsv_02_DTLinhNDThangDPTTien;Integrated Security=True");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        SqlConnection conn;
        SqlCommand cmd;
        DataTable dt;

        private void loaddgv()
        {
            string sql = "select masv,hoten,ngaysinh,case when gioitinh = 1 then 'Nam' else N'Nữ' end as gioitinh,quequan,diemrl,l.tenlop from sinhvien s inner join lop l on l.malop = s.malop";
            cmd = new SqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dgv_sinhvien.DataSource = dt;

            string sql1 = "select * from lop";
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            DataTable dt2 = new DataTable();
            dt2.Load(cmd1.ExecuteReader());
            cbb_lop.DataSource = dt2;
            cbb_lop.DisplayMember = "tenlop";
            cbb_lop.ValueMember = "malop";

        }    
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            loaddgv();
            txt_ma.DataBindings.Add("Text", dt, "masv");
            txt_hoten.DataBindings.Add("Text", dt, "hoten");
            dtp_ngaysinh.DataBindings.Add("Text", dt, "ngaysinh");

            rbt_nam.DataBindings.Add("Text", dt, "gioitinh");
            txt_quequan.DataBindings.Add("Text", dt, "quequan");
            txt_diemrl.DataBindings.Add("Text", dt, "diemrl");
            cbb_lop.DataBindings.Add("Text", dt, "tenlop");
        }

        private void dgv_sinhvien_SelectionChanged(object sender, EventArgs e)
        {
            int chondong = -1;
            chondong = dgv_sinhvien.CurrentCell.RowIndex;
            txt_ma.Text = dgv_sinhvien.Rows[chondong].Cells["masv"].Value.ToString();
            txt_hoten.Text = dgv_sinhvien.Rows[chondong].Cells["hoten"].Value.ToString();
            dtp_ngaysinh.Text = dgv_sinhvien.Rows[chondong].Cells["ngaysinh"].Value.ToString();
            if(dgv_sinhvien.Rows[chondong].Cells["gioitinh"].Value.ToString() == "Nam")
            {
                rbt_nam.Checked = true;
            }    
            else
            {
               rbt_nu.Checked = true;
            }    
            txt_quequan.Text = dgv_sinhvien.Rows[chondong].Cells["quequan"].Value.ToString();
            txt_diemrl.Text = dgv_sinhvien.Rows[chondong].Cells["diemrl"].Value.ToString();
            cbb_lop.Text = dgv_sinhvien.Rows[chondong].Cells["tenlop"].Value.ToString();

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "insert into sinhvien(masv,hoten,ngaysinh,gioitinh,quequan,diemrl,malop) values(@masv,@hoten,@ngaysinh,@gioitinh,@quequan,@diemrl,@malop)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@masv", txt_ma.Text);
            cmd.Parameters.AddWithValue("@hoten", txt_hoten.Text);
            cmd.Parameters.AddWithValue("@ngaysinh", dtp_ngaysinh.Value.ToString());
            if(rbt_nam.Checked == true)
            {
                cmd.Parameters.AddWithValue("@gioitinh", "1");
            }    
            else
            {
                cmd.Parameters.AddWithValue("@gioitinh", "0");
            }   
            cmd.Parameters.AddWithValue("@quequan", txt_quequan.Text);
            cmd.Parameters.AddWithValue("@diemrl", txt_diemrl.Text);
            cmd.Parameters.AddWithValue("@malop", cbb_lop.SelectedValue.ToString());
            if(cmd.ExecuteNonQuery()>0)
            {
                MessageBox.Show("thêm thành công");
                loaddgv();
            }    
            else
            {
                MessageBox.Show("thêm thất bại");
            }    
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int chondong = -1;
            chondong = dgv_sinhvien.CurrentCell.RowIndex;
            string sql = "update sinhvien set hoten= @hoten,ngaysinh=@ngaysinh ,gioitinh=@gioitinh ,quequan=@quequan ,diemrl = @diemrl,malop=@malop where masv=@masv";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@masv", dgv_sinhvien.Rows[chondong].Cells["masv"].Value.ToString());
            cmd.Parameters.AddWithValue("@hoten", txt_hoten.Text);
            cmd.Parameters.AddWithValue("@ngaysinh", dtp_ngaysinh.Value.ToString());
            if (rbt_nam.Checked == true)
            {
                cmd.Parameters.AddWithValue("@gioitinh", "1");
            }
            else
            {
                cmd.Parameters.AddWithValue("@gioitinh", "0");
            }
            cmd.Parameters.AddWithValue("@quequan", txt_quequan.Text);
            cmd.Parameters.AddWithValue("@diemrl", txt_diemrl.Text);
            cmd.Parameters.AddWithValue("@malop", cbb_lop.SelectedValue.ToString());
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("sửa thành công");
                loaddgv();
            }
            else
            {
                MessageBox.Show("sửa thất bại");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int chondong = -1;
            chondong = dgv_sinhvien.CurrentCell.RowIndex;
            string sql = "delete sinhvien where masv = @masv";
            cmd= new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@masv", dgv_sinhvien.Rows[chondong].Cells["masv"].Value.ToString());
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Xóa thành công");
                loaddgv();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_diemrl.Text = "";
            txt_hoten.Text = "";
            txt_ma.Text = "";
            txt_quequan.Text = "";
            cbb_lop.Text = "";
        }

        private void btn_sapxep_Click(object sender, EventArgs e)
        {
            string sql = "select masv,hoten,ngaysinh,case when gioitinh = 1 then 'Nam' else N'Nữ' end as gioitinh,quequan,diemrl,l.tenlop from sinhvien s inner join lop l on l.malop = s.malop order by diemrl DESC";
            cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dgv_sinhvien.DataSource = dt;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        
        private void btn_dau_Click(object sender, EventArgs e)
        {
            BindingContext[dt].Position = 0;
        }

        private void btn_truoc_Click(object sender, EventArgs e)
        {
            BindingContext[dt].Position--;
        }

        private void btn_sau_Click(object sender, EventArgs e)
        {
            BindingContext[dt].Position++;
        }

        private void btn_cuoi_Click(object sender, EventArgs e)
        {
            BindingContext[dt].Position = dt.Rows.Count - 1;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            new frmTimKiem().Show();
        }
    }
}
