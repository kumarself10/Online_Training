﻿using System;
using System.Linq;
using System.Security.Principal;

namespace HandsOnLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int[] no = { 12, 23, 45, 56, 76, 65, 54, 43, 32, 21, 78, 89, 90 };
            //int[] a = new int[no.Length];
            //int j = 0;
            //foreach(var i in no)
            //{
            //    if(i%2==0)
            //    {
            //        a[j] = i;
            //        j++;
            //    }
            //}
            //foreach (var i in a)
            //    Console.WriteLine(i);
            //fetch even values
            var res = from i in no where i % 2 == 0 select i;
            //using QueryMethod
            res = no.Where(i => i % 2 == 0).Select(i => i);
            no[1] = 24;
            //foreach (var i in res)
            //    Console.WriteLine(i);
            //fetch all values
            var res1 = from i in no select i;
            res1 = no.Select(i => i);
            //fetch square of array values
            var res2 = from i in no select i * i;
            res2 = no.Select(i => i * i);
            //var res2 = from i in no let k = i * i select k;
            //fetch cube of array values <100000
            var res3 = from i in no
                       let k = i * i * i
                       where k < 10000
                       select k;
            res3 = no.Where(i => (i * i * i) < 10000).Select(i => i);
            foreach (var i in res3)
                Console.WriteLine(i);
            Console.ReadKey();

        }
    }
}
