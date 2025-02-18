
namespace DoAnCuoiKy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_CaiDat = new System.Windows.Forms.Button();
            this.btn_QuanLyHoaDon = new System.Windows.Forms.Button();
            this.btn_QuanLyNhanVien = new System.Windows.Forms.Button();
            this.btn_KhachHang = new System.Windows.Forms.Button();
            this.btn_DichVu = new System.Windows.Forms.Button();
            this.btn_Phong = new System.Windows.Forms.Button();
            this.pn_Main = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uc_KhachHang = new DoAnCuoiKy.CUF.KhachHang();
            this.uc_DichVu = new DoAnCuoiKy.CUF.DichVu();
            this.uc_BangPhanCong = new DoAnCuoiKy.CUF.BangPhanCong();
            this.uc_QuanLyHoaDon = new DoAnCuoiKy.CUF.QuanLyHoaDon();
            this.uc_LichSuLamViec = new DoAnCuoiKy.CUF.LichSuLamViec();
            this.uc_QuanLyNhanVien = new DoAnCuoiKy.CUF.QuanLyNhanVien();
            this.uc_CaiDat = new DACK.CaiDat();
            this.uc_ThongKe = new DoAnCuoiKy.CUF.ThongKe();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_CaiDat);
            this.panel1.Controls.Add(this.btn_QuanLyHoaDon);
            this.panel1.Controls.Add(this.btn_QuanLyNhanVien);
            this.panel1.Controls.Add(this.btn_KhachHang);
            this.panel1.Controls.Add(this.btn_DichVu);
            this.panel1.Controls.Add(this.btn_Phong);
            this.panel1.Location = new System.Drawing.Point(2, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 414);
            this.panel1.TabIndex = 0;
            // 
            // btn_CaiDat
            // 
            this.btn_CaiDat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_CaiDat.BackgroundImage = global::DoAnCuoiKy.Properties.Resources.bb;
            this.btn_CaiDat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CaiDat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CaiDat.Location = new System.Drawing.Point(2, 233);
            this.btn_CaiDat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CaiDat.Name = "btn_CaiDat";
            this.btn_CaiDat.Size = new System.Drawing.Size(45, 45);
            this.btn_CaiDat.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btn_CaiDat, "Cài Đặt");
            this.btn_CaiDat.UseVisualStyleBackColor = false;
            this.btn_CaiDat.Click += new System.EventHandler(this.btn_CaiDat_Click);
            // 
            // btn_QuanLyHoaDon
            // 
            this.btn_QuanLyHoaDon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_QuanLyHoaDon.BackgroundImage = global::DoAnCuoiKy.Properties.Resources.aaaa;
            this.btn_QuanLyHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_QuanLyHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QuanLyHoaDon.Location = new System.Drawing.Point(2, 188);
            this.btn_QuanLyHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_QuanLyHoaDon.Name = "btn_QuanLyHoaDon";
            this.btn_QuanLyHoaDon.Size = new System.Drawing.Size(45, 45);
            this.btn_QuanLyHoaDon.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btn_QuanLyHoaDon, "Quản Lý Hóa Đơn");
            this.btn_QuanLyHoaDon.UseVisualStyleBackColor = false;
            this.btn_QuanLyHoaDon.Click += new System.EventHandler(this.btn_QuanLyHoaDon_Click);
            // 
            // btn_QuanLyNhanVien
            // 
            this.btn_QuanLyNhanVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_QuanLyNhanVien.BackgroundImage = global::DoAnCuoiKy.Properties.Resources.ccc;
            this.btn_QuanLyNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_QuanLyNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QuanLyNhanVien.Location = new System.Drawing.Point(2, 142);
            this.btn_QuanLyNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.btn_QuanLyNhanVien.Name = "btn_QuanLyNhanVien";
            this.btn_QuanLyNhanVien.Size = new System.Drawing.Size(45, 45);
            this.btn_QuanLyNhanVien.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btn_QuanLyNhanVien, "Quản Lý Nhân Viên");
            this.btn_QuanLyNhanVien.UseVisualStyleBackColor = false;
            this.btn_QuanLyNhanVien.Click += new System.EventHandler(this.btn_QuanLyNhanVien_Click);
            // 
            // btn_KhachHang
            // 
            this.btn_KhachHang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_KhachHang.BackgroundImage = global::DoAnCuoiKy.Properties.Resources.kisspng_avenue_dental_care_team_company_innovation_organiz_people_icon_5abd937528af80_5052767615223734931667;
            this.btn_KhachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_KhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KhachHang.Location = new System.Drawing.Point(2, 48);
            this.btn_KhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.btn_KhachHang.Name = "btn_KhachHang";
            this.btn_KhachHang.Size = new System.Drawing.Size(45, 45);
            this.btn_KhachHang.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btn_KhachHang, "Khách Hàng");
            this.btn_KhachHang.UseVisualStyleBackColor = false;
            this.btn_KhachHang.Click += new System.EventHandler(this.btn_KhachHang_Click);
            // 
            // btn_DichVu
            // 
            this.btn_DichVu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_DichVu.BackgroundImage = global::DoAnCuoiKy.Properties.Resources.dv;
            this.btn_DichVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DichVu.Location = new System.Drawing.Point(2, 93);
            this.btn_DichVu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DichVu.Name = "btn_DichVu";
            this.btn_DichVu.Size = new System.Drawing.Size(45, 45);
            this.btn_DichVu.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_DichVu, "Dịch Vụ");
            this.btn_DichVu.UseVisualStyleBackColor = false;
            this.btn_DichVu.Click += new System.EventHandler(this.btn_DichVu_Click);
            // 
            // btn_Phong
            // 
            this.btn_Phong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Phong.BackgroundImage = global::DoAnCuoiKy.Properties.Resources.warehouse_30px;
            this.btn_Phong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Phong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Phong.Location = new System.Drawing.Point(2, 2);
            this.btn_Phong.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Phong.Name = "btn_Phong";
            this.btn_Phong.Size = new System.Drawing.Size(45, 45);
            this.btn_Phong.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_Phong, "Phòng");
            this.btn_Phong.UseVisualStyleBackColor = false;
            this.btn_Phong.Click += new System.EventHandler(this.btn_Phong_Click);
            // 
            // pn_Main
            // 
            this.pn_Main.AutoScroll = true;
            this.pn_Main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pn_Main.Location = new System.Drawing.Point(60, 65);
            this.pn_Main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_Main.Name = "pn_Main";
            this.pn_Main.Size = new System.Drawing.Size(705, 414);
            this.pn_Main.TabIndex = 8;
            this.pn_Main.Enter += new System.EventHandler(this.pn_Main_Enter);
            this.pn_Main.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pn_Main_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(2, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 51);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(643, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(544, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ca làm việc :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DoAnCuoiKy.Properties.Resources.time_30px;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(500, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // uc_KhachHang
            // 
            this.uc_KhachHang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uc_KhachHang.Location = new System.Drawing.Point(60, 65);
            this.uc_KhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.uc_KhachHang.Name = "uc_KhachHang";
            this.uc_KhachHang.Size = new System.Drawing.Size(705, 414);
            this.uc_KhachHang.TabIndex = 2;
            // 
            // uc_DichVu
            // 
            this.uc_DichVu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uc_DichVu.Location = new System.Drawing.Point(60, 65);
            this.uc_DichVu.Margin = new System.Windows.Forms.Padding(2);
            this.uc_DichVu.Name = "uc_DichVu";
            this.uc_DichVu.Size = new System.Drawing.Size(705, 414);
            this.uc_DichVu.TabIndex = 3;
            // 
            // uc_BangPhanCong
            // 
            this.uc_BangPhanCong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uc_BangPhanCong.Location = new System.Drawing.Point(60, 65);
            this.uc_BangPhanCong.Margin = new System.Windows.Forms.Padding(2);
            this.uc_BangPhanCong.Name = "uc_BangPhanCong";
            this.uc_BangPhanCong.Size = new System.Drawing.Size(705, 414);
            this.uc_BangPhanCong.TabIndex = 4;
            // 
            // uc_QuanLyHoaDon
            // 
            this.uc_QuanLyHoaDon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uc_QuanLyHoaDon.Location = new System.Drawing.Point(60, 65);
            this.uc_QuanLyHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.uc_QuanLyHoaDon.Name = "uc_QuanLyHoaDon";
            this.uc_QuanLyHoaDon.Size = new System.Drawing.Size(705, 414);
            this.uc_QuanLyHoaDon.TabIndex = 6;
            // 
            // uc_LichSuLamViec
            // 
            this.uc_LichSuLamViec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uc_LichSuLamViec.Location = new System.Drawing.Point(60, 65);
            this.uc_LichSuLamViec.Margin = new System.Windows.Forms.Padding(2);
            this.uc_LichSuLamViec.Name = "uc_LichSuLamViec";
            this.uc_LichSuLamViec.Size = new System.Drawing.Size(705, 414);
            this.uc_LichSuLamViec.TabIndex = 5;
            // 
            // uc_QuanLyNhanVien
            // 
            this.uc_QuanLyNhanVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uc_QuanLyNhanVien.Location = new System.Drawing.Point(60, 65);
            this.uc_QuanLyNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.uc_QuanLyNhanVien.Name = "uc_QuanLyNhanVien";
            this.uc_QuanLyNhanVien.Size = new System.Drawing.Size(705, 414);
            this.uc_QuanLyNhanVien.TabIndex = 7;
            // 
            // uc_CaiDat
            // 
            this.uc_CaiDat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uc_CaiDat.Location = new System.Drawing.Point(62, 67);
            this.uc_CaiDat.Name = "uc_CaiDat";
            this.uc_CaiDat.Size = new System.Drawing.Size(705, 414);
            this.uc_CaiDat.TabIndex = 9;
            // 
            // uc_ThongKe
            // 
            this.uc_ThongKe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uc_ThongKe.Location = new System.Drawing.Point(58, 65);
            this.uc_ThongKe.Name = "uc_ThongKe";
            this.uc_ThongKe.Size = new System.Drawing.Size(705, 414);
            this.uc_ThongKe.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(774, 488);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pn_Main);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uc_KhachHang);
            this.Controls.Add(this.uc_DichVu);
            this.Controls.Add(this.uc_BangPhanCong);
            this.Controls.Add(this.uc_QuanLyHoaDon);
            this.Controls.Add(this.uc_LichSuLamViec);
            this.Controls.Add(this.uc_QuanLyNhanVien);
            this.Controls.Add(this.uc_CaiDat);
            this.Controls.Add(this.uc_ThongKe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Quản Lý Khách Sạn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_CaiDat;
        private System.Windows.Forms.Button btn_QuanLyHoaDon;
        private System.Windows.Forms.Button btn_QuanLyNhanVien;
        private System.Windows.Forms.Button btn_KhachHang;
        private System.Windows.Forms.Button btn_DichVu;
        private System.Windows.Forms.Button btn_Phong;
        private CUF.KhachHang uc_KhachHang;
        private CUF.DichVu uc_DichVu;
        private CUF.BangPhanCong uc_BangPhanCong;
        private CUF.LichSuLamViec uc_LichSuLamViec;
        private CUF.QuanLyHoaDon uc_QuanLyHoaDon;
        private CUF.QuanLyNhanVien uc_QuanLyNhanVien;
        private System.Windows.Forms.FlowLayoutPanel pn_Main;
        private DACK.CaiDat uc_CaiDat;
        private System.Windows.Forms.ToolTip toolTip1;
        private CUF.ThongKe uc_ThongKe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

