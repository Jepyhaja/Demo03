using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hissi01
{
    class Hissi
    {
        private int maxKerros = 5;
        private int minKerros = 1;
        

        private int kerros;
        public int Kerros
        {
            get
            {
                return kerros;
            }
           
            set
            {
                if (value > maxKerros)
                {
                    kerros = maxKerros;
                    Console.WriteLine("HEI ei dynamolla ole kuin 5 kerrosta!");
                }
                else if (minKerros <= value)
                {
                    kerros = value;
                    
                }
              
             }
        }
        //cons
        public Hissi()
        {
            kerros = 1;
        }

       

    }
}
