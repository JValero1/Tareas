using System;

namespace perro
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = "";
            int edad = 0;
            byte ActividadPerro = 0;
            double peso = 0.0;
            byte opcion = 0;
            
            do{
                
             Console.WriteLine("Bienvenido al programa de cuanto debe comer tu perro");
                
             Console.WriteLine("¿Cual es el peso de su perro?:");
             dato = Console.ReadLine();
             peso = Convert.ToDouble(dato);

             Console.WriteLine("¿Cual es la edad de su perro? En meses:");
             dato = Console.ReadLine();
             edad = Convert.ToInt32(dato);
                
               if(edad <=12 && edad >=2){ 
                     
                 if(peso <=2){
                   if(edad == 3 || edad == 4 || edad == 5)
                   Console.WriteLine("Su perro debe comer 60 gramos de alimento al día.");

                   else if(edad == 2){
                   Console.WriteLine("Su perro debe comer 50 gramos de alimento al día.");}

                   else if(edad <=12 && edad >=6)
                   Console.WriteLine("Su perro debe comer 55 gramos de alimento al día.");
                 }
               
                  if(peso <=5 && peso >2){
                     if(edad <=12 && edad >=6 || edad == 3)
                     Console.WriteLine("Su perro debe comer 110 gramos de alimento al día.");

                     else if(edad == 2)
                     Console.WriteLine("Su perro debe comer 95 gramos de alimento al día.");

                     else if(edad == 4 || edad == 5)
                     Console.WriteLine("Su perro debe comer 115 gramos de alimento al día.");
                  }

                  if(peso <=10 && peso >5){
                           
                     if(edad <=12 && edad >=6 || edad == 3){
                           
                        Console.WriteLine("Su perro debe comer 185 gramos de alimento al día.");
                        
                        switch (edad) {
                           case 2: Console.WriteLine("Su perro debe comer 155 gramos de alimento al día.");
                           break;
                           case 4: Console.WriteLine("Su perro debe comer 195 gramos de alimento al día.");
                           break;
                           case 5: Console.WriteLine("Su perro debe comer 190 gramos de alimento al día.");
                           break;
                           } 
                     }
                  }
               
                  if(peso <=17 && peso >10){ 
                           
                     if(edad == 4 || edad == 5)
                     Console.WriteLine("Su perro debe comer 285 gramos de alimento al día.");

                     else if(edad <=12 && edad >=6){
                     Console.WriteLine("Su perro debe comer 280 gramos de alimento al día.");}

                     switch (edad) {
                        case 2: Console.WriteLine("Su perro debe comer 215 gramos de alimento al día.");
                        break;
                        case 3: Console.WriteLine("Su perro debe comer 265 gramos de alimento al día.");
                        break;
                     } 
                  }
                  
                 if(peso <=25 && peso >17){

                     if(edad == 4 || edad == 5)
                     Console.WriteLine("Su perro debe comer 375 gramos de alimento al día.");

                     else if(edad <=12 && edad >=6)
                     Console.WriteLine("Su perro debe comer 370 gramos de alimento al día.");

                     switch (edad) {
                        case 2: Console.WriteLine("Su perro debe comer 270 gramos de alimento al día.");
                        break;
                        case 3: Console.WriteLine("Su perro debe comer 350 gramos de alimento al día.");
                        break;
                     }
                  }
                  
                  if(peso <=32 && peso > 25){
                           
                     if(edad <=12 && edad >=6 || edad == 7)
                     Console.WriteLine("Su perro debe comer 450 gramos de alimento al día.");

                     switch (edad) {
                        case 2: Console.WriteLine("Su perra debe comer 300 gramos de alimento al día.");
                        break;
                        case 3: Console.WriteLine("Su perro debe comer 400 gramos de alimento al día.");
                        break;
                        case 4: Console.WriteLine("Su perro debe comer 445 gramos de alimento al día.");
                        break;
                    }
                  }
                  
                if(peso <=40 && peso >32){
                           
                     if(edad <=12 && edad >=6 || edad == 5)
                     Console.WriteLine("Su perro debe comer 530 gramos de alimento al día.");

                     switch (edad) {
                        case 2: Console.WriteLine("Su perra debe comer 350 gramos de alimento al día.");
                        break;
                        case 3: Console.WriteLine("Su perro debe comer 475 gramos de alimento al día.");
                        break;
                        case 4: Console.WriteLine("Su perro debe comer 525 gramos de alimento al día.");
                        break;
                     }
                  }

                 if(peso <=50 && peso >40){
                           
                     switch (edad) {
                        case 2: Console.WriteLine("Su perro debe comer 405 gramos de alimento al día.");
                        break;
                        case 3: Console.WriteLine("Su perro debe comer 545 gramos de alimento al día.");
                        break;
                        case 4: Console.WriteLine("Su perro debe comer 610 gramos de alimento al día.");
                        break;
                        case 5: Console.WriteLine("Su perro debe comer 625 gramos de alimento al día.");
                        break;
                     }
                  }

                 if(peso <=60 && peso >50){
                           
                     switch (edad) {
                        case 2: Console.WriteLine("Su perro debe comer 450 gramos de alimento al día.");
                        break;
                        case 3: Console.WriteLine("Su perro debe comer 605 gramos de alimento al día.");
                        break;
                        case 4: Console.WriteLine("Su perro debe comer 685 gramos de alimento al día.");
                        break;
                        }
                  }

                 if(peso <=70 && peso >60){
                           
                     switch (edad) {
                        case 2: Console.WriteLine("Su perro debe comer 485 gramos de alimento al día.");
                        break;
                        case 3: Console.WriteLine("Su perro debe comer 670 gramos de alimento al día.");
                        break;
                        }
                  } 

                  if(peso <=90 && peso >70){
                     Console.WriteLine("Su perro debe comer 580 gramos de alimento al día.");
                  }
               }
               else
               {
                 Console.WriteLine("¿Como considera la actividad de su mascota?");
                 Console.WriteLine("1- Alta  2- Normal  3- Baja");
                 dato = Console.ReadLine();
                 ActividadPerro = Convert.ToByte(dato);
               } 
                
               if(peso < 5 && peso >= 2){  
                
                switch (ActividadPerro) {
                   case 1:
                   Console.WriteLine("Su perro debe comer entre 60 y 115 gramos de alimento al día.");
                   break;
                   case 2:
                   Console.WriteLine("Su perro debe comer entre 55 y 100 gramos de alimento al día.");
                   break;
                   case 3:
                   Console.WriteLine("Su perro debe comer entre 45 y 85 gramos de alimento al día.");
                   break;
                 }
              }

             if(peso < 10 && peso >= 5){ 
                
                switch (ActividadPerro) {
                   case 1:
                   Console.WriteLine("Su perro debe comer entre 115 y 190 gramos de alimento al día.");
                   break;
                   case 2:
                   Console.WriteLine("Su perra debe comer entre 100 y 170 gramos de alimento al día.");
                   break;
                   case 3:
                   Console.WriteLine("Su perro debe comer entre 85 y 145 gramos de alimento al día.");
                   break;
                 }
              }

              if(peso < 15 && peso >= 10){ 
                
                switch (ActividadPerro) {
                   case 1:
                   Console.WriteLine("Su perro debe comer entre 190 y 255 gramos de alimento al día.");
                   break;
                   case 2:
                   Console.WriteLine("Su perra debe comer entre 170 y 225 gramos de alimento al día.");
                   break;
                   case 3:
                   Console.WriteLine("Su perro debe comer entre 145 y 195 gramos de alimento al día.");
                   break;
                  }    
              }

              if(peso < 25 && peso >= 15){ 

                  switch (ActividadPerro) {
                   case 1:
                   Console.WriteLine("Su perro debe comer entre 255 y 380 gramos de alimento al día.");
                   break;
                   case 2:
                   Console.WriteLine("Su perra debe comer entre 225 y 330 gramos de alimento al día.");
                   break;
                   case 3:
                   Console.WriteLine("Su perro debe comer entre 195 y 285 gramos de alimento al día.");
                   break;
                  }
              }

               if(peso < 40 && peso >= 25){ 
                
                switch (ActividadPerro) {
                   case 1:
                   Console.WriteLine("Su perro debe comer entre 380 y 535 gramos de alimento al día.");
                   break;
                   case 2:
                   Console.WriteLine("Su perro debe comer entre 330 y 475 gramos de alimento al día.");
                   break;
                   case 3:
                   Console.WriteLine("Su perro debe comer entre 285 y 410 gramos de alimento al día.");
                   break;
                 }
              }

              if(peso < 55 && peso >= 40){
                
                switch (ActividadPerro) {
                   case 1:
                   Console.WriteLine("Su perro debe comer entre 535 y 680 gramos de alimento al día.");
                   break;
                   case 2:
                   Console.WriteLine("Su perra debe comer entre 475 y 600 gramos de alimento al día.");
                   break;
                   case 3:
                   Console.WriteLine("Su perro debe comer entre 410 y 520 gramos de alimento al día.");
                   break;
                 }
              }
               
               if(peso < 70 && peso >= 55){
                
                switch (ActividadPerro) {
                   case 1:
                   Console.WriteLine("Su perro debe comer entre 680 y 820 gramos de alimento al día.");
                   break;
                   case 2:
                   Console.WriteLine("Su perra debe comer entre 600 y 720 gramos de alimento al día.");
                   break;
                   case 3:
                   Console.WriteLine("Su perro debe comer entre 520 y 620 gramos de alimento al día.");
                   break;
                 }
              }
                
              if(peso < 90 && peso >= 70){ 
                
                switch (ActividadPerro) {
                   case 1:
                   Console.WriteLine("Su perro debe comer entre 820 y 985 gramos de alimento al día.");
                   break;
                   case 2:
                   Console.WriteLine("Su perra debe comer entre 720 y 870 gramos de alimento al día.");
                   break;
                   case 3:
                   Console.WriteLine("Su perro debe comer entre 620 y 750 gramos de alimento al día.");
                   break;
                  }
              }
                
              Console.WriteLine("Si desea continuar escriba 0 de lo contrario escriba 1");
              dato = Console.ReadLine();
              opcion = Convert.ToByte(dato);
              Console.Clear();
                
            }while(opcion != 1); 
        }
    }
}
