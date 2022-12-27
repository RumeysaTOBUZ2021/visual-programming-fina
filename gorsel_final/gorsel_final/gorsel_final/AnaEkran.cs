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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
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

        private void hakkımızddaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkımızda hakkımızdaekran = new Hakkımızda();
            hakkımızdaekran.Show();
        }

        private void uyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Iletisim iletisim = new Iletisim();
            iletisim.Show();
        }

        private void uyeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UyeEkran uyeekran = new UyeEkran();
            uyeekran.Show();
        }
    
    }
}
