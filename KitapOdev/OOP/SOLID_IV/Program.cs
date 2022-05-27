using SOLID_IV;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("SOLID");

//5-DIP

OracleDatabase odb = new OracleDatabase();
SqlDatabase sdb = new SqlDatabase();

DatabaseManager dbm = new DatabaseManager(sdb);
dbm.Ekle(new Urun());


DatabaseManager dbm2 = new DatabaseManager();
dbm2.Inject = sdb;
dbm2.Ekle(new Urun());

DatabaseManager dbm3 = new DatabaseManager();
dbm3.Injection(odb);
dbm3.Ekle(new Urun());
