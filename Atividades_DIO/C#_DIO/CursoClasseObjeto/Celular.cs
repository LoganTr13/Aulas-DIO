using System;
namespace CursoClasseObjeto
{
    public class Celular
    {
        public string cor;
        public double Altura;
        public double Largura;
        public string Modelo;
        
        public void Call(int num)
        {
            Console.WriteLine("Numero: " + num + "\n" + "Fazendo Chamada...");
        }
    }
}