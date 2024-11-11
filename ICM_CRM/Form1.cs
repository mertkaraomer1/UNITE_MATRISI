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
                // �N�TE_MATR�S� tablosundaki t�m kay�tlar� al
                var veriler = context.�N�TE_MATR�S�.ToList();

                // DataTable olu�tur


                // S�tunlar� ekle
                dataTable.Columns.Add("�nite");
                dataTable.Columns.Add("Katlama Tipi");
                dataTable.Columns.Add("Besleme Tipi");
                dataTable.Columns.Add("Besleme Y�n�");
                dataTable.Columns.Add("H�z");
                dataTable.Columns.Add("Max Bobin �ap�");
                dataTable.Columns.Add("Bobin Ba�l�k �ap�");
                dataTable.Columns.Add("G�� Uygulama Tipi");
                dataTable.Columns.Add("Max Bobin Geni�li�i");
                dataTable.Columns.Add("Bobin Birle�tirme �ekli");
                dataTable.Columns.Add("Gofraj Tipi");
                dataTable.Columns.Add("Gofraj Men�ei");
                dataTable.Columns.Add("Ka��t Geni�li�i");
                dataTable.Columns.Add("Dilme D�nd�rme");
                dataTable.Columns.Add("Max Bitmi� �r�n �ap�");
                dataTable.Columns.Add("Katlama Ebat�");
                dataTable.Columns.Add("Mihver �ap�");
                dataTable.Columns.Add("Perferaj Boyu");
                dataTable.Columns.Add("Makine ��k��� Ka��t Ak���");

                // Kay�tlar� DataTable'a ekle
                foreach (var kay�t in veriler)
                {
                    dataTable.Rows.Add(kay�t.�nite, kay�t.Katlama_Tipi, kay�t.Besleme_Tipi, kay�t.Besleme_Y�n�,
                                       kay�t.H�z, kay�t.Max_Bobin_�ap�, kay�t.Bobin_Ba�l�k_�ap�,
                                       kay�t.G��_Uygulama_Tipi, kay�t.Max_Bobin_Geni�li�i,
                                       kay�t.Bobin_Birle�tirme_�ekli, kay�t.Gofraj_Tipi,
                                       kay�t.Gofraj_Men�ei, kay�t.Ka��t_Geni�li�i,
                                       kay�t.Dilme_D�nd�rme, kay�t.Max_Bitmi�_�r�n_�ap�,
                                       kay�t.Katlama_Ebat�, kay�t.Mihver_�ap�,
                                       kay�t.Perferaj_Boyu, kay�t.Makine_��k���_Ka��t_Ak���);
                }

                // DataGridView'e veri kayna�� olarak ata
                advancedDataGridView1.DataSource = dataTable;
            }

        }
        DataTable dataTable = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                // ComboBox'lardan gelen verileri al
                string �nite = comboBox1.Text;
                string katlamaTipi = comboBox2.Text;
                string beslemeTipi = comboBox3.Text;
                string beslemeY�n� = comboBox4.Text;
                string h�z = comboBox5.Text;
                string maxBobin�ap� = comboBox6.Text;
                string bobinBa�l�k�ap� = comboBox7.Text;
                string g��UygulamaTipi = comboBox8.Text;
                string maxBobinGeni�li�i = comboBox9.Text;
                string bobinBirle�tirme�ekli = comboBox10.Text;
                string gofrajTipi = comboBox11.Text;
                string gofrajMen�ei = comboBox12.Text;
                string ka��tGeni�li�i = comboBox13.Text;
                string dilmeD�nd�rme = comboBox14.Text;
                string maxBitmi��r�n�ap� = comboBox15.Text;
                string katlamaEbat� = comboBox16.Text;
                string mihver�ap� = comboBox17.Text;
                string perferajBoyu = comboBox18.Text;
                string makine��k���Ka��tAk��� = comboBox19.Text;


                // Ayn� kayd�n varl���n� kontrol et
                var mevcutKay�t = context.�N�TE_MATR�S�
                    .FirstOrDefault(x => x.�nite == �nite &&
                                         x.Katlama_Tipi == katlamaTipi &&
                                         x.Besleme_Tipi == beslemeTipi &&
                                         x.Besleme_Y�n� == beslemeY�n� &&
                                         x.H�z == h�z &&
                                         x.Max_Bobin_�ap� == maxBobin�ap� &&
                                         x.Bobin_Ba�l�k_�ap� == bobinBa�l�k�ap� &&
                                         x.G��_Uygulama_Tipi == g��UygulamaTipi &&
                                         x.Max_Bobin_Geni�li�i == maxBobinGeni�li�i &&
                                         x.Bobin_Birle�tirme_�ekli == bobinBirle�tirme�ekli &&
                                         x.Gofraj_Tipi == gofrajTipi &&
                                         x.Gofraj_Men�ei == gofrajMen�ei &&
                                         x.Ka��t_Geni�li�i == ka��tGeni�li�i &&
                                         x.Dilme_D�nd�rme == dilmeD�nd�rme &&
                                         x.Max_Bitmi�_�r�n_�ap� == maxBitmi��r�n�ap� &&
                                         x.Katlama_Ebat� == katlamaEbat� &&
                                         x.Mihver_�ap� == mihver�ap� &&
                                         x.Perferaj_Boyu == perferajBoyu &&
                                         x.Makine_��k���_Ka��t_Ak��� == makine��k���Ka��tAk���);

                if (mevcutKay�t != null)
                {
                    MessageBox.Show("Bu kay�t zaten mevcut.");
                }
                else
                {
                    // Yeni kay�t olu�tur
                    var yeniKay�t = new �N�TE_MATR�S�
                    {
                        �nite = �nite,
                        Katlama_Tipi = katlamaTipi,
                        Besleme_Tipi = beslemeTipi,
                        Besleme_Y�n� = beslemeY�n�,
                        H�z = h�z,
                        Max_Bobin_�ap� = maxBobin�ap�,
                        Bobin_Ba�l�k_�ap� = bobinBa�l�k�ap�,
                        G��_Uygulama_Tipi = g��UygulamaTipi,
                        Max_Bobin_Geni�li�i = maxBobinGeni�li�i,
                        Bobin_Birle�tirme_�ekli = bobinBirle�tirme�ekli,
                        Gofraj_Tipi = gofrajTipi,
                        Gofraj_Men�ei = gofrajMen�ei,
                        Ka��t_Geni�li�i = ka��tGeni�li�i,
                        Dilme_D�nd�rme = dilmeD�nd�rme,
                        Max_Bitmi�_�r�n_�ap� = maxBitmi��r�n�ap�,
                        Katlama_Ebat� = katlamaEbat�,
                        Mihver_�ap� = mihver�ap�,
                        Perferaj_Boyu = perferajBoyu,
                        Makine_��k���_Ka��t_Ak��� = makine��k���Ka��tAk���
                    };

                    // Yeni kayd� ekle
                    context.�N�TE_MATR�S�.Add(yeniKay�t);
                    context.SaveChanges();

                    MessageBox.Show("Kay�t ba�ar�yla eklendi.");
                }
            }
            using (var context = new MyDbContext())
            {
                // �N�TE_MATR�S� tablosundaki t�m kay�tlar� al
                var veriler = context.�N�TE_MATR�S�.ToList();

                // DataTable olu�tur

               
                // S�tunlar� ekle
                dataTable.Columns.Add("�nite");
                dataTable.Columns.Add("Katlama Tipi");
                dataTable.Columns.Add("Besleme Tipi");
                dataTable.Columns.Add("Besleme Y�n�");
                dataTable.Columns.Add("H�z");
                dataTable.Columns.Add("Max Bobin �ap�");
                dataTable.Columns.Add("Bobin Ba�l�k �ap�");
                dataTable.Columns.Add("G�� Uygulama Tipi");
                dataTable.Columns.Add("Max Bobin Geni�li�i");
                dataTable.Columns.Add("Bobin Birle�tirme �ekli");
                dataTable.Columns.Add("Gofraj Tipi");
                dataTable.Columns.Add("Gofraj Men�ei");
                dataTable.Columns.Add("Ka��t Geni�li�i");
                dataTable.Columns.Add("Dilme D�nd�rme");
                dataTable.Columns.Add("Max Bitmi� �r�n �ap�");
                dataTable.Columns.Add("Katlama Ebat�");
                dataTable.Columns.Add("Mihver �ap�");
                dataTable.Columns.Add("Perferaj Boyu");
                dataTable.Columns.Add("Makine ��k��� Ka��t Ak���");

                // Kay�tlar� DataTable'a ekle
                foreach (var kay�t in veriler)
                {
                    dataTable.Rows.Add(kay�t.�nite, kay�t.Katlama_Tipi, kay�t.Besleme_Tipi, kay�t.Besleme_Y�n�,
                                       kay�t.H�z, kay�t.Max_Bobin_�ap�, kay�t.Bobin_Ba�l�k_�ap�,
                                       kay�t.G��_Uygulama_Tipi, kay�t.Max_Bobin_Geni�li�i,
                                       kay�t.Bobin_Birle�tirme_�ekli, kay�t.Gofraj_Tipi,
                                       kay�t.Gofraj_Men�ei, kay�t.Ka��t_Geni�li�i,
                                       kay�t.Dilme_D�nd�rme, kay�t.Max_Bitmi�_�r�n_�ap�,
                                       kay�t.Katlama_Ebat�, kay�t.Mihver_�ap�,
                                       kay�t.Perferaj_Boyu, kay�t.Makine_��k���_Ka��t_Ak���);
                }

                // DataGridView'e veri kayna�� olarak ata
                advancedDataGridView1.DataSource = dataTable;
            }

        }
    }

}
