using Tyuiu.IvanovEO.Sprint1.Task5.V6.Lib;
Console.WriteLine("Введи n");
int n = Convert.ToInt32(Console.ReadLine());
DataService ds  = new DataService();
Console.WriteLine(ds.Calculate(n));