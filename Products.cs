using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //----------------------------Task 1 -------------------------------
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime ProdDate { get; set; }
        public DateTime ExpDate { get; set; }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: ${Price}, Production date: {ProdDate:d}, Expiration date: {ExpDate:d}");
        }
        public virtual void ExpirationSearch()
        {
            if (ExpDate >= DateTime.Today)
            {
                Console.WriteLine($"Product: {Name} is fresh");
            }
            else
            {
                Console.WriteLine($"Product: {Name} is expired");
            }
        }
    }
    public class Batch : Product
    {
        public int Amount { get; set; }
        public Batch() { }
        public Batch(string name, int amount)
        {
            Name = name;
            Amount = amount;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: ${Price}, Amount: {Amount}, Production date: {ProdDate:d}, Expiration date: {ExpDate:d}");
        }
    }
    public class Set : Product
    {
        public Product Prod { get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: ${Price}, Set: {Prod.Name}");
        }
    }
}
