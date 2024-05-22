namespace LoginFormTasarimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            codeOlustur();  // Formda gözükmesi için loada çaüğrdım.
            timer1.Start(); // acınca timerda bailasın
        }
        void codeOlustur() // capce olusturdum bircok yerde kullanmak için burada olusturdum.
        {
            Random rastgle = new Random();
            int sayi = rastgle.Next(100000, 1000000);
            textCode.Text = sayi.ToString();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKullanici.Text == "admin" && txtSifre.Text == "1234" && txtcode1.Text == textCode.Text)
            {
                Form2 frm = new Form2();
                frm.kullanici = txtKullanici.Text; // frm.Show:() dan önce olması elzem formlar arası veri taşıma .
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı bilgi girişi : Kullanıcı adı, şifre veya kod Yanlış girildi.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac % 2 == 0)
            {
                label3.BackColor = Color.White;
            }
            else {
                label3.BackColor = Color.Red;
            }
            if (sayac == 10)
            {
                sayac = 0;  
            }
        }
    }
}
