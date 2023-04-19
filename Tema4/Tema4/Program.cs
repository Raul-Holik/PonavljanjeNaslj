using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4
{
    class Dessert
    {
        string name;
        double weight;
        int calories;

        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public int Calories { get => calories; set => calories = value; }

        public Dessert ()
        {

        }
            
        public Dessert(string name,double weight, int calories)
        {
            this.name = name;
            this.weight = weight;   
            this.calories = calories;
        }

        public override string ToString()
        {
            return "Ime torte je " + name + " teži: " + weight + " i ima " + calories + " kalorija.";
        }

        public string getDessertType()
        {
            return "Dessert";
        }

     }
     
    class Cake : Dessert
    {
        bool containsGluten;
        string cakeType;

        public Cake(string name, double weight, int calories, bool containsGluten, string cakeType) : base(name, weight, calories)
        {
            this.cakeType = cakeType;
            this.containsGluten = containsGluten;
        }

        public bool ContainsGluten { get => containsGluten; set => containsGluten = value; }
        public string CakeType { get => cakeType; set => cakeType = value; }

        public override string ToString()
        {
            return "Ime torte je " + this.Name + " teži: " + this.Weight + " i ima " + this.Calories + " kalorija." + "sadrzi gluten: " + containsGluten + " vrsta kolaca je " + cakeType;
        }
        public string getDessertType()
        {
            return "Cake " + cakeType + ".";
        }
    }

    class IceCream  :Dessert
    {
        string flavour, color;

        public IceCream(string name, double weight, int calories, string flavour, string color) : base(name, weight, calories)
        {
            this.flavour = flavour;
            this.color = color;
        }

        public string Flavour { get => flavour; set => flavour = value; }
        public string Color { get => color; set => color = value; }



        public override string ToString()
        {
            return "Ime sladoleda je " + this.Name + " teži: " + this.Weight + " i ima " + this.Calories + " kalorija." + " okus je " + flavour + " boja sladoleda je " + color;
        }

        public string getDessertType()
        {
            return "Ice cream";
        }
    }

    class Person
    {
        string name, surname;
        int age;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }

        public Person()
        {

        }
        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   name == person.name &&
                   surname == person.surname &&
                   age == person.age;
        }

        public override string ToString()
        {
            return "Ime: " + name + " prezime: " + surname + " godine: " + age;
        }
    }

    class Student:Person
    {
        string studentID;
        short academicYear;

        public Student(string name, string surname, int age, string studentID, short academicYear) : base(name, surname, age)
        {
            this.studentID = studentID;
            this.academicYear = academicYear;
        }

        public string StudentID { get => studentID; set => studentID = value; }
        public short AcademicYear { get => academicYear; set => academicYear = value; }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   base.Equals(obj) &&
                   studentID == student.studentID;
        }

        public override string ToString()
        {
            return "Ime: " + this.Name + " prezime: " + this.Surname + " godine: " + this.Age;
        }
    }

    class Teacher:Person
    {
        string email, subject;
        double salary;

        public string Email { get => email; set => email = value; }
        public string Subject { get => subject; set => subject = value; }
        double Salary { get => salary; set => salary = value; }
        public Teacher(string name, string surname, int age, string email, string subject, double salary) : base(name, surname, age)
        {
            this.email = email;
            this.subject = subject;
            this.salary = salary;
        }

        public override string ToString()
        {
            return "Ime: " + this.Name + " prezime: " + this.Surname + " godine: " + this.Age + " placa: " + this.salary;
        }

        public override bool Equals(object obj)
        {
            return obj is Teacher teacher &&
                   base.Equals(obj) &&
                   email == teacher.email;
        }

        public void IncreaseSalary(int postotak)
        {
            salary *= (1 + (postotak / 100));
        }

        public static void increaseSalary(int postotak,Teacher teacher)
        {
           for(int i = 0; i < 5; i++)
            {
                teacher.IncreaseSalary(postotak);
            }
        }
    }

    internal class Program
    {
       
        static void Main(string[] args)
        {
            Dessert dessert = new Dessert("Kolač", 90.1, 600);
            Cake cake = new Cake("Čokoladna", 70.8, 65, true, "rođendanska");
            IceCream iceCream = new IceCream("jagoda", 66.5, 88, "jagoda", "crvena");

            Console.WriteLine(dessert.ToString());
            Console.WriteLine(cake.ToString());
            Console.WriteLine(iceCream.ToString());

            Teacher p1 = new Teacher("Ante", "Antevic", 30, "ante@mail.com", "matematika", 6500);
            Teacher p2 = new Teacher("Marko", "Markovic", 40, "marko@mail.com", "tjelesni", 8000);
            Teacher p3 = new Teacher("Marija", "Maric", 26, "marija@mail.com", "hrvatski", 6000);
            Student s1 = new Student("Dario", "Daric", 16, "DA123", 2020);
            Student s2 = new Student("Ana", "Anjic", 17, "DA123", 2021);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p3.ToString());
            Console.WriteLine(s1.ToString());
            Console.WriteLine(s2.ToString());


            Console.ReadKey();
        }
    }
}
