using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDAssignment2Part2
{
    class Program
    {
       
        public static int dimensionOne = 0;
        public static int dimensionTwo = 0;
        public static int dimensionThree = 0;

        static void Main(string[] args)
        {

            int userInput = 0;
            Program prog = new Program();
           
            do
            {

                try
                {



                    prog.Menu();
                    userInput = Convert.ToInt16(Console.ReadLine());

                    if (userInput == 1)
                    {
                        DimensionOne();
                        DimensionTwo();
                        DimensionThree();
                        TriangleSolver.Analyze(dimensionOne, dimensionTwo, dimensionThree);

                    }
                    else if (userInput == 2)
                    {
                        Environment.Exit(0);
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Please select option from menu");
                    Console.WriteLine();
                    prog.Menu();

                }
            } while (userInput!=2);

            Console.ReadLine();
            
              
        }

        public void Menu()
        {
            Console.WriteLine("```````````````````````````````````````");
                Console.WriteLine("Please Select one of the Option");
                Console.WriteLine("```````````````````````````````````````");
                Console.WriteLine("1. Enter triangle dimensions");
                Console.WriteLine("2. Exit");
               
        }

        public static void DimensionOne()
        {
            Console.WriteLine("Enter the first side of Traingle");
            try
            {
                dimensionOne = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an interger");
                DimensionOne();
            }
        }
        public static void DimensionTwo()
        {
            Console.WriteLine("Enter the second side of Traingle");
            try
            {
                dimensionTwo = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an interger");
                DimensionTwo();
            }
        }
        public static void DimensionThree()
        {
            Console.WriteLine("Enter the third side of Traingle");
            try
            {
                dimensionThree = Convert.ToInt32(Console.ReadLine());
            }

            catch (Exception)
            {
                Console.WriteLine("Please enter an interger");
                DimensionThree();
            }
        }

    }
}
