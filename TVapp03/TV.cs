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
        public bool ChannelCount { get; set; }
        public int TopGearHype { get; set; }
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
        public TV(int hype)
        {
            TopGearHype = hype;
        }

        //methods

        public void TurnOff()
        {
            Console.WriteLine("one does not simply skip TopGear.");
        }
        public void Record()
        {
            Console.WriteLine("Ypur tv is now recording Emmerdale what were you thinking?!");
        }
        public void NetflixAndChill()
        {
            Console.WriteLine("Netflix initiated prepare to be 'chilled'");
        }
        public void Dataout()
        {
            Console.WriteLine("Television is on: " + IsOn);
            Console.WriteLine("Emmerdale is on air: " + EmmerdaleIsOn);
            Console.WriteLine("Can't enjoy the show beacuse of ads " + TooMuchAds);
            Console.WriteLine("Your TV has " + ChannelCount + " channels.");
            Console.WriteLine("You are this hyped about TopGear " + TopGearHype);
            Console.WriteLine("TV has been on for " + OnTime);
            Console.WriteLine("Current channel you are watching: " + CurrentChannel);
            
        }
        
    }
}
