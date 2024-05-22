namespace Dosya_İşlemleri
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
            FolderBrowserBTN = new Button();
            label1 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialog1 = new OpenFileDialog();
            openFileBTN = new Button();
            SaveBTN = new Button();
            saveFileDialog1 = new SaveFileDialog();
            textYol = new TextBox();
            labelYol = new Label();
            olusturBTN = new Button();
            KonumSecBTN = new Button();
            LabelAd = new Label();
            textAd = new TextBox();
            okuBTN = new Button();
            listBox1 = new ListBox();
            richTextBox1 = new RichTextBox();
            yazdirBTN = new Button();
            SuspendLayout();
            // 
            // FolderBrowserBTN
            // 
            FolderBrowserBTN.Location = new Point(532, 12);
            FolderBrowserBTN.Name = "FolderBrowserBTN";
            FolderBrowserBTN.Size = new Size(145, 33);
            FolderBrowserBTN.TabIndex = 0;
            FolderBrowserBTN.Text = "Folder Browser Dialog ";
            FolderBrowserBTN.UseVisualStyleBackColor = true;
            FolderBrowserBTN.Click += konumsec_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 586);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileBTN
            // 
            openFileBTN.Location = new Point(532, 51);
            openFileBTN.Name = "openFileBTN";
            openFileBTN.Size = new Size(145, 37);
            openFileBTN.TabIndex = 2;
            openFileBTN.Text = " Open File Dialog";
            openFileBTN.UseVisualStyleBackColor = true;
            openFileBTN.Click += button1_Click;
            // 
            // SaveBTN
            // 
            SaveBTN.Location = new Point(532, 91);
            SaveBTN.Name = "SaveBTN";
            SaveBTN.Size = new Size(145, 32);
            SaveBTN.TabIndex = 3;
            SaveBTN.Text = "Save File Dialog";
            SaveBTN.UseVisualStyleBackColor = true;
            SaveBTN.Click += button2_Click;
            // 
            // textYol
            // 
            textYol.Location = new Point(90, 18);
            textYol.Name = "textYol";
            textYol.Size = new Size(407, 23);
            textYol.TabIndex = 4;
            // 
            // labelYol
            // 
            labelYol.AutoSize = true;
            labelYol.Location = new Point(12, 21);
            labelYol.Name = "labelYol";
            labelYol.Size = new Size(71, 15);
            labelYol.TabIndex = 5;
            labelYol.Text = "Belge Yolu  :";
            // 
            // olusturBTN
            // 
            olusturBTN.Location = new Point(532, 167);
            olusturBTN.Name = "olusturBTN";
            olusturBTN.Size = new Size(145, 32);
            olusturBTN.TabIndex = 6;
            olusturBTN.Text = "Oluştur";
            olusturBTN.UseVisualStyleBackColor = true;
            olusturBTN.Click += olusturBTN_Click;
            // 
            // KonumSecBTN
            // 
            KonumSecBTN.Location = new Point(532, 129);
            KonumSecBTN.Name = "KonumSecBTN";
            KonumSecBTN.Size = new Size(145, 32);
            KonumSecBTN.TabIndex = 7;
            KonumSecBTN.Text = "Konum Seç";
            KonumSecBTN.UseVisualStyleBackColor = true;
            KonumSecBTN.Click += KonumSecBTN_Click;
            // 
            // LabelAd
            // 
            LabelAd.AutoSize = true;
            LabelAd.Location = new Point(12, 62);
            LabelAd.Name = "LabelAd";
            LabelAd.Size = new Size(66, 15);
            LabelAd.TabIndex = 9;
            LabelAd.Text = "Belge Adı  :";
            // 
            // textAd
            // 
            textAd.Location = new Point(90, 59);
            textAd.Name = "textAd";
            textAd.Size = new Size(407, 23);
            textAd.TabIndex = 8;
            // 
            // okuBTN
            // 
            okuBTN.Location = new Point(532, 205);
            okuBTN.Name = "okuBTN";
            okuBTN.Size = new Size(145, 32);
            okuBTN.TabIndex = 10;
            okuBTN.Text = "Oku";
            okuBTN.UseVisualStyleBackColor = true;
            okuBTN.Click += okuBTN_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 105);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(485, 214);
            listBox1.TabIndex = 11;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 334);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(485, 219);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            // 
            // yazdirBTN
            // 
            yazdirBTN.Location = new Point(532, 243);
            yazdirBTN.Name = "yazdirBTN";
            yazdirBTN.Size = new Size(145, 32);
            yazdirBTN.TabIndex = 13;
            yazdirBTN.Text = "Yazdır";
            yazdirBTN.UseVisualStyleBackColor = true;
            yazdirBTN.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 610);
            Controls.Add(yazdirBTN);
            Controls.Add(richTextBox1);
            Controls.Add(listBox1);
            Controls.Add(okuBTN);
            Controls.Add(LabelAd);
            Controls.Add(textAd);
            Controls.Add(KonumSecBTN);
            Controls.Add(olusturBTN);
            Controls.Add(labelYol);
            Controls.Add(textYol);
            Controls.Add(SaveBTN);
            Controls.Add(openFileBTN);
            Controls.Add(label1);
            Controls.Add(FolderBrowserBTN);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FolderBrowserBTN;
        private Label label1;
        private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialog1;
        private Button openFileBTN;
        private Button SaveBTN;
        private SaveFileDialog saveFileDialog1;
        private TextBox textYol;
        private Label labelYol;
        private Button olusturBTN;
        private Button KonumSecBTN;
        private Label LabelAd;
        private TextBox textAd;
        private Button okuBTN;
        private ListBox listBox1;
        private RichTextBox richTextBox1;
        private Button yazdirBTN;
    }
}
