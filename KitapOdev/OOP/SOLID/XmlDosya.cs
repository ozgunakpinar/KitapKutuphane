using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class XmlDosya : Dosya
    {
        public override void Oku()
        {
            Console.WriteLine("XML Dosyadan Oku");
        }
    }
}
