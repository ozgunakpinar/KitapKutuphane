using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET_PROJECT
{
    public class SecimYap
    {
        string secimYap;
        Kitap_Veri_Tabani kvt = new Kitap_Veri_Tabani();

        public void secim()
        {
            Console.WriteLine("1-Dosya");
            Console.WriteLine("2-KitapVeritabani");
            secimYap = Console.ReadLine();

            if(secimYap == "1")
            {

                while (true)
                {
                    Dosya dosya = new Dosya();
                    Console.WriteLine("1-Dosyadan Oku");
                    Console.WriteLine("2-Dosyaya Yaz");
                    var userInputDosya = Console.ReadLine();
                    switch (userInputDosya)
                    {
                        case "1":
                            foreach (Kitap kitap in dosya.DosyadanOku())
                                Console.WriteLine(kitap);
                        break;

                        case "2":

                            Console.Write("KitapID: ");
                            var kitapID = Console.ReadLine();

                            Console.Write("Kitap adı: ");
                            var KitapAd = Console.ReadLine();

                            Console.Write("Yazar adı: ");
                            var KitapYazar = Console.ReadLine();

                            Console.Write("fiyat gir: ");
                            var KitapFiyat = Console.ReadLine();

                            Console.WriteLine("");
                            Kitap yeniKitapData = new Kitap { KitapID = Convert.ToInt32(kitapID), Ad = Convert.ToInt32(KitapAd), Yazar = Convert.ToInt32(KitapYazar), Fiyat = Convert.ToInt32(KitapFiyat) };
                            dosya.DosyayaYaz(yeniKitapData);
                            break;
                        
                        case "x":
                            return;

                    }
                }

            }

        }

    }
}
