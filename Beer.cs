using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


public static class Beer
{

    public static string Verse(int number)
    {
        var expected = "";
        if (number == 0)
        {
            expected = "No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.\n";
        }
        else if (number == 1)
        {
            expected = "1 bottle of beer on the wall, 1 bottle of beer.\nTake it down and pass it around, no more bottles of beer on the wall.\n";
        }
        else if (number == 2)
        {
            expected = "2 bottles of beer on the wall, 2 bottles of beer.\nTake one down and pass it around, 1 bottle of beer on the wall.\n";
        }
        else
        {
            expected = number + " bottles of beer on the wall, " + number + " bottles of beer.\n" +
            "Take one down and pass it around, " + (number - 1) + " bottles of beer on the wall.\n" +
            "";
        }

        return expected;

    }

    public static string Verses(int begin, int end)
    {

        var expected = "";
        int i = begin;

        do
        {
            expected = (expected + Verse(i) + "\n");            

            i--;
        }
        while (i >= end);       

        return expected;
    }

    public static string Sing(int start, int stop)
    {
        return Verses(start, stop);
    }

}
