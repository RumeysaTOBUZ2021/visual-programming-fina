using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorsel_final
{
    internal class DataBase
    {
      public  MySqlConnection baglanti = new MySqlConnection("server=127.0.0.1; database=gp_final; user=root; password=secret");// Veritabanı bağlantısı için server bilgilerinin tutulduğu global bir nesne oluşturdum ve içine bilgilerimi girdim

        public static MySqlConnection conn;
        public static MySqlConnection GetConnection()
        {
            if (conn == null)
            {
                conn = new MySqlConnection();
            }
            return conn;
        }

      public void ekle_randavu(string saat, string deger,string a_1, string a_2, string a_3, string a_4, string a_5, string a_6,string a_7,string k_id)
        {

            baglanti.Open();
            MySqlCommand cmd = new MySqlCommand("insert into randevular (saat,deger,ad_soyad,tel,eposta,marka,km,plk,tarih,k_id) values('" + saat+"','"+deger+"','"+a_1+"','"+a_2
                +"','"+a_3+"','"+a_4+"','"+a_5+"','"+a_6+"','"+a_7+"','"+k_id+"')", baglanti);
            int a = cmd.ExecuteNonQuery();
            if (a == 1)
            {
                MessageBox.Show("randavu oluştu");
            }
            else
            {

                MessageBox.Show("randavu oluşmadı");
            }

            baglanti.Close();

        } 
        

    }
}
