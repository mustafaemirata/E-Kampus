using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UniNotSistemi
{
    public partial class OgrenciGiris : Form
    {
        public OgrenciGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=EMIR\SQLEXPRESS;Initial Catalog=DbUniversite;Integrated Security=True;Encrypt=False");

        void guvenilKodOlustur()
        {
            Random rastgele=new Random();
            string karakterler = "0123456789qwertyuıopğüasdfghjklşizxcvbnmöçQWERTYUIOPĞÜİŞLKJJHGFDSAZXCVBNMÖÇ";
            string olustur = "";
            for(int i=0;i<4; i++)
            {
                olustur += karakterler[rastgele.Next(karakterler.Length)];  
            }
            txtGUVENİLKnO.Text = olustur.ToString();   
            guvenlikNoTextBox.Text = olustur.ToString();
        }
        
        private void CBgOSTERgİZLE_CheckedChanged(object sender, EventArgs e)
        {
            if (ogrSifre.UseSystemPasswordChar == true)
            {
            
               ogrSifre.UseSystemPasswordChar = false;  

            }
            else
            {
                ogrSifre.UseSystemPasswordChar= true;
            }
        }

        private void OgrenciGiris_Load(object sender, EventArgs e)
        {
          
        }

        private void REFRESH_Click(object sender, EventArgs e)
        {
            guvenilKodOlustur();

        }

      
        private void BTNgİRİS_Click(object sender, EventArgs e)
        {
            if(ogrSifre.Text!=""&&ogrNumara.Text!=""&&guvenlikNoTextBox.Text!="")
            {
                if(ogrNumara.TextLength>10)
                {
                    MessageBox.Show("Öğrenci numarası 10 haneli olmalıdır.");
                }
                else
                {
                    if(guvenlikNoTextBox.Text==txtGUVENİLKnO.Text)
                    {
                        baglanti.Open();

                        string sorgu = "SELECT *FROM Tbl_Ogrenciler WHERE OGRENCINO=@P1 AND OGRSIFRE=@P2";
                        SqlCommand komut = new SqlCommand(sorgu,baglanti);
                        komut.Parameters.AddWithValue("@P1", ogrNumara.Text);
                        komut.Parameters.AddWithValue("@P2", ogrSifre.Text);
                        SqlDataReader oku= komut.ExecuteReader();
                        if (oku.Read())
                        {
                            string ogrenciAd = oku["OGRAD"].ToString(); 
                            string ogrenciSoyad = oku[4].ToString();
                            string okulNo = oku["OGRENCINO"].ToString();
                            MessageBox.Show(oku[3].ToString());

                            OgrenciAnaForm frm= new OgrenciAnaForm();
                            frm.ogrNo.Text = okulNo;
                            frm.ogrenciAd.Text = ogrenciAd+ogrenciSoyad;
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Girilen bilgilere ait bir kayıt bulunamadı.");
                        }



                        baglanti.Close();

                    }
                    else
                    {
                        MessageBox.Show("Güvenlik kodunu doğru giriniz.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }
        }
    }
}
