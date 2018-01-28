using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OtobüsOtomasyonu
{
    public partial class KayitForm : Form
    {
        Form1 AnaForm;
        
        public KayitForm(Form1 frm, string koltukNo, string cinsiyet)
        {

            AnaForm = frm;
            InitializeComponent();
            label2.Text = koltukNo;
            lblCinsiyet.Text = cinsiyet;
           
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            
            string mydocpath = Environment.GetFolderPath
                (Environment.SpecialFolder.MyDocuments);
            string[] bilgiler = {label2.Text+" | "+lblCinsiyet.Text+" | "+txtAdsoyad.Text+" | "+txtFiyat.Text+" | "+ DateTime.Now.ToShortDateString() };
            File.AppendAllLines(mydocpath + @"\WriteFile.txt", bilgiler);
            switch (label2.Text)
            {
                case "1":
                    AnaForm.buton1RenkDuzenlemesi(lblCinsiyet.Text);
                    break;
                case "2":
                    AnaForm.buton2RenkDuzenlemesi(lblCinsiyet.Text);
                    break;

                case "3":
                    AnaForm.buton3RenkDuzenlemesi(lblCinsiyet.Text);
                    break;
                case "4":
                    AnaForm.buton4RenkDuzenlemesi(lblCinsiyet.Text);
                    break;
                case "5":
                    AnaForm.buton5RenkDuzenlemesi(lblCinsiyet.Text);
                    break;

                case "6":
                    AnaForm.buton6RenkDuzenlemesi(lblCinsiyet.Text);
                    break;

                case "7":
                    AnaForm.buton7RenkDuzenlemesi(lblCinsiyet.Text);
                    break;
                case "8":
                    AnaForm.buton8RenkDuzenlemesi(lblCinsiyet.Text);
                    break;

                case "9":
                    AnaForm.buton9RenkDuzenlemesi(lblCinsiyet.Text);
                    break;
                case "10":
                    AnaForm.buton10RenkDuzenlemesi(lblCinsiyet.Text);
                    break;
                case "11":
                    AnaForm.buton11RenkDuzenlemesi(lblCinsiyet.Text);
                    break;

                case "12":
                    AnaForm.buton12RenkDuzenlemesi(lblCinsiyet.Text);
                    break;
                case "13":
                    AnaForm.buton13RenkDuzenlemesi(lblCinsiyet.Text);
                    break;
                case "14":
                    AnaForm.buton14RenkDuzenlemesi(lblCinsiyet.Text);
                    break;

                case "15":
                    AnaForm.buton15RenkDuzenlemesi(lblCinsiyet.Text);
                    break;



                default:
                    break;
            }
            MessageBox.Show("Kayıt tamamlandı.");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 yolcuform = new Form2(this);
            yolcuform.Show();
        }
    }
}
