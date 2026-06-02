using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.OOP.Encapsulation
{
    internal class Person
    {
        private string name;
        private int age;
        private DateTime CreatedAt;

        public Person()
        {
            CreatedAt = DateTime.Now;
        }

        public DateTime GetCreationDate()
        {
            return this.CreatedAt;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return this.name;
        }

        public void setAge(int age)
        {
            if(age > 0)
            {
                this.age = age;
            }
            else
            {
                Console.WriteLine("Age is invalid");
            }
           
        }

        public int getAge()
        {
            return this.age;
        }

        public void getInfo()
        {
            Console.WriteLine($"Name : {name}, Age : {age}");
        }
    }
}
