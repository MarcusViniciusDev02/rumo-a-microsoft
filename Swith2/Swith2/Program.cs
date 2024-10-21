string mes = Console.ReadLine().ToLower();

//Posso colocar varias cases para chegar a uma resolução.
switch (mes)
{
    case "janeiro":
    case "março":
    case "maior":
    case "junho":
    case "julho":
    case "agosto":
    case "outubro":
    case "novembro":
    case "dezembro":
        Console.WriteLine("Este mês possui 31 dias.");
        break;
    case "fevereiro":
        Console.WriteLine("Este mês possui 28 ou 29 dias.");
        break;
    default:
        Console.WriteLine("Entrada inválida");
        break;
}

//Switch aninhado

int cargo = 0;
int funcao = 0;
Console.WriteLine("Qual o seu cargo? gerente = (1) | programador = (2)");
cargo = Convert.ToInt32(Console.ReadLine());
switch (cargo)
{
    case 1:
        Console.WriteLine("Seja bem vindo gerente!");
        break;
    case 2:
        Console.WriteLine("Qual a sua função? jr = (1) | sr = (2)");
        funcao = Convert.ToInt32(Console.ReadLine());
        switch (funcao)
        {
            case 1:
                Console.WriteLine("Seja bem vindo juninho!");
                break;
            case 2:
                Console.WriteLine("Seja bem vindo patrão");
                break;
            default:
                Console.WriteLine("Tu é nada, sai daqui!");
                break;
        }
        break;
    default:
        Console.WriteLine("Tu trabalha aqui?");
        break;
}