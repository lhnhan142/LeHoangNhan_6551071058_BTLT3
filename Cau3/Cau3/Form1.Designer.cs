namespace Cau3
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
            lblTen = new Label();
            lblHoTen = new Label();
            txtHoLot = new TextBox();
            txtTen = new TextBox();
            lblHoLot = new Label();
            btnHoLot = new Button();
            btnHoTen = new Button();
            btnTen = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(113, 189);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(32, 20);
            lblTen.TabIndex = 0;
            lblTen.Text = "Tên";
            // 
            // lblHoTen
            // 
            lblHoTen.BackColor = SystemColors.ActiveCaption;
            lblHoTen.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoTen.Location = new Point(-5, 0);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(804, 100);
            lblHoTen.TabIndex = 2;
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            lblHoTen.Click += lblHoTen_Click;
            // 
            // txtHoLot
            // 
            txtHoLot.Location = new Point(246, 126);
            txtHoLot.Name = "txtHoLot";
            txtHoLot.Size = new Size(425, 27);
            txtHoLot.TabIndex = 3;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.FromArgb(255, 128, 128);
            txtTen.Location = new Point(246, 189);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(425, 27);
            txtTen.TabIndex = 5;
            // 
            // lblHoLot
            // 
            lblHoLot.AutoSize = true;
            lblHoLot.Location = new Point(101, 126);
            lblHoLot.Name = "lblHoLot";
            lblHoLot.Size = new Size(51, 20);
            lblHoLot.TabIndex = 6;
            lblHoLot.Text = "Họ lót";
            // 
            // btnHoLot
            // 
            btnHoLot.Location = new Point(132, 285);
            btnHoLot.Name = "btnHoLot";
            btnHoLot.Size = new Size(94, 29);
            btnHoLot.TabIndex = 7;
            btnHoLot.Text = "Họ lót";
            btnHoLot.UseVisualStyleBackColor = true;
            btnHoLot.Click += btnHoLot_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Location = new Point(577, 285);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(94, 29);
            btnHoTen.TabIndex = 9;
            btnHoTen.Text = "Họ và tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(353, 285);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(94, 29);
            btnTen.TabIndex = 10;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // button5
            // 
            button5.Location = new Point(305, 380);
            button5.Name = "button5";
            button5.Size = new Size(185, 29);
            button5.TabIndex = 11;
            button5.Text = "Thoát chương trình";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(btnTen);
            Controls.Add(btnHoTen);
            Controls.Add(btnHoLot);
            Controls.Add(lblHoLot);
            Controls.Add(txtTen);
            Controls.Add(txtHoLot);
            Controls.Add(lblHoTen);
            Controls.Add(lblTen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTen;
        private Label lblHoTen;
        private TextBox txtHoLot;
        private TextBox txtTen;
        private Label lblHoLot;
        private Button btnHoLot;
        private Button btnHoTen;
        private Button btnTen;
        private Button button5;
    }
}
