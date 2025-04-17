﻿using System.Reflection.Metadata;
using System.Text.Json.Serialization;

namespace _2D_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What are the dimesions of the grid, how many rows do you need?");            
            string userRow = Console.ReadLine();
            

            Console.WriteLine("What are the dimesions of the grid, how many columns do you need?");
            string userCol = Console.ReadLine();

            Console.WriteLine($"You have chosen {userRow} rows and {userCol} columns");

            
            int[,] grid = new int[int.Parse(userRow), int.Parse(userCol)];//create grid and fill with values 

            //output array 
                        
            for (int i = 0; i < 3; i++)             //row
            {
                
                for (int j = 0; j < 3; j++)         //col
                {
                    grid[i, j] = 1;                 //populate grid
                    
                }
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < 3; j++)
                {

                    Console.Write($"{grid[i,j]}");  //print

                }                  //next step populate with rad number rather than 1, need to do this within the loop (refer back to hangman project)
            }
        }
            




            //fill the grid with values → you can either put random symbols or let the user decide how to fill value, be creative
            //print the content of the grid
            //modify specific ranges → you can try to mark the cells of the grid like a chess board where alternating cells are marked or display the border of the grid



        
    }
}



////1 dimesion
//int[] Array1 = new int[5];
//Array1[3] = 1;

//Console.WriteLine(Array1[3]);

////2 dimension
//int[,] Array2 = new int[8, 8];
//Array2[2, 3] = 1;

//Console.WriteLine(Array2[2, 3]);

////3 dimension 
//int[,,] Array3 = new int[3, 3, 3];
//Array3[3, 3, 3] = 1;

//int result = 5 * Array3[3, 2, 1];

//Console.WriteLine(Array3[2, 3, 3]);

////walking array
//int[,] ArrayW = new int[3, 3];
//Array2[0, 0] = 1;

//Console.WriteLine(ArrayW[0, 0]);
//Console.WriteLine(ArrayW[0, 1]);
//Console.WriteLine(ArrayW[0, 2]);

//Console.WriteLine(ArrayW[1, 0]);
//Console.WriteLine(ArrayW[1, 1]);
//Console.WriteLine(ArrayW[1, 2]);

//Console.WriteLine(ArrayW[2, 0]);
//Console.WriteLine(ArrayW[2, 1]);
//Console.WriteLine(ArrayW[2, 2]);

//for (int lineIndex = 0; lineIndex < 3; lineIndex++) 
//{
//    Console.WriteLine(ArrayW[lineIndex, 0]);
//    Console.WriteLine(ArrayW[lineIndex, 1]);
//    Console.WriteLine(ArrayW[lineIndex, 2]);

//}

//int i = 6;
//while (i < 6)
//{
//    Console.WriteLine(i);
//    i++;
//}
//for (int a = 0; a < 6; a++)

//{
//    Console.WriteLine(a);

//}