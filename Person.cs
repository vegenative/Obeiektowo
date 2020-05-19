using System;
using System.Collections.Generic;
using System.Text;
//temat 1 zadanie 6
namespace Finances
{
    namespace Employees
    {
        class Person
        {
            private string name;
            private string surname;
            private int age;

            public void GetPerson()
            {
                Console.WriteLine("name = {0} \nsurname = {1}\nage = {2}", name, surname, age);
            }
            public void SetPerson(string name, string surname, int age)
            {
                this.name = name;
                this.surname = surname;
                this.age = age;
            }


        }
    }
}
