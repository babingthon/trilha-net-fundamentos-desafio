namespace DesafioFundamentos.Models;
class Estacionamento
{
    private decimal precoInicial;
    private decimal precoPorHora;
    private List<string> veiculos;

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
        this.veiculos = new List<string>();
    }

    public void AdicionarVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para estacionar:");
        string placa = Console.ReadLine();
        veiculos.Add(placa);
        Console.WriteLine($"Veículo com placa {placa} foi estacionado com sucesso!");
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para remover:");
        string placa = Console.ReadLine();

        if (veiculos.Remove(placa))
        {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            if (int.TryParse(Console.ReadLine(), out int horas))
            {
                decimal valorTotal = precoInicial + precoPorHora * horas;
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Número de horas inválido.");
            }
        }
        else
        {
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
        }
    }

    public void ListarVeiculos()
    {
        if (veiculos.Count == 0)
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
        else
        {
            Console.WriteLine("Os veículos estacionados são:");
            foreach (var v in veiculos)
            {
                Console.WriteLine(v);
            }
        }

    }
}

