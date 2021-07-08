using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    class Technologies
    {
        public string Name { get; set; }
        public static int IDNumber { get; set; }
        public bool Sleeping { get; set; } = false;
        public bool DeviceOn { get; set; }
        private static Random rdm = new Random();
        public int min = 1000;
        public int max = 10000;


        public Technologies(string name, int idNumber, bool deviceOn)
        {
            this.Name = name;
            IDNumber = idNumber;
            this.DeviceOn = deviceOn;
        }

        public Technologies(string name)
        {
            this.Name = name;
        }
        public Technologies(string name, bool sleeping) //sleeping status
        {
            this.Name = name;
            this.Sleeping = sleeping;
        }

        public Technologies(bool deviceOn) //device on
        {
            this.DeviceOn = deviceOn;
        }

        public Technologies(int idNumber) //id number
        {
            IDNumber = idNumber;
        }

        public Technologies(string name, int idNumber) //name with ID Number
        {
            this.Name = name;
            IDNumber = idNumber;
        }
        
        public void GetDeviceInfo()
        {
            Console.WriteLine($"{Name} has an ID number of: ({IDNumber})");
            Console.WriteLine($"Device Currently on (true/fase): {DeviceOn}");
        }
        
        public void IsDeviceSleeping()
        {
            if (!Sleeping)
            {
                DeviceOn = true;
            }
            DeviceOn = false;
        }

        public void Serials()
        {
            int newNum = rdm.Next(min, max);
            Console.WriteLine(newNum);
        }












    }

        

    



}
