using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
    public partial class frmExcel : Form
    {
        public frmExcel()
        {
            InitializeComponent();
        }
        DataTableCollection tableCollection;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Woekbook|*.xlxx " })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtFilename.Text = ofd.FileName;
                    using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cbcSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cbcSheet.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        private void cbcSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cbcSheet.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmExcel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE");
        }
    }
}
