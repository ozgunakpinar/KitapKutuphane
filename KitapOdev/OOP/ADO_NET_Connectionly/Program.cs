using ADO_NET_Connectionly;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("ADO_NET Baglantili Yontem");

//ADO
//ADO.NET
//1-Baglantili Yontem(Connectionly)
//2-Baglantisiz Yontem(Connectionless)

//Katmanlı Mimari
//1-DAL(Data Access Layer)
//2-B(L)L Layer (Business [Logic] Layer)
//3-PL (Presantation Layer)

Personel yeniPersonel = new Personel { Ad="Dursun", Soyad="Durmasin", Adres="Kartal" };

Veritabani vt = new Veritabani();
//vt.Ekle(yeniPersonel);

foreach(Personel personel in vt.Listele())
    Console.WriteLine(personel);

Personel pers = vt.Ara(345);
if(pers.PersonelID>0)
    Console.WriteLine(pers);
else
    Console.WriteLine("Aradığınız kayıt bulunamadi...");


Console.WriteLine("Toplam Kayit Sayisi={0}",vt.ToplamKayitSayisi());


//Dosyalar
Dosya dosya = new Dosya();
//dosya.DosyayaYaz(yeniPersonel);
foreach (Personel personel in dosya.DosyadanOku())
    Console.WriteLine(personel);

