//Fast Park
using FastPark.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

string mensagemDeBoasVindas = "\nOlá, boas vindas ao Fast Park";
decimal precoInicial = 0;
decimal precoPorHora = 0;

void ExibirLogo()
{
    Console.WriteLine(@"
█▀▀ ▄▀█ █▀ ▀█▀   █▀█ ▄▀█ █▀█ █▄▀
█▀░ █▀█ ▄█ ░█░   █▀▀ █▀█ █▀▄ █░█");
    Console.WriteLine(mensagemDeBoasVindas);
}

    //Input usuário do preço inicial
    
    ExibirTituloDaOpcao("Registro dos Preços");
    Console.WriteLine("Digite o preço inicial: R$");
    precoInicial = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine($"\nO valor R${precoInicial} foi registrado com sucesso!");

    //Input usuário do preço por hora
    Console.WriteLine("\nDigite o preço por hora: R$");
    precoPorHora = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine($"\nO valor R${precoPorHora} foi registrado com sucesso!");

    Console.WriteLine("\nDigite uma tecla para votar ao menu principal");
    Console.ReadKey();
    Console.Clear();

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new(precoInicial, precoPorHora);

void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para cadastrar um veículo");
    Console.WriteLine("Digite 2 para remover um veículo");
    Console.WriteLine("Digite 3 para exibir os veículos estacionados");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            es.AdicionarVeiculo();
            ExibirMenu();
            break;
        case 2:
            es.RemoverVeiculo();
            ExibirMenu();
            break;
        case 3:
            es.ListarVeiculos();
            ExibirMenu();
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            ExibirMenu();
            break;
    }
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

ExibirMenu();