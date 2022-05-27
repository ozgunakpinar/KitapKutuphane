using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET_PROJECT
{
    public class Kitap_Veri_Tabani
    {
        string strConn = "Data source=.; inital catalog=KitapDB;integrated security=true";
    

    public List<Kitap> Listele()
    {

        SqlConnection conn = new SqlConnection(strConn);

        //Veri tabanı bağlantı açılışı.
        conn.Open();

        SqlCommand cmd = new SqlCommand("SELECT * FROM Kitaplar",conn);

        SqlDataReader dr = new cmd.ExecuteReader();
        //ExecuteReader()=Select
        //ExecutenonQuery()=Insert,Update,Delete
        //ExecuteScalar() = Select geriye sadece tek bir değer döner.

        List<Kitap> kitaplar = new List<Kitap>();


        while (dr.Read())
        {
            Kitap kitap = new Kitap();
            kitap.KitapID = Convert.ToInt32(dr[0]);
            kitap.Ad = dr["Ad"].toString();
            kitap.Yazar = dr.GetString(2);
            kitap.Fiyat = dr[3].ToInt32();

            kitaplar.Add(kitap);

        }

         //Veri tabanı bağlantı kapanışı.
         conn.Close();

        return kitaplar;

    }

    public void Ekle(Kitap kitap)
    {

        SqlConnection conn = new SqlConnection(strConn);

        conn.Open();
        SqlCommmand cmd = new SqlCommmand("INSERT INTO Kitaplar VALUES(@Ad,@Yazar,@Fiyat)", conn);

        cmd.Paramaters.AddWithValue("@Ad", kitap.Ad);
        cmd.Paramaters.AddWithValue("@Yazar", kitap.Yazar);
        cmd.Paramaters.AddWithValue("@Fiyat", kitap.Fiyat);
        cmd.ExecuteNonQuery();
        conn.Close();



    }

    public Kitap Ara(int KitapID)
    {
        SqlConnection conn = new SqlConnection(strConn);

        //Veri tabanı bağlantı açılışı.
        conn.Open();

        SqlCommmand cmd = new SqlCommmand("SELECT * FROM Kitaplar WHERE KitapID = @ID)", conn);

        cmd.Kitaplar.AddWithValue("@ID", KitapID);

        //Kaydınm olup olmadığını kontrol ediyoruz.
        SqlDataReader dr = new cmd.ExecuteReader();
            
        //KitapID - geliyorsa kayıt bulunmadı yorumunu yapabiliriz.
        Kitap kitap = new Kitap(){KitapID = -1};

        dr.Read();
            if (dr.HasRows)
            {
                kitap.KitapID = Convert.ToInt32(dr[0]);
                kitap.Ad = dr["Ad"].toString();
                kitap.Yazar = dr.GetString(2);
                kitap.Fiyat = dr[3].ToInt32();

            }

            conn.Close();

            return kitap;
    }

   }

}
