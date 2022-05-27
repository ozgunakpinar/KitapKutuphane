using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET_PROJECT
{
    public class Kitap
    {
        public int KitapID { get; set; }
        public int Ad { get; set; }
        public int Yazar { get; set; }
        public int Fiyat { get; set; }

        public override string ToString()
        {
            return $"{KitapID} {Ad} {Yazar} {Fiyat}";
        }

        public static implicit operator Kitap(Kitap v)
        {
            throw new NotImplementedException();
        }
    }
}
