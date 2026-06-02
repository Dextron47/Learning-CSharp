using Giraffe2.Arrays;
using Giraffe2.ExceptionHandling;
using Giraffe2.IfStatement;
using Giraffe2.Loops;
using Giraffe2.Methods;
using Giraffe2.OOP;
using Giraffe2.OOP.Classes___Objects;
using Giraffe2.OOP.Constructor;
using Giraffe2.OOP.Encapsulation;
using Giraffe2.OOP.GetterSetter;
using Giraffe2.OOP.inheritance;
using Giraffe2.OOP.ObjectMethod;
using Giraffe2.OOP.static_class_attribute;
using Giraffe2.OOP.staticMethod___Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Giraffe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string characterName = "Tom";
            //int characterAge;
            //characterAge = 35;


            //Console.WriteLine("There was once an old man named " + characterName);
            //Console.WriteLine("He was of " + characterAge + " years old and lived in a small village.");

            //characterName = "Mike";
            //Console.WriteLine("He really liked his name " + characterName);
            //Console.WriteLine("But did not like his age " + characterAge);

            //string phrase = "Hello, World!" + " is cool";
            //char c = 'A';
            //int age = 30;

            //double pi = 3.14159;
            //bool isRaining = false;

            //Console.WriteLine("Giraffe \nAcademy");
            //Console.WriteLine("Giraffe\"Academy");
            //Console.WriteLine(phrase.Length);
            //Console.WriteLine(phrase.ToUpper());
            //Console.WriteLine(phrase.ToLower());

            //Console.WriteLine(phrase.Contains("World"));
            //Console.WriteLine(phrase[0]);
            //Console.WriteLine(phrase.IndexOf('z'));

            //Console.WriteLine(phrase.Substring(7));

            //Console.WriteLine(phrase);

            //Console.WriteLine(30);
            //Console.WriteLine(5 + 8);
            //Console.WriteLine(8-5);
            //Console.WriteLine(5 * 8);
            //Console.WriteLine(10 / 2);
            //Console.WriteLine(5 % 2);

            //int num = 6;
            //Console.WriteLine(num);

            //Console.WriteLine(num++);
            //Console.WriteLine(num--);

            //Console.WriteLine(Math.Abs(-5));
            //Console.WriteLine(Math.Pow(3, 2));
            //Console.WriteLine(Math.Min(2, 4));
            //Console.WriteLine(Math.Max(2, 4));
            //Console.WriteLine(Math.Tan(2));
            //Console.WriteLine(Math.Ceiling(2.2));
            //Console.WriteLine(Math.Sqrt(3));

            //Console.WriteLine(Math.Round(2.6));
            //Console.WriteLine(Math.Truncate(2.6));


            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Hello " + name + ", you are " + age + " years old.");

            //Console.Write("Enter 1st number: ");
            //double num1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter 2nd number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Select an operation: +, -, *, /");
            //string operation = Console.ReadLine();

            //if(operation == "+")
            //{
            //    Console.WriteLine("Result: " + (num1 + num2));
            //}
            //else if (operation == "-")
            //{
            //    Console.WriteLine("Result: " + (num1 - num2));
            //}
            //else if (operation == "*")
            //{
            //    Console.WriteLine("Result: " + (num1 * num2));
            //}
            //else if (operation == "/")
            //{
            //    Console.WriteLine("Result: " + (num1 / num2));
            //}
            //else
            //{
            //    Console.WriteLine("Invalid operation");
            //}

            //int num = Convert.ToInt32("12");

            //Console.WriteLine(num + 4);

            //MadLib.Run();
            //ArrayPractice.Run();
            //Method.SayHi();
            //Method.SayHello("Tom", 22);
            //Method.SayHello("John", 24);
            //Method.SayHello("Mike", 32);

            //Console.WriteLine(ReturnType.ReturnType.Cube(3));

            //int result = ReturnType.ReturnType.Cube(4);
            //Console.WriteLine(result);

            //IfStatement.If.Run();
            //IfStatement.If.Run2();
            //IfStatement.If.Run3();
            //IfStatement.If2.Max();
            //Console.WriteLine(IfStatement.If2.Min(511, 1011, 123));

            //Calculator.Run();
            //switchStatement.SS_Day.GetDay(3);
            //Console.WriteLine(switchStatement.SS_Day.GetDay(12));

            //WhileLoop.Run();
            //WhileLoop.Run2();
            //GuessingGame.Run();
            //GuessingGame.Run2();

            //ForLoop.Run();
            //ForLoop.Run2(); 

            //Console.WriteLine(Exponent_Function.Exponentfunc.GetPow(3, 4));

            //TwoDim.Run();

            //ExceptionHand.Run();

            //Book b = new Book();
            //b.title = "The Great Gatsby";
            //b.author = "F. Scott Fitzgerald";
            //b.pages = 180;

            //Book b2 = new Book();
            //b2.title = "Harry Potter and the Sorcerer's Stone";
            //b2.author = "J.K. Rowling";
            //b2.pages = 309; 

            //Console.WriteLine("Book name : " + b.title);
            //Console.WriteLine("Author : " + b.author);
            //Console.WriteLine("Pages : " + b.pages);
            //Console.WriteLine("Book name : " + b2.title);
            //Console.WriteLine("Author : " + b2.author);
            //Console.WriteLine("Pages : " + b2.pages);


            //Constructor.Book b3 = new Constructor.Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", 309);
            //Constructor.Book b4 = new Constructor.Book("The Great Gatsby", "F. Scott Fitzgerald", 180);

            //b3.title = "The Hobbit";
            //Console.WriteLine(b3.title);

            //Student student1 = new Student("Tom", "Computer Science", 3.5);
            //Student student2 = new Student("Mike", "Business", 2.8);
            //Console.WriteLine("Student name: " + student1.name);
            //Console.WriteLine("Major: " + student1.major);
            //Console.WriteLine("GPA: " + student1.gpa);

            //Console.WriteLine(student1.HasHonors());
            //Console.WriteLine(student2.HasHonors());

            //Movie movie1 = new Movie("The Shawshank Redemption", "Frank Darabont", "R");
            //Movie movie2 = new Movie("The Avengers", "Joss Whedon", "PG-13");

            //movie1.Rating = "PG-13";
            //Console.WriteLine(movie1.Rating);

            //Song holiday = new Song("Holiday", "Green Day", 200);
            //Console.WriteLine(Song.songCount);
            //Song Kashmir = new Song("Kashmir", "Led Zeppelin", 500);

            //Console.WriteLine(Song.songCount);
            //Console.WriteLine(holiday.GetSongCount());
            //Console.WriteLine(Kashmir.artist);

            //StaticMethod_Classes.Run();
            //UsefulTools.sayHi("Sudhanshu");

            //UsefulTools ut = new UsefulTools();

            //Chef chef = new Chef();
            ////chef.MakeChicken();
            //chef.MakeSpecialDish();

            //ItalianChef italianChef = new ItalianChef();
            ////italianChef.MakeChicken();
            //italianChef.MakeSpecialDish();
            ////italianChef.MakePasta();

            //Student2 student1 = new Student2("Sudhanshu", 22, 101, "Computer Science");
            //student1.StudentDetails();

            //Student2 student2 = new Student2("Ankit", 21, 102, "Information Technology");
            //student2.StudentDetails();

            //Student2 student3 = new Student2();
            //student3.name = "Ankit";
            //student3.age = 21;
            //student3.rollNo = 102;
            //student3.course = "Information Technology";
            //student3.StudentDetails();

            //Car car1 = new Car();
            //car1.Brand = "Toyota";
            //car1.Color = "Red";

            //Car car2  = new Car();
            //car2.Color = "Blue";

            ////car2.Brand = "Honda";

            ////car1.Start();
            ////car2.Start();

            //Console.WriteLine(car2.Color);
            //car2.Start();
            ////car2.Stop(); -- Both returns value of Brand as null because we have not assigned any value to it. So, it will print " Car has started" and " Car has stopped" without the brand name.
            //// This teaches an important OOP concept:
            //// Objects can exist with incomplete data unless we control object creation properly.
            //// That is exactly why constructors and encapsulation exist.

            //Bike b1 = new Bike();
            //b1.Brand = "Yamaha";
            //b1.Color = "Black";

            //b1.Start();
            //Console.WriteLine(b1.Color);

            //Console.WriteLine(b1.Model); // This will print null because we have not assigned any value to it. This again shows that objects can exist with incomplete data unless we control object creation properly.

            //Bike2 b1 = new Bike2();
            //Console.WriteLine(b1.Brand);

            //Bike2 b2 = new Bike2("Honda", "Civic", "Red");
            //Console.WriteLine(b2.Brand);

            //b1.Start();
            //b2.Start();

            //Student3 s1 = new Student3("Sudhanshu", 101, "Software Engineering");
            //Student3 s2 = new Student3("Ankit", 102, "BBA");

            //s1.DisplayInfo();
            //s2.DisplayInfo();

            //Stud s1 = new Stud();
            //s1.setAge(-21); // invalid age, so it will set age to 0

            //Console.WriteLine(s1.getAge()); // This will print 0 because we have set age to 0 in the setAge method when an invalid age is provided.

            //Stud s2 = new Stud();
            //s2.setAge(22); // valid age, so it will set age to 22
            //Console.WriteLine(s2.getAge());

            //Person p1 = new Person();
            //p1.setName("Sudhanshu Jha");
            //p1.setAge(-22); // invalid age, but if the field is public, we can directly assign an invalid value to it without any control. This is why we should make fields private and use getter and setter methods to control access to them.

            //Console.WriteLine(p1.getName());
            //Console.WriteLine(p1.getAge()); // This will print -22 because we have directly assigned an invalid value to the age field without any control. This again shows the importance of encapsulation in OOP.

            //Person p2 = new Person();
            //p2.setName("Ankit");
            //p2.setAge(-22);

            //Console.WriteLine(p2.getName());
            //Console.WriteLine(p2.getAge());

            //Person p3 = new Person();
            //p3.setName("Mike");
            //p3.setAge(25);

            //Console.WriteLine("Name: " + p3.getName());
            //Console.WriteLine("Age: " + p3.getAge());
            //Console.WriteLine("Created At: " + p3.GetCreationDate());
            //Console.WriteLine($"Created At : {p3.GetCreationDate():MM/dd/yyyy HH:mm:ss}");

            //SimpleBank Account1 = new SimpleBank();
            //Account1.Deposit(1000);
            //Console.WriteLine("Balance: " + Account1.GetBalance());
            
            //Account1.Withdraw(500);
            //Console.WriteLine("Balance: " + Account1.GetBalance());

            Employee employee = new Employee();
            //employee.setSalary(20000); // This will set the salary to 20000 because we have provided a valid salary value.
            //Console.WriteLine($"Salary : {employee.getSalary()}");

            employee.Salary = 20000; // This will set the salary to 20000 because we have provided a valid salary value.
            Console.WriteLine($"Salary : {employee.Salary}");

        }
    }
}
