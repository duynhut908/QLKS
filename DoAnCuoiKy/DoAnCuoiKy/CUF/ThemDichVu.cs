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

using DoAnCuoiKy.BLLayer;

namespace DoAnCuoiKy.CUF
{
    public partial class ThemDichVu : Form
    {
        ConnectDatabase db = new ConnectDatabase();
        BLThemDichVu blTDV = new BLThemDichVu();
        
        public ThemDichVu()
        {
            InitializeComponent();
            
        }
        #region Load combobox dịch vụ
        private void LoadCbbLoaiDV()
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("select * from typedv", db.getConnection);
            var dr = command.ExecuteReader();
            var dt = new DataTable(); 
            dt.Load(dr);
            dr.Dispose();
            cbbLoaiDV.DisplayMember = "Loaidv";
            cbbLoaiDV.DataSource = dt;
            db.closeConnection();
        }
        #endregion

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int soluong = 0;
            int tieuthu = 0;
            string loaiDichVu = cbbLoaiDV.Text;
            string tenDV = txtTenDV.Text;
            int giaDV = Convert.ToInt32(txtGia.Text);
            string ghiChu = txtGhiChu.Text;
            blTDV.insertDV(tenDV, loaiDichVu,giaDV,soluong,tieuthu,ghiChu);
            this.Close();
            
        }

        private void ThemDichVu_Load(object sender, EventArgs e)
        {
            LoadCbbLoaiDV();
        }
    }
}
