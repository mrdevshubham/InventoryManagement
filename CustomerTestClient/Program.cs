using Customer.Data.DataAccess;
using Customer.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerTestClient
{
    static class Program
    {
        public delegate void getAscendingMethodPointer(string[] customers);
        static void Main(string[] args)
        {

            object age = 36;
            int age1 = (int)age;

            age1 = 23;

            Console.WriteLine(age1);
            







            //using (var context = new CustomerDbContext())
            //{
            //    var customers = context.Customers.ToList();
            //    foreach (var customer in customers)
            //    {
            //        Console.WriteLine("Name is : " + customer.CustomerFirstName);
            //    }
            //}

            //Func<int, double> calculate = new Func<int, double>(CalculateHra);

            //Console.WriteLine(calculate(500));



            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}

            //CustomerDelegates customerDelegates = new CustomerDelegates();

            //var Sum = customerDelegates.DoWork<int, int, int>(2,3,(x, y) => (x + y));
            //var Multiply = customerDelegates.DoWork<int, int, int>(2, 3, (x, y) => (x * y));
            //var Subtract = customerDelegates.DoWork<int, int, int>(5, 3, (x, y) => (x - y));


            Console.Read();


        }

        static double CalculateHra(int basic)

        {
            return (double)(basic * .4);
        }

        //Func<IEnumerable<string>, IEnumerable<string>> Fmethod = new Func<IEnumerable<string>, IEnumerable<string>>(x => x.orde)

        
        private static List<string> GetNames()
        {
            return new List<string>
            {
                "Shubham",
                "Seema",
                "Avinash",
                "Misha",
                "Torona",
                "Catora"
            };
        }
    }
}
