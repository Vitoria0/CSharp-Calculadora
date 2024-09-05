namespace Main
{
    class Program
    {

        static void Main(string[] args)
        {
            Menu();
        }

        public static void Soma()
        {
            Console.WriteLine("Soma");
            int num1, num2;
            Console.WriteLine("Insira o primeiro valor:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O resultado da soma é: " + (num1 + num2));
            Menu();
        }

        public static void Subtrair()
        {
            Console.WriteLine("Subtrair");
            int num3, num4;
            Console.WriteLine("Insira o primeiro valor:");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor:");
            num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O resultado da subtração é: " + (num3 - num4));
            Menu();
        }

        public static void Multiplicar()
        {
            Console.WriteLine("Multiplicar");
            int num5, num6;
            Console.WriteLine("Insira o primeiro valor:");
            num5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor:");
            num6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O resultado da multiplicação é: " + (num5 * num6));
            Menu();
        }

        public static void Dividir()
        {
            Console.WriteLine("Dividir");
            int num7, num8;
            Console.WriteLine("Insira o primeiro valor:");
            num7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor:");
            num8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O resultado da divisão é: " + (num7 / num8));
            Menu();
        }

        public static void Sair()
        {
            Console.WriteLine("Sair");
            Environment.Exit(0);
        }

        public static void Menu()
        {
            string operacao;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Escolha um tipo de operação:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Sair");

            operacao = Console.ReadLine();

            Console.Clear();

            switch (operacao)
            {
                case "1": Soma(); break;
                case "2": Subtrair(); break;
                case "3": Multiplicar(); break;
                case "4": Dividir(); break;
                case "5": Sair(); break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    Menu();
                    break;
            }
        }

    }
}
