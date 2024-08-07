namespace CSharp_TinhTienDien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double sokWh = Convert.ToDouble(txtSokWh.Text);
            double[] giadien = {1678, 1734, 2014};

            double tongTien = 0;
            int bac = 0;

            while (sokWh > 0)
            {
                double j = Math.Min(sokWh, 50);

                tongTien += j * giadien[bac];
                sokWh -= j;

                bac++;

                lblKQ.Text = tongTien.ToString();

            }

        }
    }
}
