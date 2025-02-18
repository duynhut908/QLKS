using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.BLLayer
{
    class BLDichVu
    {
        ConnectDatabase db = new ConnectDatabase();

        #region Load số lượng dịch vụ
        public int loadNum(int mdv)
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("select SoLuong from dv WHERE MaDv = '" + mdv + "'", db.getConnection);
            int soLuong = Convert.ToInt32(command.ExecuteScalar());
            db.closeConnection();
            return soLuong;
        }
        #endregion

        #region Load id dịch vụ
        public int loadID(string phong)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("select ID from hoadon where phong = '" + phong + "' and TrangThai = 'Chưa thanh toán'", db.getConnection);
            int mahoadon = Convert.ToInt32(cmd.ExecuteScalar());
            db.closeConnection();
            return mahoadon;
        }
        #endregion

        #region Lấy giá dịch vụ
        public int giaDV(string mdv)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("select Gia from dv where MaDv = '" + mdv + "'", db.getConnection);
            int giaDichVu = Convert.ToInt32(cmd.ExecuteScalar());
            db.closeConnection();
            return giaDichVu;
        }
        #endregion

        #region Load số lượng chi tiết từng dịch vụ
        public int soLuong(int mdv)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("select SoLuong from dv WHERE MaDv = '" + mdv + "'", db.getConnection);
            int soLuong = Convert.ToInt32(cmd.ExecuteScalar());
            db.closeConnection();
            return soLuong;
        }
        #endregion

        #region Update dịch vụ
        public void updateSoLuong(int soLuongNew,int mDV)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("UPDATE dv SET SoLuong = '" + soLuongNew + "' WHERE MaDv = '" + mDV + "'; ", db.getConnection);
            cmd.ExecuteNonQuery();
            db.closeConnection();
        }
        #endregion

        #region Thêm dịch vụ
        public void insertHoadonct(int mahoadon, int mDV,decimal value, int tongTien)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("insert into hoadonct values('" + mahoadon + "','" + mDV + "','" + value + "','" + tongTien + "')", db.getConnection);
            cmd.ExecuteNonQuery();
            db.closeConnection();
        }
        #endregion

        #region Load giá tiền dịch vụ
        public int thanhTien(int mahoadon)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("select ThanhToan from hoadon where ID = '" + mahoadon + "'", db.getConnection);
            int thanhTien = Convert.ToInt32(cmd.ExecuteScalar());
            db.closeConnection();
            return thanhTien;
        }
        #endregion

        #region Update hóa đơn
        public void updateHoaDon(int tongThanhToan, int mahoadon)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("UPDATE hoadon SET ThanhToan = '" + tongThanhToan + "' WHERE ID = '" + mahoadon + "'; ", db.getConnection);
            cmd.ExecuteNonQuery();
            db.closeConnection();
        }
        #endregion
    }
}
