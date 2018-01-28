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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            
            string cinsiyet = cmbCinsiyet.Text;
            KayitForm kf = new KayitForm(this, "1",cinsiyet);
            
            if (cmbCinsiyet.Text == "")
            {
                MessageBox.Show("Lütfen önce cinsiyet seçiniz!");
                kf.Close();


            }else
                kf.ShowDialog();
            cmbCinsiyet.Text = "";
           


        }
        public void buton1RenkDuzenlemesi(string cinsiyet)
        {
            if (cinsiyet == "KADIN")
            {
                button1.BackColor = Color.Pink;
            }
            else
                button1.BackColor = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cinsiyet = cmbCinsiyet.Text;
            KayitForm kf = new KayitForm(this, "2", cinsiyet);

            if (cmbCinsiyet.Text == "")
            {
                MessageBox.Show("Lütfen önce cinsiyet seçiniz!");
                kf.Close();
                


            }
            else if (cmbCinsiyet.Text == "KADIN")
            {
                if (button3.BackColor == Color.Blue)
                {
                    MessageBox.Show("Bu koltuğu yalnızca erkek yolcular alabilir");
                    kf.Close();

                }else
                    kf.ShowDialog();


            }
            else if (cmbCinsiyet.Text=="ERKEK")
            {
                if (button3.BackColor == Color.Pink)
                {
                    MessageBox.Show("Bu koltuğu yalnızca erkek yolcular alabilir");
                    kf.Close();

                }
                else
                    kf.ShowDialog();
            }
            else
                kf.ShowDialog();

            






            cmbCinsiyet.Text = "";
        }
        public void buton2RenkDuzenlemesi(string cinsiyet)
        {

            if (cinsiyet == "KADIN")
            {
                button2.BackColor = Color.Pink;
            }
            else
                button2.BackColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cinsiyet = cmbCinsiyet.Text;
            KayitForm kf = new KayitForm(this, "3", cinsiyet);

            if (cmbCinsiyet.Text == "")
            {
                MessageBox.Show("Lütfen önce cinsiyet seçiniz!");
                kf.Close();
                if (button2.BackColor == Color.Blue)
                {
                    MessageBox.Show("Bu koltuğu yalnızca erkek yolcular alabilir");
                    kf.Close();

                }
                else
                    kf.ShowDialog();


            }
            else if (cmbCinsiyet.Text == "ERKEK")
            {
                if (button2.BackColor == Color.Pink)
                {
                    MessageBox.Show("Bu koltuğu yalnızca erkek yolcular alabilir");
                    kf.Close();

                }
                else
                    kf.ShowDialog();


            }
            else
                kf.ShowDialog();
            cmbCinsiyet.Text = "";
        }
        public void buton3RenkDuzenlemesi(string cinsiyet)
        {
            if (cinsiyet == "KADIN")
            {
                button3.BackColor = Color.Pink;
            }
            else
                button3.BackColor = Color.Blue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cinsiyet = cmbCinsiyet.Text;
            KayitForm kf = new KayitForm(this, "4", cinsiyet);

            if (cmbCinsiyet.Text == "")
            {
                MessageBox.Show("Lütfen önce cinsiyet seçiniz!");
                kf.Close();


            }
            else
                kf.ShowDialog();
            cmbCinsiyet.Text = "";
        }
        public void buton4RenkDuzenlemesi(string cinsiyet)
        {
            if (cinsiyet == "KADIN")
            {
                button4.BackColor = Color.Pink;
            }
            else
                button4.BackColor = Color.Blue;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string cinsiyet = cmbCinsiyet.Text;
            KayitForm kf = new KayitForm(this, "5", cinsiyet);

            if (cmbCinsiyet.Text == "")
            {
                MessageBox.Show("Lütfen önce cinsiyet seçiniz!");
                kf.Close();
                if (button6.BackColor == Color.Blue)
                {
                    MessageBox.Show("Bu koltuğu yalnızca erkek yolcular alabilir");
                    kf.Close();

                }
                else
                    kf.ShowDialog();


            }
            else if (cmbCinsiyet.Text == "ERKEK")
            {
                if (button6.BackColor == Color.Pink)
                {
                    MessageBox.Show("Bu koltuğu yalnızca erkek yolcular alabilir");
                    kf.Close();

                }
                else
                    kf.ShowDialog();


            }
            else
                kf.ShowDialog();
            cmbCinsiyet.Text = "";
        }
        public void buton5RenkDuzenlemesi(string cinsiyet)
        {
            if (cinsiyet == "KADIN")
            {
                button5.BackColor = Color.Pink;
            }
            else
                button5.BackColor = Color.Blue;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string cinsiyet = cmbCinsiyet.Text;
            KayitForm kf = new KayitForm(this, "6", cinsiyet);

            if (cmbCinsiyet.Text == "")
            {
                MessageBox.Show("Lütfen önce cinsiyet seçiniz!");
                kf.Close();
                if (button5.BackColor == Color.Blue)
                {
                    MessageBox.Show("Bu koltuğu yalnızca erkek yolcular alabilir");
                    kf.Close();

                }
                else
                    kf.ShowDialog();


            }
            else if (cmbCinsiyet.Text == "ERKEK")
            {
                if (button5.BackColor == Color.Pink)
                {
                    MessageBox.Show("Bu koltuğu yalnızca erkek yolcular alabilir");
                    kf.Close();

                }
                else
                    kf.ShowDialog();



            }
            else
                kf.ShowDialog();
            cmbCinsiyet.Text = "";
        }
        public void buton6RenkDuzenlemesi(string cinsiyet)
        {
            if (cinsiyet == "KADIN")
            {
                button6.BackColor = Color.Pink;
            }
            else
                button6.BackColor = Color.Blue;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string cinsiyet = cmbCinsiyet.Text;
            KayitForm kf = new KayitForm(this, "7", cinsiyet);

            if (cmbCinsiyet.Text == "")
            {
                MessageBox.Show("Lütfen önce cinsiyet seçiniz!");
                kf.Close();


            }
            else
                kf.ShowDialog();
            cmbCinsiyet.Text = "";
        }
        public void buton7RenkDuzenlemesi(string cinsiyet)
        {
            if (cinsiyet == "KADIN")
            {
                button7.BackColor = Color.Pink;
            }
            else
                button7.BackColor = Color.Blue;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            string cinsiyet = cmbCinsiyet.Text;
            KayitForm kf = new KayitForm(this, "8", cinsiyet);

            if (cmbCinsiyet.Text == "")
            {
                MessageBox.Show("Lütfen önce cinsiyet seçiniz!");
                kf.Close();
                if (button9.BackColor == Color.Blue)
                {
                    MessageBox.Show("Bu koltuğu yalnızca erkek yolcular alabilir");
                    kf.Close();

                }
                else
                    kf.ShowDialog();


            }
            else if (cmbCinsiyet.Text == "ERKEK")
            {
                if (button9.BackColor == Color.Pink)
                {
                    MessageBox.Show("Bu koltuğu yalnızca erkek yolcular alabilir");
                    kf.Close();

                }
                else
                    kf.ShowDialog();


            }
            else
                kf.ShowDialog();
            cmbCinsiyet.Text = "";
        }
        public void buton8RenkDuzenlemesi(string cinsiyet)
        {
            if (cinsiyet == "KADIN")
            {
                button8.BackColor = Color.Pink;
            }
            else
                button8.BackColor = Color.Blue;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            string cinsiyet = cmbCinsiyet.Text;
            KayitForm kf = new KayitForm(this, "9", cinsiyet);

            if (cmbCinsiyet.Text == "")
            {
                MessageBox.Show("Lütfen önce cinsiyet seçiniz!");
                kf.Close();
                if (button8.BackColor == Color.Blue)
                {
                    MessageBox.Show("Bu koltuğu yalnızca erkek yolcular alabilir");
                    kf.Close();

                }
                else
                    kf.ShowDialog();


            }
            else if (cmbCinsiyet.Text == "ERKEK")
            {
                if (button8.BackColor == Color.Pink)
                {
                    MessageBox.Show("Bu koltuğu yalnızca erkek yolcular alabilir");
                    kf.Close();

                }
                else
                    kf.ShowDialog();


            }
            else
                kf.ShowDialog();
            cmbCinsiyet.Text = "";
        }
        public void buton9RenkDuzenlemesi(string cinsiyet)
        {
            if (cinsiyet == "KADIN")
            {
                button9.BackColor = Color.Pink;
            }
            else
                button9.BackColor = Color.Blue;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string cinsiyet = cmbCinsiyet.Text;
            KayitForm kf = new KayitForm(this, "10", cinsiyet);

            if (cmbCinsiyet.Text == "")
            {
                MessageBox.Show("Lütfen önce cinsiyet seçiniz!");
                kf.Close();


            }
            else
                kf.ShowDialog();
            cmbCinsiyet.Text = "";
        }
        public void buton10RenkDuzenlemesi(string cinsiyet)
        {
            if (cinsiyet == "KADIN")
            {
                button10.BackColor = Color.Pink;
            }
            else
                button10.BackColor = Color.Blue;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string cinsiyet = cmbCinsiyet.Text;
            KayitForm kf = new KayitForm(this, "11", cinsiyet);

            if (cmbCinsiyet.Text == "")
            {
                MessageBox.Show("Lütfen önce cinsiyet seçiniz!");
                kf.Close();
                if (button12.BackColor == Color.Blue)
                {
                    MessageBox.Show("Bu koltuğu yalnızca erkek yolcular alabilir");
                    kf.Close();

                }
                else
                    kf.ShowDialog();


            }
            else if (cmbCinsiyet.Text == "ERKEK")
            {
                if (button12.BackColor == Color.Pink)
                {
                    MessageBox.Show("Bu koltuğu yalnızca erkek yolcular alabilir");
                    kf.Close();

                }
                else
                    kf.ShowDialog();


            }
            else
                kf.ShowDialog();
            cmbCinsiyet.Text = "";
        }
        public void buton11RenkDuzenlemesi(string cinsiyet)
        {
            if (cinsiyet == "KADIN")
            {
                button11.BackColor = Color.Pink;
            }
            else
                button11.BackColor = Color.Blue;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string cinsiyet = cmbCinsiyet.Text;
            KayitForm kf = new KayitForm(this, "12", cinsiyet);

            if (cmbCinsiyet.Text == "")
            {
                MessageBox.Show("Lütfen önce cinsiyet seçiniz!");
                kf.Close();
                if (button11.BackColor == Color.Blue)
                {
                    MessageBox.Show("Bu koltuğu yalnızca erkek yolcular alabilir");
                    kf.Close();

                }
                else
                    kf.ShowDialog();


            }
            else if (cmbCinsiyet.Text == "ERKEK")
            {
                if (button11.BackColor == Color.Pink)
                {
                    MessageBox.Show("Bu koltuğu yalnızca erkek yolcular alabilir");
                    kf.Close();

                }
                else
                    kf.ShowDialog();


            }
            else
                kf.ShowDialog();
            cmbCinsiyet.Text = "";
        }
        public void buton12RenkDuzenlemesi(string cinsiyet)
        {
            if (cinsiyet == "KADIN")
            {
                button12.BackColor = Color.Pink;
            }
            else
                button12.BackColor = Color.Blue;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            string cinsiyet = cmbCinsiyet.Text;
            KayitForm kf = new KayitForm(this, "13", cinsiyet);

            if (cmbCinsiyet.Text == "")
            {
                MessageBox.Show("Lütfen önce cinsiyet seçiniz!");
                kf.Close();


            }
            else
                kf.ShowDialog();
            cmbCinsiyet.Text = "";
        }
        public void buton13RenkDuzenlemesi(string cinsiyet)
        {
            if (cinsiyet == "KADIN")
            {
                button13.BackColor = Color.Pink;
            }
            else
                button13.BackColor = Color.Blue;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string cinsiyet = cmbCinsiyet.Text;
            KayitForm kf = new KayitForm(this, "14", cinsiyet);

            if (cmbCinsiyet.Text == "")
            {
                MessageBox.Show("Lütfen önce cinsiyet seçiniz!");
                kf.Close();
                if (button15.BackColor == Color.Blue)
                {
                    MessageBox.Show("Bu koltuğu yalnızca erkek yolcular alabilir");
                    kf.Close();

                }
                else
                    kf.ShowDialog();


            }
            else if (cmbCinsiyet.Text == "ERKEK")
            {
                if (button15.BackColor == Color.Pink)
                {
                    MessageBox.Show("Bu koltuğu yalnızca erkek yolcular alabilir");
                    kf.Close();

                }
                else
                    kf.ShowDialog();


            }
            else
                kf.ShowDialog();
            cmbCinsiyet.Text = "";
        }
        public void buton14RenkDuzenlemesi(string cinsiyet)
        {
            if (cinsiyet == "KADIN")
            {
                button14.BackColor = Color.Pink;
            }
            else
                button14.BackColor = Color.Blue;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string cinsiyet = cmbCinsiyet.Text;
            KayitForm kf = new KayitForm(this, "15", cinsiyet);

            if (cmbCinsiyet.Text == "")
            {
                MessageBox.Show("Lütfen önce cinsiyet seçiniz!");
                kf.Close();
                if (button14.BackColor == Color.Blue)
                {
                    MessageBox.Show("Bu koltuğu yalnızca erkek yolcular alabilir");
                    kf.Close();

                }
                else
                    kf.ShowDialog();


            }
            else if (cmbCinsiyet.Text == "ERKEK")
            {
                if (button14.BackColor == Color.Pink)
                {
                    MessageBox.Show("Bu koltuğu yalnızca erkek yolcular alabilir");
                    kf.Close();

                }
                else
                    kf.ShowDialog();

            }
            else
                kf.ShowDialog();
            cmbCinsiyet.Text = "";
        }
        public void buton15RenkDuzenlemesi(string cinsiyet)
        {
            if (cinsiyet == "KADIN")
            {
                button15.BackColor = Color.Pink;
            }
            else
                button15.BackColor = Color.Blue;
        }
    }
}
