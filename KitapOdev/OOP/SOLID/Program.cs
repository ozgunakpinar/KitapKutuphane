using SOLID;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("SOLID Prensipleri");

//1-SRP(Single Responsibility Princibles)
//2-OCP(Open Closed Princibles)
//3-LSP(Liskov's Subsutition Princibles
//4-ISP(Interface Segragation Princibles)
//5-DIP(Dependency Inversion Princibles)

//1-Tek Sorumluluk İlkesi
//Metod bu sekilde olmamalı...
void DosyadanOku(string strDosyaAdi, string tur)
{
    if (tur == ".txt")
    {
        //.....
    }
    else if (tur == ".jpg")
    {
        //....
    }
 }

//2)Open-Closed
//1-Miras
//2-Arayuz

void DosyaOku(Dosya dosya)
{
    dosya.Oku();
}

JpegDosya jpg = new JpegDosya();
TextDosya txt = new TextDosya();
XmlDosya xml = new XmlDosya();
DosyaOku(jpg);
DosyaOku(txt);
DosyaOku(xml);