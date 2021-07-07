using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    class Computer : Technologies
    {

        public int RoomNumber { get; set; }

        public Computer(int roomNumber, int idNumber) : base(idNumber)
        {
            this.RoomNumber = roomNumber;
        }


        public int ComputerLocation()
        {
            return RoomNumber;
        }

        public void Serials()
        {
            int b = 100;
            Console.WriteLine($"Computer ID: {b++}");
        }

        /*
        public int Serials()
        {
            int i = 100;
            return i + 2;
        }
        */























    }
}
