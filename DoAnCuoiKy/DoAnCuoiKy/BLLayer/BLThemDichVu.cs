using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.BLLayer
{
    class BLThemDichVu
    {
        ConnectDatabase db = new ConnectDatabase();
        public void insertDV(string tenDV, string loaiDV,int gia,int soluong,int tieuthu,string ghiChu)
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("insert into dv values (N'" + tenDV + "',N'" + loaiDV + "','" + gia + "','" + soluong + "','" + tieuthu + "',N'" + ghiChu + "','')", db.getConnection);
            command.ExecuteNonQuery();
            db.closeConnection();
        }
    }
}
