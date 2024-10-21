// Multiplas expressões no bloco for.
for(int i = 0, j = 0; i + j <= 10; i++, j++)
{
    Console.WriteLine($"i = {i} e j = {j}");
}

//Loop for aninhados
//Exemplo = tabuada.
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10;  j ++)
    {
        int multiplicacao = i * j;
        Console.WriteLine($"{i} * {j} = {multiplicacao}");
    }
}

