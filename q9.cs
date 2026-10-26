//https://www.codingame.com/ide/puzzle/horse-racing-duals

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
        List<int> horsesPower=new List<int>();
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            int pi = int.Parse(Console.ReadLine());
            horsesPower.Add(pi);
        }

        horsesPower.Sort();
        List<int> powerSubs=new List<int>();
        for (int i=1;i<N;i++){
            powerSubs.Add(horsesPower[i]-horsesPower[i-1]);
        }


        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(powerSubs.Min());
    }
}