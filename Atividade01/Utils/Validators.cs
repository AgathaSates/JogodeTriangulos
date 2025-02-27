namespace Atividade01.Utils
{
    internal class Validators
    {
        public static int IsInt(int min, int max)
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < min || number > max)
            {
                Write.WrongOption();
            }
            return number;
        }

        public static double IsDouble(string number)
        {
            double value;
            number = number.Replace(',', '.');
            while (!double.TryParse(number, out value) || value <= 0)
            {
                Write.WrongValue();
                number = Console.ReadLine().Replace(',', '.');
            }
            return value;
        }
    }
}
