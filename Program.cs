Console.WriteLine("[Tela adm] - Bem vindo ao sistema de estacionamento");
Console.WriteLine("Digite o preço inicial de cobrança:");
Decimal precoInicial = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite o preço cobrado por hora:");
Decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());
string placaDoCarro = "";
int opcao = 0;
int tempoEstacionado = 0;
List<string> cadastroDeCarros = new List<string>();

while(opcao != 4)
{
    Console.Clear();
    Console.WriteLine("Opções válidas:");
    Console.WriteLine("1. Cadastrar veículo");
    Console.WriteLine("2. Remover veículo");
    Console.WriteLine("3. Listar veículos");
    Console.WriteLine("4. Encerrar");
    Console.WriteLine("Digite o numero da opção: ");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch(opcao)
    {
        case 1:
            Console.WriteLine("Digite a placa do carro que deseja cadastrar");
            placaDoCarro = Console.ReadLine();
            cadastroDeCarros.Add(placaDoCarro);
            Console.WriteLine("Carro cadastrado com sucesso!\n");
            System.Threading.Thread.Sleep(2000);
            break;
        case 2:
            Console.WriteLine("Digite a placa do carro que deseja remover");
            placaDoCarro = Console.ReadLine();
            while(cadastroDeCarros.IndexOf(placaDoCarro) < 0)
            {
                Console.WriteLine("Placa não encontrada... Digite novamente:");
                placaDoCarro = Console.ReadLine();
            }
            Console.WriteLine("Quantas horas o carro passou estacioando?");
            tempoEstacionado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Total a pagar = R${precoInicial + (precoPorHora * tempoEstacionado)}");
            cadastroDeCarros.Remove(placaDoCarro);
            Console.WriteLine("Carro removido com sucesso\n");
            System.Threading.Thread.Sleep(2000);
            break;
        case 3:
            Console.WriteLine("Os carros estacionados são:");
            foreach (string carros in cadastroDeCarros)
            {
                Console.WriteLine(carros);
            }
            Console.WriteLine();
            System.Threading.Thread.Sleep(2000);
            break;
        case 4:
            Console.WriteLine("Programa encerrado\n");
            break;
        
        default:
            Console.WriteLine("Opção inválida!\n");
            System.Threading.Thread.Sleep(2000);
            break;
    }
}