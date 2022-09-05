using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace EstacionarApp.Model
{
    public class Estacionamento
    {
        public decimal ValorEstacionamento { get; set; }
        public decimal ValorPorHora { get; set; }

        public List<string> veiculos = new List<string>();

        public Estacionamento()
        {
            this.ValorEstacionamento = 25;
            this.ValorPorHora = 2;
        }

        public void AdicionarVeiculo()
        {            
           Console.WriteLine("Digite a placa do veículo para adicionar: ");
           string placa = Console.ReadLine().ToUpper();
           Console.WriteLine();

           if(!placa.Equals(""))
           {
                veiculos.Add(placa);
                Console.WriteLine("Placa Adicionada!");
            }
           else
           {
                Console.WriteLine("Informe a Placa para Continuar!");
           }
        }

        public void RemoverVeículo()
        {
            Console.WriteLine("Digite a placa do veículo para remover: ");
            string placa = Console.ReadLine().ToUpper();
            Console.WriteLine();

            decimal valorTotal = 0;

            if(!placa.Equals(""))
            {
                if (veiculos.Contains(placa))
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu no estacionamento: ");
                    int qtdHoras = Convert.ToInt32(Console.ReadLine());

                    valorTotal = this.ValorEstacionamento + this.ValorPorHora * qtdHoras;

                    veiculos.Remove(placa);

                    Console.WriteLine($"O Veículo {placa} foi Removido com sucesso!");
                    Encerrar(valorTotal);
                }
                else
                {
                    Console.WriteLine("Não há veículo cadastrado com esta placa! Tente Novamente.");
                }
            }
            else
            {
                Console.WriteLine("Informe a Placa para Continuar!");
            }

            
        }

        public void ListarVeículo()
        {            
           if(veiculos.Count > 0)
           {
                for(int i=0; i < veiculos.Count; i++)
                {                    
                    Console.WriteLine($"{i+1} - {veiculos[i]}");
                }
                Console.WriteLine();
            }
           else
           {
                Console.WriteLine("Não há veículos cadastrados!");
           }
        }

        public void Encerrar(decimal total)
        {   
            Console.WriteLine($"Valor do Estacionamento: R$ {ValorEstacionamento}");
            Console.WriteLine($"Valor Por Hora: R$ {ValorPorHora}");
            Console.WriteLine($"Valor Total: R$ {total}");
        }
    }
}
