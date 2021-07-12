using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbgEcommerce
{
    public class Cat
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Breed { get; set; }

        public string Speak()
        {
            return "Miau I am " + Name;
        }

       public void Walk()
        {// to be changed using logger
            Console.WriteLine( Name + " is walking");
        }
    }
}
