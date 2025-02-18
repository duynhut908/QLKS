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
    public partial class DVhotel : UserControl
    {
        ConnectDatabase db = new ConnectDatabase();
        private string TenDV;
        public DVhotel(string tenDV)
        {
            InitializeComponent();
            this.TenDV = tenDV;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DVhotel_Load(object sender, EventArgs e)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("select tenDV from dv", db.getConnection);
            lb_TenDV.Text = TenDV;
            db.closeConnection();
        }
    }
}
