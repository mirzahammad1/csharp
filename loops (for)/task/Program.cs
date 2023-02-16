// See https://aka.ms/new-console-template for more information
Console.WriteLine("LAB TASK # 7 B");
Console.WriteLine("MATHEMATICS FIBONACCI SERIES");
int n1 = 0;
int n2 = 1;
Console.WriteLine("enter range");
int range = int.Parse(Console.ReadLine());
for (int i = 0 ; i < range; i++  )
{
    int n3 = n1 + n2;
    n1 = n2;
    n2 = n3;
    Console.WriteLine(n3);
}