using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vahvistin02
{
    class Program
    {
        static void Main(string[] args)
        {
            Vahvistin vahvari = new Vahvistin();



            int luku;

            do
            {

                Console.WriteLine("vahvistin volume: " + vahvari.Vol);
                Console.WriteLine("laita volume 0-100");
                string kerros = Console.ReadLine();
                vahvari.Vol = int.Parse(kerros);
                luku = int.Parse(kerros);



            } while (luku != 0);
        }
    }
}
