using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IV
{
    public class SqlDatabase : ICRUD<Urun>
    {
        public Urun Bul(int id)
        {
            throw new NotImplementedException();
        }

        public void Ekle(Urun t)
        {
            Console.WriteLine("Sql veritabanına urun eklendi...");
        }

        public void Guncelle(Urun t)
        {
            throw new NotImplementedException();
        }

        public List<Urun> Listele()
        {
            throw new NotImplementedException();
        }

        public void Sil(int id)
        {
            throw new NotImplementedException();
        }
    }
}
