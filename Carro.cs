using System.Threading;

namespace ExemploEvento1
{
    public class Carro
    {
        public string Telefone { get; set; }

        int qtdTanque = 0;


        //Vamos criar dois DELEGATES:

        public delegate void EventoCarro(); //DELEGATE
        public event EventoCarro TanqueVazio; //que é isso?? EVENT?


        public delegate void Chamar(string textoqualquer); //DELEGATE
        public event Chamar Ligacao;


        public Carro(int qtdGasolina, string telefone)
        {
            this.qtdTanque = qtdGasolina;
            this.Telefone = telefone;
        }

        public void Ligar()
        {
            while(true){
                System.Console.WriteLine("Tanque: " + this.qtdTanque); //usou System aqui pq não declarou USING SYSTEM lá em cima.
                Thread.Sleep(1000);
                this.qtdTanque--;

                if(this.qtdTanque.Equals(3)){
                    this.Ligacao(this.Telefone);
                }


                if(this.qtdTanque.Equals(0)){ //Equals: verificar se o valor é zero
                    this.TanqueVazio(); //Esse evento depende de um DELEGATE em algum lugar.

                    break;
                }
            }
        }
    }
}