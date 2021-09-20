using System;

class Program
{
    static void Main() {
       int[][] compiled = new int[3][];
       
       compiled[0] = new int[3];
       compiled[0][0]=6;
       compiled[0][1]=7;
       compiled[0][2]=9;
    
       compiled[1] = new int[6];
       
       compiled[2]= new int[6] {6,5,2,4,5,1};
    
        Console.WriteLine("here we have " + compiled[2][0]);
    }
}