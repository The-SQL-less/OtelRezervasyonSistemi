using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyonSistemi
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri fr = new FrmYeniMusteri();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr = new FrmMusteriler();
            fr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("  \n                            🆃🅷🅴🆂🆀🅻🅻🅴🆂🆂 🇨​🇴​🇵​🇾​🇷​🇮​🇬​🇭​🇹​ ©₂₀₂₂ \n\n 𝟐𝟎𝟒𝟖𝟎𝟎𝟗𝟖 Busenur ADIBELLİ \n\n 𝟐𝟎𝟒𝟖𝟎𝟎𝟗𝟓 Damla KARAKUŞ \n\n 𝟐𝟎𝟒𝟖𝟎𝟎𝟓𝟖 Gökhan Esat HAZIRLAR \n\n 𝟏𝟗𝟒𝟖𝟎𝟏𝟎𝟏 Oğuz Kağan İPEK \n\n 𝟐𝟎𝟒𝟖𝟎𝟎𝟑𝟔 Aleyna GÜNEŞ \n\n 𝟐𝟎𝟒𝟖𝟎𝟎𝟕𝟐 Mehmet Ali AÇIKGÖZ\n\n Bu Proje Ondokuz Mayız Üniversitesi Samsun Meslek Yüksekokulu Bilgisayar Programcılığı Veri Tabanı-II Dersininin Final Projesi için oluşturulmuştur.");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmGelirGider fr = new FrmGelirGider();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmStoklar fr = new FrmStoklar();
            fr.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmRadyoDinle fr = new FrmRadyoDinle();
            fr.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmGazeteler fr = new FrmGazeteler();
            fr.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmSifreGuncelle fr = new FrmSifreGuncelle();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmMesajlar fr = new FrmMesajlar();
            fr.Show();
        }
    }
}
