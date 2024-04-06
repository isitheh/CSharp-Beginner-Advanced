using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Starded_C_
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private string fullName;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.fullName = GetFullName();
        }

        private string GetFullName()
        {
            return firstName + " " + lastName;
        }

        public void PrintPerson()
        {
            Console.WriteLine("Full Name: " + fullName);
            Console.WriteLine("Age: " + age);
        }
    }
}
