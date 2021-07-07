using System;
using Technology;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            Technologies device1 = new Technologies("John's Phone", 54, true);

            SmartPhone phone1 = new SmartPhone(true, "Patrick's Phone", 0101, true);
            phone1.GetDeviceInfo();
            phone1.Serials();
            phone1.SmartPhoneTest();

            Laptop num1 = new Laptop("Personal", "Patrick's Laptop");
            num1.UsedFor();


            




        }
    }
}
