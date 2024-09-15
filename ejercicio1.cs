int numerosIngresados=7;
int[] numerosUsuario;
int[] numerosUsuarioTriple;
int contador = 0;
while (numerosIngresados < 8)//Aqui me aseguro que el numero de elementos que contendra el arreglo seran almenos 8
{
    try
    {
        Console.WriteLine("Por favor ingrese el numero de elementos que contendra el arreglo (minimo 8)");
        numerosIngresados = Convert.ToInt32(Console.ReadLine()); //Aqui nos aseguramos que lo que se lee sea un numero entero y solamente eso
    }
    catch {
        Console.WriteLine("Estimado usuario: Por favor verifique que el dato ingresado sea un numero entero.");
    }
}

numerosUsuario = new int[numerosIngresados];
numerosUsuarioTriple = new int[numerosIngresados];
    
for (int i = 0; i < numerosUsuario.Length; i++)
{
    bool bandera = true;
    while (bandera) 
    {
        try
        {
            Console.Write("Ingrese el entero en la pocision #" + i + " :");
            numerosUsuario[i] = Convert.ToInt32(Console.ReadLine());
            bandera = false;
        }
        catch {
            Console.WriteLine("Apreciable user: El dato ingresado no es compatible con el parametro solicitado.");
        }
    }
}

Console.WriteLine("Indice\t\t1er arreglo\t\t2do arreglo");
for (int j = 0; j < numerosUsuario.Length; j++)
{
    numerosUsuarioTriple[j] = numerosUsuario[j] * 3;
    Console.WriteLine(j + "\t\t"+ numerosUsuario[j] + "\t\t\t\t" + numerosUsuarioTriple[j]);
}

