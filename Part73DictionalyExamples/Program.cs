using System;
using System.Collections.Generic;
namespace Part73DictionalyExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer()
            {
                //variables value assignments 
                Id=101,
                Name="Shubham"
            };
            Customer c2 = new Customer()
            {
                Id=102,
                Name="Saurabh"
            };
            Customer c3 = new Customer()
            {
                Id=103,
                Name="Virendra"
            };

            Dictionary<int, Customer> dic1 = new Dictionary<int, Customer>();
            dic1.Add(c1.Id, c1);
            dic1.Add(c2.Id, c2);
            dic1.Add(c3.Id, c3);

    
            foreach(KeyValuePair<int,Customer>keys in dic1)
            {
               bool b= dic1.ContainsKey(108);
                Console.WriteLine(b);
               bool b1= dic1.ContainsValue(c1);
                Console.WriteLine(b1);
                Console.WriteLine(dic1.Count);
                Console.WriteLine("Key={0}",keys.Key);
                Customer custo = keys.Value;
                Console.WriteLine("Id={0},Name={1}", custo.Id, custo.Name);
            }

          }


    }
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
    }
}