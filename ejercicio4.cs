using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>();
            List<int> numerosOrdenados;
            int nuevoNumero, numeroMayor, numeroMedio, numeroMenor, posicionMayor, posicionMedio, posicionMenor;

            // Lectura de los elementos que van a ir dentro del arreglo
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese el elemento #" + (i + 1) + ": ");
                nuevoNumero = Convert.ToInt32(Console.ReadLine());
                listaNumeros.Add(nuevoNumero);
            }

            // Crear una copia de la lista original y ordenarla para saber que numero es el numero mayor de la lista
            numerosOrdenados = new List<int>(listaNumeros);//pasamos toda la lista como parametros de la nueva lista
            numerosOrdenados.Sort();
            numerosOrdenados.Reverse();

            // Encontrando el número mayor, menor y del centro
            numeroMayor = numerosOrdenados[0];//como la lista esta en reversa el primer elemento sera el numero mayor
            numeroMedio = numerosOrdenados[numerosOrdenados.Count / 2];//calculamos el numero del centro de la lista
            numeroMenor = numerosOrdenados[numerosOrdenados.Count - 1];//el ultimo numero en el arreglo es el menor

            // Encontrar las posiciones originales
            posicionMayor = listaNumeros.IndexOf(numeroMayor);
            posicionMedio = listaNumeros.IndexOf(numeroMedio);
            posicionMenor = listaNumeros.IndexOf(numeroMenor);

            // Mostrar los resultados
            Console.WriteLine("El número mayor es:" + numeroMayor+ " y ocupa la posición "+ (posicionMayor + 1));
            Console.WriteLine("El número del medio es:" +numeroMedio+ " y ocupa la posición "+ (posicionMedio + 1));
            Console.WriteLine("El número menor es:"+numeroMenor+" y ocupa la posición "+(posicionMenor + 1));
        }
    }
}