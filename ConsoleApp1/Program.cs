using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kata.Unique((new List<int>() { 1, 5, 2, 0, 2, -3, 1, 10 }));
        }
    }

    public class Kata
    {
        public static List<int> Unique(List<int> integers)
        {
            //for(int i = 0; i < integers.Count-1; i++)
            //{
            //    for(var j = i+1; j < integers.Count; j++)
            //    {
            //        if(integers[i] == integers[j])
            //        {
            //           integers.RemoveAt(j);
            //        }
            //    }
            //}
            List<int> withDupes = integers;
            List<int> noDupes = withDupes.Distinct().ToList();
            return noDupes;
        }
    }
}
