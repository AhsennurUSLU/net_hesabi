namespace net_hesabi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click_1(object sender, EventArgs e)
        {
            double turkceDogru, turkceYanlis, turkceNet;
            double matDogru, matYanlis, matNet;
            double fizDogru, fizYanlis, fizNet;
            double biyDogru, biyYanlis, biyNet;
            double kimDogru, kimYanlis, kimNet;
            double topNet;

            turkceDogru = Convert.ToDouble(txtTurkceDogru.Text);
            turkceYanlis = Convert.ToDouble(txtTurkceYanlis.Text);

            matDogru = Convert.ToDouble(txtMatDogru.Text);
            matYanlis = Convert.ToDouble(txtMatYanlis.Text);

            fizDogru = Convert.ToDouble(txtFizDogru.Text);
            fizYanlis = Convert.ToDouble(txtFizYanlis.Text);

            biyDogru = Convert.ToDouble(txtBiyDogru.Text);
            biyYanlis = Convert.ToDouble(txtBiyYanlis.Text);

            kimDogru = Convert.ToDouble(txtKimDogru.Text);
            kimYanlis = Convert.ToDouble(txtKimYanlis.Text);


            turkceNet = turkceDogru - (turkceYanlis / 4);
            matNet = matDogru - (matYanlis / 4);
            fizNet = fizDogru - (fizYanlis / 4);
            biyNet = biyDogru - (biyYanlis / 4);
            kimNet = kimDogru - (kimYanlis / 4);
            topNet = turkceNet + matNet + kimNet + fizNet + biyNet;

            txtTurkceNet.Text = turkceNet.ToString();
            txtMatNet.Text = matNet.ToString();
            txtFizNet.Text = fizNet.ToString();
            txtBiyNet.Text = biyNet.ToString();
            txtKimNet.Text = kimNet.ToString();
            txtTopNet.Text = topNet.ToString();

        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}