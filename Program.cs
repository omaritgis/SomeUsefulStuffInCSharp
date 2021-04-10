using System;
using System.Linq;


namespace SomeUsefulStuffInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = {1,2,3,4,5};
            calculations.plusMinusZero(arr);
            calculations.minimaxSum(arr);
            calculations.genStatsAndGetProportion(2);
            Console.WriteLine("Plus: " + calculations.confidenceInterval(0.83,true));
            Console.WriteLine("Minus: " +calculations.confidenceInterval(0.83,false));
        }

        

        
    }
}
