
using EstacionarApp.Model;
Console.OutputEncoding = System.Text.Encoding.UTF8;


Estacionamento estacionamento = new Estacionamento();

bool verdade = true;

while(verdade)
{
    Console.Clear();
    Console.WriteLine("Seja Bem Vindo(a) ao Estacionamento!");
    Console.WriteLine("Estacione Por R$ 25.00");
    Console.WriteLine("Valor Por Hora 2.00");

    Console.WriteLine();

    Console.WriteLine("Digite a Opção Desejada:");
    Console.WriteLine("1 - Cadastrar Veículo");
    Console.WriteLine("2 - Remover Veículo");
    Console.WriteLine("3 - Listar Veículos");
    Console.WriteLine("4 - Encerrar Programa");

    int opcao = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    switch (opcao)
    {
        case 1:            
            estacionamento.AdicionarVeiculo();
            break;
        case 2:            
            estacionamento.RemoverVeículo();
            break;
        case 3:
            estacionamento.ListarVeículo();    
            break;
        case 4:
            verdade = false;            
            break;
        default:
            Console.WriteLine("Opção Inválida! Tente Novamente.");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}
Console.WriteLine("Programa Encerrado!");


