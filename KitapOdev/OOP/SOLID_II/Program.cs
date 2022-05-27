using SOLID_II;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("SOLID");

//3-Liskov's

Personel p = new Personel();
Memur m = new Memur();
Hizmetli h = new Hizmetli();

p.MaasHesapla();
m.MaasHesapla();
h.MaasHesapla();
Console.WriteLine("--------------------");

Personel p2 = new Personel();
Personel m2 = new Memur();
Personel h2 = new Hizmetli();

p2.MaasHesapla();
m2.MaasHesapla();
h2.MaasHesapla();

