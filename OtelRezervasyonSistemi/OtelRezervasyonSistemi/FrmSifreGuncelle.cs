﻿using System;
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
    public partial class FrmSifreGuncelle : Form
    {
        public FrmSifreGuncelle()
        {
            InitializeComponent();
        }
        //SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4DKCRAA;Initial Catalog=OtelR;Integrated Security=True");

        // AZURE CONN
        SqlConnection baglanti = new SqlConnection("Data Source=thesqlless.database.windows.net;Initial Catalog=OtelRez;Persist Security Info=True;User ID=thesqlless;Password=DBsmyo55");
        
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update AdminGiris set Kullanici='" + TxtKullaniciAdi.Text + "',Sifre='" + TxtSifre.Text +"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla Güncellendi.");

        }
    }
}
