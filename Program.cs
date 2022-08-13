Console.Clear();
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Bem vindo a Kalculator!");
Console.WriteLine("_______________________________________________ \n");

Menu();

static void Menu()
{
  Console.Clear();
  Console.WriteLine("O que deseja fazer?");
  Console.WriteLine("1 - Soma");
  Console.WriteLine("2 - Subtração");
  Console.WriteLine("3 - Multiplicação");
  Console.WriteLine("4 - Divisão");
  Console.WriteLine("5 - Sair");
  Console.WriteLine("_______________________________________________ \n");
  Console.Write("Digite a opção desejada: ");
  short opcao = short.Parse(Console.ReadLine());
  if (opcao == 5) Environment.Exit(0);

  Console.Clear();
  Console.WriteLine("_______________________________________________ \n");
  Console.WriteLine("Digite os dois números que deseja calcular: ");

  Console.Write("Digite o primeiro número: ");
  float num1 = float.Parse(Console.ReadLine());
  Console.Write("Digite o segundo número: ");
  float num2 = float.Parse(Console.ReadLine());
  Console.WriteLine("_______________________________________________ \n");
  Console.WriteLine("Processando...: ");
  Console.Clear();

  switch (opcao)
  {
    case 1: Soma(num1, num2); break;
    case 2: Subtracao(num1, num2); break;
    case 3: Multiplicacao(num1, num2); break;
    case 4: Divisao(num1, num2); break;
    default:
      Console.WriteLine("Opção inválida!");
      Menu(); break;
  }
}

static void Soma(float num1, float num2)
{
  var result = num1 + num2;
  Console.WriteLine($"O Resultado da Soma é: {result}");
  Console.ReadKey();
}

static void Subtracao(float num1, float num2)
{
  var result = num1 - num2;
  Console.WriteLine($"O Resultado da Subtração é: {result}");
  Console.ReadKey();
}

static void Divisao(float num1, float num2)
{
  var result = num1 / num2;
  Console.WriteLine($"O Resultado da Divisão é: {result}");
}

static void Multiplicacao(float num1, float num2)
{
  var result = num1 * num2;
  Console.WriteLine($"O Resultado da Multiplicação é: {result}");
}