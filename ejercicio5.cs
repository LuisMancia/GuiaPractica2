using System;
using System.Collections;

class Program
{
    static void Main()
    {
        string opcion;
        int controlUsuario = 1;
        int[] numeroLetras;//declaro arreglo vacio de enteros
        ArrayList listadoPalabras = new ArrayList();
        Console.WriteLine("Por favor ingrese los elementos de tipo String que desea utilizar:");
        Console.Write("\n");
        do
        {
            Console.Write(controlUsuario + ". ");//esto se usa para que el usuario sepa cuantos datos se han ingresado, al principio la primera palabra tiene "indice" uno
            listadoPalabras.Add(Console.ReadLine());
            Console.Write("Para seguir presione Enter, para finalizar presione N.");
            opcion = Console.ReadLine().ToUpper();
            controlUsuario++;
        } while (opcion != "N");

        numeroLetras = new int[listadoPalabras.Count]; //se usa Count porque devuelve el valor entero del tamano del arraylist
        
        for (int i = 0; i < listadoPalabras.Count; i++)
        {
            numeroLetras[i] = ((string)listadoPalabras[i]).Length;//se castea el arraylist para que a las cadenas de texto dentro se les pueda sacar el tamano
        }

        Console.WriteLine("\n-------------------RESULTADO-------------------\r\n\n");
        Console.WriteLine("ÍNDICE\tPALABRA\t\t\tNÚMERO DE CARACTERES");
        Console.WriteLine("---------------------------------------------");

        for (int j = 0; j < listadoPalabras.Count; j++)
        {
            Console.WriteLine(j+"\t"+listadoPalabras[j]+"\t\t\t\t"+numeroLetras[j]);
        }
    }
}

