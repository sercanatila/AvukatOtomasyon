using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;



namespace avukat
{
    class baglantim

    {
        OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XE; User Id=SYSTEM;password=1506;");
        OracleCommand komut = new OracleCommand();
        OracleDataAdapter adaptor = new OracleDataAdapter();
        OracleDataReader oku;
        public void baglantikapat()
        {
            baglanti.Close();
        }
        public DataTable tablodoldurma(string komut)
        {

            DataTable tablo = new DataTable();
            this.baglanti.Open();
            this.komut.CommandType = CommandType.Text;
            this.komut.CommandText = komut;
            this.komut.Connection = baglanti;
            adaptor.SelectCommand = this.komut;
            adaptor.Fill(tablo);
            this.baglanti.Close();
            return tablo;
        }
        public OracleDataReader okuyucu(string komut)
        {
            this.baglanti.Open();
            this.komut.Connection = baglanti;
            this.komut.CommandType = CommandType.Text;
            this.komut.CommandText = komut;
            this.oku = this.komut.ExecuteReader();
            
            return this.oku;

        }
        public void komutCalıstır(string komut)
        {
            this.baglanti.Open();
            this.komut.CommandType = CommandType.Text;
            this.komut.Connection = baglanti;
            this.komut.CommandText = komut;
            this.komut.ExecuteNonQuery();
            this.baglanti.Close();
        }

        public void baglantikapa()
        {
            this.baglanti.Close();
        }


         public string idd,isim;
        public string prosedurAVUKATGIRIS(string kullaniciadi, string pass,String pozisyon)
        {
            string cevap;

            this.komut.CommandText = "AVUKATGIRIS";
            this.komut.Connection = baglanti;
            this.komut.CommandType = CommandType.StoredProcedure;

            this.komut.Parameters.Clear();

            this.komut.Parameters.Add("NICKNAME", OracleDbType.Varchar2, 2000).Value = kullaniciadi;
            this.komut.Parameters["NICKNAME"].Direction = ParameterDirection.Input;

            this.komut.Parameters.Add("PASS", OracleDbType.Varchar2, 2000).Value = pass;
            this.komut.Parameters["PASS"].Direction = ParameterDirection.Input;

            this.komut.Parameters.Add("POZISYON", OracleDbType.Varchar2, 2000).Value = pozisyon;
            this.komut.Parameters["POZISYON"].Direction = ParameterDirection.Input;

            this.komut.Parameters.Add("id", OracleDbType.Decimal, 20).Direction = ParameterDirection.Output;
            this.komut.Parameters.Add("isim", OracleDbType.Varchar2, 20).Direction = ParameterDirection.Output;
            this.komut.Parameters.Add("cevap", OracleDbType.Varchar2, 20).Direction = ParameterDirection.Output;

            baglanti.Open();
            this.komut.ExecuteNonQuery();
            idd = this.komut.Parameters["id"].Value.ToString();
            isim = this.komut.Parameters["isim"].Value.ToString();
            cevap = this.komut.Parameters["cevap"].Value.ToString();
            baglanti.Close();
            return cevap;
        }

        public string prosedurPersonelIslem(string islem, string ad, string soyad, string id, string poz, string bno, string sifre, string kulid)
        {
            string cevap;

            this.komut.CommandText = "PERSONELISLEM";
            this.komut.Connection = baglanti;
            this.komut.CommandType = CommandType.StoredProcedure;
            this.komut.Parameters.Clear();

            this.komut.Parameters.Add("islem", OracleDbType.Varchar2, 2000).Value = islem;
            this.komut.Parameters["islem"].Direction = ParameterDirection.Input;          
            this.komut.Parameters.Add("namee", OracleDbType.Varchar2, 2000).Value = ad;
            this.komut.Parameters["namee"].Direction = ParameterDirection.Input;
            this.komut.Parameters.Add("surname", OracleDbType.Varchar2, 2000).Value = soyad;
            this.komut.Parameters["surname"].Direction = ParameterDirection.Input;
            this.komut.Parameters.Add("id", OracleDbType.Varchar2, 2000).Value = id;
            this.komut.Parameters["id"].Direction = ParameterDirection.Input;
            this.komut.Parameters.Add("pz", OracleDbType.Varchar2, 2000).Value = poz;
            this.komut.Parameters["pz"].Direction = ParameterDirection.Input;
            this.komut.Parameters.Add("bn", OracleDbType.Decimal, 2000).Value = bno;
            this.komut.Parameters["bn"].Direction = ParameterDirection.Input;
            this.komut.Parameters.Add("pass", OracleDbType.Varchar2, 2000).Value = sifre;
            this.komut.Parameters["pass"].Direction = ParameterDirection.Input;
            this.komut.Parameters.Add("nick", OracleDbType.Varchar2, 2000).Value = kulid;
            this.komut.Parameters["nick"].Direction = ParameterDirection.Input;

            this.komut.Parameters.Add("cevap", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;

            baglanti.Open();
            this.komut.ExecuteNonQuery();
            cevap = this.komut.Parameters["cevap"].Value.ToString();
            baglanti.Close();
            return cevap;
        }
        public string prosedurDavaIslem(string islem, string id, string tarih, string dno, string dnevi, string eno, string ac, string dali, string daci)
        {
            string cevap;
            this.komut.CommandText = "DAVAISLEM";
            this.komut.Connection = baglanti;
            this.komut.CommandType = CommandType.StoredProcedure;
            this.komut.Parameters.Clear();

            this.komut.Parameters.Add("islem", OracleDbType.Varchar2, 2000).Value = islem;
            this.komut.Parameters["islem"].Direction = ParameterDirection.Input;
            this.komut.Parameters.Add("id", OracleDbType.Varchar2, 2000).Value = id;
            this.komut.Parameters["id"].Direction = ParameterDirection.Input;
            this.komut.Parameters.Add("tarih", OracleDbType.Varchar2, 2000).Value = tarih;
            this.komut.Parameters["tarih"].Direction = ParameterDirection.Input;
            this.komut.Parameters.Add("dno", OracleDbType.Decimal, 2000).Value = dno;
            this.komut.Parameters["dno"].Direction = ParameterDirection.Input;
            this.komut.Parameters.Add("dnevi", OracleDbType.Varchar2, 2000).Value = dnevi;
            this.komut.Parameters["dnevi"].Direction = ParameterDirection.Input;
            this.komut.Parameters.Add("eno", OracleDbType.Varchar2, 2000).Value = eno;
            this.komut.Parameters["eno"].Direction = ParameterDirection.Input;
            this.komut.Parameters.Add("ac", OracleDbType.Varchar2, 2000).Value = ac;
            this.komut.Parameters["ac"].Direction = ParameterDirection.Input;
            this.komut.Parameters.Add("dali", OracleDbType.Varchar2, 2000).Value = dali;
            this.komut.Parameters["dali"].Direction = ParameterDirection.Input;
            this.komut.Parameters.Add("daci", OracleDbType.Varchar2, 2000).Value = daci;
            this.komut.Parameters["daci"].Direction = ParameterDirection.Input;

            this.komut.Parameters.Add("cevap", OracleDbType.Varchar2, 200).Direction = ParameterDirection.Output;
            baglanti.Open();
            this.komut.ExecuteNonQuery();
            cevap = this.komut.Parameters["cevap"].Value.ToString();
            baglanti.Close();
            return cevap;
        }
    
        public string prosedurMahkemeIslem(string islem, string mad, string eno, string mtur, string bil)
        {
            string cevap;
            this.komut.CommandText = "MAHKEMEISLEM";
            this.komut.Connection = baglanti;
            this.komut.CommandType = CommandType.StoredProcedure;
            this.komut.Parameters.Clear();

            this.komut.Parameters.Add("islem", OracleDbType.Varchar2, 2000).Value = islem;
            this.komut.Parameters["islem"].Direction = ParameterDirection.Input;
            this.komut.Parameters.Add("namee", OracleDbType.Varchar2, 2000).Value = mad;
            this.komut.Parameters["namee"].Direction = ParameterDirection.Input;
            this.komut.Parameters.Add("noo", OracleDbType.Varchar2, 2000).Value = eno;
            this.komut.Parameters["noo"].Direction = ParameterDirection.Input;
            this.komut.Parameters.Add("tur", OracleDbType.Varchar2, 2000).Value = mtur;
            this.komut.Parameters["tur"].Direction = ParameterDirection.Input;
            this.komut.Parameters.Add("il", OracleDbType.Varchar2, 2000).Value = bil;
            this.komut.Parameters["il"].Direction = ParameterDirection.Input;
            

            this.komut.Parameters.Add("cevap", OracleDbType.Varchar2, 200).Direction = ParameterDirection.Output;
            baglanti.Open();
            this.komut.ExecuteNonQuery();
            cevap = this.komut.Parameters["cevap"].Value.ToString();
            baglanti.Close();
            return cevap;
        }

    }
}
