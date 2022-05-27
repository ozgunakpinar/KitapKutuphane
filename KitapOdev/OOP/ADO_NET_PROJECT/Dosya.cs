using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET_PROJECT
{
    public class Dosya
    {
        public void DosyayaYaz(Kitap kitap)
        {   //Append modunu açmak için 2. parametreyi true olarak veriyoruz.
            //Vermezsek creat olarak açılır.
            StreamWriter writer = new StreamWriter("kitap.data",true);

            string strKitap = $"{kitap.KitapID};{kitap.Ad};{kitap.Yazar};{kitap.Fiyat}";

            writer.WriteLine(strKitap);
            writer.Close();
        }

        public List<Kitap> DosyadanOku()
        {
            StreamReader reader = new StreamReader("kitap.data",true);
            List<Kitap> kitap = new List<Kitap>();

            while (!reader.EndOfStream)
            {
                string strKitap = reader.ReadLine();
                var data = strKitap.Split(";");

                Kitap kitap = new Kitap();
                kitap.KitapID = Convert.ToInt32(data[0]);
                kitap.Ad = data[1];
                kitap.Yazar = data[2];
                kitap.Fiyat = Convert.ToInt32(data[3]);

                Kitap.Add(kitap);
            }

            reader.Close();

            return kitap;
        }
    }
}
