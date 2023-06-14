using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//02_01_DTLinhNDThangDPTTien
//Đinh Tùng Linh 19103100098
//Nguyễn Đức Thắng 19103100106
//Đào Phan Trường Tiến 19103100032
//Tin 13a2

namespace _02_01_DTLinhNDThangDPTTien_LTNET
{
    public partial class frmBaocaolop : Form
    {
        public frmBaocaolop()
        {
            InitializeComponent();
        }

        private void frmReportlop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlsv_02_DTLinhNDThangDPTTienDataSet1.lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.qlsv_02_DTLinhNDThangDPTTienDataSet1.lop);

            this.reportViewer1.RefreshReport();
        }
    }
}
