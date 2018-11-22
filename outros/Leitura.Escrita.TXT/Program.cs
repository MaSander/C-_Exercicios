using System;
using  System.IO;

namespace Leitura.Escrita.TXT
{
    class Program
    {
        private const string Path = "string.txt";
        static int[] numeros = new int[5];
        static string Linha;
        static Random random = new Random();
        static void Main(string[] args)
        {
            if(File.Exists("string.txt")){
                Console.WriteLine("\nO arquivo ja existe");
                using(StreamReader ler = new StreamReader("string.txt")){
                    while((Linha = ler.ReadLine()) != null){
                        Console.WriteLine($"{Linha}");
                    }
                }
            } else{
                for(int i = 0; i < 5; i++){
                    numeros[i] = random.Next(1000);
                }
                using(StreamWriter Escrever = new StreamWriter("string.txt")){
                    for(int i = 0; i < 5; i++){
                        Escrever.WriteLine(numeros[i]);
                    }
                }

                using(StreamReader ler = new StreamReader("string.txt")){
                    string Linha;
                    while((Linha = ler.ReadLine()) != null){
                        System.Console.WriteLine($"{Linha}");
                    }
                }
            }
            
        }
    }
}
