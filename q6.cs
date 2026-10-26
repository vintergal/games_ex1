//https://www.codingame.com/ide/puzzle/defibrillators

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
        string LON = Console.ReadLine().Replace(',', '.');
        string LAT = Console.ReadLine().Replace(',', '.');
        int N = int.Parse(Console.ReadLine());
        Defibrillator[] defibrillators =new Defibrillator[N];
        for (int i = 0; i < N; i++)
        {
            string DEFIB = Console.ReadLine();
            string[] DEFIB_splitted=DEFIB.Split(";");
            string name=DEFIB_splitted[1];
            double distance=getDistance(double.Parse(LON),double.Parse(DEFIB_splitted[4].Replace(',', '.')),double.Parse(LAT),double.Parse(DEFIB_splitted[5].Replace(',', '.')));
            defibrillators[i]=new Defibrillator(name,distance);
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(defibrillators.MinBy(defibrillator=>defibrillator.getDistance()).getName());
    }
    static double getDistance(double longitudeA,double longitudeB,double latitudeA,double latitudeB){
        longitudeA=longitudeA* Math.PI / 180.0;
        longitudeB=longitudeB* Math.PI / 180.0;
        latitudeA=latitudeA* Math.PI / 180.0;
        latitudeB=latitudeB* Math.PI / 180.0;

        double x=(longitudeB-longitudeA)*Math.Cos((latitudeA+latitudeB)/2);
        double y=latitudeB-latitudeA;
        return Math.Sqrt(x*x+y*y)*6371;
    }
}
class Defibrillator{
    private string name;
    private double distance;

    public Defibrillator(string name, double distance){
        this.name=name;
        this.distance=distance;
    }

    public string getName(){
        return this.name;
    }
    
    public double getDistance(){
        return this.distance;
    }
}

