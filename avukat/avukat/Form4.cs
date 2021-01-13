using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avukat
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public string isim;
        baglantim bagla = new baglantim();
        private void Form4_Load(object sender, EventArgs e)
        {
            label3.Text = isim;

            dataGridView2.DataSource = bagla.tablodoldurma("SELECT * FROM MAHKEME");
            dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            // dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
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
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA WHERE davanevı LIKE '" + textBox5.Text + "%'");
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Davanevi")
            {
                textBox5.Text = "";
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Davanevi";
                dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cevap = bagla.prosedurDavaIslem("sil", textBox1.Text, dateTimePicker1.Text, textBox2.Text, textBox5.Text, textBox4.Text, textBox3.Text, textBox6.Text, textBox7.Text);
            MessageBox.Show(cevap);
            dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cevap = bagla.prosedurDavaIslem("kayit", textBox1.Text, dateTimePicker1.Text, textBox2.Text, textBox5.Text, textBox4.Text, textBox3.Text, textBox6.Text, textBox7.Text);
            MessageBox.Show(cevap);
            dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cevap = bagla.prosedurDavaIslem("guncelle", textBox1.Text, dateTimePicker1.Text, textBox2.Text, textBox5.Text, textBox4.Text, textBox3.Text, textBox6.Text, textBox7.Text);
            MessageBox.Show(cevap);
            dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM DAVA");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox15.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox16.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox12.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
           // textBox9.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }
        private void textBox16_TextChanged(object sender, EventArgs e)
        {

            dataGridView2.DataSource = bagla.tablodoldurma("SELECT * FROM MAHKEME WHERE mahkemead LIKE '" + textBox16.Text + "%'");
        }

        private void textBox16_Enter(object sender, EventArgs e)
        {
            if (textBox16.Text == "Mahkeme Adı")
            {
                textBox16.Text = "";
            }
        }

        private void textBox16_Leave(object sender, EventArgs e)
        {
            if (textBox16.Text == "")
            {
                textBox16.Text = "Mahkeme Adı";
                dataGridView2.DataSource = bagla.tablodoldurma("SELECT * FROM MAHKEME");
            }
        }
        private void textBox15_TextChanged(object sender, EventArgs e)
        {

            dataGridView2.DataSource = bagla.tablodoldurma("SELECT * FROM MAHKEME WHERE esasno LIKE '" + textBox15.Text + "%'");
        }

        private void textBox15_Enter(object sender, EventArgs e)
        {
            if (textBox15.Text == "Esas No")
            {
                textBox15.Text = "";
            }
        }

        private void textBox15_Leave(object sender, EventArgs e)
        {
            if (textBox15.Text == "")
            {
                textBox15.Text = "Esas No";
                dataGridView2.DataSource = bagla.tablodoldurma("SELECT * FROM MAHKEME");
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = bagla.tablodoldurma("SELECT * FROM MAHKEME WHERE mahkemead LIKE '" + textBox12.Text + "%'");
        }

        private void textBox12_Enter(object sender, EventArgs e)
        {
            if (textBox12.Text == "Mahkeme Türü")
            {
                textBox12.Text = "";
            }
        }

        private void textBox12_Leave(object sender, EventArgs e)
        {
            if (textBox12.Text == "")
            {
                textBox12.Text = "Mahkeme Türü";
                dataGridView2.DataSource = bagla.tablodoldurma("SELECT * FROM MAHKEME");
            }
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = bagla.tablodoldurma("SELECT * FROM MAHKEME WHERE mahkemeıl LIKE '" + textBox9.Text + "%'");
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "Bulunduğu il")
            {
                textBox9.Text = "";
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.Text = "Bulunduğu İl";
                dataGridView2.DataSource = bagla.tablodoldurma("SELECT * FROM MAHKEME");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cevap = bagla.prosedurMahkemeIslem("guncelle", textBox16.Text, textBox15.Text, textBox12.Text, textBox9.Text);
            MessageBox.Show(cevap);
            dataGridView1.DataSource = bagla.tablodoldurma("SELECT * FROM MAHKEME");
        }
    }
   
}




