namespace Atividade01.Utils
{
    internal class Interface
    {
        public static void MainTitle() 
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("  Bem vindo ao Jogo dos Triângulos! ");
            Console.WriteLine("=====================================");           
        }

        public static void MainMenu() 
        {
            Console.WriteLine("==============================");
            Console.WriteLine("     O que deseja fazer?");
            Console.WriteLine("==============================");
            Console.WriteLine("-----------------------------");
            Console.WriteLine(" 1 - Verificar um triângulo.");
            Console.WriteLine(" 2 - Sair do programa.");
            Console.WriteLine("-----------------------------");            
            Console.Write(" Escolha uma opção: "); 
        }

        public static void TriangleTitleMenu() 
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("   Vamos começar com as medidas! ");
            Console.WriteLine("=====================================");            
        }

        public static void WrongOption() 
        {            
            Console.Write(" Opção inválida! Digite novamente: ");            
        }

        public static void WrongValue()
        {
            Console.Write(" Valor inválido! Digite novamente: ");
        }

        public static void Goodbye() 
        {
            Console.WriteLine();
            Console.WriteLine(" Até a próxima!");
            Console.WriteLine();
        }
    }
}
