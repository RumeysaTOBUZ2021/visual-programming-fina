﻿using System;
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
    public partial class Iletisim : Form
    {
        public Iletisim()
        {
            InitializeComponent();
        }
       
        private void Iletisim_Load(object sender, EventArgs e)
        {
            groupBox1.Parent = pictureBox8;
            groupBox1.BackColor = Color.Transparent;
            groupBox2.Parent = pictureBox8;
            groupBox2.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
