using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET_Connectionly
{
    //Dosyalar
    //1-Text Dosya 
    //2-Binary Dosya =>2 kısımdan olusur =>head,data

    //Veri payşımı için
    //1-CSV(Comma Seperated Values)
    //2-XML(Extensible Markup Language)
    //3-JSON(Javascript Object Notation)

    public class Dosya
    {
        public void DosyayaYaz(Personel personel) {
            
            //2.parametreyi true olarak verirsek append modunda açar...
            //Soylenmezse create modunda acar..
            StreamWriter writer = new StreamWriter("personel.data",true);

            string strPersonel = $"{personel.PersonelID};{personel.Ad}; {personel.Soyad};{personel.Adres}";

            writer.WriteLine(strPersonel);
            writer.Close();

        }

        public List<Personel> DosyadanOku()
        {
            StreamReader reader = new StreamReader("personel.data");
            List<Personel> personeller = new List<Personel>();
            
            while(!reader.EndOfStream)
            {
                string strPersonel = reader.ReadLine();
                var data = strPersonel.Split(";");

                Personel personel = new Personel();
                personel.PersonelID = Convert.ToInt32(data[0]);
                personel.Ad = data[1];
                personel.Soyad = data[2];
                personel.Adres = data[3];

                personeller.Add(personel);
            }
            
            reader.Close();

            return personeller;
        }
    }
}
