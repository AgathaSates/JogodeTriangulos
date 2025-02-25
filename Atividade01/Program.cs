using Atividade01.Entities;
using Atividade01.Utils;

namespace Atividade01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interface.MainTitle();
            while (true)
            {
                Interface.MainMenu();
                int menuOption = Validators.IsInt(1, 2);
                switch (menuOption) 
                {
                    case 1: Triangle.NewTriangle(); break;
                    case 2: Interface.Goodbye(); return;
                }                              
            }
        }
    }
}
