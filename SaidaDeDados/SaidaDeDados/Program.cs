//Saída de dados.

int idade = 25;
String nome = "Maria";

Console.Write(nome);//Escreve, mas não pula linha.
Console.WriteLine(idade); //Escreve uma linha e pula para outra.

// Melhor forma de escrever. (Interpolação)
Console.WriteLine($"{nome} tem {idade} anos.");

//PlaceHolders
Console.WriteLine("{0} tem {1} anos.", nome, idade);
