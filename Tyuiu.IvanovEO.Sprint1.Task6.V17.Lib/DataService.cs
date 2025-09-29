using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.IvanovEO.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {
            string s = new string(value.ToLower().Where(char.IsLetterOrDigit).ToArray());
            return s.SequenceEqual(s.Reverse());

        }
    }
}
