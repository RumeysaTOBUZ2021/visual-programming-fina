using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
        public static UyeEkran frm;
        public UyeEkran()
        {
            InitializeComponent();
        }
        
        private void UyeEkran_Load(object sender, EventArgs e)
        {

        }
        DataBase db = new DataBase();
        private void button1_Click(object sender, EventArgs e)
        {
            
            db.baglanti.Open();
            MySqlCommand cmd = new MySqlCommand("select * from uyeler where kullanici_adi='"+textBox1.Text+"' and  sifre= '"+textBox2.Text+"'",db.baglanti);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                AnaSayfa.ae.Text = "Giriş Yapıldı Merhaba " + dr["kullanici_adi"].ToString();
                AnaSayfa.ae.uyeToolStripMenuItem.Text = "Çıkış Yap";
                AnaSayfa.ae.uye_id = (int)dr["id"];
                AnaSayfa.ae.login = true;
                int x =(int)dr["yetki"];
                if(x==1)
                {
                    AnaSayfa.ae.admin=true;
                    AnaSayfa.ae.label1.Text = "Merhaba Admin";
                }
                else
                {
                    AnaSayfa.ae.label1.Text = "Giriş Yapıldı Merhaba " + dr["kullanici_adi"].ToString();
               
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı şifre hatalı");
            }
            db.baglanti.Close();
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UyeKayıt uyeKayıtekran = new UyeKayıt();
            uyeKayıtekran.Show();
            this.Hide();
        }
    }
}
