Console.Clear();
Console.ForegroundColor = ConsoleColor.Black;
string senhaDigitada;
string senhaCorreta = "123abc";

Console.Write("Digite sua Senha : ");
senhaDigitada = Console.ReadLine()!;

bool acertou = senhaDigitada == senhaCorreta;

if(acertou)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Senha Correta!!!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ERROOOOOUUUUUUU!!!");
};
Console.ResetColor();
