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
        public static Random rdm = new Random();

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

        public void Serials()
        {
            int newNum = rdm.Next();
            Console.WriteLine(newNum);
        }














    }
}
