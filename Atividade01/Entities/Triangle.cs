using Atividade01.Utils;

namespace Atividade01.Entities
{
    internal class Triangle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Triangle(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public bool IsTriangle()
        {
            return (X + Y > Z && X + Z > Y && Y + Z > X);
        }

        public string TriangleType()
        {
            if (!IsTriangle())
            {
                return " Triângulo inválido, as medidas informadas não formam um triângulo.";
            }
            else if (X == Y && Y == Z)
            {
                return " Este é um triângulo Equilátero!";
            }
            else if (X == Y || X == Z || Y == Z)
            {
                return " Este é um triângulo Isósceles!";
            }
            else
            {
                return " Este é um triângulo Escaleno!";
            }
        }

        public static void NewTriangle()
        {
            Console.Clear();
            Interface.TriangleTitleMenu();
            double value1, value2, value3;

            Console.Write(" Digite o 1º lado do triângulo: ");
            value1 = Validators.IsDouble(Console.ReadLine());

            Console.Write(" Digite o 2º lado do triângulo: ");
            value2 = Validators.IsDouble(Console.ReadLine());

            Console.Write(" Digite o 3º lado do triângulo: ");
            value3 = Validators.IsDouble(Console.ReadLine());

            Triangle triangle = new Triangle(value1, value2, value3);
            string type = triangle.TriangleType();

            Console.WriteLine();
            Console.WriteLine(type);
            Console.WriteLine();
            Console.Write(" Pressione Enter para voltar ao menu principal ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
