//---------------------------- Task 0 - 1 -------------------------------

// ArrayList list = new ArrayList();

// try
// {
//     object s = list[18];
// }
// catch(ArgumentOutOfRangeException ex)
// {
//     Console.WriteLine($"Error: {ex.Message}");
//     Console.WriteLine($"StackTrace:{ex.StackTrace}");
// }
// finally
// {
//     Console.WriteLine("Final");
// }


//---------------------------- Task 0 - 2 -------------------------------

// Dictionary<int,string> dct = new Dictionary<int, string>(10)
// {
//     {1,"One"},
//     {2,"Two"},
//     {3,"Three"},
//     {4,"Four"},
//     {5,"Five"},
//     {6,"Six"},
//     {7,"Seven"},
//     {8,"Eight"},
//     {9,"Nine"},
//     {10,"Ten"}
// };
// Console.Write("Dictionary collection: ");
// foreach(var a in dct)
// {
//     Console.Write($"{a} ");
// }


//---------------------------- Task 0 - 3 -------------------------------

// List<int> list1 = new List<int>(1) {1};
// list1.Add(1);
// list1.Add(2);
// list1.Add(3);
// list1.Add(4);
// list1.Add(4);
// list1.Add(5);

// list1 = list1.Distinct().ToList();

// Console.WriteLine(string.Join(",",list1));


//---------------------------- Task 1 -------------------------------

// List<Product> prd = new List<Product>()
// {
//     new Product()
//     {
//         Name = "Water",
//         Price = 0.5m,
//         ProdDate = new DateTime(2023, 04, 15),
//         ExpDate = new DateTime(2024, 04, 15)
//     },
//     new Product()
//     {
//         Name = "Water1",
//         Price = 0.7m,
//         ProdDate = new DateTime(2023, 04, 15),
//         ExpDate = new DateTime(2024, 04, 15)
//     },
//     new Product()
//     {
//         Name = "Water2",
//         Price = 1m,
//         ProdDate = new DateTime(2023, 04, 15),
//         ExpDate = new DateTime(2024, 04, 15)
//     },
//     new Product()
//     {
//         Name = "Water3",
//         Price = 2.5m,
//         ProdDate = new DateTime(2023, 04, 15),
//         ExpDate = new DateTime(2024, 04, 15)
//     },
//     new Product()
//     {
//         Name = "Water4",
//         Price = 5m,
//         ProdDate = new DateTime(2023, 04, 15),
//         ExpDate = new DateTime(2024, 04, 15)
//     }
// };

// foreach(var c in prd)
// {
//     c.DisplayInfo();
// }

// prd[0].Price = 100;
// Console.WriteLine();

// foreach(var c in prd)
// {
//     c.DisplayInfo();
// }

// Console.WriteLine($"\n{prd.Count}");
// prd.RemoveAt(4);

// Console.WriteLine("Вывод перебиранием foreach");
// foreach(var c in prd)
// {
//     c.DisplayInfo();
// }

// Console.WriteLine("Вывод перебиранием for");
// for(int a = 0; a < prd.Count; a++)
// {
//     prd[a].DisplayInfo();
// }

// Console.WriteLine("Вывод с помощью FindAll");
// List<Product> searchProd = prd.FindAll(item => item.Price > 0);
// foreach(Product itm in searchProd)
// {
//     itm.DisplayInfo();
// }

// prd.Clear();

// Console.WriteLine();
// foreach(var c in prd)
// {
//     c.DisplayInfo();
// }


//---------------------------- Task 2 -------------------------------

// SortedSet<Product> sortedPrd = new SortedSet<Product>(new Rules());

// sortedPrd.Add(new Product()
//     {
//         Name = "Water",
//         Price = 4.99m,
//         ProdDate = new DateTime(2023, 04, 15),
//         ExpDate = new DateTime(2024, 04, 15)
//     });
// sortedPrd.Add(new Product()
//     {
//         Name = "Water1",
//         Price = 3m,
//         ProdDate = new DateTime(2023, 04, 15),
//         ExpDate = new DateTime(2024, 04, 15)
//     });
// sortedPrd.Add(new Product()
//     {
//         Name = "Water2",
//         Price = 2.5m,
//         ProdDate = new DateTime(2023, 04, 15),
//         ExpDate = new DateTime(2024, 04, 15)
//     });
// sortedPrd.Add(new Product()
//     {
//         Name = "Water3",
//         Price = 1.5m,
//         ProdDate = new DateTime(2023, 04, 15),
//         ExpDate = new DateTime(2024, 04, 15)
//     });
// sortedPrd.Add(new Product()
//     {
//         Name = "Water4",
//         Price = 0.5m,
//         ProdDate = new DateTime(2023, 04, 15),
//         ExpDate = new DateTime(2024, 04, 15)
//     });

// foreach(var d in sortedPrd)
// {
//     d.DisplayInfo();
// }


//---------------------------- Task 3 -------------------------------

// var water = new List<Product>()
// {
//     new Product()
//     {
//         Name = "Water",
//         Price = 50m,
//         ProdDate = new DateTime(2023, 04, 15),
//         ExpDate = new DateTime(2024, 04, 15)
//     },
//     new Product()
//     {
//         Name = "Water1",
//         Price = 700m,
//         ProdDate = new DateTime(2023, 04, 15),
//         ExpDate = new DateTime(2024, 04, 15)
//     },
//     new Product()
//     {
//         Name = "Water2",
//         Price = 150m,
//         ProdDate = new DateTime(2023, 04, 15),
//         ExpDate = new DateTime(2024, 04, 15)
//     },
//     new Product()
//     {
//         Name = "Water3",
//         Price = 250m,
//         ProdDate = new DateTime(2023, 04, 15),
//         ExpDate = new DateTime(2024, 04, 15)
//     },
//     new Product()
//     {
//         Name = "Water4",
//         Price = 1500m,
//         ProdDate = new DateTime(2023, 04, 15),
//         ExpDate = new DateTime(2024, 04, 15)
//     }
// };

// var expensiveWater = new List<Product>();
// var cheapWater = new List<Product>();   // удаление в цикле foreach не сработало
//                                         // поэтому я просто сделал новый лист без дорогих
//                                         // и очистил первоначальный в методе ExpensiveSort
// ExpensiveSort();

// expensiveWater.Sort(new Rules());
// expensiveWater[0].DisplayInfo();

// void ExpensiveSort()
// {
//     foreach(var a in water)
//     {
//         if(a.Price > 300)
//         {
//             expensiveWater.Add(a);
//         }
//         else if(a.Price < 300)
//         {
//             cheapWater.Add(a);
//         }
//     }
//     water.Clear();
// }


//---------------------------- Task 4 -------------------------------

// var water = new Dictionary<int, Batch>();

// water.Add(1, new Batch("Water1", 5));
// water.Add(2, new Batch("Water2", 10));
// water.Add(3, new Batch("Water3", 20));
// water.Add(4, new Batch("Water4", 50));
// water.Add(5, new Batch("Water5", 100));

// PairsValues(water);
// Console.WriteLine();
// ProductsNames(water);
// Console.WriteLine("\n");
// AmountValues(water);


// void PairsValues(Dictionary<int,Batch> tmp1)
// {
//     foreach(var a in tmp1)
//     {
//         Console.WriteLine($"{a.Value.Name} = {a.Value.Amount}");
//     }
// }
// void ProductsNames(Dictionary<int,Batch> tmp2)
// {
//     foreach(var b in tmp2)
//     {
//         Console.Write($"{b.Value.Name} ");
//     }
// }
// void AmountValues(Dictionary<int,Batch> tmp3)
// {   
//     foreach(var c in tmp3)
//     {
//         Console.Write($"{c.Value.Amount} ");
//     }
// }

//---------------------------- Task 5 -------------------------------


using ConsoleApp1;

var water = new Dictionary<int, Batch>();

water.Add(1, new Batch("Water1", 5));
water.Add(2, new Batch("Water2", 10));
water.Add(3, new Batch("Water3", 20));
water.Add(4, new Batch("Water4", 50));
water.Add(5, new Batch("Water5", 100));

var waterList = new List<string>(water.Count);

string tmp = water[1].Name + " - " + water[1].Amount;
waterList.Add(tmp);

for (int a = 2; a <= water.Count; a++)
{
    tmp = water[a].Name + " - " + water[a].Amount;
    waterList.Add(tmp);
}

Console.WriteLine(string.Join(", ", waterList));

//----

var water1 = new List<Product>()
{
    new Product()
    {
        Name = "Water",
        Price = 50m,
        ProdDate = new DateTime(2023, 04, 15),
        ExpDate = new DateTime(2024, 04, 15)
    },
    new Product()
    {
        Name = "Water1",
        Price = 700m,
        ProdDate = new DateTime(2023, 04, 15),
        ExpDate = new DateTime(2024, 04, 15)
    },
    new Product()
    {
        Name = "Water2",
        Price = 150m,
        ProdDate = new DateTime(2023, 04, 15),
        ExpDate = new DateTime(2024, 04, 15)
    },
    new Product()
    {
        Name = "Water3",
        Price = 250m,
        ProdDate = new DateTime(2023, 04, 15),
        ExpDate = new DateTime(2024, 04, 15)
    },
    new Product()
    {
        Name = "Water4",
        Price = 1500m,
        ProdDate = new DateTime(2023, 04, 15),
        ExpDate = new DateTime(2024, 04, 15)
    }
};

var water1Dictionary = new Dictionary<int, Product>();


for (int c = 0, d = 1; d <= water1.Count; d++, c++)
{
    water1Dictionary.Add(d, water1[c]);
    water1Dictionary[d].DisplayInfo();
}