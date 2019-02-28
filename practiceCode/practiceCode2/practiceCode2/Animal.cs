using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceCode2
{
    class Animal
    {
        public string name = "NoName";

        virtual public void makeNoise()
        {
            Console.WriteLine("I am an Animal!");
        }


    }

    class Dog : Animal
    {
        public Dog(string newName)
        {
            name = newName;
        }
        public override void makeNoise()
        {
            Console.WriteLine("Woof!!");
        }
    }

    class Bird : Animal
    {
        public int wingSpan;

        public override void makeNoise()
        {
            Console.WriteLine("I am a Birdy!");
        }
    }

    class Parrot : Bird
    {
        public override void makeNoise()
        {
            Console.WriteLine("RRRRR im a Parrot!!!");
        }

    }
}
