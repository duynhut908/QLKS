namespace DACK
{
    partial class CaiDat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChinhSuaPass = new System.Windows.Forms.Button();
            this.btnChinhSuaUser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(79, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(79, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnChinhSuaPass);
            this.panel1.Controls.Add(this.btnChinhSuaUser);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(67, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 229);
            this.panel1.TabIndex = 1;
            // 
            // btnChinhSuaPass
            // 
            this.btnChinhSuaPass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChinhSuaPass.Location = new System.Drawing.Point(255, 66);
            this.btnChinhSuaPass.Name = "btnChinhSuaPass";
            this.btnChinhSuaPass.Size = new System.Drawing.Size(76, 20);
            this.btnChinhSuaPass.TabIndex = 1;
            this.btnChinhSuaPass.Text = "Chỉnh Sửa";
            this.btnChinhSuaPass.UseVisualStyleBackColor = false;
            this.btnChinhSuaPass.Click += new System.EventHandler(this.btnChinhSuaPass_Click);
            // 
            // btnChinhSuaUser
            // 
            this.btnChinhSuaUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChinhSuaUser.Location = new System.Drawing.Point(255, 22);
            this.btnChinhSuaUser.Name = "btnChinhSuaUser";
            this.btnChinhSuaUser.Size = new System.Drawing.Size(76, 20);
            this.btnChinhSuaUser.TabIndex = 1;
            this.btnChinhSuaUser.Text = "Chỉnh Sửa";
            this.btnChinhSuaUser.UseVisualStyleBackColor = false;
            this.btnChinhSuaUser.Click += new System.EventHandler(this.btnChinhSuaUser_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(147, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "pass";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(147, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "user";
            // 
            // CaiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "CaiDat";
            this.Size = new System.Drawing.Size(705, 414);
            this.Load += new System.EventHandler(this.CaiDat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChinhSuaPass;
        private System.Windows.Forms.Button btnChinhSuaUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
