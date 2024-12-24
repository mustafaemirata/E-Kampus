using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniNotSistemi
{
    public partial class OgrenciAnaForm : Form
    {
        public OgrenciAnaForm()
        {
            InitializeComponent();
        }
      public SqlConnection baglanti = new SqlConnection(@"Data Source=EMIR\SQLEXPRESS;Initial Catalog=DbUniversite;Integrated Security=True;Encrypt=False");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void ortalamaKontrol()
        {
            double donemOrt = Convert.ToDouble(donemOrtalama.Text);
            double genelOrt=Convert.ToDouble(genelOrtalama.Text);

            if(donemOrt<2.00)
            {
                donemOrtalama.ForeColor = Color.Red;
            }
            else
            {
                donemOrtalama.ForeColor= Color.Green;
            }
            if(genelOrt<2.00)
            {
                genelOrtalama.ForeColor= Color.Red;
            }
            else
            {
                genelOrtalama.ForeColor = Color.Green;

            }
        }
        private void OgrenciAnaForm_Load(object sender, EventArgs e)
        {
            panelGenel.Visible = false;
            ogrenciBilgiGetir();
            ortalamaKontrol();
        }

        void ogrenciBilgiGetir()
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("SELECT *FROM Tbl_OgrenciDetay WHERE OGRNO=@P1",baglanti);
            komut.Parameters.AddWithValue("@P1", ogrNo.Text);
            SqlDataReader oku=komut.ExecuteReader();

            if(oku.Read())
            {
                ogrFakulte.Text = "Okul No: "+oku[2].ToString();
                donemOrtalama.Text = oku[5].ToString();
                genelOrtalama.Text = oku[6].ToString();
                ogrBolum.Text = oku[3].ToString();
                ogrenciSinif.Text = oku[4].ToString()+". Sınıf";
                ogrResim.ImageLocation = oku[7].ToString();
            }





            baglanti.Close();
        }
        private void bilgiResim_Click(object sender, EventArgs e)
        {
            if (panelGenel.Visible == false)
            {
                bilgiResim.Image = Properties.Resources.GreenInfo;

                panelGenel.Visible=true;
            }
            else
            {
                bilgiResim.Image = Properties.Resources.info_4_;

                panelGenel.Visible=false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.Orange;

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(17, 28, 43);

        }
    }
}
