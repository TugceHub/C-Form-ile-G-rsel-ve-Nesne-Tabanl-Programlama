namespace Form_Islemleri
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
            btnForm = new Button();
            btnform3 = new Button();
            SuspendLayout();
            // 
            // btnForm
            // 
            btnForm.Location = new Point(28, 25);
            btnForm.Name = "btnForm";
            btnForm.Size = new Size(135, 39);
            btnForm.TabIndex = 0;
            btnForm.Text = "Form 2'ye Git";
            btnForm.UseVisualStyleBackColor = true;
            btnForm.Click += btnForm_Click;
            // 
            // btnform3
            // 
            btnform3.Location = new Point(28, 83);
            btnform3.Name = "btnform3";
            btnform3.Size = new Size(135, 39);
            btnform3.TabIndex = 1;
            btnform3.Text = "Form 3'e Git";
            btnform3.UseVisualStyleBackColor = true;
            btnform3.Click += btnform3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(185, 168);
            Controls.Add(btnform3);
            Controls.Add(btnForm);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnForm;
        private Button btnform3;
    }
}
