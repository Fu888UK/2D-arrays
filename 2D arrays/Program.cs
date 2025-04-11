namespace _2D_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What are the dimesions of the grid?");
            Console.ReadLine();
            int userInput = 0;


            int[,] Array2 = new int[8, 8];
            Array2[2, 3] = 1;

            Console.WriteLine(Array2[2, 3]);
            //example taken from vid in moodule 



        }
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

////walking
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