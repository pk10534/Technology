using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    class SmartPhone : Technologies
    {

        public bool DataPlan { get; set; } = true;

        public SmartPhone(bool dataPlan, int idNumber) : base(idNumber)
        {
            this.DataPlan = dataPlan;
        }
        
        public SmartPhone(bool dataPlan, string name, int idNumber, bool deviceOn) : base(name, idNumber, deviceOn)
        {
            this.DataPlan = dataPlan;
        }



        public void SmartPhoneTest()
        {
            if (DataPlan == true)
            {
                Console.WriteLine("This is a smartphone, not a computer!");
            }
            else 
            {
                Console.WriteLine("This is a Computer!");
            }
        }

        public int SerialsCalculate()
        {
            int i = 100;
            return i++;
        }

        public void Serials()
        {
            int result = SerialsCalculate();
            Console.WriteLine(result);
        }


        /*
        public void Serials()
        {
            int i;
            for (i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }
        */

        /*
        public int Serials()
        {
            int a = 101;
            return a + 2;
        }
        */














    }
}
