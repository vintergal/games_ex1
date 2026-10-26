//https://www.codingame.com/ide/puzzle/temperatures
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string[] inputs = Console.ReadLine().Split(' ');
        int NO_TEMP=5527;
        int closestToZero=NO_TEMP;

        for (int i = 0; i < n; i++)
        {
            int t = int.Parse(inputs[i]);// a temperature expressed as an integer ranging from -273 to 5526
            if ((t*t)<(closestToZero*closestToZero)){
                closestToZero=t;
            }
            if (t==-closestToZero){
                if (t>closestToZero){
                closestToZero=t;
                }
            }

        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        if (closestToZero==NO_TEMP){
        Console.WriteLine("0");
        }else{
        Console.WriteLine(closestToZero);
        }
    }
}