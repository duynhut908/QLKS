using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.BLLayer
{
    class BLThemNV
    {
        ConnectDatabase db = new ConnectDatabase();

        #region Lấy họ tên nhân viên
        public string layHoTen(int x)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("select HoTen from nhanvien where ID = N'" + x + "'", db.getConnection);
            string hoTen = cmd.ExecuteScalar().ToString();
            db.closeConnection();
            return hoTen;
        }
        #endregion

        #region Lấy ngày sinh nhân viên
        public string layNgaySinh(int x)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("select NgaySinh from nhanvien where ID = N'" + x + "'", db.getConnection);
            string ngaysinh = cmd.ExecuteScalar().ToString();
            db.closeConnection();
            return ngaysinh;
        }
        #endregion

        #region Lấy giới tính nhân viên
        public string layGioiTinh(int x)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("select GioiTinh from nhanvien where ID = N'" + x + "'", db.getConnection);
            string gioitinh = cmd.ExecuteScalar().ToString();
            db.closeConnection();
            return gioitinh;
        }
        #endregion

        #region Lấy cmnd nhân viên
        public string layCMND(int x)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("select CMND from nhanvien where ID = N'" + x + "'", db.getConnection);
            string cmnd = cmd.ExecuteScalar().ToString();
            db.closeConnection();
            return cmnd;
        }
        #endregion

        #region Lấy sdt nhân viên
        public string laySDT(int x)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("select SoDT from nhanvien where ID = N'" + x + "'", db.getConnection);
            string sodt = cmd.ExecuteScalar().ToString();
            db.closeConnection();
            return sodt;
        }
        #endregion

        #region Lấy địa chỉ nhân viên
        public string layDiaChi(int x)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("select DiaChi from nhanvien where ID = N'" + x + "'", db.getConnection);
            string diachi = cmd.ExecuteScalar().ToString();
            db.closeConnection();
            return diachi;
        }
        #endregion

        #region Lấy chức vụ nhân viên
        public string layChucVu(int x)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("select ChucVu from nhanvien where ID = N'" + x + "'", db.getConnection);
            string chucvu = cmd.ExecuteScalar().ToString();
            db.closeConnection();
            return chucvu;
        }
        #endregion

        #region Thêm nhân viên
        public void insertNV(int id,string hoTen,string ngaySinh, string gioiTinh,string cmnd,string sdt,string diaChi,string chucVu)
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("insert into nhanvien values ('" + id + "', N'" + hoTen + "', N'" + ngaySinh + "', N'" + gioiTinh + "', N'" + cmnd + "', N'" + sdt + "', N'" + diaChi + "',N'" + chucVu + "')", db.getConnection);
            command.ExecuteNonQuery();
            db.closeConnection();
        }
        #endregion

        #region Sửa thông tin nhân viên
        public void updateNV(int id, string hoTen, string ngaySinh, string gioiTinh, string cmnd, string sdt, string diaChi, string chucVu)
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("UPDATE nhanvien SET HoTen = N'" + hoTen + "', NgaySinh = N'" + ngaySinh + "', GioiTinh = N'" + gioiTinh + "', CMND = N'" + cmnd + "', SoDT = N'" + sdt + "', DiaChi = N'" + diaChi + "', ChucVu = N'" + chucVu + "' WHERE ID = '" + id + "';", db.getConnection);
            command.ExecuteNonQuery();
            db.closeConnection();
        }
        #endregion

        #region Xóa nhân viên
        public void xoaNV(int id)
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("delete from nhanvien where ID = '" + id + "'", db.getConnection);
            command.ExecuteNonQuery();
            db.closeConnection();
        }
        #endregion
    }
}
