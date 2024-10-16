//Nullable Type


//Covalência.
using System.Xml;

int? i = null;
int b = i ?? 0;
Console.WriteLine(b);

// Expressões com nulable;
int? x = 4;
int? y = 3;
int? z = x * y;

Console.WriteLine(z);

//HasValue e Value
//Hasvalue = Checa se um objeto tem valor;
//Value = exibe valor;

int? bb = null;

if (bb.HasValue)
{
    Console.WriteLine($"bb = {bb.Value}"); //Caso possua valor, será exibido.
}
else
{
    Console.WriteLine($"bb não possui valor"); //Caso null será exibido
}

Console.ReadKey();