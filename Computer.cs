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
        private static Random rdm = new Random();
        public int min = 1000;
        public int max = 10000;

        public Computer(int roomNumber, int idNumber) : base(idNumber)
        {
            this.RoomNumber = roomNumber;
        }


        public void ComputerLocation()
        {
            Console.WriteLine($"Room number: {RoomNumber}");
        }


        public void Serials()
        {
            int newNum = rdm.Next();
            Console.WriteLine(newNum);
        }























    }
}
