using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace avukat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        baglantim baglantim = new baglantim();
        
        private void button1_Click(object sender, EventArgs e)
        {
            string cevap = null;
            if (radioButton1.Checked == true)
            {
                cevap = baglantim.prosedurAVUKATGIRIS(textBox1.Text, textBox3.Text, "Avukat");
                if (cevap == "Bilgiler Doğru")
                {
                    Form2 f2 = new Form2();
                    f2.isim = baglantim.isim;
                    f2.Show();
                    this.Hide();
                }
                else if (cevap == "Bilgiler Yanlış")
                {
                    label4.Text = "Bilgiler Yanlış";
                }
            }
            else if (radioButton2.Checked == true)
            {
                cevap = baglantim.prosedurAVUKATGIRIS(textBox1.Text, textBox3.Text, "Stajyer");
                if (cevap == "Bilgiler Doğru")
                {
                    Form4 f4 = new Form4();
                    f4.isim = baglantim.isim;
                    f4.Show();
                    this.Hide();
                }
                else if (cevap == "Bilgiler Yanlış")
                {
                    label4.Text = "Bilgiler Yanlış";
                }
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Kullanıcı Girişi";
            this.AcceptButton = button1; this.CancelButton = cikis;
            radioButton1.Checked = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            
        }
    }

}
