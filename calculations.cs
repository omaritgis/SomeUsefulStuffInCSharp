using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NUnit.Framework;

namespace SomeUsefulStuffInCSharp{

    public static class calculations{

        public static void minimaxSum(int[] arr){
            var listed = arr.ToList();
            listed.Sort();
            var firstval = listed.Sum() - listed.ElementAt(0);
            var secondVal = listed.Sum() - listed.Last();
            System.Console.WriteLine(secondVal + " " + firstval);
        }

        public static void plusMinusZero(int[] arr){
            float minus = 0; float plus = 0; float zero = 0;
            foreach(int i in arr){
                minus += i<0 ? 1 : 0;
                plus += i>0 ? 1:0;
                zero += i == 0 ? 1:0;
            }

            Console.WriteLine(plus/arr.Length);
            Console.WriteLine(minus/arr.Length);
            System.Console.WriteLine(zero/arr.Length);
        }

        public static void genStatsAndGetProportion(int minAmount){
            Random rand = new Random();
            List<List<int>> totalStats = new List<List<int>>();
            List<List<int>> customMatches = new List<List<int>>();
            for (int i = 0; i < 100; i++)
            {
                List<int> stats = new List<int>();                
                for(int j = 0; j<36; j++){
                    stats.Add(rand.Next(1,356));
                }
                stats.Sort();
                var sameb = 0;
                for (int k = 0; k < stats.Count(); k++)
                {
                    double one = stats.ElementAt(k);
                    double two = stats.ElementAt(k+1 != stats.Count() ? k+1 : k);
                    sameb += one == two ? 1 : 0;
                }
                //System.Console.WriteLine("Column {i}", stats);
                sameb--;
                totalStats.Add(stats);
                if(sameb >= minAmount){
                    customMatches.Add(stats);
                }
            }

            double proportion = customMatches.Count() / totalStats.Count();
        }
        
        
        public static double confidenceInterval(double phatt, bool plus){
            double n = 100;
            double p2 = plus ? phatt + 1.96*Math.Sqrt((phatt * (1-phatt)) / n) : phatt - 1.96*Math.Sqrt((phatt * (1-phatt)) / n);
            return p2;
        }
    }

    [TestFixture]
    public class calculationsTest {
        [TestCase(0.83)]
        public static double confidenceInterval(double phatt){
            double n = 100;
            double p1 = phatt + 1.96*Math.Sqrt((phatt * (1-phatt)) / n);
            double p2 = phatt - 1.96*Math.Sqrt((phatt * (1-phatt)) / n);
            Assert.IsTrue(0.832 < p1 && 0.832 > p2, "Test");
            
            return p2;
        }
    }
}