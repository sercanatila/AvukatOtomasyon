using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace avukat
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string isim;
        baglantim bagla = new baglantim();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = isim;
            dataGridView3.DataSource = bagla.tablodoldurma("SELECT * FROM PERSONEL");
            dataGridView2.DataSource = bagla.tablodoldurma("SELECT * FROM MAHKEME");
            dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox18.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
           // dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
             textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
             textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = isim + "Hoşgeldiniz";
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            string cevap = bagla.prosedurDavaIslem("kayit", textBox1.Text, dateTimePicker1.Text, textBox2.Text, textBox18.Text, textBox4.Text, textBox3.Text, textBox6.Text, textBox7.Text);
            MessageBox.Show(cevap);
            dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string cevap = bagla.prosedurPersonelIslem("kayit", textBox14.Text, textBox11.Text, textBox16.Text, textBox15.Text, textBox13.Text, textBox17.Text, textBox8.Text);
            MessageBox.Show(cevap);
            dataGridView3.DataSource = bagla.tablodoldurma("SELECT * FROM PERSONEL");
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox16.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            textBox15.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            textBox13.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            textBox14.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            textBox11.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
            textBox17.Text = dataGridView3.CurrentRow.Cells[5].Value.ToString();
            textBox8.Text = dataGridView3.CurrentRow.Cells[6].Value.ToString();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA WHERE personelid LIKE '" + textBox1.Text + "%'");
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox16.Text == "Personel Id")
            {
                textBox16.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox16.Text == "")
            {
                textBox16.Text = "Personel Id";
                dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA");
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA WHERE dosyano LIKE '" + textBox2.Text + "%'");
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox16.Text == "Dosya No")
            {
                textBox16.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Dosya No";
                dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA");
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA WHERE acıklaması LIKE '" + textBox3.Text + "%'");
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Açıklama")
            {
                textBox3.Text = "";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Açıklama";
                dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA");
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA WHERE esasno LIKE '" + textBox4.Text + "%'");
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Esas No")
            {
                textBox4.Text = "";
            }
        }

    

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Esas No";
                dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA");
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA WHERE davalı LIKE '" + textBox6.Text + "%'");
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Davalı")
            {
                textBox6.Text = "";
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Davalı";
                dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA");
            }
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA WHERE davacı LIKE '" + textBox7.Text + "%'");
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "Davacı")
            {
                textBox7.Text = "";
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "Davacı";
                dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA");
            }
        }
        private void textBox18_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA WHERE davanevı LIKE '" + textBox18.Text + "%'");
        }

        private void textBox18_Enter(object sender, EventArgs e)
        {
            if (textBox18.Text == "Davanevi")
            {
                textBox18.Text = "";
            }
        }

        private void textBox18_Leave(object sender, EventArgs e)
        {
            if (textBox18.Text == "")
            {
                textBox18.Text = "Davanevi";
                dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA");
            }
        }


        private void textBox16_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA WHERE personelid LIKE '" + textBox1.Text + "%'");
        }

        private void textBox16_Enter(object sender, EventArgs e)
        {
            if (textBox16.Text == "Personel Id")
            {
                textBox16.Text = "";
            }
        }

        private void textBox16_Leave(object sender, EventArgs e)
        {
            if (textBox16.Text == "")
            {
                textBox16.Text = "Personel Id";
                dataGridView3.DataSource = bagla.tablodoldurma("SELECT * FROM PERSONEL");
            }
        }



        private void textBox13_Enter(object sender, EventArgs e)
        {
            if (textBox13.Text == "Büro No")
            {
                textBox13.Text = "";
            }
        }

        private void textBox13_Leave(object sender, EventArgs e)
        {
            if (textBox13.Text == "")
            {
                textBox13.Text = "Büro No";
                dataGridView3.DataSource = bagla.tablodoldurma("SELECT * FROM PERSONEL");
            }
        }
        private void textBox14_TextChanged(object sender, EventArgs e)
        {

            dataGridView3.DataSource = bagla.tablodoldurma("SELECT * FROM PERSONEL WHERE ad LIKE '" + textBox14.Text + "%'");
        }

        private void textBox14_Enter(object sender, EventArgs e)
        {
            if (textBox14.Text == "Ad")
            {
                textBox14.Text = "";
            }
        }

        private void textBox14_Leave(object sender, EventArgs e)
        {
            if (textBox14.Text == "")
            {
                textBox14.Text = "Ad";
                dataGridView3.DataSource = bagla.tablodoldurma("SELECT * FROM PERSONEL");
            }
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {

            dataGridView3.DataSource = bagla.tablodoldurma("SELECT * FROM PERSONEL WHERE soyad LIKE '" + textBox11.Text + "%'");
        }

        private void textBox11_Enter(object sender, EventArgs e)
        {
            if (textBox11.Text == "Soyad")
            {
                textBox11.Text = "";
            }
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                textBox11.Text = "Soyad";
                dataGridView3.DataSource = bagla.tablodoldurma("SELECT * FROM PERSONEL");
            }
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

            dataGridView3.DataSource = bagla.tablodoldurma("SELECT * FROM PERSONEL WHERE kullanıcıadı LIKE '" + textBox8.Text + "%'");
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "Kullanıcı Adı")
            {
                textBox8.Text = "";
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "Kullanıcı Adı";
                dataGridView3.DataSource = bagla.tablodoldurma("SELECT * FROM PERSONEL");
            }
        }
        private void textBox17_TextChanged(object sender, EventArgs e)
        {

            dataGridView3.DataSource = bagla.tablodoldurma("SELECT * FROM PERSONEL WHERE sıfre LIKE '" + textBox17.Text + "%'");
        }

        private void textBox17_Enter(object sender, EventArgs e)
        {
            if (textBox17.Text == "Şifre")
            {
                textBox17.Text = "";
            }
        }

        private void textBox17_Leave(object sender, EventArgs e)
        {
            if (textBox17.Text == "")
            {
                textBox17.Text = "Şifre";
                dataGridView3.DataSource = bagla.tablodoldurma("SELECT * FROM PERSONEL");
            }
        }

        private void textBox15_TextChanged_1(object sender, EventArgs e)

        {

            dataGridView3.DataSource = bagla.tablodoldurma("SELECT * FROM PERSONEL WHERE pozisyon LIKE '" + textBox15.Text + "%'");
        }

        private void textBox15_Enter_1(object sender, EventArgs e)
        {
            if (textBox15.Text == "Pozisyon")
            {
                textBox15.Text = "";
            }
        }

        private void textBox15_Leave_1(object sender, EventArgs e)
        {
            if (textBox15.Text == "")
            {
                textBox15.Text = "Pozisyon";
                dataGridView3.DataSource = bagla.tablodoldurma("SELECT * FROM PERSONEL");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string cevap = bagla.prosedurPersonelIslem("guncelle", textBox14.Text, textBox11.Text, textBox16.Text, textBox15.Text, textBox13.Text, textBox17.Text, textBox8.Text);
            MessageBox.Show(cevap);
            dataGridView3.DataSource = bagla.tablodoldurma("SELECT * FROM PERSONEL");
        }
        
        
      
        private void button1_Click_2(object sender, EventArgs e)
        {
            string cevap = bagla.prosedurPersonelIslem("sil", textBox14.Text, textBox11.Text, textBox16.Text, textBox15.Text, textBox13.Text, textBox17.Text, textBox8.Text);
            MessageBox.Show(cevap);
            dataGridView3.DataSource = bagla.tablodoldurma("SELECT * FROM PERSONEL");
        }

 
        private void button9_Click(object sender, EventArgs e)
        {
            string cevap = bagla.prosedurDavaIslem("sil", textBox1.Text, dateTimePicker1.Text, textBox2.Text, textBox18.Text, textBox4.Text, textBox3.Text, textBox6.Text, textBox7.Text);
            MessageBox.Show(cevap);
            dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA WHERE davatarıh LIKE '" + dateTimePicker1.Text + "%'");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cevap = bagla.prosedurDavaIslem("guncelle", textBox1.Text, dateTimePicker1.Text, textBox2.Text, textBox18.Text, textBox4.Text, textBox3.Text, textBox6.Text, textBox7.Text);
            MessageBox.Show(cevap);
            dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox19.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox21.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox9.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = bagla.tablodoldurma("SELECT * FROM MAHKEME WHERE mahkemead LIKE '" + textBox21.Text + "%'");
        }

        private void textBox21_Enter(object sender, EventArgs e)
        {
            if (textBox21.Text == "Mahkeme Adı")
            {
                textBox21.Text = "";
            }
        }

        private void textBox21_Leave(object sender, EventArgs e)
        {
            if (textBox21.Text == "")
            {
                textBox21.Text = "Mahkeme Adı";
                dataGridView2.DataSource = bagla.tablodoldurma("SELECT * FROM MAHKEME");
            }
        }
        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = bagla.tablodoldurma("SELECT * FROM MAHKEME WHERE esasno LIKE '" + textBox19.Text + "%'");
        }

        private void textBox19_Enter(object sender, EventArgs e)
        {
            if (textBox19.Text == "Esas No")
            {
                textBox19.Text = "";
            }
        }

        private void textBox19_Leave(object sender, EventArgs e)
        {
            if (textBox19.Text == "")
            {
                textBox19.Text = "Esas No";
                dataGridView2.DataSource = bagla.tablodoldurma("SELECT * FROM MAHKEME");
            }
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = bagla.tablodoldurma("SELECT * FROM MAHKEME WHERE mahkemetur LIKE '" + textBox9.Text + "%'");
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "Mahkeme Türü")
            {
                textBox9.Text = "";
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.Text = "Mahkeme Türü";
                dataGridView2.DataSource = bagla.tablodoldurma("SELECT * FROM MAHKEME");
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = bagla.tablodoldurma("SELECT * FROM MAHKEME WHERE mahkemeıl LIKE '" + textBox5.Text + "%'");
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Bulunduğu İl")
            {
                textBox5.Text = "";
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Bulunduğu İl";
                dataGridView2.DataSource = bagla.tablodoldurma("SELECT * FROM MAHKEME");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cevap = bagla.prosedurMahkemeIslem("sil", textBox21.Text, textBox19.Text, textBox9.Text, textBox5.Text);
            MessageBox.Show(cevap);
            dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM MAHKEME");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string cevap = bagla.prosedurMahkemeIslem("kayit", textBox21.Text, textBox19.Text, textBox9.Text, textBox5.Text);
            MessageBox.Show(cevap);
            dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM MAHKEME");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string cevap = bagla.prosedurMahkemeIslem("guncelle", textBox21.Text, textBox19.Text, textBox9.Text, textBox5.Text);
            MessageBox.Show(cevap);
            dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM MAHKEME");
        }
    }
}
