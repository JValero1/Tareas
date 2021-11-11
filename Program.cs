using System;

namespace t2
{
  class Program
 {
    static void Main(string[] args)
   {      
     string cadena = "";
     byte edad = 0;
     double altura = 0.0;
     int opcion = 0;

     Console.WriteLine("Hola, por favor ingresa tu edad:");
     cadena = Console.ReadLine();
     edad = Convert.ToByte(cadena);

     if(edad >= 18)
     {
        Console.WriteLine("Puedes pasar");   
      }
       else
     {
       Console.WriteLine("Puedes pasar solo si estas acompañado por un adulto");
                
      }       
           
      Console.WriteLine("Bienvenido");

      Console.WriteLine("¿cual es tu altura? En metros");
      cadena = Console.ReadLine();
      altura = Convert.ToDouble(cadena);

     if(altura <= 1.5)
     {     
       Console.WriteLine("A cúal atracción quieres subir? 1 = carritos chocones 2 = carrusel 3 = rueda de la fortuna");
        cadena = Console.ReadLine();
        opcion = Convert.ToInt32(cadena);   
      
        if(opcion == 1 || opcion == 2 || opcion == 3)
        {
        Console.WriteLine("Esperamos que lo haya disfrutado, Gracias por visitarnos");
        }
      }
      else
      {
        Console.WriteLine("A cúal atracción quieres subir? 1 = bailarina 2 = montaña rusa 3 = martillo");
       cadena = Console.ReadLine();
       opcion = Convert.ToInt32(cadena);

       if(opcion == 1 || opcion == 2 || opcion == 3)
       {
       Console.WriteLine("Esperamos que lo haya disfrutado, Gracias por visitarnos");
       }
      }    
    }
  }
} 
