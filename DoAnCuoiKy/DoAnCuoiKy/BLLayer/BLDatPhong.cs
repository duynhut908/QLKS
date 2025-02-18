using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.BLLayer
{
    class BLDatPhong
    {
        ConnectDatabase db = new ConnectDatabase();

        #region Load tất cả các phòng
        public string LoadPhong(string maphong)
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("select typephong.TenPhong from phong " +
                                                "inner join typephong on phong.LoaiPhong = typephong.TypePhong " +
                                                "where phong.MaPhong = '" + maphong + "'", db.getConnection);
            string loai = command.ExecuteScalar().ToString();
            db.closeConnection();
            return loai;
        }
        #endregion
        
        #region Load tiền chi tiết của từng phòng
        public int loadTien(string loaiphong)
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("select ChiPhi from typephong where TypePhong = '" + loaiphong + "'", db.getConnection);
            int giaphong = Convert.ToInt32(command.ExecuteScalar());
            db.closeConnection();
            return giaphong;
        }
        #endregion

        #region Thêm hóa đơn mới
        public void insetHoaDon(string maphong, string timeIn,string timeOut, string ttThanhToan, int tongtien)
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("insert into hoadon values ('" + maphong + "'," +
                                                "'" + timeIn + "','" + timeOut + "',N'" + ttThanhToan + "','" + tongtien + "')", db.getConnection);
            command.ExecuteNonQuery();
            db.closeConnection();
        }
        #endregion

        #region Thêm khách hàng mới
        public void insetKhachHang(string tenKhach, string cmnd, string sdt,string maphong, string ghichu,string ttThanhToan)
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("insert into khachhang values (N'" + tenKhach + "'," +
                                                "'" + cmnd + "','" + sdt + "','" + maphong + "',N'" + ghichu + "','" + ttThanhToan + "')", db.getConnection);
            command.ExecuteNonQuery();
            db.closeConnection();
        }
        #endregion

        #region Cập nhập trạng thái phòng
        public void updatePhong(string trangthaiP,string maphong)
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("update phong set TrangThai = N'" + trangthaiP + "' where MaPhong = '" + maphong + "'", db.getConnection);
            command.ExecuteNonQuery();

            db.closeConnection();
        }
        #endregion
    }
}
