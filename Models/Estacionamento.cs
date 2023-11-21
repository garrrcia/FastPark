namespace FastPark.Models
{
    //classe Estacionamento --> de acordo com o diagrama
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Cadastro de veículos");
            Console.WriteLine("Digite a placa do veículo:");
            string placa = Console.ReadLine()!;
            veiculos.Add(placa);
            Console.WriteLine($"\nA placa {placa} foi registrada com sucesso!\n");

            Console.WriteLine("\nDigite uma tecla para votar ao menu principal");
            Console.ReadKey();
            Console.Clear();
           
        }

        public void RemoverVeiculo()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Saída de veículos");
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine()!;


            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                string InputHora = Console.ReadLine()!;
                decimal horas = Convert.ToDecimal(InputHora);

                decimal valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa.ToUpper());

                Console.WriteLine($"O veículo de placa{placa} foi removido");
                Console.WriteLine($"o valor total foi {valorTotal}");
                Console.WriteLine("\nDigite uma tecla para votar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Veículos estacionados");
            // Verifica se há veículos no estacionamento
            if (veiculos.Count != 0)
            {
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine($"Os veículos estacionados são: {veiculo}");
                }
                Console.WriteLine("\nDigite uma tecla para votar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
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
    }
}