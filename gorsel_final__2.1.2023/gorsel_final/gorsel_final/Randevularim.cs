using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gorsel_final
{
    public partial class Randevularim : Form
    {
        public static Randevularim rndd;
   
        public Randevularim()
        {
            InitializeComponent();
            rndd = this;
          
            listView1.GridLines = true;
            listView1.AllowColumnReorder = true;
            listView1.LabelEdit = true;
            listView1.FullRowSelect = true;
            listView1.Sorting = SortOrder.Ascending;
            listView1.View = View.Details;
        }
        DataBase db=new DataBase();


        void listeleme_Kalip()
        {
            listView1.Items.Clear();
            db.baglanti.Open();
                string sql = "Select * from randevular where k_id='" + AnaSayfa.ae.uye_id.ToString() + "'";
                MySqlCommand cmd = new MySqlCommand(sql, db.baglanti);
                MySqlDataReader Reader = cmd.ExecuteReader();
              
                while (Reader.Read())
                {
                    ListViewItem lv = new ListViewItem(Reader.GetInt32(0).ToString());
                    lv.SubItems.Add(Reader.GetString(1));
                


                    lv.SubItems.Add(Reader.GetString(2));
                    lv.SubItems.Add(Reader.GetString(3));
                    lv.SubItems.Add(Reader.GetString(4));
                    lv.SubItems.Add(Reader.GetString(5));
                    lv.SubItems.Add(Reader.GetString(6));
                    lv.SubItems.Add(Reader.GetString(7));
                    lv.SubItems.Add(Reader.GetString(8));
                    lv.SubItems.Add(Reader.GetString(9));





                    listView1.Items.Add(lv);
                }
                Reader.Close();
                cmd.Dispose();
                db.baglanti.Close();


          
        }

        void listeleme_Kalip_admin()
        {
            listView1.Items.Clear();
            db.baglanti.Open();
            string sql = "Select * from randevular ";
            MySqlCommand cmd = new MySqlCommand(sql, db.baglanti);
            MySqlDataReader Reader = cmd.ExecuteReader();

            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetInt32(0).ToString());
                lv.SubItems.Add(Reader.GetString(1));

                lv.SubItems.Add(Reader.GetString(2));
                lv.SubItems.Add(Reader.GetString(3));
                lv.SubItems.Add(Reader.GetString(4));
                lv.SubItems.Add(Reader.GetString(5));
                lv.SubItems.Add(Reader.GetString(6));
                lv.SubItems.Add(Reader.GetString(7));
                lv.SubItems.Add(Reader.GetString(8));
                lv.SubItems.Add(Reader.GetString(9));

                listView1.Items.Add(lv);
            }
            Reader.Close();
            cmd.Dispose();
            db.baglanti.Close();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Randevularim_Load(object sender, EventArgs e)
        {
            if (AnaSayfa.ae.admin)
            {
                label1.Text = "Merhaba Admin";
                listeleme_Kalip_admin();
            }
            else
            {
                label1.Text = "Merhaba Üyemiz";
                listeleme_Kalip();
            }
           
        }
    }
}
