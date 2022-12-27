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

namespace gorsel_final
{
    public partial class BM_PeriyodikBakım : Form
    {
        public BM_PeriyodikBakım()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BM_PeriyodikBakım_Load(object sender, EventArgs e)
        {
            richTextBox1.Parent = pictureBox1;
            richTextBox1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*RandevuAl randevuekran = new RandevuAl();
            randevuekran.Show();*/
        }
    }
}
