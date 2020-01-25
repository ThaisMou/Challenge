using System;

namespace Desafio
{
    public class First{
     static void Main (string[] args){
        int x = 3;
        int a = 9;
        int b = 5;
        int c = 15;
        string value = "5";
        if( a % x == 0){ Console.WriteLine("Cira");}
        if((b.ToString().Contains(value))){Console.WriteLine("Dinha");}
        if( (c % x == 0 ) && (c.ToString()).Contains(value)){Console.WriteLine("CiraDinha");}
        Console.ReadLine();
     }
    }
}
