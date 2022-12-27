namespace gorsel_final
{
    partial class Hakkımızda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hakkımızda));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hizmetlerimizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bakımVeMuayeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kampanyalarımızToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızddaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.hizmetlerimizToolStripMenuItem,
            this.kampanyalarımızToolStripMenuItem,
            this.hakkımızddaToolStripMenuItem,
            this.iletişimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            // 
            // hizmetlerimizToolStripMenuItem
            // 
            this.hizmetlerimizToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bakımVeMuayeneToolStripMenuItem});
            this.hizmetlerimizToolStripMenuItem.Name = "hizmetlerimizToolStripMenuItem";
            this.hizmetlerimizToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.hizmetlerimizToolStripMenuItem.Text = "Hizmetlerimiz";
            // 
            // bakımVeMuayeneToolStripMenuItem
            // 
            this.bakımVeMuayeneToolStripMenuItem.Name = "bakımVeMuayeneToolStripMenuItem";
            this.bakımVeMuayeneToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.bakımVeMuayeneToolStripMenuItem.Text = "Bakım ve Muayene";
            // 
            // kampanyalarımızToolStripMenuItem
            // 
            this.kampanyalarımızToolStripMenuItem.Name = "kampanyalarımızToolStripMenuItem";
            this.kampanyalarımızToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.kampanyalarımızToolStripMenuItem.Text = "Kampanyalarımız";
            // 
            // hakkımızddaToolStripMenuItem
            // 
            this.hakkımızddaToolStripMenuItem.Name = "hakkımızddaToolStripMenuItem";
            this.hakkımızddaToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.hakkımızddaToolStripMenuItem.Text = "Hakkımızda";
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 422);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Hakkımızda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Hakkımızda";
            this.Text = "Hakkımızda";
            this.Load += new System.EventHandler(this.Hakkımızda_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hizmetlerimizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bakımVeMuayeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kampanyalarımızToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızddaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}