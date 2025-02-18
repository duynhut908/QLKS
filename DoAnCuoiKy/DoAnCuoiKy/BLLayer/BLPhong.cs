using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.BLLayer
{
    class BLPhong
    {
        ConnectDatabase db = new ConnectDatabase();

        #region Load dữ liệu phòng
        public string LoadDuLieuPhong(string loaiphong)
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("select typephong.TenPhong from typephong " +
                                                "where typephong.TypePhong = '" + loaiphong + "'", db.getConnection);
            string loai = command.ExecuteScalar().ToString();

            return loai;
            db.closeConnection();
        }
        #endregion

        #region Xóa Phòng
        public void XoaPhong(string maphong)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("delete from phong where MaPhong = '" + maphong + "'", db.getConnection);
            cmd.ExecuteNonQuery();
            db.closeConnection();
        }
        #endregion
    }
}
