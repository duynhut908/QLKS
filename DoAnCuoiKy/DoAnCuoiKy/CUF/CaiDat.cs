using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DACK
{
    public partial class CaiDat : UserControl
    {
        public CaiDat()
        {
            InitializeComponent();
        }

        private void btnChinhSuaUser_Click(object sender, EventArgs e)
        {
            DoiTenUser doiTenUser = new DoiTenUser();
            doiTenUser.Show();
        }

        private void btnChinhSuaPass_Click(object sender, EventArgs e)
        {
            DoiPass doiPass = new DoiPass();
            doiPass.Show();
        }

        private void CaiDat_Load(object sender, EventArgs e)
        {

        }
    }
}
