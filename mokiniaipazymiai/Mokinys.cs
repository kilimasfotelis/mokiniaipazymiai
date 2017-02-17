using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mokiniaipazymiai
{
  class Mokinys
  {
    public string Vardas;
    public string Pavarde;
    public List<Pazimys> pazymiai;
    public Mokinys()
    {
      pazymiai = new List<Pazimys>();
    }
    // : this() kreipiasi i tos pacios klases konstruktoriu, kurio argumentai () - tiesiog tusti, bazini konstruktoriu be parametru
    public Mokinys (string vardas, string pavarde) : this()
    {
      Vardas = vardas;
      Pavarde = pavarde;
    }
    public void MokiniuIvedimas()
    {
      Console.WriteLine("Mokinio vardas?");
      Vardas = Console.ReadLine();
      Console.WriteLine("Mokinio pavarde?");
      Pavarde = Console.ReadLine();
      Console.WriteLine();
    }
    //public void PazymiuPridejimas()
    //{
    // for (int i = 0; i < 4; i++)
    //  {
    //    Pazimys paz = new Pazimys();
    //    paz.Ivedimas();
    //    pazymiai.Add(paz);
    //  }
    //}
    public void MokiniuIsvedimas()
    {
      
    }

  }
}
