using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int indice;
            ArrayList transportes = new ArrayList()
            {
                "CARRO",
                "AVION",
                "TREN",
                "BARCO",
                "COHETE",
                "BICICLETA",
                "MOTOCICLETA"
            };

            Console.WriteLine("Ingrese el nombre de un medio de transporte:");
            string nuevoTransporte = Console.ReadLine().ToUpper();
            Console.WriteLine("\n");
            if(transportes.Contains(nuevoTransporte)){
                indice = transportes.IndexOf(nuevoTransporte);
                transportes.RemoveAt(indice);
                Console.WriteLine("Ingrese el nombre de un medio de transporte distinto:");
                nuevoTransporte = Console.ReadLine().ToUpper();
                Console.WriteLine("\n");
                transportes.Insert(indice, nuevoTransporte);
                Console.WriteLine("Datos Actualizados");
            }
            else{
                Console.WriteLine("No se realizaron cambios");
            }
            Console.WriteLine("\n");
            
            foreach (var transporte in transportes)
            {
                Console.WriteLine(transporte);
            }

            Console.ReadKey();
        }
    }
}
