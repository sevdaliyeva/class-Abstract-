// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//2.Input Juan Sara Carlos,Output Explain Study Study
//using System;
//public class ClassPerson
//{
//    public static void Main(string[] args)
//    {

//        Person[] persons = new Person[3];

//        for (int i = 0; i < 3; i++)
//        {
//            if (i == 0)
//            {
//                persons[i] = new Teacher(Console.ReadLine());
//            }
//            else
//            {
//                persons[i] = new Student(Console.ReadLine());
//            }
//        }

//        for (int i = 0; i < 3; i++)
//        {
//            if (i == 0)
//            {
//                ((Teacher)persons[i]).Explain();

//            }
//            else
//            {
//                ((Student)persons[i]).Study();
//            }
//        }
//    }

//    public class Person
//    {
//        public string Name { get; set; }

//        public Person(string name)
//        {
//            Name = name;
//        }

//        public override string ToString()
//        {
//            return "Hello! My name is " + Name;
//        }
//    }

//    public class Teacher : Person
//    {
//        public Teacher(string name) : base(name)
//        {
//            Name = name;
//        }

//        public void Explain()
//        {
//            Console.WriteLine("Explain");
//        }
//    }

//    public class Student : Person
//    {
//        public Student(string name) : base(name)
//        {
//            Name = name;
//        }

//        public void Study()
//        {
//            Console.WriteLine("Study");
//        }
//    }
//}
//3.Input:Tobby,output Tobby Eating
//using System;

//public class AbstractClass
//{
//    public static void Main(string[] args)
//    {
//        Dog dog = new Dog();
//        dog.SetName(Console.ReadLine());
//        Console.WriteLine(dog.GetName());
//        dog.Eat();
//    }

//    public class Dog : Animal
//    {
//        public override void Eat()
//        {
//            Console.WriteLine("Eating");
//        }
//    }

//    public abstract class Animal
//    {
//        private string Name;

//        public void SetName(string name)
//        {
//            Name = name;
//        }

//        public string GetName()
//        {
//            return Name;
//        }

//        public abstract void Eat();
//    }
//}
//4.Input Juan Sara Carlos.Output Hello My name is Juan.
//using System;
//public class ClassPerson
//{
//    public static void Main(string[] args)
//    {
//        int total = 3;
//        Person[] persons = new Person[total];

//        for (int i = 0; i < total; i++)
//        {
//            persons[i] = new Person(Console.ReadLine());
//        }

//        for (int i = 0; i < total; i++)
//        {
//            Console.WriteLine(persons[i].ToString());
//        }
//    }
//     public class Person
//    {
//        public string Name { get; set; }

//        public Person(string name)
//        {
//            Name = name;
//        }
//        public override string ToString()
//        {
//            return "Hello! My name is " + Name;
//        }
//        ~Person()
//        {
//            Name = string.Empty;
//        }
//    }
//}
