using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.IvanovEO.Sprint1.Task2.V11.Lib
{
    public class DataService : ISprint1Task2V11
    {
        public int ConvertHoursMinutesToSeconds(int value, int valueTwo)
        {
            Console.WriteLine(value * 3600 + valueTwo * 60);
            return value * 3600 + valueTwo * 60;
        }
    }
}
