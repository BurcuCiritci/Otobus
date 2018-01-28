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
    public partial class Form2 : Form
    {
        
        public Form2(KayitForm Ky)
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamReader sr = new StreamReader(mydocpath + @"\WriteFile.txt");
            string line;
            line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                string[] kolon = line.Split('|');
                dataGridView1.Rows.Add(kolon[0], kolon[1], kolon[2], kolon[3], kolon[4]);
                line = sr.ReadLine();
            }

            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
