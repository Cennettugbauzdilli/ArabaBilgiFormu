using System;
using System.Windows.Forms;

namespace Araba_bilgi_formu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TextBox'lardan gelen verileri değişkenlerde saklıyoruz
            string marka = txtMarka.Text;
            string model = txtModel.Text;
            string renk = txtRenk.Text;
            string kapiSayisi = txtKapiSayisi.Text;
            string pencereSayisi = txtPencereSayisi.Text;
            string yakitTuketimi = txtYakit.Text;

            // Bilgileri güzel bir şekilde formatlıyoruz
            string bilgi = $"🚗 Araba Bilgileri:\n\n" +
                           $"Marka: {marka}\n" +
                           $"Model: {model}\n" +
                           $"Renk: {renk}\n" +
                           $"Kapı Sayısı: {kapiSayisi}\n" +
                           $"Pencere Sayısı: {pencereSayisi}\n" +
                           $"100 km’de Yakıt Tüketimi: {yakitTuketimi} Litre";

            // Kullanıcıya gösteriyoruz
            MessageBox.Show(bilgi, "Araba Bilgi Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
