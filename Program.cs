using Estacionamento.Entidades;
using Estacionamento.Servicos;
using System.Globalization;


string modeloDeData = "dd/MM/yyyy HH:mm";
Console.WriteLine("Entre com os dados do aluguel");
Console.Write("Modelo do carro: ");
string modelo = Console.ReadLine();
Console.Write("Entrada (dd/MM/yyyy hh:mm): ");
DateTime entrada = DateTime.ParseExact(Console.ReadLine(), modeloDeData, CultureInfo.InvariantCulture);
Console.Write("Saida (dd/MM/yyyy hh:mm): ");
DateTime saida = DateTime.ParseExact(Console.ReadLine(), modeloDeData, CultureInfo.InvariantCulture);

Console.Write("Entre com o valor por hora: ");
double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Entre com o valor por dia: ");
double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

AluguelCarro aluguelCarro = new AluguelCarro(entrada, saida, new Veiculo(modelo));

ServicoDeAluguel servicoDeAluguel = new ServicoDeAluguel(hora, dia);

servicoDeAluguel.ProcessoDePagamento(aluguelCarro);

Console.WriteLine("Fatura: ");
Console.WriteLine(aluguelCarro.Fatura);
Console.WriteLine("Periodo: " + servicoDeAluguel.Periodo);
