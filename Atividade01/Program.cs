using Atividade01.Entities;
using Atividade01.Utils;

namespace Atividade01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write.MainTitle();
            while (true)
            {
                Write.MainMenu();
                int menuOption = Validators.IsInt(1, 2);
                switch (menuOption) 
                {
                    case 1: Triangle.NewTriangle(); break;
                    case 2: Write.Goodbye(); return;
                }                              
            }
        }
    }
}
