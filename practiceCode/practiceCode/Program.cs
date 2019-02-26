using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceCode
{
    class Program
    {
        static void Main(string[] args)

            //THIS IS A SINGLE LINE COMMENT

            /*THIS IS
             A MULTI
             LINE
             COMMENT
             */

        {
            /*int myNumber = 1;
            int otherNumber = 5;
            myNumber = otherNumber * 55;

            myNumber = myNumber + 1;
            //or
            myNumber += 1;
            //or
            myNumber ++; //++ and -- increment by 1

            float num = 1.5f;

            string message = "Am I a progammer yat?????"; //double quotes for strings
            char mes = 'A'; //single quote for characters
            bool myMessage = true;  //True or false 

            Console.WriteLine(message);
            Console.WriteLine(num);
            */

            /*
            int myNumber = -5;
            int checkValue = -15;

            int absolute = Math.Abs(myNumber);//prints out absolute value i.e turns negative to positive 

            if (checkValue > 0)
            {
                myNumber = 1;
            }
            else if (checkValue < -20)
            {
                myNumber = -2;
            }
            else
            {
                myNumber = -1;
            }
            */

            int myNum = 1;

            /*
            int[] myArray = new int[5];
            myArray[0] = 8;
            myArray[1] = 6;
            */

            int[] myArray = { 8, 6, 7, 5, 3, 0, 9 };



            int myValue = 0;
            int forLoopVal = 0;
            
            while (myValue < 10)
            {
                myValue ++;
            }

            for (int i = 0; i < 5; i++)
            {
                forLoopVal += 10;
            }

            //Console.WriteLine(myNumber);
            Console.WriteLine(myArray[2]);
            Console.WriteLine(forLoopVal);
            //Console.WriteLine(absolute);
            Console.ReadKey();
        }
    }
}
