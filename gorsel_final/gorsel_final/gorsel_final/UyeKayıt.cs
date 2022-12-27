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
using MySql.Data;

namespace gorsel_final
{
    public partial class UyeKayıt : Form
    {
        //AnaEkran ana =new AnaEkran();

        public MySqlConnection baglanti;

        public UyeKayıt()
        {
            InitializeComponent();
            //this.ana = anaEkran;
            baglanti = new MySqlConnection("server=127.0.0.1; database=gp_final; user=root; password=secret");// Veritabanı bağlantısı için server bilgilerinin tutulduğu global bir nesne oluşturdum ve içine bilgilerimi girdim
    
        }


    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UyeEkran uyekran = new UyeEkran();
            uyekran.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeEkran uye = new UyeEkran();
            string yeniKullanici = textBox1.Text;
            string sifre = textBox2.Text;
            string sifreTekrar = textBox3.Text;
            bool od = on_dogrulama(yeniKullanici, sifre, sifreTekrar); //ön doğrulamamı gerçekleştirdim ve değerini od değişkenine atadım



            try
            {
                if (od) //eğer od true ise kayıt işlemini gerçekleştirsin
                {

                    try
                    {
                        baglanti.Open();

                        string sql = "INSERT INTO uyeler (kullanici_adi, sifre) VALUES('"+yeniKullanici+"', '"+sifre+"')";
                        MySqlCommand cmd = new MySqlCommand(sql, baglanti);
                        cmd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }

                    baglanti.Close();


                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        bool on_dogrulama(string yk, string s, string st) //Ön doğrulama işlemini gerçekleştirmek için metot oluşturdum
        {
            if (yk == "" || s == "" || st == "") //Eğer herhangi bir textbox boşsa false değeri döndürsün
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
                return false;
            }
            if (s != st) //şifre ve tekrarı aynı değilse false değeri döndürsün
            {
                MessageBox.Show("Girdiğiniz şifre ve tekrarı birbiriyle uyuşmuyor!");
                return false;
            }
            else
            {
                //İstenmiyen durumlardan biriyle karşılaşılmazsa true değeri döndürsün
                return true;

            }
        }

        private void UyeKayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
