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

            Console.WriteLine("Please select the mode you would like 1 for random numbers, 2 for alternating symbols or 3 for marking the borders");
            string mode = Console.ReadLine();

            Console.WriteLine($"You have selected {mode}");
            int selectedMode = int.Parse(mode);

            Console.WriteLine("What are the dimensions of the grid, how many rows do you need?");
            string userRow = Console.ReadLine();

            Console.WriteLine("What are the dimesions of the grid, how many columns do you need?");
            string userCol = Console.ReadLine();

            Console.WriteLine($"You have chosen {userRow} rows and {userCol} columns");


            char[,] grid = new char[int.Parse(userRow), int.Parse(userCol)];//create grid and fill with values    //a 2D array 

            //output array 

            int rows = int.Parse(userRow);
            int cols = int.Parse(userCol);

            Random rnd = new Random();

            //cast a type into a type (try a string array rather than char or int)

            //grid[i, j] = (char)('0' + rnd.Next(0, 9)); 

            // (selectedWord[i].ToString() == userGuess)

            //  hiddenWord[i] = Char.Parse(userGuess);

            //(grid.ToString() == )


            if (selectedMode == 1)
            {
                for (int i = 0; i < grid.GetLength(0); i++)                 //row
                {
                    for (int j = 0; j < grid.GetLength(1); j++)             //col
                    {
                        grid[i, j] = (char)('0' + rnd.Next(0, 9));                //populate grid                    
                    }
                }

                for (int i = 0; i < grid.GetLength(0); i++)
                {
                    Console.WriteLine("");
                    for (int j = 0; j < grid.GetLength(1); j++)
                    {
                        Console.Write($"{grid[i, j]}");  //print
                    }
                }

            }

            if (selectedMode == 2) //populate grid for mode 2 (alternate symbols)
            {
                for (int i = 0; i < grid.GetLength(0); i++)       //row   
                {
                    for (int j = 0; j < grid.GetLength(1); j++)         //col
                    {
                        grid[i, j] = ((i + j) % 2 == 0) ? SYM1 : SYM2;          //? researched that i can use this symbol, shorthand for if-else
                                                                                //i+j adds row and colms
                                                                                //(i + j) % 2 == 0) checks if the sum is even, the % gives the remainder (as discussed in LC)
                                                                                //even - true, odd = false 
                                                                                //if true evaluates SYM1
                                                                                //if false evaluates SYM2 
                                                                                                        
                    }

                }
                for (int i = 0; i < grid.GetLength(0); i++)
                {
                    Console.WriteLine("");
                    for (int j = 0; j < grid.GetLength(1); j++)
                    {
                        Console.Write(grid[i, j] + " ");  //print

                    }
                    Console.WriteLine();
                }
            }

            if (selectedMode == 3)
            {
                for (int i = 0; i < rows; i++)                                //outer loop i goes through each row 
                {
                    for (int j = 0; j < cols; j++)                            // inner loop j goes through eacj col 
                    {
                        grid[i, j] = ((i + j) % 2 == 0) ? SYM1 : SYM2;        //checks if i and j are even 
                    }
                }
                Console.Write("+");             

                for (int j = 0; j < cols-1; j++)              //top border 
                {
                    Console.Write("-+");                   //??? added a + but now getting 2 extra -                   
                    //Console.Write("+");                   //??? AFTER DUBUGGING FEEL I SHOULD ADD SOMETHING HERE (FOR COL)                     
                }
                Console.WriteLine("");

                for (int i = 0; i < rows; i++)
                {
                    Console.Write("|");
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(grid[i, j] + "");    //replaced space with|, but now has extra | at the end 
                    }
                    Console.WriteLine("|");

                }

                Console.Write("+");
                for (int j = 0; j < cols-1; j++)  //bottom border 
                {
                    Console.Write("-+");       //added a +
                }
                Console.WriteLine("");          

                









                ////////    Console.WriteLine("+---+---+---+");
                ////////    for (int i = 0; i < grid.GetLength(0); i++)                 //row
                ////////    {
                ////////        for (int j = 0; j < grid.GetLength(1); j++)             //col
                ////////        {

                ////////            grid[i, j] = ((i + j) % 2 == 0) ? SYM1 : SYM2;
                ////////            //grid[i, j] = (char)('0' + rnd.Next(0, 9));                //populate grid

                ////////            //Console.WriteLine($"|{i,j}|{i,j}|{i,j}");

                ////////        }
                ////////    }


                ////////    for (int i = 0; i < grid.GetLength(0); i++)
                ////////    {
                ////////        Console.WriteLine("");
                ////////        for (int j = 0; j < grid.GetLength(1); j++)
                ////////        {
                ////////            Console.Write(grid[i, j] + " ");  //print

                ////////        }
                ////////    }


                //}
                //2nd and 3rd modes
                // populate grid for each modes 




                //fill the grid with values → you can either put random symbols or let the user decide how to fill value, be creative
                //print the content of the grid
                //modify specific ranges → you can try to mark the cells of the grid like a chess board where alternating cells are marked or display the border of the grid




            }
        }
    }
}



