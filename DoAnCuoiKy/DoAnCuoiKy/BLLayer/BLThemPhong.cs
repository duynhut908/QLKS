using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.BLLayer
{
    class BLThemPhong
    {
        ConnectDatabase db = new ConnectDatabase();
        public void themPhong(string tenphong,string trangThai,string loaiPhong)
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("insert into phong values ('" + tenphong + "',N'" + trangThai + "','" + loaiPhong + "')", db.getConnection);
            command.ExecuteNonQuery();
            db.closeConnection();
        }
    }
}
