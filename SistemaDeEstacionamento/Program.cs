using SistemaDeEstacionamento.Models;

Estacionamento estacionamento = new();

Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!");
Console.WriteLine("Digite o preço inicial: ");
estacionamento.PrecoInicial = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o preço por hora: ");
estacionamento.PrecoHora = Convert.ToDouble(Console.ReadLine());

Console.Clear();

int opcao = 0;
string menu = "Digite a sua opção:\n1 - Cadastrar veículo \n2 - Remover veículo \n3 - Lista veículos \n4 - Encerrar";
List<string> placas = [];

do
{
    Console.WriteLine(menu);
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Digite a placa do veículo para continuar:");
            placas.Add(Console.ReadLine());
            break;

        case 2:
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();
            placas.Remove(placa);

            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            int quantidadeHoras = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R${estacionamento.PrecoInicial + estacionamento.PrecoHora * quantidadeHoras:N2}");
            break;

        case 3:
            Console.WriteLine("Os veículos estacionados são:");
            placas.ForEach(Console.WriteLine);
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar.");
    Console.ReadKey();
    Console.Clear();
    
} while (opcao != 4);

Console.WriteLine("Programa encerrado.");