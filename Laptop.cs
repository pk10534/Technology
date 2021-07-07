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

        public string UsedFor()
        {
            if (DeviceOn == false)
            {
                return "Cannot access device: Currently sleeping";
            }
            return PersonalOrWork;
        }

        public string Serials()
        {
            int b = 100;
            return ($"Laptop ID: {b++}");
        }











    }
}
