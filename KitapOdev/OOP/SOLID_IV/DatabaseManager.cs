using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IV
{
    //DIP prensibini 3 sekilde uygulayabiliriz...
    //1-ctor
    //2-property
    //3-methods

    public class DatabaseManager:ICRUD<Urun>
    {
        public DatabaseManager()
        {

        }

        private  ICRUD<Urun> _db;
        //ctor injection
        public DatabaseManager(ICRUD<Urun> db)
        {
            _db = db;
        }

        //property injection
        public ICRUD<Urun> Inject { 
            get { return _db; } 
            set { _db = value; }
        }

        //method injection
        public void Injection(ICRUD<Urun> db)
        {
            _db = db;
        }



        public Urun Bul(int id)
        {
            throw new NotImplementedException();
        }

        public void Ekle(Urun t)
        {
           _db.Ekle(t);
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



        //DIP'e uygun degil...
        //public void Listele() {
        //    //OracleDatabase db = new OracleDatabase();
        //    SqlDatabase db = new SqlDatabase();
        //}
    }
}
