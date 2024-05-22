namespace LoginFormTasarimi
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
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            txtSifre = new TextBox();
            txtKullanici = new TextBox();
            label3 = new Label();
            txtcode1 = new TextBox();
            textCode = new TextBox();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 99);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 132);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 1;
            label2.Text = "Şifre";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(134, 240);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(109, 25);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Beni Hatırla";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(134, 200);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(126, 32);
            button1.TabIndex = 5;
            button1.Text = "Giriş Yap ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(268, 205);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(126, 21);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Şifremi Unuttum";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(134, 128);
            txtSifre.Margin = new Padding(4);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '.';
            txtSifre.Size = new Size(256, 29);
            txtSifre.TabIndex = 2;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // txtKullanici
            // 
            txtKullanici.Location = new Point(134, 88);
            txtKullanici.Margin = new Padding(4);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(256, 29);
            txtKullanici.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkTurquoise;
            label3.Location = new Point(134, 27);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(231, 34);
            label3.TabIndex = 7;
            label3.Text = "KULLANICI GİRİŞİ";
            // 
            // txtcode1
            // 
            txtcode1.Location = new Point(134, 164);
            txtcode1.Name = "txtcode1";
            txtcode1.Size = new Size(126, 29);
            txtcode1.TabIndex = 3;
            // 
            // textCode
            // 
            textCode.Enabled = false;
            textCode.Location = new Point(264, 164);
            textCode.Name = "textCode";
            textCode.Size = new Size(126, 29);
            textCode.TabIndex = 9;
            textCode.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 167);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(85, 21);
            label4.TabIndex = 10;
            label4.Text = "Kodu Giniz";
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(488, 318);
            Controls.Add(label4);
            Controls.Add(textCode);
            Controls.Add(txtcode1);
            Controls.Add(label3);
            Controls.Add(txtKullanici);
            Controls.Add(txtSifre);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ImeMode = ImeMode.Disable;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private Button button1;
        private LinkLabel linkLabel1;
        private TextBox txtSifre;
        private TextBox txtKullanici;
        private Label label3;
        private TextBox txtcode1;
        private TextBox textCode;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}
