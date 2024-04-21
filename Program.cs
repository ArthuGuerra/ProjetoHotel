using System.Globalization;
using ProjetoHotelDIO.Entities;
//using 

Console.WriteLine("olá, bem vindos ao Hotel Maravilla!");
Console.WriteLine("Por favor, coloque quantas pessoas irão ficar no quarto");
List<Pessoa> list = new List<Pessoa>();
try
{
int n = int.Parse(Console.ReadLine());

for(int i =1; i <= n; i++)
{

    Console.WriteLine($"Nome: ");
    string nome = Console.ReadLine();
    Console.WriteLine($"");

    Console.WriteLine($"SobreNomes");
    string sobreNome = Console.ReadLine();
    Console.WriteLine($"");

    Console.WriteLine($"Email: ");
    string email = Console.ReadLine();
    Console.WriteLine($"");

    Console.WriteLine($"Cidade Origem:");
    string cidade = Console.ReadLine();
    Console.WriteLine($"");

    Pessoa p1 = new Pessoa(nome,sobreNome,email,cidade);
    list.Add(p1);
    
}

Suite suite = new Suite("Premium", 2, 300.00M); 

Console.WriteLine($"Coloque quantas diárias irão ficar");
int dias = int.Parse(Console.ReadLine());
Console.WriteLine($"");
Reserva reserva = new Reserva(dias);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(list);
Console.WriteLine($"");
Console.WriteLine(reserva.ToString());
Console.WriteLine($"");
Console.WriteLine($"Valor Cobrado na diária: R${suite.ValorDiaria.ToString("F2",CultureInfo.InvariantCulture)}");
Console.WriteLine($"Valor Total: R${reserva.CalcularValorDiaria().ToString("F2",CultureInfo.InvariantCulture)}");


} catch(FormatException e )
{
    Console.WriteLine("formato inválido - " + e.Message);
}
catch(Exception e)
{
    Console.WriteLine("Algum erro genérico identificado - " + e.Message);
}



