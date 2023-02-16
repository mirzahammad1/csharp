// See https://aka.ms/new-console-template for more information
using System.Data.Common;

//Console.WriteLine("LAB TASK # 8 B");
//Console.WriteLine("\n");
//for (int i = 0; i <= 6; i++)
//{
//    for (int j = 0; j <= 6; j++)
//    {
//        if (((i == 0 || i == 3 || i == 6) && j > 1 && j < 5) 
//            || (j == 1 && (i == 1 || i == 2 || i == 6)) 
//            || (j == 5 && (i == 0 || i == 4 || i == 5)))
//            Console.Write("*");
//        else
//            Console.Write(" ");
//    }
//    Console.Write("\n");
//}
//Console.Write("\n");

List<int> numbers = new List<int>();
for (int i = 3; i <=100; i += 3)
{
    Console.WriteLine(i+3);
}
Console.WriteLine("\n");
for (int j = 5; j <= 100; j += 5)
{
    Console.WriteLine(j+5);
}
numbers.ForEach(Console.WriteLine);
int sum1 = numbers.Sum();
Console.WriteLine(sum1);
Console.ReadLine();