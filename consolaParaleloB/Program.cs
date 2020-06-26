using System;

namespace consolaParaleloB
{
    class Programa1
    {
        static void Main(string[] argumentos)
        {
            int[] costoDelServicio = new int[3];
            costoDelServicio[0] = 10;
            costoDelServicio[1] = 15;
            costoDelServicio[2] = 20;
            if (argumentos.Length > 0) {
                if (argumentos[0] == "Peluqueria")
                {
                    Console.Write("El servicio que usted ha escogido es:" + argumentos[0] + "Que tiene un valor de" + costoDelServicio[1] + "\n" );
                }
                if (argumentos[0] == "Vacunas")
                {
                    Console.Write("El servicio que usted ha escogido es:" + argumentos[0] + "Que tiene un valor de" + costoDelServicio[0] + "\n");
                }
                if (argumentos[0] == "Spa")
                {
                    Console.Write("El servicio que usted ha escogido es:" + argumentos[0] + "Que tiene un valor de" + costoDelServicio[2] + "\n");
                }
            }
            Console.Write("Registro de su mascota \n");
            Console.WriteLine("Ingrese el nombre de su mascota: \n");
            var nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad de su mascota: \n");
            var edad = Console.ReadLine();
            Console.WriteLine("Ingrese la raza: \n");
            var raza = Console.ReadLine();
            Console.WriteLine("Ingrese el color: \n");
            var color = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("La informacion de su mascota es:");
            Console.WriteLine($"\n Nombre: {nombre} \n Edad: {edad} \n Raza: {raza} \n Color: {color} \n ");
            Console.ReadKey();

        } 
    }
}
