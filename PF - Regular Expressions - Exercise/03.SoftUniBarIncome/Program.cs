using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            string pattern = @"\%(?<name>[A-z][a-z]+)\%[^|$%.]*\<(?<product>\w+)\>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+|\d+\.\d+)\$";
            string command = Console.ReadLine();
            decimal income = 0m;
            while (command!= "end of shift")
            {
                foreach (Match match in Regex.Matches(command,pattern))
                {
                    Customer customer = new Customer();
                    customer.Name = match.Groups["name"].Value;
                    customer.Product = match.Groups["product"].Value;
                    customer.Count = int.Parse(match.Groups["count"].Value);
                    customer.Price = decimal.Parse(match.Groups["price"].Value);
                    Console.WriteLine($"{customer.Name}: {customer.Product} - {customer.Total():f2}");
                    income += customer.Total();
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {income:f2}");
        }
    }
    public class Customer
    {
        public string Name { get; set; }
        public string Product { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public decimal Total()
        {
            return Price * Count;
        }
    }
}
