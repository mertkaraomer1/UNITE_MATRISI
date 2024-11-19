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
                dataTable.Columns.Add("Çalýþýlacak Kaðýt Geniþliði");
                dataTable.Columns.Add("Gofraj Desen Çalýþma Þekli");
                dataTable.Columns.Add("Gofraj Takýmý");
                dataTable.Columns.Add("Gofraj Adedi");
                dataTable.Columns.Add("Tahrik Þekli");
                dataTable.Columns.Add("Ürün Tipi");
                dataTable.Columns.Add("Kanal Sayýsý");
                dataTable.Columns.Add("Kaðýt Koparma Þekli");
                dataTable.Columns.Add("Kenar Kontrol");
                dataTable.Columns.Add("Ürün Çapý");
                dataTable.Columns.Add("Log/dak");
                dataTable.Columns.Add("Ürün Yüksekliði");
                dataTable.Columns.Add("Eco ICM");
                dataTable.Columns.Add("Log Adedi");
                dataTable.Columns.Add("Log Loader Adedi");

               
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
                                       kayýt.Perferaj_Boyu, kayýt.Makine_Çýkýþý_Kaðýt_Akýþý,kayýt.Çalýþýlacak_Kaðýt_Geniþliði,
                                       kayýt.Gofraj_Desen_Çalýþma_Þekli,kayýt.Gofraj_Takýmý,kayýt.Gofraj_Adedi,kayýt.Tahrik_Þekli,
                                       kayýt.Ürün_Tipi,kayýt.Kanal_Sayýsý,kayýt.Kaðýt_Koparma_Þekli,kayýt.Kenar_Kontrol,
                                       kayýt.Ürün_Çapý,kayýt.Log_dak,kayýt.Ürün_Yüksekliði,kayýt.Eco_ICM,kayýt.Log_Adedi,kayýt.Log_Loader_Adedi);
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
                string ÇalýþýlacakKaðýtGeniþliði=comboBox20.Text;
                string GofrajDesenÇalýþmaÞekli = comboBox22.Text;
                string GofrajTakýmý = comboBox23.Text;
                string GofrajAdedi = comboBox24.Text;
                string TahrikÞekli = comboBox25.Text;
                string ÜrünTipi = comboBox26.Text;
                string KanalSayýsý = comboBox27.Text;
                string KaðýtKoparmaÞekli = comboBox28.Text;
                string KenarKontrol = comboBox29.Text;
                string ÜrünÇapý = comboBox30.Text;
                string Logdak = comboBox31.Text;
                string ÜrünYüksekliði = comboBox32.Text;
                string EcoICM = comboBox21.Text;
                string LogAdedi = comboBox33.Text;
                string LogLoaderAdedi = comboBox34.Text;


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
                                         x.Makine_Çýkýþý_Kaðýt_Akýþý == makineÇýkýþýKaðýtAkýþý&&
                                         x.Çalýþýlacak_Kaðýt_Geniþliði== ÇalýþýlacakKaðýtGeniþliði&&
                                         x.Gofraj_Desen_Çalýþma_Þekli== GofrajDesenÇalýþmaÞekli&&
                                         x.Gofraj_Takýmý== GofrajTakýmý&&
                                         x.Gofraj_Adedi== GofrajAdedi&&
                                         x.Tahrik_Þekli== TahrikÞekli&&x.Ürün_Tipi== ÜrünTipi&&
                                         x.Kanal_Sayýsý== KanalSayýsý&&
                                         x.Kaðýt_Koparma_Þekli== KaðýtKoparmaÞekli&&
                                         x.Kenar_Kontrol== KenarKontrol&&
                                         x.Ürün_Çapý== ÜrünÇapý&&
                                         x.Log_dak== Logdak&&x.Ürün_Yüksekliði== ÜrünYüksekliði&&
                                         x.Eco_ICM== EcoICM&&x.Log_Adedi== LogAdedi&&
                                         x.Log_Loader_Adedi== LogLoaderAdedi);

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
                        Makine_Çýkýþý_Kaðýt_Akýþý = makineÇýkýþýKaðýtAkýþý,
                        Çalýþýlacak_Kaðýt_Geniþliði = ÇalýþýlacakKaðýtGeniþliði,
                        Gofraj_Desen_Çalýþma_Þekli = GofrajDesenÇalýþmaÞekli,
                        Gofraj_Takýmý = GofrajTakýmý,
                        Gofraj_Adedi = GofrajAdedi,
                        Tahrik_Þekli = TahrikÞekli,
                        Ürün_Tipi = ÜrünTipi,
                        Kanal_Sayýsý = KanalSayýsý,
                        Kaðýt_Koparma_Þekli = KaðýtKoparmaÞekli,
                        Kenar_Kontrol = KenarKontrol,
                        Ürün_Çapý = ÜrünÇapý,
                        Log_dak = Logdak,
                        Ürün_Yüksekliði = ÜrünYüksekliði,
                        Eco_ICM = EcoICM,
                        Log_Adedi =LogAdedi,
                        Log_Loader_Adedi = LogLoaderAdedi
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

                dataTable.Clear();
                dataTable.Columns.Clear();
                dataTable.Rows.Clear();
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
                dataTable.Columns.Add("Çalýþýlacak Kaðýt Geniþliði");
                dataTable.Columns.Add("Gofraj Desen Çalýþma Þekli");
                dataTable.Columns.Add("Gofraj Takýmý");
                dataTable.Columns.Add("Gofraj Adedi");
                dataTable.Columns.Add("Tahrik Þekli");
                dataTable.Columns.Add("Ürün Tipi");
                dataTable.Columns.Add("Kanal Sayýsý");
                dataTable.Columns.Add("Kaðýt Koparma Þekli");
                dataTable.Columns.Add("Kenar Kontrol");
                dataTable.Columns.Add("Ürün Çapý");
                dataTable.Columns.Add("Log/dak");
                dataTable.Columns.Add("Ürün Yüksekliði");
                dataTable.Columns.Add("Eco ICM");
                dataTable.Columns.Add("Log Adedi");
                dataTable.Columns.Add("Log Loader Adedi");

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
                                       kayýt.Perferaj_Boyu, kayýt.Makine_Çýkýþý_Kaðýt_Akýþý,kayýt.Çalýþýlacak_Kaðýt_Geniþliði,
                                       kayýt.Gofraj_Desen_Çalýþma_Þekli, kayýt.Gofraj_Takýmý, kayýt.Gofraj_Adedi, kayýt.Tahrik_Þekli,
                                       kayýt.Ürün_Tipi, kayýt.Kanal_Sayýsý, kayýt.Kaðýt_Koparma_Þekli, kayýt.Kenar_Kontrol,
                                       kayýt.Ürün_Çapý, kayýt.Log_dak, kayýt.Ürün_Yüksekliði, kayýt.Eco_ICM, kayýt.Log_Adedi, kayýt.Log_Loader_Adedi);
                }

                // DataGridView'e veri kaynaðý olarak ata
                advancedDataGridView1.DataSource = dataTable;
            }

        }


    }

}
