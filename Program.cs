using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace Requêtes_Faciles___.NET__
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Entiers = new List<int> { 1, 2, 3, 4, 5, 6, 2, 8, 9, 45, 12, 3, 47 };

            // Query Method 

            var query = from x in Entiers where x > 5 select x;

            foreach (var x in query)
                  // if (x > 5)
                    Console.WriteLine(x);
        }
    }
}
