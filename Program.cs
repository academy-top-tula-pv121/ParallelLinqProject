using System.Collections;
using System.Diagnostics;

namespace ParallelLinqProject
{
    internal class Program
    {
        static int Sqr(int n) => n * n;
        static void Main(string[] args)
        {
            var numbers = ParallelEnumerable.Range(1, 20);

            //var numbers = ParallelEnumerable.Repeat(5, 10);
            //var pquery = from num in numbers.AsParallel()
            //             select Sqr(num);

            //foreach (int n in pquery)
            //    Console.WriteLine(n);

            //(from num in numbers.AsParallel() select Sqr(num)).ForAll(n => Console.WriteLine(n));
            //Console.WriteLine();




            //int c = 0;
            ////var pquery = 
            //numbers.AsParallel()
            //       .WithExecutionMode(ParallelExecutionMode.ForceParallelism)
            //       .WithDegreeOfParallelism(2)
            //       .ForAll(n => { if (n % 2 == 0) c++; });
            //Console.WriteLine($"even = {c}");

            //.AsOrdered()

            //{
            //    if (num == 7)
            //        throw new Exception("exception with 6");
            //    else
            //        return num;
            //});//.ForAll(n => Console.WriteLine(n));
            //try
            //{
            //    foreach (int n in pquery)
            //        Console.WriteLine(n);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}






            //IEnumerable<int> numbers = Enumerable.Range(0, Int32.MaxValue);

            //Stopwatch sw = Stopwatch.StartNew();
            //int countLinq = (from n in numbers
            //               where n % 2 == 0
            //               select n).Count();
            //Console.WriteLine($"{countLinq} - {sw.ElapsedMilliseconds}");


            //IEnumerable<int> pnumbers = ParallelEnumerable.Range(0, Int32.MaxValue);
            //sw.Restart();
            //int countPLinq = (from n in numbers.AsParallel()
            //                  where n % 2 == 0
            //                  select n).Count();
            //Console.WriteLine($"{countPLinq} - {sw.ElapsedMilliseconds}");
            //int f = 3;
            //var result = numbers.AsParallel()
            //                    .WithMergeOptions(ParallelMergeOptions.Default)
            //                    .Select(n =>
            //                    {
            //                        if (n == f) Console.WriteLine($"!!!!{n}");
            //                        Thread.Sleep(500);
            //                        return n;
            //                    });

            //f = 4;
            //.AsOrdered()
            //.Where(n => n % 2 == 0)
            //.AsSequential()
            //.AsUnordered()
            //.Where(n => n % 5 == 0);
            //.ForAll(n => Console.WriteLine(n));
            //f = 5;
            //Stopwatch sw = Stopwatch.StartNew();
            //foreach (var n in result)
            //    Console.WriteLine($"{n} - {sw.ElapsedMilliseconds}");



            //var result = numbers.AsParallel()
            //                    .Select(n => n * n)
            //                    .Cast<string>();


            //Console.WriteLine(result.GetType());
            //foreach (string s in result)
            //    Console.WriteLine(s.ToString());



            ArrayList list = new ArrayList();
            list.Add(123);
            list.Add("hello");
            list.Add(123.35);
            list.Add(new DateTime());
            list.Add("world");
            list.Add(321);
            list.Add(true);
            list.Add(new int[] { 1, 2, 3});
            list.Add(555);


            var result = list.AsParallel()
                             .OfType<string>()
                             .Select(n => n);

            foreach (var s in result)
                Console.WriteLine(s);
        }
    }
}