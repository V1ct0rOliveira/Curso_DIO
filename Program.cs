using System;
using System.Threading.Tasks.Dataflow;

class Program{
    public static void Main(){
        Console.WriteLine("----------------------------");
        Console.WriteLine("| Sistema de Rank Valorant |");
        Console.WriteLine("----------------------------");
        Console.WriteLine("");

        String nome;
        float rank;

        Console.Write("Digite Seu nome: ");
        nome = Console.ReadLine();
        Console.Write("\nDigite seu Nível(1 a 10.001, Digitar o rank sem o '.'): ");
        rank = float.Parse(Console.ReadLine());

        if(rank <= 1000){
            Console.WriteLine("\nO Heroi " + nome + " Está no nivel Ferro");
        }
        else if(rank >= 1001 && rank <= 2000){
            Console.WriteLine("\nO Heroi " + nome + " Está no nivel Bronze");
        }
        else if(rank >= 2001 && rank <= 4000){
            Console.WriteLine("\nO Heroi " + nome + " Está no nivel Prata");
        }
        else if(rank >= 4001 && rank <= 6000){
            Console.WriteLine("\nO Heroi " + nome + " Está no nivel Ouro");
        }
        else if(rank >= 6001 && rank <= 7000){
            Console.WriteLine("\nO Heroi " + nome + " Está no nivel Platina");
        }
        else if(rank >= 7001 && rank <= 8000){
            Console.WriteLine("\nO Heroi " + nome + " Está no nivel Diamante");
        }
        else if(rank >= 8001 && rank <= 9000){
            Console.WriteLine("\nO Heroi " + nome + " Está no nivel Ascendente");
        }
        else if(rank >= 9001 && rank <= 10000){
            Console.WriteLine("\nO Heroi " + nome + " Está no nivel Imortal");
        }
        else if(rank >= 10001 ){
            Console.WriteLine("\nO Heroi " + nome + " Está no nivel Radiante");
        }
        else{
            Console.WriteLine("O Nível digita está incorreto!");
        }
    }
}