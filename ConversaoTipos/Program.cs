// Conversão implícita: Conversão automáticamente feita.
//Conversão Explícita: Conversão manualmente feita, onde se assume o risco de perda de dados.

int varInt = 100;
double varDouble = varInt;

System.Console.WriteLine(varDouble);
int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;

//conversões implícitas
System.Console.WriteLine(numeroInt);
System.Console.WriteLine(numeroLong);
System.Console.WriteLine(numeroLong);
System.Console.WriteLine(numeroLong);
System.Console.WriteLine(numeroDecimal);

//Conversão explícita com cast.
//Pode perder dados (precisão).
varDouble = 12.444;
varInt = (int)varDouble;

System.Console.WriteLine(varInt);

int num1 = 2;
int num2 = 3;
// vai fazer a soma em formato int e perder dados. O resultado vai ser 1 ao invés de 1.5
float divisao = num2 / num1;

System.Console.WriteLine(divisao);

Console.ReadLine();