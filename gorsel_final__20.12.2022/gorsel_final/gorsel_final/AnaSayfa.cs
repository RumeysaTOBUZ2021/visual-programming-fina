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
        
        public AnaSayfa()
        {
            InitializeComponent();

        }

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
            BM_PeriyodikBakım periyodikekran = new BM_PeriyodikBakım();
            periyodikekran.Show();
        }

        private void üyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeEkran uyeekran = new UyeEkran();
            uyeekran.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
