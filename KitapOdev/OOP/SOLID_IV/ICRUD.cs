using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IV
{
    public interface ICRUD<T> where T:class
    {
         void Ekle(T t);
         void Guncelle(T t);
         List<T> Listele();
         T Bul(int id);
         void Sil(int id);
    }
}
