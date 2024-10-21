//São tipos de referência nulas 
//Tipos de referência anulaveis

//Solução para poder resolver o problema e impedir
//que o NullableReferenceException ocorra.

string? nome = null;
Console.WriteLine(nome?.ToUpper());

Console.ReadLine();