using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace OtelRezervasyonSistemi
{
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
       
        //SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4DKCRAA;Initial Catalog=OtelR;Integrated Security=True");

        // AZURE CONN
        SqlConnection baglanti = new SqlConnection("Data Source=thesqlless.database.windows.net;Initial Catalog=OtelRez;Persist Security Info=True;User ID=thesqlless;Password=DBsmyo55");
       
        private void veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from Stoklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["İcecekler"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void veriler2()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select*from Faturalar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["Elektrik"].ToString();
                ekle.SubItems.Add(oku2["Su"].ToString());
                ekle.SubItems.Add(oku2["İnternet"].ToString());
                listView2.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void BtnKaydet2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into Faturalar(Elektrik,Su,İnternet) values( '" + TxtElektrik.Text + "','" + TxtSu.Text + "','" + Txtİnternet.Text + "')", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            veriler2();
        }

        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklar(Gida,İcecekler,Cerezler) values( '" + TxtGidalar.Text + "','" + Txtİcecekler.Text + "','" + TxtAtistirmaliklar.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();
        }
    }
}
