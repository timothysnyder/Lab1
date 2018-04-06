using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit1Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int FirstInput;
                int SecondInput;
                Console.WriteLine("Please Enter Number");
                string one = Console.ReadLine();
                bool TestInputOne = int.TryParse(one, out FirstInput);
                Console.WriteLine("Please Enter Another Number");
                string two = Console.ReadLine();
                bool TestInputTwo = int.TryParse(two, out SecondInput);

                if (TestInputOne !=true || TestInputTwo !=true)
                {
                    Console.WriteLine("Value is less than 10");
                }
                if (one.Length !=3 ||two.Length !=3)
                { }
                string[] arrayone = one.Split();
                string[] arraytwo = two.Split();
                int[] FirstArray= new Int32[3];
                int[] SecondArray= new Int32[3];
                for (int i = 0; i < 3; i++)
                {
                    FirstArray[i] = int.Parse(arrayone[i]);

                    SecondArray[i] = int.Parse(arraytwo[i]);
                }
                 

            }




        }
    }
}
