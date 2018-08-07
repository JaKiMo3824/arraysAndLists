using System;
using System.Collections.Generic;


    class Program
    {
        static void Main()
        {
        //1) create a one-dimensional Array of strings. Ask the user to select an index of the array and then display the string at the index on the screen.
        
        string[] wordArray = new string[] { "dog", "cat", "bird", "mouse", "fish", "chinchilla", "snake" };

        Console.WriteLine("Please pick a number between 0 and 6 and I will tell you its corresponding pet in the array.");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(wordArray[number]);
        Console.ReadLine();
        
        //2) create a one-dimensional array of integers. ask the user to select an index of the array and then display the integer at that index on the screen.

        int[] numArray = new int[] { 24, 16, 89, 56, 71, 90 };

        Console.WriteLine("Please pick a number between 0 and 5 and I will tell you its corresponding number in the array.");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(numArray[num]);
        Console.ReadLine();
        

        //3) add in a message that displays when the user selects an index that doesn't exist.

        int[] numArray = new int[] { 24, 16, 89, 56, 71, 90 };

        Console.WriteLine("Please pick a number between 0 and 5 and I will tell you its corresponding number in the array.");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num != 0 - 5)
        {
            Console.WriteLine("You did not select a number between 0 and 5. You Lose.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine(numArray[num]);
            Console.ReadLine();
        }
        
        //4) create a list of strings. ask the user to select an index of the list and then display the content at that index on the screen

        List<string> stringList = new List<string>();
        stringList.Add("Thomas");
        stringList.Add("Jane");
        stringList.Add("Jeff");
        stringList.Add("Tina");

        Console.WriteLine("Please select a number from 0 to 3 and I will give you the corresponding name to that number.");
        int numName = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(stringList[numName]);
        Console.ReadLine();



    }
    }

