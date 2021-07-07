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



        public string SmartPhoneTest()
        {
            if (DataPlan == true)
            {
                return "This is a smartphone, not a computer!";
            }
            else 
            {
                return "This is a Computer!";
            }
        }

        public string Serials()
        {
            int b = 100;
            return ($"SmartPhone ID: {b++}");
        }

        /*
        public int Serials()
        {
            int a = 101;
            return a + 2;
        }
        */














    }
}
