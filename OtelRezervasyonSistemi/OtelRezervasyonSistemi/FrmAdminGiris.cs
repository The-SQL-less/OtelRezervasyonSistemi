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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        //SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4DKCRAA;Initial Catalog=OtelR;Integrated Security=True");

        // AZURE CONN
        SqlConnection baglanti = new SqlConnection("Data Source=thesqlless.database.windows.net;Initial Catalog=OtelRez;Persist Security Info=True;User ID=thesqlless;Password=DBsmyo55");
        

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            // vt baglandıgında calıstıracagımız kod
            try
            {
                baglanti.Open();
                string sql = "select * from AdminGiris where Kullanici=@Kullaniciadi AND Sifre=@Sifresi";
                SqlParameter prm1 = new SqlParameter("Kullaniciadi", TxtKullanıcıAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Sifresi", TxtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);

                da.Fill(dt);

                if(dt.Rows.Count>0)
                {
                    FrmAnaForm fr = new FrmAnaForm();
                    fr.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş");
            } 

            /*
            string kadi,sifre;
            kadi = Convert.ToString(TxtKullanıcıAdi.Text);
            sifre = Convert.ToString(TxtSifre.Text);
            

            if(kadi=="admin" && sifre=="1234")
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız.");
                TxtSifre.Clear();
            }*/
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
//Data Source=DESKTOP-4DKCRAA;Initial Catalog=OtelR;Integrated Security=True
//Server=tcp:thesqlless.database.windows.net,1433;Initial Catalog=OtelRez;Persist Security Info=False;User ID=thesqlless;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;
