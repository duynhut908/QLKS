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
    public partial class DichVu : UserControl
    {
        ConnectDatabase db = new ConnectDatabase();
        BLDichVu blDV = new BLDichVu();

        #region Load List Dịch Vụ
        public void List_DV()
        {

            db.openConnection();
            SqlCommand command = new SqlCommand("select tenDV from dv", db.getConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DVhotel dvHotel = new DVhotel(reader.GetValue(0).ToString());
                dvHotel.AutoSize = false;
                flpn_dichvu.Controls.Add(dvHotel);
            }
            db.closeConnection();
        }
        #endregion

        #region Load combobox phòng
        private void LoadCbbPhong()
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("select MaPhong from phong where TrangThai = 'Đang thuê'", db.getConnection);
            var dr = command.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbb_Phong.DisplayMember = "MaPhong";
            //cbb_Phong.ValueMember = "MaPhong";
            cbb_Phong.DataSource = dt;
            db.closeConnection();
        }
        #endregion

        #region Load combobox Dịch Vụ
        private void LoadCbbDV()
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("select * from dv", db.getConnection);
            var dr = command.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbb_DichVu.DisplayMember = "TenDv";
            //cbb_Phong.ValueMember = "MaPhong";
            cbb_DichVu.ValueMember = "MaDv";
            cbb_DichVu.DataSource = dt;
            db.closeConnection();
        }
        #endregion

        #region Load DGV DV
        private void LoadDGVDivhVu()
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("select * from hoadonct", db.getConnection);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
            db.closeConnection();
        }
        #endregion

        #region Load Num
        private void LoadeNum()
        {
            string maDichVu = cbb_DichVu.SelectedValue.ToString();
            int mDV = Convert.ToInt32(maDichVu);
            int soLuong = blDV.loadNum(mDV);
            numericUpDown1.Maximum = soLuong;
        }
        #endregion
        public DichVu()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ThemDichVu them = new ThemDichVu();
            them.Show();

        }

        private void btn_NhapKho_Click(object sender, EventArgs e)
        {
            NhapKho nhap = new NhapKho();
            nhap.Show();
        }

        private void DichVu_Load(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Click += Btn_Click;
            LoadCbbPhong();
            LoadCbbDV();
            List_DV();
            LoadDGVDivhVu();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flpn_dichvu_MouseClick(object sender, MouseEventArgs e)
        {
            flpn_dichvu.Controls.Clear();
            List_DV();
            LoadCbbDV();
            LoadCbbPhong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string phong = cbb_Phong.Text;
            int mahoadon = blDV.loadID(phong);

            decimal value = numericUpDown1.Value;
            string num = Convert.ToString(value);

            string maDichVu = cbb_DichVu.SelectedValue.ToString();
            int mDV = Convert.ToInt32(maDichVu);
            int giaDichVu = blDV.giaDV(maDichVu);
            int tongTien = (int)(giaDichVu * value);
            int soLuong = blDV.soLuong(mDV);
            int soLuongNew = (int)(soLuong - value);
            blDV.updateSoLuong(soLuongNew,mDV);
            blDV.insertHoadonct(mahoadon,mDV,value,tongTien);
            int thanhTien = blDV.thanhTien(mahoadon);
            int tongThanhToan = (int)(thanhTien + tongTien);
            blDV.updateHoaDon(tongThanhToan,mahoadon);
            LoadDGVDivhVu();
        }

        private void DichVu_MouseMove(object sender, MouseEventArgs e)
        {
            LoadCbbDV();
            LoadCbbPhong();
        }

        private void cbb_DichVu_MouseMove(object sender, MouseEventArgs e)
        {
            LoadeNum();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            LoadeNum();
        }
    }
}
