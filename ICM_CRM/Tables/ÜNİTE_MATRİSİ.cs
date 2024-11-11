using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICM_CRM.Tables
{
    public class ÜNİTE_MATRİSİ
    {
        public int M_ID { get; set; } // Primary Key
        public string Ünite { get; set; }
        public string Katlama_Tipi{ get; set; }
         public string Besleme_Tipi { get; set; }
        public string Besleme_Yönü { get; set; }

        public string Hız { get; set; }

        public string Max_Bobin_Çapı { get; set; }

        public string Bobin_Başlık_Çapı { get; set; }

        public string Güç_Uygulama_Tipi { get; set; }

        public string Max_Bobin_Genişliği { get; set; }

        public string Bobin_Birleştirme_Şekli { get; set; }

        public string Gofraj_Tipi { get; set; }

        public string Gofraj_Menşei { get; set; }

        public string Kağıt_Genişliği { get; set; }

        public string Dilme_Döndürme { get; set; }

        public string Max_Bitmiş_Ürün_Çapı { get; set; }

        public string Katlama_Ebatı { get; set; }

        public string Mihver_Çapı { get; set; }

        public string Perferaj_Boyu { get; set; }

        public string Makine_Çıkışı_Kağıt_Akışı { get; set; }

    }
}
