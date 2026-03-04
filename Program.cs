using System;
using System.ComponentModel.Design;
using System.Security.AccessControl;
using Microsoft.Win32;
//Parte 2: Desafio 1
/*class Program
{
    private static string usuariovalido = "";
    private static string claveavalido = "";


    static void Main()
    {
        Console.WriteLine("Bienvenido");
        Registrar();
        
        Console.Write("Ingrese el usuario y clave: ");
        IniciodeSesion();

        Console.Write("Presione cualquier tecla para finalizar");
        Console.ReadKey();
        

    }

    private static void Registrar()
    {
        Console.WriteLine("Registrar");
        Console.Write("Crea un usuario: ");
        usuariovalido = Console.ReadLine();
        
        Console.Write("Crea clave: ");
        claveavalido = Console.ReadLine();
        
        Console.WriteLine("Registro valido");
        
        
    }

    private static void IniciodeSesion()
    {
        Console.Write("Ingrese el usuario: ");
        string usuario = Console.ReadLine();
        
        Console.Write("Ingrese el clave: ");
        string clavea = Console.ReadLine();


        if (usuario == usuariovalido && clavea == claveavalido)
        {
            Console.WriteLine("Bienvenido " + usuariovalido);
            
        }
        else
        {
            Console.WriteLine("Error, usuario y clave incorrectos");
            
            
            
        }

            





    }




}*/


//Parte 2: Desafio 2



/*class Program
{

    static int puntajeRecord = 1;
    static string jugadorRecord = "MVP";

    static void Main()
    {
        bool continuar = true;

        Console.WriteLine("Registro de records");
        Console.WriteLine($"El puntaje record es de {puntajeRecord} por {jugadorRecord}");


        while (continuar)
        {
            try
            {
                Console.Write("\nIngrese el nombre del jugador: ");
                string nombreJugador = Console.ReadLine();

                Console.WriteLine("\nIngrese el record del jugador: ");
                int nombreRecord = int.Parse(Console.ReadLine());

                Updaterecord(nombreRecord, nombreJugador);

                Console.Write("\nIngresar otro puntaje?  s/n: ");
                string respuesta = Console.ReadLine().ToLower();
                if (respuesta != "s") continuar = false;



            }
            catch (Exception e)
            {
                Console.WriteLine("Error, por favor ingresar datos validos");
                throw;
            }

            




        }




    }

    public static void Updaterecord(int nombreRecord, string nombreJugador)
    {
        if (nombreRecord >  puntajeRecord)
        {
            puntajeRecord = nombreRecord;
            jugadorRecord = nombreJugador;
            
            Console.WriteLine("Nuevo Record registrado! ");
            Console.WriteLine($"El nuevo record ahora pertenece a  {nombreJugador} con la puntuacion de {nombreRecord}");
            






        }
        else
        {
            Console.WriteLine("Ningun record ha sido batido");
            Console.WriteLine($"El record actual es de {nombreJugador} con {nombreRecord} puntos");
            
            
            
            
        }
            


    }
    
    
    
    
    
}*/
    
    
    
    
    

