using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    class Laptop : Technologies
    {
        public string PersonalOrWork { get; set; }

           
        public Laptop(string personalOrWork, string name) : base(name)
        {
            this.PersonalOrWork = personalOrWork;
        }

        public void UsedFor()
        {
            if (DeviceOn == false)
            {
                Console.WriteLine("Cannot access device: Currently sleeping");
            }
            Console.WriteLine(PersonalOrWork);
        }

        public void Serials()
        {
            int b = 100;
            Console.WriteLine($"Laptop ID: {b++}");
        }











    }
}
