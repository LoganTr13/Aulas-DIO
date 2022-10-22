using System;

namespace CursoClasseObjeto
{
    class Program
    {
        static void Main()
        {
            Celular celular1 = new Celular();

            celular1.cor = "preto";
            celular1.Altura = 15.5;
            celular1.Largura = 8.5;
            celular1.Modelo = "Motorola";

            Console.WriteLine("--- Celular 1 ---");
            Console.WriteLine("Cor: " + celular1.cor + "\n" + "Altura: " + celular1.Altura + "\n" + 
            "Largura: " + celular1.Largura+ "\n" + "Modelo: " + celular1.Modelo + "\n");
            celular1.Call(985080263);

            Celular celular2 = new Celular();

            celular2.cor = "preto";
            celular2.Altura = 15.5;
            celular2.Largura = 8.5;
            celular2.Modelo = "Samsung";

            Console.WriteLine("--- Celular 2 ---");
            Console.WriteLine("Cor: " + celular2.cor + "\n" + "Altura: " + celular2.Altura + "\n" + 
            "Largura: " + celular2.Largura + "\n" + "Modelo: " + celular2.Modelo + "\n");
            celular2.Call(984399613);

            Console.ReadLine();
        }
    }
}