using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Starded_C_
{
    public class NonStaticClass
    {
        public string MyInstanceProperty { get; set; } = "InstanceProp.";
        public static string MyStaticProperty { get; set; } = "StaticProp";

        public static void StaticMethod()
        {
            Console.WriteLine("I am a static method inside a non-static class.");
            Console.WriteLine("I can access static properties: " + MyStaticProperty);
            // Console.WriteLine("I can access instance properties: " + MyInstanceProperty);
        }
    }
}
