namespace Cau2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi my name is Nhan");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form was clicked.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hi , Welcome to C# 2010 programming!");
        }
    }
}
