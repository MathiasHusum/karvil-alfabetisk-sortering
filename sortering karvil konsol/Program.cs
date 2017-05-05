using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortering_karvil_konsol
{
    class Program : karvilKunder
    {
        static void Main(string[] args)
        {
            string[] a = new string[] //lægger alle inputs ind i et array.
            {
              //kunderNavn //en mock klasse som bliver byttet ud med den fra vores tables.
             };
            
             var sortstring = from s in a //sorterer arrayet i omvændt rekkefølge.
                        orderby s descending
                        select s;

            foreach (string c in sortstring) //viser arrayet i konsol vinduet.
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
        
    }
}
