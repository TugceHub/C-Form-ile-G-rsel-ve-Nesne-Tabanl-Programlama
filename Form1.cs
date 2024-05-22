namespace Dosya_İşlemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void konumsec_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog(); // Bu dialog penceresini bana göster.
            textYol.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textYol.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        string Belgeadi, Belgeyolu;

        private void KonumSecBTN_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Belgeyolu = folderBrowserDialog1.SelectedPath;
                textYol.Text = Belgeyolu;
            }
        }

        private void olusturBTN_Click(object sender, EventArgs e)
        {
            Belgeadi = textAd.Text;
            StreamWriter sw = File.CreateText(Belgeyolu + "//" + Belgeadi + ".txt");
            MessageBox.Show("Belgeniz Oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void okuBTN_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) ;
            {
                StreamReader oku = new StreamReader(openFileDialog1.FileName);
                string satir = oku.ReadLine();
                while (satir != null)
                {
                    listBox1.Items.Add(satir);
                    satir = oku.ReadLine();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.Filter= "Metin Dosyası | *.txt";  // filtreleme
            saveFileDialog1.ShowDialog();
            StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName);   
           kaydet.WriteLine(richTextBox1.Text);
            kaydet.Close(); 
            MessageBox.Show("Kayıt Başarılı.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Warning);    
        }
    }
}
