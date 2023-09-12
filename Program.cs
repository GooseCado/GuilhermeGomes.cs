// See https://aka.ms/new-console-template for more information
namespace Fibonacci
{
  using System;

public class GuilhermeGomes
    {
    public static void Main()
        {
         int n = 10;
            int termo = 0;
            int segtermo = 1;
            int proximotermo = 0;
            for(int i=0; i < n; i++)
            {
                Console.WriteLine(termo);
                if(i < n - 1)
                
                
               
                proximotermo = termo + segtermo;
                termo = segtermo;
                segtermo = proximotermo;
            }
            Console.WriteLine();
            
        }
    }
}
