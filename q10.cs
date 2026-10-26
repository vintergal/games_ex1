//https://www.codingame.com/ide/puzzle/island-escape

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
        int N = int.Parse(Console.ReadLine());
        int[,] elevations=new int[N,N];
        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            for (int j = 0; j < N; j++)
            {
                int elevation = int.Parse(inputs[j]);
                elevations[i,j]=elevation;
            }
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");


        
        bool[,] visited=new bool[N,N];
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                visited[i,j]=false;
            }
        }
        int x0=N/2;
        int y0=x0;
        Console.WriteLine(canGetOut(elevations[x0,y0],x0,y0,elevations,visited)?"yes":"no");
    }

    static bool canGetOut(int previousElevation,int posX,int posY,int[,] elevations,bool[,] visited){
        
        if (!isValidPlace(posX,posY,visited)){
            return false;
        }

        if (elevations[posX,posY]==0){
            return true;
        }
        visited[posX,posY]=true;

        int currentElevation=elevations[posX,posY];
        

        if (Math.Abs(currentElevation-elevations[posX-1,posY])<=1&&canGetOut(currentElevation,posX-1,posY,elevations,visited)){
            return true;
        }
        
        if (Math.Abs(currentElevation-elevations[posX+1,posY])<=1&&canGetOut(currentElevation,posX+1,posY,elevations,visited)){
            return true;
        }
        if (Math.Abs(currentElevation-elevations[posX,posY-1])<=1&&canGetOut(currentElevation,posX,posY-1,elevations,visited)){
            return true;
        }
        if (Math.Abs(currentElevation-elevations[posX,posY+1])<=1&&canGetOut(currentElevation,posX,posY+1,elevations,visited)){
            return true;
        }

        return false;
    }

    static bool isValidPlace(int posX,int posY,bool[,] visited){
        int N=visited.Length;
        return posX>=0 && posY>=0 && posX<N && posY<N && !visited[posX,posY];
    }
}