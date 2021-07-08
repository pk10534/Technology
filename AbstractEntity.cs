using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public abstract class AbstractEntity
    {
        public abstract int Numbers { get; }
        private static Random rdm = new Random();
        public int min = 1000;
        public int max = 10000;


        public void Serials()
        {
            int newNum = rdm.Next(min, max); 
            Console.WriteLine(newNum);
        }







    }
}
