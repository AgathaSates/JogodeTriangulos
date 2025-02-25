using Atividade01.Utils;

namespace Atividade01.Entities
{
    internal class Validators
    {
        public static int IsInt(int min, int max) 
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out  number) || number < min || number > max)
            {
                Interface.WrongOption();
            }
            return number;
        }

        public static double IsDouble(string number) 
        {
            double value;
            number = number.Replace(',','.');
            while (!double.TryParse(number , out  value ) || value <= 0) 
            {
                Interface.WrongValue();
                number = Console.ReadLine().Replace(',', '.');
            }
            return value;
        }        
    }
}
