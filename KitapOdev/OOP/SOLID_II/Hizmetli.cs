using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_II
{
    public class Hizmetli:Personel
    {
        public override void MaasHesapla()
        {
            Console.WriteLine("Hizmetli Maas Hesaplamasi...");
        }
    }
}
