using System;

namespace ExemploEvento1
{
    class Program
    {

        static void tanque_vazio(){
            Console.WriteLine("Tanque vazio.");
        }
        static void ligar_uber(){
            Console.WriteLine("Chamando Uber.");
        }
        static void ligar_casa(string telefone){
            Console.WriteLine("Combustível acabando - ligar para: "+ telefone);
        }


        static void Main(string[] args)
        {
            Carro carro = new Carro(10, "11 45463452345-235345234532"); // instanciando meu novo carro com 10L de gasolina (qtdGasolina) e telefone
            carro.TanqueVazio += new Carro.EventoCarro(tanque_vazio); // 
            carro.TanqueVazio += new Carro.EventoCarro(ligar_uber);
            carro.Ligacao += new Carro.Chamar(ligar_casa);
            carro.Ligar();
        }
    }
}
