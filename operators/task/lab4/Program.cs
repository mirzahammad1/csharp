// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;

Console.WriteLine("LAB 4");
Console.WriteLine("Enter Your Grocery Card ID : ");
int g_id = int.Parse(Console.ReadLine());
bool check = g_id == 123;
Console.WriteLine("your card no. is : {0}",check);
Console.WriteLine("\n");
Console.WriteLine("Enter your 1st item from row 1 -----");
string _item1 = Console.ReadLine();
int number = 1;
Console.WriteLine("What is the price of your item ------");
int p1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter your 2nd item from row 2 -----");
string _item2 = Console.ReadLine();
number++;
Console.WriteLine("What is the price of your item ------");
int p2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter your 3rd item from row 3 -----");
string _item3 = Console.ReadLine();
number++;
Console.WriteLine("What is the price of your item ------");
int p3 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter your 4th item from row 4 -----");
string _item4 = Console.ReadLine();
number++;
Console.WriteLine("What is the price of your item ------");
int p4 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter your 5th item from row 5-----");
string _item5 = Console.ReadLine();
number++;
Console.WriteLine("What is the price of your item ------");
int p5 = int.Parse(Console.ReadLine());
bool check_prices = (p1 < 100) && (p2 < 100) && (p3 < 100) && (p4 < 100) && (p5 < 100);
Console.WriteLine("\n");
Console.WriteLine("all items are less than 100 rs :" + check);

int add = p1 + p2 + p3 + p4 + p5;

Console.WriteLine("your id is :" + g_id);
Console.WriteLine("total number item :" + number);
Console.WriteLine("your price is :" + add );

Console.ReadKey();