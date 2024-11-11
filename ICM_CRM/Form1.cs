using ICM_CRM.Context;
using ICM_CRM.Tables;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ICM_CRM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                // ÜNÝTE_MATRÝSÝ tablosundaki tüm kayýtlarý al
                var veriler = context.ÜNÝTE_MATRÝSÝ.ToList();

                // DataTable oluþtur


                // Sütunlarý ekle
                dataTable.Columns.Add("Ünite");
                dataTable.Columns.Add("Katlama Tipi");
                dataTable.Columns.Add("Besleme Tipi");
                dataTable.Columns.Add("Besleme Yönü");
                dataTable.Columns.Add("Hýz");
                dataTable.Columns.Add("Max Bobin Çapý");
                dataTable.Columns.Add("Bobin Baþlýk Çapý");
                dataTable.Columns.Add("Güç Uygulama Tipi");
                dataTable.Columns.Add("Max Bobin Geniþliði");
                dataTable.Columns.Add("Bobin Birleþtirme Þekli");
                dataTable.Columns.Add("Gofraj Tipi");
                dataTable.Columns.Add("Gofraj Menþei");
                dataTable.Columns.Add("Kaðýt Geniþliði");
                dataTable.Columns.Add("Dilme Döndürme");
                dataTable.Columns.Add("Max Bitmiþ Ürün Çapý");
                dataTable.Columns.Add("Katlama Ebatý");
                dataTable.Columns.Add("Mihver Çapý");
                dataTable.Columns.Add("Perferaj Boyu");
                dataTable.Columns.Add("Makine Çýkýþý Kaðýt Akýþý");

                // Kayýtlarý DataTable'a ekle
                foreach (var kayýt in veriler)
                {
                    dataTable.Rows.Add(kayýt.Ünite, kayýt.Katlama_Tipi, kayýt.Besleme_Tipi, kayýt.Besleme_Yönü,
                                       kayýt.Hýz, kayýt.Max_Bobin_Çapý, kayýt.Bobin_Baþlýk_Çapý,
                                       kayýt.Güç_Uygulama_Tipi, kayýt.Max_Bobin_Geniþliði,
                                       kayýt.Bobin_Birleþtirme_Þekli, kayýt.Gofraj_Tipi,
                                       kayýt.Gofraj_Menþei, kayýt.Kaðýt_Geniþliði,
                                       kayýt.Dilme_Döndürme, kayýt.Max_Bitmiþ_Ürün_Çapý,
                                       kayýt.Katlama_Ebatý, kayýt.Mihver_Çapý,
                                       kayýt.Perferaj_Boyu, kayýt.Makine_Çýkýþý_Kaðýt_Akýþý);
                }

                // DataGridView'e veri kaynaðý olarak ata
                advancedDataGridView1.DataSource = dataTable;
            }

        }
        DataTable dataTable = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                // ComboBox'lardan gelen verileri al
                string ünite = comboBox1.Text;
                string katlamaTipi = comboBox2.Text;
                string beslemeTipi = comboBox3.Text;
                string beslemeYönü = comboBox4.Text;
                string hýz = comboBox5.Text;
                string maxBobinÇapý = comboBox6.Text;
                string bobinBaþlýkÇapý = comboBox7.Text;
                string güçUygulamaTipi = comboBox8.Text;
                string maxBobinGeniþliði = comboBox9.Text;
                string bobinBirleþtirmeÞekli = comboBox10.Text;
                string gofrajTipi = comboBox11.Text;
                string gofrajMenþei = comboBox12.Text;
                string kaðýtGeniþliði = comboBox13.Text;
                string dilmeDöndürme = comboBox14.Text;
                string maxBitmiþÜrünÇapý = comboBox15.Text;
                string katlamaEbatý = comboBox16.Text;
                string mihverÇapý = comboBox17.Text;
                string perferajBoyu = comboBox18.Text;
                string makineÇýkýþýKaðýtAkýþý = comboBox19.Text;


                // Ayný kaydýn varlýðýný kontrol et
                var mevcutKayýt = context.ÜNÝTE_MATRÝSÝ
                    .FirstOrDefault(x => x.Ünite == ünite &&
                                         x.Katlama_Tipi == katlamaTipi &&
                                         x.Besleme_Tipi == beslemeTipi &&
                                         x.Besleme_Yönü == beslemeYönü &&
                                         x.Hýz == hýz &&
                                         x.Max_Bobin_Çapý == maxBobinÇapý &&
                                         x.Bobin_Baþlýk_Çapý == bobinBaþlýkÇapý &&
                                         x.Güç_Uygulama_Tipi == güçUygulamaTipi &&
                                         x.Max_Bobin_Geniþliði == maxBobinGeniþliði &&
                                         x.Bobin_Birleþtirme_Þekli == bobinBirleþtirmeÞekli &&
                                         x.Gofraj_Tipi == gofrajTipi &&
                                         x.Gofraj_Menþei == gofrajMenþei &&
                                         x.Kaðýt_Geniþliði == kaðýtGeniþliði &&
                                         x.Dilme_Döndürme == dilmeDöndürme &&
                                         x.Max_Bitmiþ_Ürün_Çapý == maxBitmiþÜrünÇapý &&
                                         x.Katlama_Ebatý == katlamaEbatý &&
                                         x.Mihver_Çapý == mihverÇapý &&
                                         x.Perferaj_Boyu == perferajBoyu &&
                                         x.Makine_Çýkýþý_Kaðýt_Akýþý == makineÇýkýþýKaðýtAkýþý);

                if (mevcutKayýt != null)
                {
                    MessageBox.Show("Bu kayýt zaten mevcut.");
                }
                else
                {
                    // Yeni kayýt oluþtur
                    var yeniKayýt = new ÜNÝTE_MATRÝSÝ
                    {
                        Ünite = ünite,
                        Katlama_Tipi = katlamaTipi,
                        Besleme_Tipi = beslemeTipi,
                        Besleme_Yönü = beslemeYönü,
                        Hýz = hýz,
                        Max_Bobin_Çapý = maxBobinÇapý,
                        Bobin_Baþlýk_Çapý = bobinBaþlýkÇapý,
                        Güç_Uygulama_Tipi = güçUygulamaTipi,
                        Max_Bobin_Geniþliði = maxBobinGeniþliði,
                        Bobin_Birleþtirme_Þekli = bobinBirleþtirmeÞekli,
                        Gofraj_Tipi = gofrajTipi,
                        Gofraj_Menþei = gofrajMenþei,
                        Kaðýt_Geniþliði = kaðýtGeniþliði,
                        Dilme_Döndürme = dilmeDöndürme,
                        Max_Bitmiþ_Ürün_Çapý = maxBitmiþÜrünÇapý,
                        Katlama_Ebatý = katlamaEbatý,
                        Mihver_Çapý = mihverÇapý,
                        Perferaj_Boyu = perferajBoyu,
                        Makine_Çýkýþý_Kaðýt_Akýþý = makineÇýkýþýKaðýtAkýþý
                    };

                    // Yeni kaydý ekle
                    context.ÜNÝTE_MATRÝSÝ.Add(yeniKayýt);
                    context.SaveChanges();

                    MessageBox.Show("Kayýt baþarýyla eklendi.");
                }
            }
            using (var context = new MyDbContext())
            {
                // ÜNÝTE_MATRÝSÝ tablosundaki tüm kayýtlarý al
                var veriler = context.ÜNÝTE_MATRÝSÝ.ToList();

                // DataTable oluþtur

               
                // Sütunlarý ekle
                dataTable.Columns.Add("Ünite");
                dataTable.Columns.Add("Katlama Tipi");
                dataTable.Columns.Add("Besleme Tipi");
                dataTable.Columns.Add("Besleme Yönü");
                dataTable.Columns.Add("Hýz");
                dataTable.Columns.Add("Max Bobin Çapý");
                dataTable.Columns.Add("Bobin Baþlýk Çapý");
                dataTable.Columns.Add("Güç Uygulama Tipi");
                dataTable.Columns.Add("Max Bobin Geniþliði");
                dataTable.Columns.Add("Bobin Birleþtirme Þekli");
                dataTable.Columns.Add("Gofraj Tipi");
                dataTable.Columns.Add("Gofraj Menþei");
                dataTable.Columns.Add("Kaðýt Geniþliði");
                dataTable.Columns.Add("Dilme Döndürme");
                dataTable.Columns.Add("Max Bitmiþ Ürün Çapý");
                dataTable.Columns.Add("Katlama Ebatý");
                dataTable.Columns.Add("Mihver Çapý");
                dataTable.Columns.Add("Perferaj Boyu");
                dataTable.Columns.Add("Makine Çýkýþý Kaðýt Akýþý");

                // Kayýtlarý DataTable'a ekle
                foreach (var kayýt in veriler)
                {
                    dataTable.Rows.Add(kayýt.Ünite, kayýt.Katlama_Tipi, kayýt.Besleme_Tipi, kayýt.Besleme_Yönü,
                                       kayýt.Hýz, kayýt.Max_Bobin_Çapý, kayýt.Bobin_Baþlýk_Çapý,
                                       kayýt.Güç_Uygulama_Tipi, kayýt.Max_Bobin_Geniþliði,
                                       kayýt.Bobin_Birleþtirme_Þekli, kayýt.Gofraj_Tipi,
                                       kayýt.Gofraj_Menþei, kayýt.Kaðýt_Geniþliði,
                                       kayýt.Dilme_Döndürme, kayýt.Max_Bitmiþ_Ürün_Çapý,
                                       kayýt.Katlama_Ebatý, kayýt.Mihver_Çapý,
                                       kayýt.Perferaj_Boyu, kayýt.Makine_Çýkýþý_Kaðýt_Akýþý);
                }

                // DataGridView'e veri kaynaðý olarak ata
                advancedDataGridView1.DataSource = dataTable;
            }

        }
    }

}
