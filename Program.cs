using Finances.Employees;
using System;

namespace Employees
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Person Person1 = new Person();
            Empolyee Person2 = new Empolyee();

            Person1.SetPerson("Pablo", "Wozniak", 22);
            Person1.GetPerson();

            Person2.SetEmployee("cook", 4);
            Console.WriteLine(Person2.GetEmplyee()); 

        }
    }
}
