namespace DesafioFundamentos.Models
{
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
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string? placa = Console.ReadLine();

                if(!string.IsNullOrEmpty(placa))
                {
                veiculos.Add(placa);
                Console.WriteLine("Seu veiculo foi adicionado com sucesso!");
                } else
                {
                Console.WriteLine("Insira uma Placa válida");
                }
            
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string? placa = Console.ReadLine();           

            if (!string.IsNullOrEmpty(placa))
            {
                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    int horas = 0;
                    decimal valorTotal = 0; 
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                    horas = Convert.ToInt32(Console.ReadLine());

                    valorTotal = precoInicial + (precoPorHora * horas);
                
                
                    veiculos.Remove(placa);
                

                    Console.WriteLine($"O veículo de placa: {placa}, gerou um valor total de: R$ {valorTotal}");
                }
                else
                {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (string automovel in veiculos)
                {
                    Console.WriteLine($"{automovel}");
                }
                
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
