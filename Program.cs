using System;

namespace Calculator
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.Clear();
            Menu();


        }
        public static void Menu()
        {
            int opcao = 1;
            while (opcao !> 0)
            {
                Console.WriteLine("[1]: Soma");
                Console.WriteLine("[2]: Subtração");
                Console.WriteLine("[3]: Multiplicação");
                Console.WriteLine("[4]: Divisão");
                Console.WriteLine("[5]: Exponenciação");
                Console.WriteLine("[6]: Raiz Quadrada");
                Console.WriteLine("[0]: Sair");
                Console.Write("Selecione a operação que deseja realizar: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Informe o primeiro valor: ");
                        float valor1 = float.Parse(Console.ReadLine());

                        Console.Write("");
                        Console.Write("Informe o segundo valor: ");
                        float valor2 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Resultado: " + Soma(valor1, valor2));
                        Console.Write("");
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Informe o primeiro valor: ");
                        valor1 = float.Parse(Console.ReadLine());

                        Console.Write("");
                        Console.Write("Informe o segundo valor: ");
                        valor2 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Resultado: " + Subtracao(valor1, valor2));
                        Console.Write("");
                        break;

                    case 3:
                        Console.Clear();
                        Console.Write("Informe o primeiro valor: ");
                        valor1 = float.Parse(Console.ReadLine());

                        Console.Write("");
                        Console.Write("Informe o valor que deseja multiplicar: ");
                        valor2 = float.Parse(Console.ReadLine());

                        
                        Console.WriteLine("Resultado: " + Multiplicacao(valor1, valor2));
                        Console.Write("");
                        break;

                    case 4:
                        Console.Clear();
                        Console.Write("Informe o primeiro valor: ");
                        valor1 = float.Parse(Console.ReadLine());

                        Console.Write("");
                        Console.Write("Informe o valor que deseja dividir: ");
                        valor2 = float.Parse(Console.ReadLine());

                        
                        Console.WriteLine("Resultado: " + Divisao(valor1, valor2));
                        Console.Write("");
                        break;

                    case 5:
                        Console.Clear();
                        Console.Write("Informe o valor que deseja elevar: ");
                        valor1 = float.Parse(Console.ReadLine());

                        Console.Write("");
                        Console.Write("Informe a quanto deseja elevar: ");
                        valor2 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Resultado: " + Exponenciacao((double)valor1, (double)valor2));
                        Console.Write("");
                        break;

                    case 6:
                        Console.Clear();
                        Console.Write("Informe o valor que deseja obter a raiz quadrada: ");
                        valor1 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Resultado: " + RaizQuadrada((double)valor1));
                        Console.Write("");
                        break;

                    case 0:
                        Console.Write("Finalizando calculadora...");
                        break;

                    default: 
						Console.WriteLine("Opção digitada inválida!");
						break;

                }
            }
        }

        public static float Soma(float v1, float v2)
        {
            return v1 + v2;
        }

        public static float Subtracao(float v1, float v2)
        {
            return v1 - v2;
        }

        public static float Multiplicacao(float v1, float v2)
        {
            return v1 * v2;
        }

        public static float Divisao(float v1, float v2)
        {
            return v1 / v2;
        }

        public static double Exponenciacao(double v1, double v2)
        {
            return Math.Pow(v1, v2);
        }

        public static double RaizQuadrada(double v1)
        {
            return Math.Round(Math.Sqrt(v1));
        }

    }
}