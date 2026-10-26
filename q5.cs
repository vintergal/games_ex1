//https://www.codingame.com/ide/puzzle/cheap-choices

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
        int c = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        Item[] items=new Item[c];
        for (int i = 0; i < c; i++)
        {
            string item = Console.ReadLine();
            string[] item_parts=item.Split(" ");
            items[i]=new Item(item_parts[0],item_parts[1],int.Parse(item_parts[2]));

        }
        for (int i = 0; i < p; i++)
        {
            string order = Console.ReadLine();
            string[] order_parts=order.Split(" ");
            Item[] found_items=items.Where(item=> item.isThisItem(order_parts[0],order_parts[1]) && !item.wasSold()).ToArray<Item>();
            if (found_items.Length>0){
                Item chosenItem=found_items.MinBy(item=>item.getPrice());
                chosenItem.sell();
                Console.WriteLine(chosenItem.getPrice());
            }else{
                Console.WriteLine("NONE");
            }
        }
    

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

    }
}
class Item{
    private string name;
    private string size;
    private int price;
    bool sold;
    public Item(string name, string size, int price){
        this.name=name;
        this.size=size;
        this.price=price;
        this.sold=false;
    }
    public bool isThisItem(string name, string size){
        return this.name.Equals(name) && this.size.Equals(size);
    }
    public int getPrice(){
        return this.price;
    }
    public bool wasSold(){
        return this.sold;
    }
    public void sell(){
        this.sold=true;
    }
}