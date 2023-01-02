using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorsel_final
{
    public partial class RandevuAl : Form
    {
        public static RandevuAl rand_al;
        public string x_deger;
        public string x_saat;
        public RandevuAl()
        {
            InitializeComponent();
            rand_al = this;
        }
        DataBase db = new DataBase();
        private void label3_Click(object sender, EventArgs e)
        {
        
        }

        private void RandevuAl_Load(object sender, EventArgs e)
        {
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.ekle_randavu(x_saat,x_deger,textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text,dateTimePicker1.Value.ToString(),AnaSayfa.ae.uye_id.ToString());
        }
    }
}
