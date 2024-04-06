using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Starded_C_
{
    public class DemoClass
    {
        //A constructor is a special method that is called when an object is created.
        //It is used to initialize the object and does not have a return type.
        //The name of the constructor is the same as the name of the class.
        //If you do not provide a constructor, the compiler will automatically create a default constructor for you.
        //You can have multiple constructors in a class with different parameters. This is called constructor overloading.
        public DemoClass()
        {
            Console.WriteLine("I am a constructor.");
        }

        //Constructor overloading
        public DemoClass(string message)
        {
            Console.WriteLine(message);
        }
    }
}
