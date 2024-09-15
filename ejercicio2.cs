using System;
using System.Collections;

class ejercio2
{
    static void Main(string[]urgs)
    {
        
        ArrayList lista = new ArrayList();
        Console.WriteLine("Ingrese 10 elementos ");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Elemento {i + 1} ");
            lista.Add(Console.ReadLine());
        }

        string opcion;
        do
        {
            Console.Clear(); 
            MostrarMenu();
            Console.Write("Seleccione una opción ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "a":
                    AgregarElemento(lista);
                    break;
                case "b":
                    ActualizarElemento(lista);
                    break;
                case "c":
                    EliminarElemento(lista);
                    break;
                case "d":
                    MostrarOrdenadoAZ(lista);
                    break;
                case "e":
                    MostrarOrdenadoZA(lista);
                    break;
                case "f":
                    Console.WriteLine("Cerrando el programa ");
                    break;
                default:
                    Console.WriteLine("Opción no válida ");
                    Pausa();
                    break;
            }

        } while (opcion != "f");
    }

    
    static void MostrarMenu()
    {
        Console.WriteLine("Menú de opciones ");
        Console.WriteLine("a) Agregar un nuevo elemento ");
        Console.WriteLine("b) Actualizar un elemento ");
        Console.WriteLine("c) Eliminar un elemento ");
        Console.WriteLine("d) Mostrar alfabéticamente (A-Z) ");
        Console.WriteLine("e) Mostrar alfabéticamente en orden inverso (Z-A) ");
        Console.WriteLine("f) Cerrar programa ");
    }

   
    static void AgregarElemento(ArrayList lista)
    {
        Console.Write("Ingrese un nuevo elemento  ");
        string nuevoElemento = Console.ReadLine();
        lista.Add(nuevoElemento);
        Console.WriteLine("Elemento fue agregado con éxito ");
        Pausa();
    }

    
    static void ActualizarElemento(ArrayList lista)
    {
        Console.Write("Ingrese un elemento que desea actualizar  ");
        string viejoElemento = Console.ReadLine();

        if (lista.Contains(viejoElemento))
        {
            Console.Write("Ingrese un nuevo valor ");
            string nuevoElemento = Console.ReadLine();
            int index = lista.IndexOf(viejoElemento);
            lista[index] = nuevoElemento;
            Console.WriteLine("Elemento fue actualizado con éxito ");
        }
        else
        {
            Console.WriteLine("Este elemento no existe en la lista ");
        }
        Pausa();
    }

    
    static void EliminarElemento(ArrayList lista)
    {
        Console.Write("Ingrese un elemento que desea eliminar ");
        string elemento = Console.ReadLine();

        if (lista.Contains(elemento))
        {
            lista.Remove(elemento);
            Console.WriteLine("Elemento fue eliminado con éxito ");
        }
        else
        {
            Console.WriteLine("Este elemento no existe en la lista ");
        }
        Pausa();
    }


    static void MostrarOrdenadoAZ(ArrayList lista)
    {
        lista.Sort(); 
        Console.WriteLine("Lista ordenada alfabéticamente (A-Z) ");
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }
        Pausa();
    }

    static void MostrarOrdenadoZA(ArrayList lista)
    {
        lista.Sort();
        lista.Reverse(); 
        Console.WriteLine("Lista ordenada alfabéticamente  (Z-A) ");
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }
        Pausa();
    }

 
    static void Pausa()
    {
        Console.WriteLine("Presione una tecla para continuar ");
        Console.ReadKey();
    }
}