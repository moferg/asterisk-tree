using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteriskTree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Expected output: 
            //    *             Line 1, 4 spaces, 1 star          spaceDiff 3      starDiff 0
            //   ***            Line 2, 3 spaces, 3 stars         spaceDiff 1      starDiff 1
            //  *****           Line 3, 2 spaces, 5 stars         spaceDiff -1     starDiff 2
            // *******          Line 4, 1 space,  7 stars         spaceDiff -3     starDiff 3
            //*********         Line 5, 0 space,  9 stars         spaceDiff -5     starDiff 4

            // Hints: 3 total loops, 1 outer and 2 inner
            // Outer loop goes from line to line
            // Inner loops print spaces and stars

            for(int row = 0; row < 5; row++)
            {
                for(int spaces = 4; spaces > row; spaces--)
                {
                    Console.Write(" ");
                }

                for(int stars = -row + 1; stars <= row + 1; stars++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
