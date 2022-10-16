// See https://aka.ms/new-console-template for more information
Console.WriteLine("A demonstration of multidimensional arrays");

// Create a new array by size
int[,] array = new int[9,9];

//int[,] array = new int[3,3] { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };

//Console.WriteLine("Array size: " + array.Length);

/*
for(int i = 1; i <= 3; i++){
    for (int j = 1; j <= 3; j++){        
        array[i-1, j-1] =ctr;
        ctr++;
    }
}*/

// create a multiplication table

/*
for(int i = 1; i <= 9; i++){
    for (int j = 1; j <= 9; j++){     
        array[i-1, j-1] = i * j;
        Console.Write(array[i-1, j-1] + " ");
    }
    Console.Write('\n');
}
*/

int[][] ourArray = new int[4][];

ourArray[0] = new int[5];
ourArray[1] = new int[3];
ourArray[2] = new int[8];
ourArray[3] = new int[5];

ourArray[0] = new int[] { 1, 2, 3, 4, 5 };
ourArray[1] = new int[] { 2, 4, 6 };
ourArray[2] = new int[] { 3, 6, 9, 12, 15, 18, 21, 24 };
ourArray[3] = new int[] { 4, 8, 12, 16, 20 };


// jagged array example

string[] names = { "John", "Paul", "George", "Ringo" };

string[][] bands =
{
    new string[] { "John", "Paul", "George", "Ringo" },
    new string[] { "Peter", "Paul", "Mary"}
};