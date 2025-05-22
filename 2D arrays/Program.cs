using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Text.Json.Serialization;

namespace _2D_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const char SYM1 = 'X';
            const char SYM2 = 'O';
            const char RANDOMNUMBERS = '1';
            const char ALTTERNATINGSYMBOLS = '2';
            const char MARKINGBORDERS = '3';
            
            Console.WriteLine($"Please select the mode you would like {RANDOMNUMBERS} for random numbers, {ALTTERNATINGSYMBOLS} for alternating symbols or {MARKINGBORDERS} for marking the borders");
            string mode = Console.ReadLine();

            Console.WriteLine($"You have selected {mode}");
            int selectedMode = int.Parse(mode);

            Console.WriteLine("What are the dimensions of the grid, how many rows do you need?");
            string userRow = Console.ReadLine();

            Console.WriteLine("What are the dimesions of the grid, how many columns do you need?");
            string userCol = Console.ReadLine();

            Console.WriteLine($"You have chosen {userRow} rows and {userCol} columns");


            char[,] grid = new char[int.Parse(userRow), int.Parse(userCol)];

            int rows = int.Parse(userRow);
            int cols = int.Parse(userCol);

            Random rnd = new Random();                       

            if (selectedMode == 1)
            {
                for (int i = 0; i < grid.GetLength(0); i++)                 
                {
                    for (int j = 0; j < grid.GetLength(1); j++)             
                    {
                        grid[i, j] = (char)('0' + rnd.Next(0, 9));                                   
                    }
                }
                for (int i = 0; i < grid.GetLength(0); i++)
                {
                    Console.WriteLine("");
                    for (int j = 0; j < grid.GetLength(1); j++)
                    {
                        Console.Write($"{grid[i, j]}"); 
                    }
                }
            }
            if (selectedMode == 2) 
            {
                for (int i = 0; i < grid.GetLength(0); i++)     
                {
                    for (int j = 0; j < grid.GetLength(1); j++)        
                    {
                        grid[i, j] = ((i + j) % 2 == 0) ? SYM1 : SYM2;                                                                                                        
                    }
                }
                for (int i = 0; i < grid.GetLength(0); i++)
                {
                    Console.WriteLine("");
                    for (int j = 0; j < grid.GetLength(1); j++)
                    {
                        Console.Write(grid[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            if (selectedMode == 3)
            {
                for (int i = 0; i < rows; i++)                                
                {
                    for (int j = 0; j < cols; j++)                             
                    {
                        grid[i, j] = ((i + j) % 2 == 0) ? SYM1 : SYM2;        
                    }
                }
                Console.Write("+");             

                for (int j = 0; j < cols; j++)               
                {
                    Console.Write("-+");                                        
                }
                Console.WriteLine("");

                for (int i = 0; i < rows; i++)
                {
                    Console.Write("|");
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(grid[i, j] + "|");     
                    }
                    Console.WriteLine("");
                }
                Console.Write("+");
                for (int j = 0; j < cols; j++)  
                {
                    Console.Write("-+");       
                }
                Console.WriteLine("");                      









               




            }
        }
    }
}



