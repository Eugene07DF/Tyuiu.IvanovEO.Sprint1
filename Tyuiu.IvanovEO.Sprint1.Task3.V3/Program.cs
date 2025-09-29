using Tyuiu.IvanovEO.Sprint1.Task3.V3.Lib;
Console.WriteLine("Введите длинну");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите ширину");
double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите высоту");
double z = Convert.ToDouble(Console.ReadLine());
DataService ds = new DataService();
Console.WriteLine(Math.Round(ds.ParallelepipedVolume(x,y,z), 3));
