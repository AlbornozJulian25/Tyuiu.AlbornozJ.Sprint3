
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AlbornozJ.Sprint3.Task3.V17.Lib
{
    public class DataService : ISprint3Task3V17
    {
        public int ConvertStringToInt(string value)
        {
            string numbersOnly = "";

            foreach (char chr in value)
            {
                if (chr >= '0' && chr <= '9')
                {
                    numbersOnly += chr;
                }
            }

            return int.Parse(numbersOnly);
        }
    }
}
