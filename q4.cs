//https://www.codingame.com/ide/puzzle/unary
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
    static string getStringToAdd(char digit, int blockSize,bool isLastBlock){
        string output="";
        if (digit=='1'){
            output+="0 ";
        }else{
            output+="00 ";
        }
        for (int i=0;i<blockSize;i++){
            output+="0";
        }
        if (!isLastBlock){
            output+=" ";
        }
        return output;
    }
    static void Main(string[] args)
    {
        string MESSAGE = Console.ReadLine();

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        string messageEncoded="";
        foreach (char c in MESSAGE){
            messageEncoded+=Convert.ToString(c, 2).PadLeft(7, '0');

        }
        MESSAGE=messageEncoded;
        string output="";


        char first_in_block=MESSAGE[0];
        int blockSize=1;

        for (int i=1;i<MESSAGE.Length;i++){

            if (MESSAGE[i]==first_in_block){
                blockSize++;
            }else{
                output+=getStringToAdd(first_in_block,blockSize,false);
                first_in_block=MESSAGE[i];
                blockSize=1;
            }
        }
        output+=getStringToAdd(first_in_block,blockSize,true);



        Console.WriteLine(output);
    }
}