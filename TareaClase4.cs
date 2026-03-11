


using System.ComponentModel.Design;

static void Desafio1()
{
    Console.WriteLine("Ingrese un numero positivo: ");
    int numero =  int.Parse(Console.ReadLine());
    Console.WriteLine("1");
    for (int i = 1; i <= numero; i++)
    {
        
        if (i % 2 != 0)
        {
            
            continue;
            
            
            
        }
        
        Console.WriteLine(i);
        
        
        
    }
    
    
}
//Desafio1();


static void Desafio2()
{
    Console.WriteLine("Ingrese un numero positivo: ");
    
    
    
    
   if (int.TryParse(Console.ReadLine(), out int nuprimo) && nuprimo > 0)
   {
       if (nuprimo == 1)
       {
           Console.WriteLine("El numero 1 no se considera un numero primo");
           
       }
       else
       {
           bool Primo = true;

           for (int i = 2; i <= Math.Sqrt(nuprimo); i++)
           {
               if (nuprimo % i == 0)
               {
                   Primo = false;
                   break;

               }

           }

           if (Primo)
           {
               Console.WriteLine("El numero es primo");
               
           }
           else
           {
               Console.WriteLine("El numero no es primo");
               
           }
       }   
       
   }
    
}
//Desafio2();


static void Desafio3()
{
    double Total = 0;
    int Calificaciones = 0;
    string final = "";

    Console.WriteLine("Ingrese calificaciones del 1 al 10");
    Console.WriteLine("Escriba: 'fin' si desea finalizar");

    while (true)
    {
        Console.WriteLine("Ingrese la calificacion o escriba 'fin'");
        final = Console.ReadLine().ToLower().Trim();

        if (final == "fin")
        {
            break;
            
        }

        if (int.TryParse(final, out int sumanotas))
        {
            if(sumanotas >= 1 &&  sumanotas <= 10)
            {

                Total += sumanotas;
                Calificaciones++;
                
            }
            else
            {
                Console.WriteLine("Las notas solo pueden ser del 1 al 10");
            }
            
            
            
        }
        else
        {
            Console.WriteLine("Datos no valido, escriba un numero del 1 al 10 o 'fin'");
            
            
        }


    }
    if (Calificaciones > 0)
    {
        double promedio = Total / Calificaciones;
        Console.WriteLine("El total de calificaciones es: " + Calificaciones);
        Console.WriteLine("El promedio total es de: " + promedio);
        
        
        
    }
    else
    {
        Console.WriteLine("No se ingresaron suficientes datos para calcular promedio");
        
        
        
    }
    Console.ReadKey();
    
}
//Desafio3();


























