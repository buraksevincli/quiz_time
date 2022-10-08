using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_hw_bilgi_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Text = "Yarışmayı Başlat";
        }
        int soruno=0, dogruno=0, yanlisno=0 ;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnB.Text;

            if (label5.Text == label4.Text)
            {
                dogruno++;
                lblDogruno.Text = dogruno.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlisno++;
                lblYanlisno.Text = yanlisno.ToString();
                pictureBox2.Visible = true;
                MessageBox.Show("Doğru Cevap: " + label4.Text,"Yanlış!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnC.Text;

            if (label5.Text == label4.Text)
            {
                dogruno++;
                lblDogruno.Text = dogruno.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlisno++;
                lblYanlisno.Text = yanlisno.ToString();
                pictureBox2.Visible = true;
                MessageBox.Show("Doğru Cevap: " + label4.Text,"Yanlış!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnD.Text;

            if (label5.Text == label4.Text)
            {
                dogruno++;
                lblDogruno.Text = dogruno.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlisno++;
                lblYanlisno.Text = yanlisno.ToString();
                pictureBox2.Visible = true;
                MessageBox.Show("Doğru Cevap: " + label4.Text,"Yanlış!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnA.Text;

            if (label5.Text == label4.Text)
            {
                dogruno++;
                lblDogruno.Text = dogruno.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlisno++;
                lblYanlisno.Text = yanlisno.ToString();
                pictureBox2.Visible = true;
                MessageBox.Show("Doğru Cevap: " + label4.Text,"Yanlış!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnSonraki.Enabled=false;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            soruno++;

            if (soruno == 1)
            {
                btnSonraki.Text = "Sonraki";
                lblSoruno.Text = soruno.ToString();
                richTextBox1.Text ="Atatürk hangi yılda doğmuştur?";
                btnA.Text = "1923";
                btnB.Text = "1938";
                btnC.Text = "1881";
                btnD.Text = "1823";
                label4.Text = "1881";
            }
            if (soruno == 2)
            {
                lblSoruno.Text = soruno.ToString();
                richTextBox1.Text = "Cumhuriyet hangi yılda ilan edilmiştir?";
                btnA.Text = "1938";
                btnB.Text = "1923";
                btnC.Text = "1881";
                btnD.Text = "1823";
                label4.Text = "1923";
            }
            if (soruno == 3)
            {
                lblSoruno.Text = soruno.ToString();
                richTextBox1.Text = "Everest Tepesine tırmanan ilk Türk dağcı kimdir?";
                btnA.Text = "Engin Altan Düzyatan";
                btnB.Text = "Burak Sevinçli";
                btnC.Text = "Nazım Hikmet";
                btnD.Text = "Nasuh MAHRUKİ";
                label4.Text = "Nasuh MAHRUKİ";
            }
            if (soruno == 4)
            {
                lblSoruno.Text = soruno.ToString();
                richTextBox1.Text = "Amerika kıtasını 2’ye ayıran önemli su geçidinin adı nedir?";
                btnA.Text = "Kızılırmak";
                btnB.Text = "Panama";
                btnC.Text = "Fırat";
                btnD.Text = "Yeşilırmak";
                label4.Text = "Panama";
            }
            if (soruno == 5)
            {
                lblSoruno.Text = soruno.ToString();
                richTextBox1.Text = "Notada durak işareti hangisidir ?";
                btnA.Text = "Ses";
                btnB.Text = "Es";
                btnC.Text = "Sus";
                btnD.Text = "Pus";
                label4.Text = "Es";
            }
            if (soruno == 6)
            {
                lblSoruno.Text = soruno.ToString();
                richTextBox1.Text = "Maddenin ölçülemeyen özelliği hangisidir ?";
                btnA.Text = "Hacim";
                btnB.Text = "Kütle";
                btnC.Text = "Koku";
                btnD.Text = "Yoğunluk";
                label4.Text = "Koku";
            }
            if (soruno == 7)
            {
                lblSoruno.Text = soruno.ToString();
                richTextBox1.Text = "Pusulada ( N ) harfi hangi yönü ifade eder ?";
                btnA.Text = "Kuzey";
                btnB.Text = "Güney";
                btnC.Text = "Doğu";
                btnD.Text = "Batı";
                label4.Text = "Kuzey";
            }
            if (soruno == 8)
            {
                lblSoruno.Text = soruno.ToString();
                richTextBox1.Text = "Çocuk hakları günü hangi tarihte kutlanmaktadır ?";
                btnA.Text = "23 Nisan";
                btnB.Text = "19 Mayıs";
                btnC.Text = "30 Ağustos";
                btnD.Text = "20 Kasım";
                label4.Text = "20 Kasım";
            }
            if (soruno == 9)
            {
                lblSoruno.Text = soruno.ToString();
                richTextBox1.Text = "Cumhurbaşkanı kim tarafından seçilir ?";
                btnA.Text = "Milletvekilleri";
                btnB.Text = "Cumhurbaşkanı";
                btnC.Text = "Halk";
                btnD.Text = "Onu Allah biliyor";
                label4.Text = "Halk";
            }
            if (soruno == 10)
            {
                lblSoruno.Text = soruno.ToString();
                richTextBox1.Text = "Türkçe hangi dil grubuna girmektedir ?";
                btnA.Text = "Ural - Altay";
                btnB.Text = "Inter - Milan";
                btnC.Text = "Fenerbahçe - Galatasaray";
                btnD.Text = "Barcelona - Real Madrid";
                label4.Text = "Ural - Altay";

                btnSonraki.Text = "Sonuçlar";
            }
            if (soruno == 11)
            {
                lblSoruno.Text = "Bitti";
                richTextBox1.Text="Tebrikler Yarışmayı Tamamladınız!";
                btnA.Text = "Tebrikler";
                btnB.Text = "Tebrikler";
                btnC.Text = "Tebrikler";
                btnD.Text = "Tebrikler";
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                btnA.Enabled=false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
                MessageBox.Show(("Sonuçlar!"+ "\n" +"Doğru:" + dogruno + "\n" +"Yanlış:"+yanlisno),"Tebrikler!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }
    }
}
