int valorInt = 23; 
string s1 = valorInt.ToString();

string num1 = "13";
double valorDouble = 5.35;
bool valorBool = true;

// int num = num1.toInt();
//Class Convert
System.Console.WriteLine(Convert.ToString(valorInt));
System.Console.WriteLine(Convert.ToDouble(valorInt));
System.Console.WriteLine(Convert.ToString(valorBool));
System.Console.WriteLine(Convert.ToInt32(valorDouble));
Console.WriteLine(Convert.ToString(valorBool));

//OverflowException = Estourar capacidade de dados.
int varInt = 100000;
System.Console.WriteLine(Convert.ToByte(varInt));
Console.WriteLine(num1);

Console.ReadKey();
