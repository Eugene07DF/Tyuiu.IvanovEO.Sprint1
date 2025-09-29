using Tyuiu.IvanovEO.Sprint1.Task6.V17.Lib;
Console.WriteLine("Введите строку");
string str = Console.ReadLine();
DataService ds =  new DataService();
Console.WriteLine(ds.CheckPalindrome(str));
