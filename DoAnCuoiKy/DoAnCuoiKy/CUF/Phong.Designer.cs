
namespace DoAnCuoiKy.CUF
{
    partial class Phong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lb_maphong = new System.Windows.Forms.Label();
            this.lb_trangthai = new System.Windows.Forms.Label();
            this.lb_Loaiphong = new System.Windows.Forms.Label();
            this.btn_Dat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ThemSuaXoa = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemSuaXoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_maphong
            // 
            this.lb_maphong.AutoSize = true;
            this.lb_maphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maphong.Location = new System.Drawing.Point(38, 19);
            this.lb_maphong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_maphong.Name = "lb_maphong";
            this.lb_maphong.Size = new System.Drawing.Size(49, 17);
            this.lb_maphong.TabIndex = 0;
            this.lb_maphong.Text = "Phòng";
            // 
            // lb_trangthai
            // 
            this.lb_trangthai.AutoSize = true;
            this.lb_trangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_trangthai.Location = new System.Drawing.Point(9, 58);
            this.lb_trangthai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_trangthai.Name = "lb_trangthai";
            this.lb_trangthai.Size = new System.Drawing.Size(70, 17);
            this.lb_trangthai.TabIndex = 1;
            this.lb_trangthai.Text = "Còn trống";
            // 
            // lb_Loaiphong
            // 
            this.lb_Loaiphong.AutoSize = true;
            this.lb_Loaiphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Loaiphong.Location = new System.Drawing.Point(9, 89);
            this.lb_Loaiphong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Loaiphong.Name = "lb_Loaiphong";
            this.lb_Loaiphong.Size = new System.Drawing.Size(35, 17);
            this.lb_Loaiphong.TabIndex = 2;
            this.lb_Loaiphong.Text = "Loại";
            // 
            // btn_Dat
            // 
            this.btn_Dat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dat.Location = new System.Drawing.Point(11, 128);
            this.btn_Dat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Dat.Name = "btn_Dat";
            this.btn_Dat.Size = new System.Drawing.Size(43, 33);
            this.btn_Dat.TabIndex = 3;
            this.btn_Dat.Text = "Đặt";
            this.btn_Dat.UseVisualStyleBackColor = true;
            this.btn_Dat.Click += new System.EventHandler(this.btn_Dat_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(69, 128);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Trả";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Tra_Click);
            // 
            // ThemSuaXoa
            // 
            this.ThemSuaXoa.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.ThemSuaXoa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thênToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.ThemSuaXoa.Name = "ThemSuaXoa";
            this.ThemSuaXoa.Size = new System.Drawing.Size(181, 70);
            // 
            // thênToolStripMenuItem
            // 
            this.thênToolStripMenuItem.Name = "thênToolStripMenuItem";
            this.thênToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thênToolStripMenuItem.Text = "Thêm";
            this.thênToolStripMenuItem.Click += new System.EventHandler(this.thênToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Dat);
            this.Controls.Add(this.lb_Loaiphong);
            this.Controls.Add(this.lb_trangthai);
            this.Controls.Add(this.lb_maphong);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Phong";
            this.Size = new System.Drawing.Size(126, 177);
            this.Load += new System.EventHandler(this.Phong_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Phong_MouseClick);
            this.ThemSuaXoa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_maphong;
        private System.Windows.Forms.Label lb_trangthai;
        private System.Windows.Forms.Label lb_Loaiphong;
        private System.Windows.Forms.Button btn_Dat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip ThemSuaXoa;
        private System.Windows.Forms.ToolStripMenuItem thênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
    }
}
