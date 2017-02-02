using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hissi01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Hissi hissi = new Hissi();
            int luku;

            do
            {
                Console.WriteLine("Olet " + hissi.Kerros + " kerroksessa.");

                Console.WriteLine("Paina kerroksen 1-5 nappia");
                string kerros = Console.ReadLine();
                hissi.Kerros = int.Parse(kerros);
                luku = int.Parse(kerros);

                
                
            } while(luku != 0);

                


        }
    }
}
