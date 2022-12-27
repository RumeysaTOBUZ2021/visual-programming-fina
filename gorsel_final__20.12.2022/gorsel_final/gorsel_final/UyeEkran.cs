using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gorsel_final
{
    public partial class UyeEkran : Form
    {
        public UyeEkran()
        {
            InitializeComponent();
        }
        //public MySqlConnection baglanti = new MySqlConnection("Server=127.0.0.1; Database=g_final_güz; Uid=root; Pwd=secret");// Veritabanı bağlantısı için server bilgilerinin tutulduğu global bir nesne oluşturdum ve içine bilgilerimi girdim
        public  void veritabani_baglantisi() // Veritabanı bağlantısını açmak için ayrı bir metot oluşturdum
        {
           /* try // Bağlantıda sorun oluşması durumunda hatanın ne olduğunu öğrenebilmek için try-catch kullandım
            {
                baglanti.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message); //Bağlantıyı açarken hata oluşursa, ayrıntılı bir şekilde bunu görebileyim
            }
            baglanti.Close();
        }
        bool giris_dogrulama(string kAdi, string sifre) //Girişi doğrulamak için ayrı bir metot oluşturdum, geriye bool tipi değer döndürecek
        {
            baglanti.Open();
            veritabani_baglantisi(); //veritabani_baglantisi metotunu çağırarak veritabanına bağlantıyı açtım
            MySqlCommand cmd = new MySqlCommand(); //Veritabanına göndereceğim sorguyu tutabilmesi için nesne oluşturdum
            //NOT: MySqlCommand veritabanı üzerinde sorgulama, ekleme, güncelleme, silme işlemlerini yapmak için kullanılır
            cmd.CommandText = "SELECT * FROM uyegiris WHERE kullanici_adi=@kAdi AND sifre=@sifre"; //Nesnenin içine sorgumu yazdım
            cmd.Parameters.AddWithValue("@kAdi", kAdi); //textboxlara girilen değerleri, parametrelere aktardım
            cmd.Parameters.AddWithValue("@sifre", sifre); //Not: Parametre kullanarak injection'a karşı önlem alıyorum
            cmd.Connection = baglanti; //Komutu veritabanına yolladım
            MySqlDataReader login = cmd.ExecuteReader(); //MySqlDataReader'ı, yolladığım komuttan dönen değerleri satır satır okuması için kullandım
            if (login.Read()) //Read metodu geriye bool türünde değer döndürür
            {
                baglanti.Close();
                return true; //Okunacak satır var ise true değer döndürür
            }
            else
            {
                baglanti.Close();
                return false; // Okunacak değer yoksa da false değeri döndürür
            }*/
        }
        private void UyeEkran_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if(textBox1.Text == "" || textBox2.Text == "" || textBox1.Text == "Kullanıcı Adı" || textBox2.Text == "Kullanıcı Adı")
           {
               MessageBox.Show("Lütfen Boş Alanları Doldurun!");
           }*/

            /*string kAdi = textBox1.Text; //textboxtaki değerleri string değişkenlere atadım
            string sifre = textBox2.Text;
            if (kAdi == "" || sifre == "") //Eğer textboxlardan biri boşsa beni uyarsın ve işlem yapmasın
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
                return;
            }
            bool a = giris_dogrulama(kAdi, sifre); //giris_dogrulama metotuna giriş bilgilerini yolladım ve bool tipinde bir değer elde ettim
            if (a) //Dönen değer true ise yani bilgiler veritabanındaki kayıtlarda mevcutsa if kod bloğu çalışsın
            {
                MessageBox.Show("Giriş Doğrulandı.");
                //Not: Bu if bloğuna giriş doğrulandığında gerçekleşmisini istediğiniz kodları yazabilirsiniz
            }
            else //Dönen değer true değilse yani false ise bu kod bloğu çalışsın
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!");*/
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UyeKayıt uyeKayıtekran = new UyeKayıt();
            uyeKayıtekran.Show();
            this.Hide();
        }
    }
}
