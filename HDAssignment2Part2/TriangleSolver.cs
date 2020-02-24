using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDAssignment2Part2
{
    public static class TriangleSolver
    {
        public static string Analyze(int dimensionOne, int dimensionTwo, int dimensionThree)
        {
            if ((dimensionOne + dimensionTwo > dimensionThree) && (dimensionTwo + dimensionThree > dimensionOne) && (dimensionThree + dimensionOne > dimensionTwo))
            {
                Console.WriteLine("Triangle is created");
                Console.WriteLine();

                if (dimensionOne == dimensionTwo || dimensionTwo == dimensionThree || dimensionThree == dimensionOne)
                {
                    Console.WriteLine("Isosceles Triangle is formed");
                }
                else if (dimensionOne == dimensionTwo && dimensionTwo == dimensionThree)
                {
                    Console.WriteLine("Eqilateral Triangle is formed");
                }
                else
                {
                    Console.WriteLine("Scalene Triangle is formed");
                }
            }
            else
            {
                Console.WriteLine("The Triangle is not Created");
            }
            return "";
        }
    }
}
