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
    public partial class AnaSayfa : Form
    {
        public static AnaSayfa ae;
        public int uye_id;
        public bool login;
        public bool admin;
        
        public AnaSayfa()
        {
            InitializeComponent();
            ae = this;
        }
        BM_PeriyodikBakım bkm = new BM_PeriyodikBakım();
        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Iletisim iletisimekran=new Iletisim();
            iletisimekran.Show();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void hakkımızddaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkımızda hakkımızdaekran = new Hakkımızda();
            hakkımızdaekran.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void periyodikBakımToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (login)
            {
                BM_PeriyodikBakım periyodikekran = new BM_PeriyodikBakım();
                periyodikekran.Show();
            }
            else
            {
                MessageBox.Show("Lütfen önce giriş yapın");
            }


          
        }

        private void üyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          


            if (!login)
            {
                UyeEkran uyeekran = new UyeEkran();
                uyeekran.Show();
            }
            else
            {
                Application.Exit();

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Randevularim randevu=new Randevularim();
            randevu.Show();
        }

        private void periyodikBakımToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            if (login)
            {

                BM_PeriyodikBakım.bmp.x = 0;
                bkm.ShowDialog();
                BM_PeriyodikBakım.bmp.x = 0;
            }
            else
            {
                MessageBox.Show("Lütfen önce giriş yapın");
            }


        }

        private void kışBakımıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login)
            {

                BM_PeriyodikBakım.bmp.x = 1;
                bkm.ShowDialog();
                BM_PeriyodikBakım.bmp.x = 1;
            }
            else
            {
                MessageBox.Show("Lütfen önce giriş yapın");
            }

        }

        private void baharBakımıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login)
            {

                BM_PeriyodikBakım.bmp.x = 2;
                bkm.ShowDialog();
                BM_PeriyodikBakım.bmp.x = 2;
            }
            else
            {
                MessageBox.Show("Lütfen önce giriş yapın");
            }

        }

        private void klimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login)
            {

                BM_PeriyodikBakım.bmp.x = 3;
                bkm.ShowDialog();
                BM_PeriyodikBakım.bmp.x = 3;
            }
            else
            {
                MessageBox.Show("Lütfen önce giriş yapın");
            }


        }

        private void motorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login)
            {

                BM_PeriyodikBakım.bmp.x = 4;
                bkm.ShowDialog();
                BM_PeriyodikBakım.bmp.x = 4;
            }
            else
            {
                MessageBox.Show("Lütfen önce giriş yapın");
            }

        }

        private void frenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (login)
            {

                BM_PeriyodikBakım.bmp.x = 5;
                bkm.ShowDialog();
                BM_PeriyodikBakım.bmp.x = 5;
            }
            else
            {
                MessageBox.Show("Lütfen önce giriş yapın");
            }


   
        }

        private void lastikToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (login)
            {

                BM_PeriyodikBakım.bmp.x = 6;
                bkm.ShowDialog();
                BM_PeriyodikBakım.bmp.x = 6;
            }
            else
            {
                MessageBox.Show("Lütfen önce giriş yapın");
            }


        }

        private void randevularımToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
     
        }

        private void randevularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login)
            {
                Randevularim rdv = new Randevularim();
                rdv.Show();
            }
            else
            {
                MessageBox.Show("Lütfen önce giriş yapın");
            }
      
        }
    }
}
