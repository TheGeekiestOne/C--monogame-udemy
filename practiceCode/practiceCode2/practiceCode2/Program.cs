using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceCode2
{



 

    struct House
    {
        public string address;
        public int width;
        public int length;

        public House(string a, int w, int l)
        {
            address = a;
            width = w;
            length = l;
        }

        public int Area()
        {
            return width * length;
        }
    }

    enum Meal
    {
        Breakfast,
        Lunch,
        Dinner
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat("Atom", 8);
            myCat.setName("Gizmo");

            myCat.Age = 5;

            Console.WriteLine(myCat.getName());
            Console.WriteLine(myCat.Age);

            Dog myDog = new Dog("MAX!");

            myDog.makeNoise();
            Console.WriteLine(myDog.name);

            Parrot myParrot = new Parrot();

            myParrot.makeNoise();



            House myHouse = new House("789 road Street", 20, 10);
            /*
            myHouse.address = "123 Streeto";
            myHouse.width = 50;
            myHouse.length = 35;
            */

            //Meal bestMeal = Meal.Dinner;
            Meal bestMeal = (Meal)0;


            Console.WriteLine(myHouse.address);
            Console.WriteLine(myHouse.Area());


            Console.WriteLine((int)Meal.Breakfast);
            Console.WriteLine((int)Meal.Lunch);
            Console.WriteLine((int)Meal.Dinner);

            Console.ReadKey();

            
        }
    } 
}


