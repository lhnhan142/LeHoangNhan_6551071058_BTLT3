namespace TaoMau
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pwlbl = new Label();
            lblHienThi = new Label();
            txtMatKhau = new TextBox();
            txtHienThi = new TextBox();
            btnShow = new Button();
            btnTiep = new Button();
            bntDong = new Button();
            SuspendLayout();
            // 
            // pwlbl
            // 
            pwlbl.AutoSize = true;
            pwlbl.Location = new Point(131, 60);
            pwlbl.Name = "pwlbl";
            pwlbl.Size = new Size(110, 20);
            pwlbl.TabIndex = 0;
            pwlbl.Text = "Nhập mật khẩu";
            pwlbl.Click += label1_Click;
            // 
            // lblHienThi
            // 
            lblHienThi.AutoSize = true;
            lblHienThi.Location = new Point(146, 111);
            lblHienThi.Name = "lblHienThi";
            lblHienThi.Size = new Size(61, 20);
            lblHienThi.TabIndex = 1;
            lblHienThi.Text = "Hiển thị";
            lblHienThi.Click += label2_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(256, 60);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(125, 27);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.Text = "áhdkasd";
            // 
            // txtHienThi
            // 
            txtHienThi.Location = new Point(256, 104);
            txtHienThi.Name = "txtHienThi";
            txtHienThi.Size = new Size(125, 27);
            txtHienThi.TabIndex = 3;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(146, 251);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 4;
            btnShow.Text = "Hiển thị";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnTiep
            // 
            btnTiep.Location = new Point(350, 251);
            btnTiep.Name = "btnTiep";
            btnTiep.Size = new Size(94, 29);
            btnTiep.TabIndex = 5;
            btnTiep.Text = "Tiếp";
            btnTiep.UseVisualStyleBackColor = true;
            btnTiep.Click += btnTiep_Click;
            // 
            // bntDong
            // 
            bntDong.Location = new Point(569, 251);
            bntDong.Name = "bntDong";
            bntDong.Size = new Size(94, 29);
            bntDong.TabIndex = 6;
            bntDong.Text = "Đóng";
            bntDong.UseVisualStyleBackColor = true;
            bntDong.Click += bntDong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bntDong);
            Controls.Add(btnTiep);
            Controls.Add(btnShow);
            Controls.Add(txtHienThi);
            Controls.Add(txtMatKhau);
            Controls.Add(lblHienThi);
            Controls.Add(pwlbl);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pwlbl;
        private Label lblHienThi;
        private TextBox txtMatKhau;
        private TextBox txtHienThi;
        private Button btnShow;
        private Button btnTiep;
        private Button bntDong;
    }
}
