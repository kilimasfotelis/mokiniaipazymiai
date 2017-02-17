using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mokiniaipazymiai
{
    class Pazimys
    {
        int Geografija;
        int Matematika;
        int Lietuviu;
        int Fizika;
        double Vidurkis;

        public Pazimys()
        {
        }

        // Ivedimo metodas
        public void Ivedimas()
        {
            Console.WriteLine("Iveskite mokinio pazymius");
            Console.WriteLine("Geografija: ");
            Geografija = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Matematika: ");
            Matematika = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lietuviu: ");
            Lietuviu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fizika: ");
            Fizika = Convert.ToInt32(Console.ReadLine());
        }

        // Isvedimo metodas
        public void Info()
        {
            Console.WriteLine("Mokinio pazymiai:");
            Console.WriteLine("Matematika: {0}", Matematika);
            Console.WriteLine("Lietuviu: {0}", Lietuviu);
            Console.WriteLine("Geografija: {0}", Geografija);
            Console.WriteLine("Matematika: {0}", Matematika);
        }

        // Vidurkio metodas
        public void VidurSkaiciav()
        {
            Vidurkis = (double)(Matematika + Fizika + Geografija + Lietuviu) / 4;
        }


    }
}
