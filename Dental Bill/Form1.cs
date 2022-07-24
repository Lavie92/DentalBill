namespace Dental_Bill
{
    public partial class Form1 : Form
    {
        float price = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtTenKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void btnConfrm_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                string warning = "Vui lòng nhập đầy đủ họ tên";
                MessageBox.Show(warning);
            }
            else
            {
                int price = 0;
                if (chkScaling.Checked)
                {
                    price += Convert.ToInt32(lblScaling.Text);
                }
                if (chkTeethWhitening.Checked)
                {
                    price += 1302002;
                }
                if (chkXRay.Checked)
                {
                    price += 500000;
                }
                price += (Int32)nudFillings.Value * 200000;
                txtTotal.Text = price.ToString();
            }    

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}