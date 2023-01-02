using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gorsel_final
{
    public partial class BM_PeriyodikBakım : Form
    {
        DataBase db= new DataBase();

        public static BM_PeriyodikBakım bmp;
      public int x;
      public  void goruntule()
        {
            listBox1.Items.Clear();
            db.baglanti.Open();
            MySqlCommand islem = new MySqlCommand("select * from hizmetler where tur ='"+x.ToString()+"'", db.baglanti);
            MySqlDataReader oku=islem.ExecuteReader();
            while (oku.Read())
            {

                listBox1.Items.Add(oku["h_ad"]);
            }

            db.baglanti.Close();
        }
        public BM_PeriyodikBakım()
        {
            InitializeComponent();
            bmp = this;


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BM_PeriyodikBakım_Load(object sender, EventArgs e)
        {
            goruntule();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandevuAl randevuekran = new RandevuAl();
            RandevuAl.rand_al.x_deger = listBox1.SelectedItems[0].ToString();
            RandevuAl.rand_al.x_saat = listBox2.SelectedItems[0].ToString();
            randevuekran.ShowDialog();
        }
    }
}
