using Tyuiu.IvanovEO.Sprint1.Task2.V11.Lib;
DataService ds = new DataService();
Console.WriteLine("Введите количество часов");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество минут");
int y = Convert.ToInt32(Console.ReadLine());
ds.ConvertHoursMinutesToSeconds(x, y);