using System;

namespace chainResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            var cachorro = new Cachorro();
            var gato = new Gato();
            var esquilo = new Esquilo();
            
            cachorro.SetNext(gato).SetNext(esquilo);
            var respostas = new Client().Valida(cachorro);
            respostas.ForEach(r => Console.WriteLine(r));       


        }
    }
}
