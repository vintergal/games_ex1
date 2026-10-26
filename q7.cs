//https://www.codingame.com/ide/puzzle/logic-gates

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
        string[] inputs;
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        
        Dictionary<string,string> inputSignals=new Dictionary<string, string>();
        
        for (int i = 0; i < n; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            inputSignals.Add(inputs[0],inputs[1]);

        }
        for (int i = 0; i < m; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            string outputName = inputs[0];
            string type = inputs[1];
            string inputName1 = inputs[2];
            string inputName2 = inputs[3];
            Console.WriteLine(outputName+" "+getOutputSignal(inputSignals[inputName1],inputSignals[inputName2],type));
        }
        
    }
    static string getOutputSignal(string SignalA,string SignalB,string gate){
        string output="";
        for (int i=0;i<SignalA.Length;i++){
            output+=getOutputBit(SignalA[i],SignalB[i],gate).ToString();
        }
        return output;

    }
    static char getOutputBit(char bitA,char bitB,string gate){
        char BIT_ONE='-';
        char BIT_ZERO='_';
        switch (gate){
            case "AND":
            return (bitA==BIT_ONE && bitB==BIT_ONE)?BIT_ONE:BIT_ZERO;
            case "OR":
            return (bitA==BIT_ONE || bitB==BIT_ONE)?BIT_ONE:BIT_ZERO;
            case "XOR":
            return (bitA!=bitB)?BIT_ONE:BIT_ZERO;
            case "NAND":
            return !(bitA==BIT_ONE && bitB==BIT_ONE)?BIT_ONE:BIT_ZERO;
            case "NOR":
            return !(bitA==BIT_ONE || bitB==BIT_ONE)?BIT_ONE:BIT_ZERO;
            case "NXOR":
            return (bitA==bitB)?BIT_ONE:BIT_ZERO;
            default:
            return BIT_ZERO;
        }
        
    }
}


