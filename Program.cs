// Johanna Huaraca
using System;
using System.Diagnostics;
class Program{
    
     static void Main(string[] args)
    {
    int n,k;
    	
	do {
        Console.WriteLine("\n\tSerie de fibonacci  ");
		Console.WriteLine("Introduzca el número de términos: ");
        n = Convert.ToInt32(Console.ReadLine());//número de términos
	
	}while (n <= 1);
     Stopwatch time1 = new Stopwatch();//cronómetro 1
     Stopwatch time2 = new Stopwatch();//cronómetro 2

	    Console.WriteLine("\n\tSerie números de fibonacci recursivo: ");
           time1.Start();// inicio del cronómetro 1
	for (k = 0; k < n; k++)
	{
		Console.Write(" "+ (new Program().FibonacciRecursivo(k))+" " ); 
	}
            time1.Stop();// fin del cronómetro 1
            Console.WriteLine($"Tiempo: {time1.Elapsed.TotalMilliseconds} ms");
    
	    Console.WriteLine("\n\tSerie números de fibonacci iterativo: ");
             time2.Start();// inicio del cronómetro 2
                FibonacciIterativo(n);
             time2.Stop();// fin del cronómetro 2
            Console.WriteLine($"Tiempo: {time2.Elapsed.TotalMilliseconds} ms");
	Console.ReadKey();//hasta aplastar cualuier tecla
 
    }
    long  FibonacciRecursivo(int num){//llamada recursiva
        
        if (num < 2) { 
            return num; 
        }
	    else { 
           return FibonacciRecursivo(num -2 )+FibonacciRecursivo (num - 1);
             }
    }
    static void FibonacciIterativo(int num){//llamada iterativa
       
      int i;	long actual,ant1,ant2;  
  	  ant1 = ant2 = 1; 
  	  Console.Write(" 0  1  1 ");
 	for (i=1; i<num-2; i++) { 
        actual = ant1 + ant2; 
        Console.Write($" "+actual+" ");
        ant2 = ant1; 
        ant1 = actual; 
    }
    }

}

