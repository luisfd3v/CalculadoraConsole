Console.WriteLine("Por favor, digite o primeiro número: ");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Por favor, digite o segundo número: ");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a operação (+, -, *, /): ");
string operacao = Console.ReadLine();

double resultado = 0;

switch (operacao)
{
    case "+":
        resultado = numero1 + numero2;
        break;
    case "-":
        resultado = numero1 - numero2;
        break;
    case "*":
        resultado = numero1 * numero2;
        break;
    case "/":
        resultado = numero1 / numero2;
        break;
    default:
        Console.WriteLine("Operação inválida.");
        return;
}

Console.WriteLine($"O resultado é: {resultado}");