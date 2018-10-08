namespace Goruntu_Isleme
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöntemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bT709ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ortalamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açıklıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.kanalÇıkarımıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rÇıkarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gÇıkarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bÇıkarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.yöntemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resimToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // resimToolStripMenuItem
            // 
            this.resimToolStripMenuItem.Name = "resimToolStripMenuItem";
            this.resimToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.resimToolStripMenuItem.Text = "Resim";
            this.resimToolStripMenuItem.Click += new System.EventHandler(this.resimToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // yöntemlerToolStripMenuItem
            // 
            this.yöntemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bT709ToolStripMenuItem,
            this.ortalamaToolStripMenuItem,
            this.lumaToolStripMenuItem,
            this.açıklıkToolStripMenuItem,
            this.kanalÇıkarımıToolStripMenuItem});
            this.yöntemlerToolStripMenuItem.Name = "yöntemlerToolStripMenuItem";
            this.yöntemlerToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.yöntemlerToolStripMenuItem.Text = "Yöntemler";
            // 
            // bT709ToolStripMenuItem
            // 
            this.bT709ToolStripMenuItem.Name = "bT709ToolStripMenuItem";
            this.bT709ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.bT709ToolStripMenuItem.Text = "BT-709";
            this.bT709ToolStripMenuItem.Click += new System.EventHandler(this.bT709ToolStripMenuItem_Click);
            // 
            // ortalamaToolStripMenuItem
            // 
            this.ortalamaToolStripMenuItem.Name = "ortalamaToolStripMenuItem";
            this.ortalamaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ortalamaToolStripMenuItem.Text = "Ortalama";
            this.ortalamaToolStripMenuItem.Click += new System.EventHandler(this.ortalamaToolStripMenuItem_Click);
            // 
            // lumaToolStripMenuItem
            // 
            this.lumaToolStripMenuItem.Name = "lumaToolStripMenuItem";
            this.lumaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.lumaToolStripMenuItem.Text = "Luma";
            this.lumaToolStripMenuItem.Click += new System.EventHandler(this.lumaToolStripMenuItem_Click);
            // 
            // açıklıkToolStripMenuItem
            // 
            this.açıklıkToolStripMenuItem.Name = "açıklıkToolStripMenuItem";
            this.açıklıkToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.açıklıkToolStripMenuItem.Text = "Açıklık";
            this.açıklıkToolStripMenuItem.Click += new System.EventHandler(this.açıklıkToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 505);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ana Resim";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 480);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(498, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 505);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gri Form";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(6, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(460, 480);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // kanalÇıkarımıToolStripMenuItem
            // 
            this.kanalÇıkarımıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rÇıkarToolStripMenuItem,
            this.gÇıkarToolStripMenuItem,
            this.bÇıkarToolStripMenuItem});
            this.kanalÇıkarımıToolStripMenuItem.Name = "kanalÇıkarımıToolStripMenuItem";
            this.kanalÇıkarımıToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.kanalÇıkarımıToolStripMenuItem.Text = "Kanal Çıkarımı";
            // 
            // rÇıkarToolStripMenuItem
            // 
            this.rÇıkarToolStripMenuItem.Name = "rÇıkarToolStripMenuItem";
            this.rÇıkarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.rÇıkarToolStripMenuItem.Text = "R Çıkar";
            this.rÇıkarToolStripMenuItem.Click += new System.EventHandler(this.rÇıkarToolStripMenuItem_Click);
            // 
            // gÇıkarToolStripMenuItem
            // 
            this.gÇıkarToolStripMenuItem.Name = "gÇıkarToolStripMenuItem";
            this.gÇıkarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.gÇıkarToolStripMenuItem.Text = "G Çıkar";
            this.gÇıkarToolStripMenuItem.Click += new System.EventHandler(this.gÇıkarToolStripMenuItem_Click);
            // 
            // bÇıkarToolStripMenuItem
            // 
            this.bÇıkarToolStripMenuItem.Name = "bÇıkarToolStripMenuItem";
            this.bÇıkarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.bÇıkarToolStripMenuItem.Text = "B Çıkar";
            this.bÇıkarToolStripMenuItem.Click += new System.EventHandler(this.bÇıkarToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Gri Yöntemleri";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöntemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bT709ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ortalamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açıklıkToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ToolStripMenuItem kanalÇıkarımıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rÇıkarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gÇıkarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bÇıkarToolStripMenuItem;
    }
}