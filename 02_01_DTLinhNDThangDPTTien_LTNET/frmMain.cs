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
    public partial class frmMain : Form
    {
        public frmMain(string mod,string username)
        {
            this.mod = mod;
            this.username = username;
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=LAPTOP-F171DVDP\LINHTOT;Initial Catalog=qlsv_02_DTLinhNDThangDPTTien;Integrated Security=True");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        string mod = "";
        string username;
        SqlConnection conn;
        SqlCommand cmd;

        private void Addfrom(Form f)
        {
            this.pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            if(mod.Equals("True"))
            {
                QuanLyTaiKhoanToolStripMenuItem.Visible = false;
                
            }
            
        }



        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMK f = new frmDoiMK(username);
            Addfrom(f);
        }

        private void QuanLyTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaiKhoan f = new frmTaiKhoan();
            Addfrom(f);
        }

        private void sinhViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmSinhVien f = new frmSinhVien();
            Addfrom(f);
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLop f = new frmLop();
            Addfrom(f);
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTacgia f = new frmTacgia();
            Addfrom(f);
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWord f = new frmWord();
            Addfrom(f);
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExcel f = new frmExcel();
            Addfrom(f);
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Accessories\Paint");

        }

        private void sinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBaocaoSV f = new frmBaocaoSV();
            Addfrom(f);
        }

        private void lớpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBaocaolop f = new frmBaocaolop();
            Addfrom(f);
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHuongdan f = new frmHuongdan();
            Addfrom(f);
        }

        private void bảnQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phiên bản hiện tại: version 0.0.1");
        }
    }
}
