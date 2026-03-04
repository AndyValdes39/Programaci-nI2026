using System;

//Parte 1: Desafio 1
static void CalcularIngresosUsuario()
{
    Console.WriteLine("Ingrese el nombre del usuario:");
    string nombreUsuario = Console.ReadLine();


    double totalSuma = 0;
    int meses = 3;
    
    
    for (int i = 1; i <= meses; i++)
    {
        Console.Write($"Ingresa el ingreso del mes {i}: ");
        
        totalSuma += Convert.ToDouble(Console.ReadLine());
    }

    
    double promedio = totalSuma / meses;



    Console.WriteLine($"\nHola {nombreUsuario}, el total de lo que ganaste suma {totalSuma} y promediaste {promedio}");
}
//CalcularIngresosUsuario();


//Parte 1: Desafio 2

    /*class Program
    {
        static void Calculadora()
        {
            Console.WriteLine("Escriba el primer numero:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el segundo numero:");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n--Resultado");
            Console.WriteLine($"Suma: {Sumar(numero, numero2)}");
            Console.WriteLine($"Resta: {Restar(numero, numero2)}");
            Console.WriteLine($"Multiplicacion: {Multiplicar(numero, numero2)}");
            Console.WriteLine($"Dividir: {Dividir(numero, numero2)}");





        }

        public static int Sumar(int a, int b)
        {
            return a + b;
        }

        public static int Restar(int a, int b)
        {
            return a - b;
        }

        public static int Dividir(int a, int b)
        {
            if (a / b == 0) return 0;



            return a / b;
        }

        public static int Multiplicar(int a, int b)
        {
            return a * b;

        }

    }*/

//Parte 1: Desafio 3
    static void ValidarSuma()
    {
        try
        {
            Console.WriteLine("Ingresa el primer valor:");
            int v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo valor:");
            int v2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Resultado de la suma {v1 + v2}");

        }
        catch (Exception e)
        {
            Console.WriteLine("Error en el programa, el valor introducido no es valido o no fue ingresado");
            throw;
        }
        finally
        {
            Console.WriteLine("Saliendo del programa");
            Console.ReadKey();
        }
        
        
        
    }

    //ValidarSuma();

