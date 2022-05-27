using ADO_NET_PROJECT;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("ADO_NET_Baglantili_Project");

// Kitap yeniKitap = new Kitap { Ad = "SavasveBaris", Yazar = "Dostoyevski", Fiyat = "Kartal" };

/*
Kitap_Veri_Tabani vt = new Kitap_Veri_Tabani();
vt.Ekle(yeniKitap);
foreach (Kitap kitap in vt.Listele())
    Console.WriteLine(kitap);

Kitap  ktp= vt.Ara(123);
if (ktp.KitapID > 0)
    Console.WriteLine(ktp);
else
    Console.WriteLine("Kayıt bulunamadı."); */

//Dosyalar

//Dosyaya yazma
Dosya dosya = new Dosya();
dosya.DosyayaYaz(yeniKitap);

//Dosyadan okuma
foreach (Kitap kitap in dosya.DosyadanOku())
    Console.WriteLine(kitap);

SecimYap SecimYap = new SecimYap();
SecimYap.secim();

