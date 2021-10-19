using System;

namespace t1
{
    class Program
    {
        static void Main(string[] args)
        {
                 //numero: 178   
                 byte a = 1;
		 byte b = 7;
		 byte c = 8;
         
	 	 //aacb
		 Console.WriteLine("numero 1: " + a + a + c + b);

		 Console.WriteLine("----");

                 //bca
		 Console.WriteLine("numero 2: " + b + c + a);

	   	 Console.WriteLine("----");
 
		 //bcbc
	 	 Console.WriteLine("numero 3: " + b + c + b + c);
        }
    }
}
