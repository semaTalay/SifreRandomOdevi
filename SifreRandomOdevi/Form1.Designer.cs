namespace SifreRandomOdevi
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
            listView1 = new ListView();
            grpParametreler = new GroupBox();
            nmdUzunluk = new NumericUpDown();
            nudSayi = new NumericUpDown();
            btnUret = new Button();
            label2 = new Label();
            label1 = new Label();
            cboxOzelKarakter = new CheckBox();
            cboxRakam = new CheckBox();
            cboxBüyükHarf = new CheckBox();
            cboxKücükHarf = new CheckBox();
            grpParametreler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmdUzunluk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSayi).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(410, 16);
            listView1.Name = "listView1";
            listView1.Size = new Size(339, 375);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // grpParametreler
            // 
            grpParametreler.Controls.Add(nmdUzunluk);
            grpParametreler.Controls.Add(nudSayi);
            grpParametreler.Controls.Add(btnUret);
            grpParametreler.Controls.Add(label2);
            grpParametreler.Controls.Add(label1);
            grpParametreler.Controls.Add(cboxOzelKarakter);
            grpParametreler.Controls.Add(cboxRakam);
            grpParametreler.Controls.Add(cboxBüyükHarf);
            grpParametreler.Controls.Add(cboxKücükHarf);
            grpParametreler.Location = new Point(12, 16);
            grpParametreler.Name = "grpParametreler";
            grpParametreler.Size = new Size(366, 375);
            grpParametreler.TabIndex = 6;
            grpParametreler.TabStop = false;
            grpParametreler.Text = "PARAMETRELER";
            // 
            // nmdUzunluk
            // 
            nmdUzunluk.Location = new Point(199, 266);
            nmdUzunluk.Name = "nmdUzunluk";
            nmdUzunluk.Size = new Size(120, 23);
            nmdUzunluk.TabIndex = 14;
            // 
            // nudSayi
            // 
            nudSayi.Location = new Point(199, 231);
            nudSayi.Name = "nudSayi";
            nudSayi.Size = new Size(120, 23);
            nudSayi.TabIndex = 14;
            // 
            // btnUret
            // 
            btnUret.Location = new Point(173, 313);
            btnUret.Name = "btnUret";
            btnUret.Size = new Size(121, 36);
            btnUret.TabIndex = 13;
            btnUret.Text = "ÜRET";
            btnUret.UseVisualStyleBackColor = true;
            btnUret.Click += btnUret_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 268);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 9;
            label2.Text = "Şifre Uzunluğu : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 233);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 10;
            label1.Text = "Şifre Sayısı : ";
            // 
            // cboxOzelKarakter
            // 
            cboxOzelKarakter.AutoSize = true;
            cboxOzelKarakter.Location = new Point(106, 168);
            cboxOzelKarakter.Name = "cboxOzelKarakter";
            cboxOzelKarakter.Size = new Size(95, 19);
            cboxOzelKarakter.TabIndex = 5;
            cboxOzelKarakter.Text = "Özel Karakter";
            cboxOzelKarakter.UseVisualStyleBackColor = true;
            // 
            // cboxRakam
            // 
            cboxRakam.AutoSize = true;
            cboxRakam.Location = new Point(106, 133);
            cboxRakam.Name = "cboxRakam";
            cboxRakam.Size = new Size(62, 19);
            cboxRakam.TabIndex = 6;
            cboxRakam.Text = "Rakam";
            cboxRakam.UseVisualStyleBackColor = true;
            // 
            // cboxBüyükHarf
            // 
            cboxBüyükHarf.AutoSize = true;
            cboxBüyükHarf.Location = new Point(106, 95);
            cboxBüyükHarf.Name = "cboxBüyükHarf";
            cboxBüyükHarf.Size = new Size(85, 19);
            cboxBüyükHarf.TabIndex = 7;
            cboxBüyükHarf.Text = "Büyük Harf";
            cboxBüyükHarf.UseVisualStyleBackColor = true;
            // 
            // cboxKücükHarf
            // 
            cboxKücükHarf.AutoSize = true;
            cboxKücükHarf.Location = new Point(106, 58);
            cboxKücükHarf.Name = "cboxKücükHarf";
            cboxKücükHarf.Size = new Size(85, 19);
            cboxKücükHarf.TabIndex = 8;
            cboxKücükHarf.Text = "Küçük Harf";
            cboxKücükHarf.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 405);
            Controls.Add(grpParametreler);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            grpParametreler.ResumeLayout(false);
            grpParametreler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmdUzunluk).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSayi).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ListView listView1;
        private GroupBox grpParametreler;
        private Button btnUret;
        private Label label2;
        private Label label1;
        private CheckBox cboxOzelKarakter;
        private CheckBox cboxRakam;
        private CheckBox cboxBüyükHarf;
        private CheckBox cboxKücükHarf;
        private NumericUpDown nmdUzunluk;
        private NumericUpDown nudSayi;
    }
}