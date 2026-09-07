namespace Cau5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNhapTen.Focus();
            radRed.Checked = true;
        }

        // Sự kiện trống do lỡ nhấp đúp (cứ để nguyên không sao)
        private void button1_Click(object sender, EventArgs e)
        {
        }

        // Sự kiện trống do lỡ nhấp đúp
        private void RadBlack_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapTen.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
            {
                lblLapTrinh.ForeColor = Color.Red;
                txtNhapTen.ForeColor = Color.Red;
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
            {
                lblLapTrinh.ForeColor = Color.Green;
                txtNhapTen.ForeColor = Color.Green;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
            {
                lblLapTrinh.ForeColor = Color.Blue;
                txtNhapTen.ForeColor = Color.Blue;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked)
            {
                lblLapTrinh.ForeColor = Color.Black;
                txtNhapTen.ForeColor = Color.Black;
            }
        }

        // ==========================================
        // ĐÃ SỬA LỖI Ở 3 HÀM FONT BÊN DƯỚI
        // ==========================================
        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            // Bật/tắt In đậm cho ô Kết quả (Đã đổi toàn bộ txtLapTrinh thành lblLapTrinh)
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Bold);
            // Bật/tắt In đậm cho ô Nhập tên
            txtNhapTen.Font = new Font(txtNhapTen.Font.Name, txtNhapTen.Font.Size, txtNhapTen.Font.Style ^ FontStyle.Bold);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            // Bật/tắt In nghiêng cho ô Kết quả (Đã đổi toàn bộ txtLapTrinh thành lblLapTrinh)
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Italic);
            // Bật/tắt In nghiêng cho ô Nhập tên
            txtNhapTen.Font = new Font(txtNhapTen.Font.Name, txtNhapTen.Font.Size, txtNhapTen.Font.Style ^ FontStyle.Italic);
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            // Bật/tắt Gạch chân cho ô Kết quả (Đã đổi toàn bộ txtLapTrinh thành lblLapTrinh)
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Underline);
            // Bật/tắt Gạch chân cho ô Nhập tên
            txtNhapTen.Font = new Font(txtNhapTen.Font.Name, txtNhapTen.Font.Size, txtNhapTen.Font.Style ^ FontStyle.Underline);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Sự kiện trống do lỡ nhấp đúp
        private void lblLapTrinh_Click(object sender, EventArgs e)
        {
        }
    }
}