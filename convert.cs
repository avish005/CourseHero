using System;
namespace MyApplication
{
 class Program
 {
   static void Main(string[] args)
   {
   	int i=1;
    
   	Console.WriteLine("Hectare \t Acre \t   Sq.Miles \t Sq.KM \t Sq.Yards \t Sq.Ft.");
     while(i<=20)
     {
          Console.WriteLine(i + "\t\t" + (0.404686 * i) + "\t" + (i/259) + "\t   " + (i/100) + "\t"  +  (i * 11960) + "\t\t" + (i * 107639) );
         i++;
     }
     
     Console.WriteLine("Acre \t Hectare \t   Sq.Miles \t Sq.KM \t Sq.Yards \t Sq.Ft.");
     while(i<=20)
     {
          Console.WriteLine(i + "\t" + (i/2.471) + "\t" + (i/640) + "\t   " + ( i/247) + "\t"  +  (i * 4840) + "\t\t" + (i * 43560) );
         i++;
     }
    
   }
 }
}
