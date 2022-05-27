using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class JpegDosya : Dosya
    {
        public override void Oku()
        {
            Console.WriteLine("JPG Dosyadan Oku");
        }
    }
}
