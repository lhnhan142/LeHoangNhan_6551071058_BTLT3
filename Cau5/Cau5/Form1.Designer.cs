namespace Cau5
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
            components = new System.ComponentModel.Container();
            grpColor = new GroupBox();
            radBlack = new RadioButton();
            radGreen = new RadioButton();
            radBlue = new RadioButton();
            radRed = new RadioButton();
            grpFont = new GroupBox();
            chkItalic = new CheckBox();
            chkUnderline = new CheckBox();
            chkBold = new CheckBox();
            lblNhapTen = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtNhapTen = new TextBox();
            lblLap = new Label();
            btnThoat = new Button();
            lblLapTrinh = new Label();
            grpColor.SuspendLayout();
            grpFont.SuspendLayout();
            SuspendLayout();
            // 
            // grpColor
            // 
            grpColor.BackColor = SystemColors.ActiveCaption;
            grpColor.Controls.Add(radBlack);
            grpColor.Controls.Add(radGreen);
            grpColor.Controls.Add(radBlue);
            grpColor.Controls.Add(radRed);
            grpColor.Location = new Point(174, 73);
            grpColor.Name = "grpColor";
            grpColor.Size = new Size(183, 268);
            grpColor.TabIndex = 0;
            grpColor.TabStop = false;
            grpColor.Text = "Color";
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radBlack.Location = new Point(16, 207);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(67, 24);
            radBlack.TabIndex = 3;
            radBlack.TabStop = true;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radGreen.ForeColor = Color.Green;
            radGreen.Location = new Point(16, 91);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(72, 24);
            radGreen.TabIndex = 2;
            radGreen.TabStop = true;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radBlue.ForeColor = Color.Blue;
            radBlue.Location = new Point(16, 150);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(61, 24);
            radBlue.TabIndex = 1;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(16, 31);
            radRed.Name = "radRed";
            radRed.Size = new Size(57, 24);
            radRed.TabIndex = 0;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            // 
            // grpFont
            // 
            grpFont.BackColor = Color.FromArgb(255, 224, 192);
            grpFont.Controls.Add(chkItalic);
            grpFont.Controls.Add(chkUnderline);
            grpFont.Controls.Add(chkBold);
            grpFont.Location = new Point(427, 87);
            grpFont.Name = "grpFont";
            grpFont.Size = new Size(172, 196);
            grpFont.TabIndex = 1;
            grpFont.TabStop = false;
            grpFont.Text = "Font";
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            chkItalic.Location = new Point(16, 77);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(121, 24);
            chkItalic.TabIndex = 6;
            chkItalic.Text = "Nghiêng Italic";
            chkItalic.UseVisualStyleBackColor = true;
            // 
            // chkUnderline
            // 
            chkUnderline.AutoSize = true;
            chkUnderline.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            chkUnderline.Location = new Point(16, 136);
            chkUnderline.Name = "chkUnderline";
            chkUnderline.Size = new Size(101, 24);
            chkUnderline.TabIndex = 5;
            chkUnderline.Text = "Gạch Chân";
            chkUnderline.UseVisualStyleBackColor = true;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkBold.Location = new Point(16, 26);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(100, 24);
            chkBold.TabIndex = 4;
            chkBold.Text = "Đậm Bold";
            chkBold.UseVisualStyleBackColor = true;
            // 
            // lblNhapTen
            // 
            lblNhapTen.AutoSize = true;
            lblNhapTen.BackColor = Color.Black;
            lblNhapTen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhapTen.ForeColor = Color.Lime;
            lblNhapTen.Location = new Point(73, 17);
            lblNhapTen.Name = "lblNhapTen";
            lblNhapTen.Size = new Size(100, 28);
            lblNhapTen.TabIndex = 2;
            lblNhapTen.Text = "Nhập tên";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtNhapTen
            // 
            txtNhapTen.Location = new Point(209, 21);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(249, 27);
            txtNhapTen.TabIndex = 4;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            // 
            // lblLap
            // 
            lblLap.AutoSize = true;
            lblLap.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLap.ForeColor = Color.Fuchsia;
            lblLap.Location = new Point(138, 397);
            lblLap.Name = "lblLap";
            lblLap.Size = new Size(125, 25);
            lblLap.TabIndex = 5;
            lblLap.Text = "Lập trình bởi:";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(542, 397);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.Location = new Point(299, 396);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(237, 30);
            lblLapTrinh.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLapTrinh);
            Controls.Add(btnThoat);
            Controls.Add(lblLap);
            Controls.Add(txtNhapTen);
            Controls.Add(lblNhapTen);
            Controls.Add(grpFont);
            Controls.Add(grpColor);
            Name = "Form1";
            Text = "Định Dạng (Formater)";
            grpColor.ResumeLayout(false);
            grpColor.PerformLayout();
            grpFont.ResumeLayout(false);
            grpFont.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpColor;
        private RadioButton radBlack;
        private RadioButton radGreen;
        private RadioButton radBlue;
        private RadioButton radRed;
        private GroupBox grpFont;
        private CheckBox chkItalic;
        private CheckBox chkUnderline;
        private CheckBox chkBold;
        private Label lblNhapTen;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtNhapTen;
        private Label txtLapTrinh;
        private Label lblLap;
        private Button btnThoat;
        private Label lblLapTrinh;
    }
}