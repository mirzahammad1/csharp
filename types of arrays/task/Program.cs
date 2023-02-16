// See https://aka.ms/new-console-template for more information
using System.Reflection.PortableExecutable;

Console.WriteLine("------------------------LAB TASK # 10 A------------------------");
string[] names = {"Student","Quiz#1","Quiz#2", "Quiz#3", "Quiz#4", "Quiz#5"};
Console.WriteLine();

int[] high = new int[6];
int[] low = new int[6];
int[] add = new int[6];
string[,] marks = new string[6,6];
for (int row = 0; row < marks.GetLength(0); row++) //row
{
    for (int col = 0; col < marks.GetLength(1); col++)//col
    {
        Console.WriteLine("enter value at row {0} and {1} ", row, col);
        marks[row, col] = Console.ReadLine();
    }
}

for (int i = 0; i < names.Length; i++)
{
     Console.Write(names[i] + "  | ");
}
Console.WriteLine();
for (int i = 0; i < marks.GetLength(0); i++)
{
    for (int j = 0; j < marks.GetLength(1); j++)
    {
        Console.Write(marks[i, j] + "        ");
    }
    Console.WriteLine();
}
Console.WriteLine("------------------------------------------------------------------");
