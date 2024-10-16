Console.WriteLine("## Struct DateTime");

DateTime dataAtual = DateTime.Now;
Console.WriteLine("Data atual: " + dataAtual);
Console.ReadKey();

//Cria uma data específica
DateTime dataHoje = new DateTime(2022, 09, 06);
Console.WriteLine(dataHoje);
Console.ReadKey();

//Definir as horas
DateTime dataHoraHoje = new DateTime(2022, 09, 06, 23, 33, 01);
Console.WriteLine(dataHoraHoje);

//Outras informações da data atual.

DateTime hoje = DateTime.Now;
Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Day);
Console.WriteLine(hoje.Minute);
Console.WriteLine(hoje.Second);
Console.WriteLine(hoje.Millisecond);

//Adicionando valores.

Console.WriteLine(hoje.AddDays(30));
Console.WriteLine(hoje.AddMonths(1));
Console.WriteLine(hoje.AddHours(2));
Console.WriteLine(hoje.AddYears(1));

//Data no formato longo e curo
Console.WriteLine(hoje.ToLongDateString);
Console.WriteLine(hoje.ToShortDateString);

Console.WriteLine(hoje.ToLongTimeString);
Console.WriteLine(hoje.ToShortTimeString);