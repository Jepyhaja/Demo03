﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVapp03
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tele = new TV();
            tele.IsOn = true;
            tele.TopGearHype = 9001;
            tele.TooMuchAds = true;
            tele.NetflixAndChill();
            tele.Dataout();


        }
    }
}
