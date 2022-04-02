int deno, nume;
double  resultado;

Console.Write("\nDigite o numerador: ");
nume = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o denominador: ");
deno = Convert.ToInt32(Console.ReadLine());

bool zero = deno == 0;

if (zero)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nNão é possivel dividir por 0!");
    Console.ResetColor();
}
else
{
    resultado = nume / deno;
    Console.WriteLine($"\n{nume} dividido por {deno} é igual a {resultado}");
}