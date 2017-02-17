using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mokiniaipazymiai
{
  class Program
  {
    static void Main(string[] args)
    {

      Program p = new Program();
      Console.WriteLine("Kiek mokiniu?");
      int mokinukai = Convert.ToInt32(Console.ReadLine());
      List<Mokinys> mokiniai = new List<Mokinys>();
      for (int i = 0; i < mokinukai; i++)
      {
        Mokinys m = new Mokinys();
        m.MokiniuIvedimas();
        m.PazymiuPridejimas();
        mokiniai.Add(m);
      }

      int o = 1;
      foreach (var item in mokiniai)
      {
        Console.WriteLine("Mokinys nr.{0}", o);
        item.MokiniuIsvedimas();
        o++;
      }
      Pazimys z = new Pazimys();
      Console.WriteLine("kurio mokinio vidurki nori pamatyt?");
     int mokinionumeris = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(mokiniai[mokinionumeris - 1].Vardas);
      Console.WriteLine(mokiniai[mokinionumeris - 1].Pavarde);
      mokiniai[mokinionumeris - 1].pazymiai.VidurSkaiciav();
    Console.ReadLine();
    } 
  }
}
