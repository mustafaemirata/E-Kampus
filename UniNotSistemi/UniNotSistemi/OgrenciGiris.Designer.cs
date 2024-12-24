namespace UniNotSistemi
{
    partial class OgrenciGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ogrNumara = new System.Windows.Forms.TextBox();
            this.ogrSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guvenlikNoTextBox = new System.Windows.Forms.TextBox();
            this.txtGUVENİLKnO = new System.Windows.Forms.Label();
            this.REFRESH = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTNgİRİS = new System.Windows.Forms.Button();
            this.CBgOSTERgİZLE = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.REFRESH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 48);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(726, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(47, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "ÖĞRENCİ GİRİŞ EKRANI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "ÖĞRENCİ NUMARASI:";
            // 
            // ogrNumara
            // 
            this.ogrNumara.Location = new System.Drawing.Point(327, 101);
            this.ogrNumara.Name = "ogrNumara";
            this.ogrNumara.Size = new System.Drawing.Size(178, 34);
            this.ogrNumara.TabIndex = 2;
            // 
            // ogrSifre
            // 
            this.ogrSifre.Location = new System.Drawing.Point(327, 141);
            this.ogrSifre.Name = "ogrSifre";
            this.ogrSifre.Size = new System.Drawing.Size(178, 34);
            this.ogrSifre.TabIndex = 3;
            this.ogrSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "ŞİFRE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "GÜVENLİK NUMARASI:";
            // 
            // guvenlikNoTextBox
            // 
            this.guvenlikNoTextBox.Location = new System.Drawing.Point(327, 181);
            this.guvenlikNoTextBox.Name = "guvenlikNoTextBox";
            this.guvenlikNoTextBox.Size = new System.Drawing.Size(78, 34);
            this.guvenlikNoTextBox.TabIndex = 6;
            // 
            // txtGUVENİLKnO
            // 
            this.txtGUVENİLKnO.AutoSize = true;
            this.txtGUVENİLKnO.Location = new System.Drawing.Point(411, 187);
            this.txtGUVENİLKnO.Name = "txtGUVENİLKnO";
            this.txtGUVENİLKnO.Size = new System.Drawing.Size(66, 28);
            this.txtGUVENİLKnO.TabIndex = 7;
            this.txtGUVENİLKnO.Text = "label5";
            // 
            // REFRESH
            // 
            this.REFRESH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.REFRESH.Image = global::UniNotSistemi.Properties.Resources.refresh_button;
            this.REFRESH.Location = new System.Drawing.Point(483, 187);
            this.REFRESH.Name = "REFRESH";
            this.REFRESH.Size = new System.Drawing.Size(37, 28);
            this.REFRESH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.REFRESH.TabIndex = 8;
            this.REFRESH.TabStop = false;
            this.REFRESH.Click += new System.EventHandler(this.REFRESH_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::UniNotSistemi.Properties.Resources.graduation;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BTNgİRİS
            // 
            this.BTNgİRİS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.BTNgİRİS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNgİRİS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNgİRİS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNgİRİS.Location = new System.Drawing.Point(327, 239);
            this.BTNgİRİS.Name = "BTNgİRİS";
            this.BTNgİRİS.Size = new System.Drawing.Size(193, 46);
            this.BTNgİRİS.TabIndex = 9;
            this.BTNgİRİS.Text = "GİRİŞ YAP";
            this.BTNgİRİS.UseVisualStyleBackColor = false;
            this.BTNgİRİS.Click += new System.EventHandler(this.BTNgİRİS_Click);
            // 
            // CBgOSTERgİZLE
            // 
            this.CBgOSTERgİZLE.AutoSize = true;
            this.CBgOSTERgİZLE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBgOSTERgİZLE.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBgOSTERgİZLE.Location = new System.Drawing.Point(377, 291);
            this.CBgOSTERgİZLE.Name = "CBgOSTERgİZLE";
            this.CBgOSTERgİZLE.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CBgOSTERgİZLE.Size = new System.Drawing.Size(143, 24);
            this.CBgOSTERgİZLE.TabIndex = 10;
            this.CBgOSTERgİZLE.Text = "Şifre Göster/Gizle";
            this.CBgOSTERgİZLE.UseVisualStyleBackColor = true;
            this.CBgOSTERgİZLE.CheckedChanged += new System.EventHandler(this.CBgOSTERgİZLE_CheckedChanged);
            // 
            // OgrenciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 373);
            this.Controls.Add(this.CBgOSTERgİZLE);
            this.Controls.Add(this.BTNgİRİS);
            this.Controls.Add(this.REFRESH);
            this.Controls.Add(this.txtGUVENİLKnO);
            this.Controls.Add(this.guvenlikNoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ogrSifre);
            this.Controls.Add(this.ogrNumara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OgrenciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OgrenciGiris_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.REFRESH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ogrNumara;
        private System.Windows.Forms.TextBox ogrSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox guvenlikNoTextBox;
        private System.Windows.Forms.Label txtGUVENİLKnO;
        private System.Windows.Forms.PictureBox REFRESH;
        private System.Windows.Forms.Button BTNgİRİS;
        private System.Windows.Forms.CheckBox CBgOSTERgİZLE;
    }
}

