using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class BeerSong
{   
    public static string Verse(int number)
    {
        var verse = "";
        var newline = "\n";        

        if (number == 0)
        {
            verse = "No more bottles of beer on the wall, no more bottles of beer."+newline+"Go to the store and buy some more, 99 bottles of beer on the wall."+newline;
        }
        else if (number == 1)
        {
            verse = "1 bottle of beer on the wall, 1 bottle of beer." + newline + "Take it down and pass it around, no more bottles of beer on the wall." + newline;
        }
        else if (number == 2)
        {
            verse = "2 bottles of beer on the wall, 2 bottles of beer." + newline + "Take one down and pass it around, 1 bottle of beer on the wall." + newline;
        }
        else
        {
            verse = number + " bottles of beer on the wall, " + number + " bottles of beer." + newline +
            "Take one down and pass it around, " + (number - 1) + " bottles of beer on the wall." + newline +
            "";
        }

        return verse;

    }

    public static string Verses(int begin, int end)
    {

        var verse = "";
        int i = begin;

        do
        {            

            if (i == end)
            {
                verse = (verse + Verse(i) + "");
            }
            else
            {
                verse = (verse + Verse(i) + "\n");
            }

            i--;
        }
        while (i >= end);

        return verse;
    }

    public static string Sing(int start, int stop)
    {
        return Verses(start, stop);
    }


   

}   

