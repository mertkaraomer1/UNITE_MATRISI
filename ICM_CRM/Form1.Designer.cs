namespace ICM_CRM
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            comboBox19 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox18 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox17 = new ComboBox();
            comboBox6 = new ComboBox();
            comboBox16 = new ComboBox();
            comboBox7 = new ComboBox();
            comboBox15 = new ComboBox();
            comboBox8 = new ComboBox();
            comboBox14 = new ComboBox();
            comboBox9 = new ComboBox();
            comboBox13 = new ComboBox();
            comboBox10 = new ComboBox();
            comboBox12 = new ComboBox();
            comboBox11 = new ComboBox();
            advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Çözgü", "Knurling", "Trim", "Laminasyon", "Sargı", "Katlama", "Kalender", "Baskı", "Gofraj", "Uç Tutkallama", "Log Saw 1 Line", "Log Saw 2 Line", "Log Saw 4 Line", "Band Saw", "Transfer", "Kraft Sarma", "Paketleme", "Kolileme" });
            comboBox1.Location = new Point(6, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(219, 28);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "1- Ünite";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "V Katlama", "Z Katlama", "1/4 katlama", "1/8 Katlama", "1/6 Katlama" });
            comboBox2.Location = new Point(231, 26);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(219, 28);
            comboBox2.TabIndex = 1;
            comboBox2.Text = "2- Katlama Tipi";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox19);
            groupBox1.Controls.Add(comboBox5);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(comboBox18);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(comboBox17);
            groupBox1.Controls.Add(comboBox6);
            groupBox1.Controls.Add(comboBox16);
            groupBox1.Controls.Add(comboBox7);
            groupBox1.Controls.Add(comboBox15);
            groupBox1.Controls.Add(comboBox8);
            groupBox1.Controls.Add(comboBox14);
            groupBox1.Controls.Add(comboBox9);
            groupBox1.Controls.Add(comboBox13);
            groupBox1.Controls.Add(comboBox10);
            groupBox1.Controls.Add(comboBox12);
            groupBox1.Controls.Add(comboBox11);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(12, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1878, 210);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(1403, 152);
            button1.Name = "button1";
            button1.Size = new Size(172, 56);
            button1.TabIndex = 19;
            button1.Text = "KAYDET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox19
            // 
            comboBox19.FormattingEnabled = true;
            comboBox19.Items.AddRange(new object[] { "Sağ", "Sol" });
            comboBox19.Location = new Point(1092, 152);
            comboBox19.Name = "comboBox19";
            comboBox19.Size = new Size(219, 28);
            comboBox19.TabIndex = 18;
            comboBox19.Text = "19- Makine Çıkışı(Kağıt Akışına Göre)";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "200 m/dak", "300 m/dak", "400 m/dak", "450 m/dak", "550 m/dak", "650 m/dak" });
            comboBox5.Location = new Point(906, 26);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(219, 28);
            comboBox5.TabIndex = 4;
            comboBox5.Text = "5- Hız";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Sağ", "Sol" });
            comboBox4.Location = new Point(681, 26);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(219, 28);
            comboBox4.TabIndex = 3;
            comboBox4.Text = "4- Besleme Yönü";
            // 
            // comboBox18
            // 
            comboBox18.FormattingEnabled = true;
            comboBox18.Items.AddRange(new object[] { "100 mm", "110 mm", "120 mm" });
            comboBox18.Location = new Point(867, 152);
            comboBox18.Name = "comboBox18";
            comboBox18.Size = new Size(219, 28);
            comboBox18.TabIndex = 17;
            comboBox18.Text = "18- Perferaj Boyu";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Yerden Alma", "Vinç İle ", "Vinç ile Ot. Değişim", "Kaldırma Lifti", "Manuel", "In-Line" });
            comboBox3.Location = new Point(456, 26);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(219, 28);
            comboBox3.TabIndex = 2;
            comboBox3.Text = "3- Besleme Tipi";
            // 
            // comboBox17
            // 
            comboBox17.FormattingEnabled = true;
            comboBox17.Items.AddRange(new object[] { "45 mm", "50 mm", "60 mm" });
            comboBox17.Location = new Point(642, 152);
            comboBox17.Name = "comboBox17";
            comboBox17.Size = new Size(219, 28);
            comboBox17.TabIndex = 16;
            comboBox17.Text = "17- Mihver Çapı";
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "1200 mm", "1400 mm", "1700 mm", "1800 mm", "2500 mm" });
            comboBox6.Location = new Point(1131, 26);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(219, 28);
            comboBox6.TabIndex = 5;
            comboBox6.Text = "6- Max. Bobin Çapı";
            // 
            // comboBox16
            // 
            comboBox16.FormattingEnabled = true;
            comboBox16.Items.AddRange(new object[] { "185 mm", "200 mm", "210 mm", "220 mm", "230 mm", "240 mm", "245 mm", "250 mm", "260 mm", "270 mm", "280 mm", "290 mm", "300 mm", "310 mm", "320 mm", "330 mm", "340 mm", "350 mm", "360 mm", "370 mm", "380 mm", "390 mm" });
            comboBox16.Location = new Point(1581, 90);
            comboBox16.Name = "comboBox16";
            comboBox16.Size = new Size(219, 28);
            comboBox16.TabIndex = 15;
            comboBox16.Text = "16- Katlama Ebatı";
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Items.AddRange(new object[] { "76 mm", "152 mm", "452 mm" });
            comboBox7.Location = new Point(1356, 26);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(219, 28);
            comboBox7.TabIndex = 6;
            comboBox7.Text = "7- Bobin Başlık Çapı";
            // 
            // comboBox15
            // 
            comboBox15.FormattingEnabled = true;
            comboBox15.Items.AddRange(new object[] { "200 mm", "300 mm" });
            comboBox15.Location = new Point(1356, 90);
            comboBox15.Name = "comboBox15";
            comboBox15.Size = new Size(219, 28);
            comboBox15.TabIndex = 14;
            comboBox15.Text = "15- Max. Bitmiş Ürün Çapı";
            // 
            // comboBox8
            // 
            comboBox8.FormattingEnabled = true;
            comboBox8.Items.AddRange(new object[] { "Hidrolik", "Pnömatik" });
            comboBox8.Location = new Point(1581, 26);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(219, 28);
            comboBox8.TabIndex = 7;
            comboBox8.Text = "8- Güç Uygulama Tipi";
            // 
            // comboBox14
            // 
            comboBox14.FormattingEnabled = true;
            comboBox14.Items.AddRange(new object[] { "Evet", "Hayır" });
            comboBox14.Location = new Point(1131, 90);
            comboBox14.Name = "comboBox14";
            comboBox14.Size = new Size(219, 28);
            comboBox14.TabIndex = 13;
            comboBox14.Text = "14- Dilme Döndürme";
            // 
            // comboBox9
            // 
            comboBox9.FormattingEnabled = true;
            comboBox9.Items.AddRange(new object[] { "120 mm", "400 mm", "800 mm", "1650 mm", "1900 mm", "2850 mm" });
            comboBox9.Location = new Point(6, 90);
            comboBox9.Name = "comboBox9";
            comboBox9.Size = new Size(219, 28);
            comboBox9.TabIndex = 8;
            comboBox9.Text = "9- Max. Bobin Genişliği";
            // 
            // comboBox13
            // 
            comboBox13.FormattingEnabled = true;
            comboBox13.Items.AddRange(new object[] { "120 mm", "400 mm", "800 mm", "1650 mm", "1900 mm", "2850 mm" });
            comboBox13.Location = new Point(906, 90);
            comboBox13.Name = "comboBox13";
            comboBox13.Size = new Size(219, 28);
            comboBox13.TabIndex = 12;
            comboBox13.Text = "13- Kağıt Genişliği";
            // 
            // comboBox10
            // 
            comboBox10.FormattingEnabled = true;
            comboBox10.Items.AddRange(new object[] { "Manuel", "Otomatik" });
            comboBox10.Location = new Point(231, 90);
            comboBox10.Name = "comboBox10";
            comboBox10.Size = new Size(219, 28);
            comboBox10.TabIndex = 9;
            comboBox10.Text = "10- Bobin Birleştirme Şekli";
            // 
            // comboBox12
            // 
            comboBox12.FormattingEnabled = true;
            comboBox12.Items.AddRange(new object[] { "Yerli", "İthal" });
            comboBox12.Location = new Point(681, 90);
            comboBox12.Name = "comboBox12";
            comboBox12.Size = new Size(219, 28);
            comboBox12.TabIndex = 11;
            comboBox12.Text = "12- Gofraj Menşei";
            // 
            // comboBox11
            // 
            comboBox11.FormattingEnabled = true;
            comboBox11.Items.AddRange(new object[] { "Çerçeve", "Tam Yüzey", "Tam Yüzey Çerçeve" });
            comboBox11.Location = new Point(456, 90);
            comboBox11.Name = "comboBox11";
            comboBox11.Size = new Size(219, 28);
            comboBox11.TabIndex = 10;
            comboBox11.Text = "11- Gofraj Tipi";
            // 
            // advancedDataGridView1
            // 
            advancedDataGridView1.AllowUserToAddRows = false;
            advancedDataGridView1.AllowUserToDeleteRows = false;
            advancedDataGridView1.BackgroundColor = Color.White;
            advancedDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            advancedDataGridView1.FilterAndSortEnabled = true;
            advancedDataGridView1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView1.Location = new Point(12, 217);
            advancedDataGridView1.MaxFilterButtonImageHeight = 23;
            advancedDataGridView1.Name = "advancedDataGridView1";
            advancedDataGridView1.ReadOnly = true;
            advancedDataGridView1.RightToLeft = RightToLeft.No;
            advancedDataGridView1.RowHeadersWidth = 51;
            advancedDataGridView1.Size = new Size(1878, 751);
            advancedDataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1902, 1033);
            Controls.Add(advancedDataGridView1);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private GroupBox groupBox1;
        private ComboBox comboBox19;
        private ComboBox comboBox18;
        private ComboBox comboBox17;
        private ComboBox comboBox16;
        private ComboBox comboBox15;
        private ComboBox comboBox14;
        private ComboBox comboBox13;
        private ComboBox comboBox12;
        private ComboBox comboBox11;
        private ComboBox comboBox10;
        private ComboBox comboBox9;
        private ComboBox comboBox8;
        private ComboBox comboBox7;
        private ComboBox comboBox6;
        private ComboBox comboBox5;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private Button button1;
    }
}
