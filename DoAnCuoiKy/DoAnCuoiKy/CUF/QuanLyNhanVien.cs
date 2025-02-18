using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy.CUF
{
    public partial class QuanLyNhanVien : UserControl
    {
        ConnectDatabase db = new ConnectDatabase();
        int x;
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        #region Load DGV Dịch Vụ

        private void LoadDGVDivhVu()
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("select * from nhanvien", db.getConnection);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
            db.closeConnection();
        }
        #endregion

        private void thêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemNV themNV = new ThemNV();
            themNV.Show();
        }

        private void sửaNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ThemNV suaNV = new ThemNV(x);
            suaNV.Show();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show();
            }
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadDGVDivhVu();
        }

        private void xóaNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int y = 1;
            ThemNV xoaNV = new ThemNV(x,1);
            xoaNV.Show();
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            x = id;
        }

        private void QuanLyNhanVien_Click(object sender, EventArgs e)
        {
            LoadDGVDivhVu();
        }
    }
}
