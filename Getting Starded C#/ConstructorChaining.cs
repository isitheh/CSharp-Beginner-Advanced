using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Starded_C_
{
    public class ConstructorChaining
    {
        public ConstructorChaining()
            : this("Hello from default constructor")
        {
            Console.WriteLine("Default Constructor");
        }

        public ConstructorChaining(string message)
        {
            Console.WriteLine("Parametized constructor printing a message {0}", message);
        }
    }
}
