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
    public partial class frmLop : Form
    {
        public frmLop()
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
            string sql = "select * from lop";
            cmd = new SqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dgv_lop.DataSource = dt;
        }
        private void frmLop_Load(object sender, EventArgs e)
        {
            loaddgv();
            txt_malop.DataBindings.Add("Text", dt, "malop");
            txt_tenlop.DataBindings.Add("Text", dt, "tenlop");
            txt_email.DataBindings.Add("Text", dt, "email");
            txt_hotenlt.DataBindings.Add("Text", dt, "hotenlt");
        }

        private void dgv_lop_SelectionChanged(object sender, EventArgs e)
        {
            int chondong = -1;
            chondong = dgv_lop.CurrentCell.RowIndex;
            txt_malop.Text = dgv_lop.Rows[chondong].Cells["malop"].Value.ToString();
            txt_tenlop.Text = dgv_lop.Rows[chondong].Cells["tenlop"].Value.ToString();
            txt_email.Text = dgv_lop.Rows[chondong].Cells["email"].Value.ToString();
            txt_hotenlt.Text = dgv_lop.Rows[chondong].Cells["hotenlt"].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "insert into lop(malop,tenlop,email,hotenlt) values(@malop,@tenlop,@email,@hotenlt)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@malop", txt_malop.Text);
            cmd.Parameters.AddWithValue("@tenlop", txt_tenlop.Text);
            cmd.Parameters.AddWithValue("@email", txt_email.Text);
            cmd.Parameters.AddWithValue("@hotenlt", txt_hotenlt.Text);
            if (cmd.ExecuteNonQuery() > 0)
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
            chondong = dgv_lop.CurrentCell.RowIndex;
            string sql = "update lop set tenlop= @tenlop, email=@email , hotenlt=@hotenlt where malop=@malop";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@malop", dgv_lop.Rows[chondong].Cells["malop"].Value.ToString());
            cmd.Parameters.AddWithValue("@tenlop", txt_tenlop.Text);
            cmd.Parameters.AddWithValue("@email", txt_email.Text);
            cmd.Parameters.AddWithValue("@hotenlt", txt_hotenlt.Text);
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
            chondong = dgv_lop.CurrentCell.RowIndex;
            string sql = "delete lop where malop = @malop";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@malop", dgv_lop.Rows[chondong].Cells["malop"].Value.ToString());
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
            txt_malop.Text = "";
            txt_tenlop.Text = "";
            txt_email.Text = "";
            txt_hotenlt.Text = "";
        }

        private void btn_sapxep_Click(object sender, EventArgs e)
        {
            string sql = "select * from lop order by tenlop";
            cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dgv_lop.DataSource = dt;
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
            new frmTimkiemlop().Show();
        }
    }
}
