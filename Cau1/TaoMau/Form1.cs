namespace TaoMau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bntDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            lblHienThi.Text = "";
            txtMatKhau.Clear();
            txtHienThi.Focus();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtMatKhau.Text;

        }
    }
}
