//https://www.codingame.com/ide/puzzle/shadows-of-the-knight-episode-1

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
class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]); // width of the building.
        int H = int.Parse(inputs[1]); // height of the building.
        int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
        inputs = Console.ReadLine().Split(' ');
        int X0 = int.Parse(inputs[0]);
        int Y0 = int.Parse(inputs[1]);

        int min_x=0;
        int min_y=0;
        int max_x=W-1;
        int max_y=H-1;
        // game loop
        while (true)
        {
            string bombDir = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");


            // the location of the next window Batman should jump to.

            if (bombDir.Contains("U")){
                max_y=Y0-1;
                Y0=(max_y+min_y)/2;
            }else if (bombDir.Contains("D")){
                min_y=Y0+1;
                Y0=(max_y+min_y)/2;
            }
            if (bombDir.Contains("L")){
                max_x=X0-1;
                X0=(max_x+min_x)/2;
            }else if (bombDir.Contains("R")){
                min_x=X0+1;
                X0=(max_x+min_x)/2;
            }

            Console.WriteLine(X0+" "+Y0);
        }
    }
}