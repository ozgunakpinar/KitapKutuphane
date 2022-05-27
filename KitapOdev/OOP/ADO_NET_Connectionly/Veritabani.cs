using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET_Connectionly
{
    public class Veritabani
    {
        string strConn = "Data source=.;initial catalog=PersonelDB;integrated security=true";

        public List<Personel> Listele() {

            SqlConnection conn = new SqlConnection(strConn);

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Personeller",conn);

            SqlDataReader dr = cmd.ExecuteReader();
            //ExecuteReader() =>SELECT
            //ExecuteNonQuery() =>INSERT,UPDATE,DELETE
            //EcecuteScalar() =>SELECT Geriye sadece 1 tek bir deger(tek satir tek sutun)
            List<Personel> personeller = new List<Personel>();
            while (dr.Read()) 
            {
                // dr["column_name"]
                // dr[0] =>indis
                // dr.GetString(indis)

                Personel personel = new Personel();
                personel.PersonelID = Convert.ToInt32(dr[0]);
                personel.Ad = dr["Ad"].ToString();
                personel.Soyad = dr.GetString(2);
                personel.Adres = dr[3].ToString();

                personeller.Add(personel);

            }

            conn.Close();

            return personeller;

        }

        public void Ekle(Personel personel)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            //INSERT Cumlesine aktarılacak olan veriler metinlerin birleştirilmesi yontemiyle gonderilmemeli....
            //!!! SQL Injection 
            //Parametre Kullanılmalı...
            SqlCommand cmd = new SqlCommand("INSERT INTO Personeller VALUES(@ad,@soyad,@adres)", conn);

            cmd.Parameters.AddWithValue("@ad", personel.Ad);
            cmd.Parameters.AddWithValue("@soyad", personel.Soyad);
            cmd.Parameters.AddWithValue("@adres", personel.Adres);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Personel Ara(int personelID)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Personeller WHERE PersonelID=@ID", conn);

            cmd.Parameters.AddWithValue("@ID", personelID);

            SqlDataReader dr = cmd.ExecuteReader();
            Personel personel = new Personel() { PersonelID=-1};

            dr.Read();
            if (dr.HasRows)
            {
                personel.PersonelID = Convert.ToInt32(dr[0]);
                personel.Ad = dr["Ad"].ToString();
                personel.Soyad = dr.GetString(2);
                personel.Adres = dr[3].ToString();
            }
            conn.Close();
            return personel;
        }

        public int ToplamKayitSayisi()
        {
            int sonuc = 0;
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT Count(*) FROM Personeller ", conn);

            //SqlDataReader dr = cmd.ExecuteReader();
            //dr.Read();
            //sonuc = Convert.ToInt32(dr[0]);

            //.Parse() =>metodlarında parametre string olmalı...
            //sonuc =int.Parse(cmd.ExecuteScalar().ToString());
            //Convert.Int32() de object olsada donusturur...
            sonuc = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return sonuc;
        }
    }
}
