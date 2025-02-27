namespace Atividade01.Utils
{
    internal class Write
    {
        public static void MainTitle() 
        {
            Color.SetColorPhraseDarkCyan(" =====================================");
            Color.SetColorPhraseDarkCyan("   Bem vindo ao Jogo dos Triângulos! ");
            Color.SetColorPhraseDarkCyan(" =====================================");
            Console.WriteLine();
            Color.SetColorPhraseDarkYellow(" -> Enter para entrar no jogo ");
            Console.ReadKey();
            Console.Clear();
        }

        public static void MainMenu() 
        {
            Color.SetColorPhraseDarkCyan(" ==============================");
            Color.SetColorPhraseDarkCyan("      O que deseja fazer?");
            Color.SetColorPhraseDarkCyan(" ==============================");
            Color.SetColorPhraseMenuYellow(" -----------------------------");
            Color.SetColorPhraseMenuYellow("  1 - Verificar um triângulo.");
            Color.SetColorPhraseMenuYellow("  2 - Sair do programa.");
            Color.SetColorPhraseMenuYellow(" -----------------------------");            
            Color.SetColorPhraseDarkYellow(" -> Escolha uma opção: "); 
        }

        public static void TriangleTitleMenu() 
        {
            Color.SetColorPhraseDarkCyan(" =====================================");
            Color.SetColorPhraseDarkCyan("    Vamos começar com as medidas! ");
            Color.SetColorPhraseDarkCyan(" =====================================");
            Console.WriteLine();
        }

        public static void WrongOption() 
        {            
           Color.SetColorPhraseDarkRed(" -> (X) Opção inválida! Digite novamente: ");            
        }

        public static void WrongValue()
        {
            Color.SetColorPhraseDarkRed(" -> (X) Valor inválido! Digite novamente: ");
        }

        public static void Goodbye() 
        {
            Console.Clear();
            Console.WriteLine( );
            Color.SetColorPhraseDarkCyan(" ---------------------");
            Color.SetColorPhraseDarkCyan("  Até a próxima!  0/ ");
            Color.SetColorPhraseDarkCyan(" ---------------------");
        }
    }
}
