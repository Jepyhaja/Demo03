using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVapp03
{
    class TV
    {
        //properties

        public bool IsOn { get; set; }
        public bool EmmerdaleIsOn { get; set; }
        public bool TooMuchAds { get; set; }
        public int ChannelCount { get; set; }
        public double TopGearHype { get; set; }
        public int OnTime { get; set; }
        public string CurrentChannel { get; set; }

        //consturctor
        public TV()
        {

        }

        public TV(string channel)
        {
            CurrentChannel = channel;
        }
        public TV(double hype)
        {
            TopGearHype = hype;
        }

        //methods

        public void TurnOff()
        {
            Console.WriteLine("one does not simply skip TopGear.");
            TopGearHype *= 2;
        }
        public void Record()
        {
            Console.WriteLine("Ypur tv is now recording Emmerdale what were you thinking?!");
            CurrentChannel = "The one you never watch!";
            TopGearHype /= 1.5;
        }
        public void NetflixAndChill()
        {
            Console.WriteLine("Netflix initiated prepare to be 'chilled'");
            CurrentChannel = "bruh! You're waching Netfilx";
            TooMuchAds = false;
        }
        public void Dataout()
        {
            Console.WriteLine("Television is on: " + IsOn);
            Console.WriteLine("Emmerdale is on air: " + EmmerdaleIsOn);
            Console.WriteLine("Can't enjoy the show beacuse of ads " + TooMuchAds);
            Console.WriteLine("Your TV has " + ChannelCount + " channels.");
            Console.WriteLine("You are this hyped about TopGear: " + TopGearHype);
            Console.WriteLine("TV has been on for " + OnTime + " minutes.");
            Console.WriteLine("Current channel you are watching: " + CurrentChannel);
            
        }
        
    }
}
