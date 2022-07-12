using System;

namespace Ejercicio01DeRecuperatorioDeLoureyroAxel
{
    class Program
    {
        static void Main(string[] args)
        {
			double dolaroficial;
			double dolarparalelo;
			double euros1;
			double euros2;
			double pesos1;
			double pesos2;
			Console.WriteLine("ingrese la cantidad de dolares oficiales que posee");
			dolaroficial = Double.Parse(Console.ReadLine());
			Console.WriteLine("ingrese la cantidad de dolares paralelos que posee");
			dolarparalelo = Double.Parse(Console.ReadLine());
			pesos1 = dolaroficial * 230;
			pesos2 = dolarparalelo * 280;
			euros1 = dolaroficial * 1.17;
			euros2 = dolarparalelo * 1.17;
			Console.WriteLine("con " + dolaroficial + " dolares oficiales puede comprar " + pesos1 + " pesos y con " + dolarparalelo + " dolares paralelos puede comprar " + pesos2 + " pesos");
			Console.WriteLine(" con " + dolaroficial + " dolares puede comprar " + euros1 + " euros y con " + dolarparalelo + " dolares puede comprar " + euros2 + " euros");

		}
    }
}
