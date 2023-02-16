//See https://aka.ms/new-console-template for more information
//Console.WriteLine("\t Lab Assignment # 01");
//Console.WriteLine("\t\t Question 1:");
//Console.WriteLine("Write a program that asks the user for a number n and prints the sum of the numbers from 1 to n.");
//Console.WriteLine("\n");
//Console.WriteLine("Input Value of terms : ");
//int n = Convert.ToInt32(Console.ReadLine());
//int i = 0;
//int sum = 0;
//Console.WriteLine("The first {0} natural number are :", n);
//for (i = 1; i <= n; i++)
//{
//    Console.WriteLine("{0} ", i);
//    sum += i;
//}
//Console.WriteLine("The Sum of Natural Number upto {0} terms : {1} ", n, sum);

//Console.WriteLine("Question 2:");
//Console.WriteLine("Write a program that takes a character from user as input and check whether it is an alphabet (alphabet could be capital and small) or not. If it is an alphabet, then check it is vowel or consonant. If it is number or any special character, then print invalid input.");
//Console.WriteLine("\n");
//Console.WriteLine("ENTER AN ALPHABAT");
//char ch = char.Parse(Console.ReadLine());
//char alpha = char.ToUpper(ch);
//switch (alpha)
//{
//    case 'A':
//    case 'E':
//    case 'I':
//    case 'O':
//    case 'U':
//        Console.WriteLine("{0} is a vowel", alpha);
//        break;
//    case 'B':
//    case 'C':
//    case 'D':
//    case 'F':
//    case 'G':
//    case 'H':
//    case 'J':
//    case 'K':
//    case 'L':
//    case 'M':
//    case 'N':
//    case 'P':
//    case 'Q':
//    case 'R':
//    case 'S':
//    case 'T':
//    case 'V':
//    case 'W':
//    case 'X':
//    case 'Y':
//    case 'Z':
//        Console.WriteLine("{0} is a consonant", alpha);
//        break;
//    default:
//        Console.WriteLine("Please Enter Alphabet");
//        break;
//}

//Console.WriteLine("Question 3:");
//Console.WriteLine("\n");
//Console.WriteLine("In a XYZ company, worker’s punctuality is determined on the basis of the absents in a month.\r\n⦁\t" +
//    "If the worker has 0 absents, then the worker is said to be highly punctual.\r\n⦁\t" +
//    "If the worker has 1 absents, then the worker is said to be moderately punctual.\r\n⦁\t" +
//    "If the worker has 2 absents, then the worker is on warning period.\r\n⦁\t" +
//    "If the worker has 3 absents, then the worker must leave the company.\r\n" +
//    "Number of absents of a worker will be user input then find the punctuality of the worker");
//Console.WriteLine("\n");
//Console.WriteLine("How many time you were absent in this month");
//int abs = int.Parse(Console.ReadLine());
//if (abs <= 3)
//{
//    if (abs == 0)
//        Console.WriteLine("highly punctual");
//    if (abs == 1)
//        Console.WriteLine("moderately punctual");
//    if (abs == 2)
//        Console.WriteLine("warning period");
//}
//else
//{
//    Console.WriteLine("worker must leave the company");
//}

Console.WriteLine("Question 4:");
Console.WriteLine("Write a program to calculate and print the bill of a given customer. Customer ID," +
    " Customer Name and unit consumed by the user should be taken as input from the keyboard and display the total amount to pay to the customer");
Console.WriteLine("\n");

double chrg, surchrg = 0;
double perut, netamt;

Console.WriteLine("Input Customer ID :");
int id = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the name of the customer :");
string name = Console.ReadLine();
Console.WriteLine("Input the unit consumed by the customer : ");
int unit = Convert.ToInt32(Console.ReadLine());
if (unit < 99)
    chrg = 1.50;
else if (unit >= 100 && unit < 200)
    chrg = 2.00;
else if (unit >= 200 && unit < 400)
    chrg = 2.50;
else
    chrg = 3.00;
perut = unit * chrg;
if (perut > 400)
    surchrg = perut * 15 / 100.0;
netamt = perut + surchrg;
if (netamt < 100)
    netamt = 100;
Console.WriteLine("\nElectricity Bill\n");
Console.WriteLine("Customer ID.NO                      :"+ id);
Console.WriteLine("Customer Name                       :"+ name);
Console.WriteLine("unit Consumed                       :"+ unit);
Console.WriteLine("Amount Charges @Rs. {0}  per unit   :{1}", chrg, perut);
Console.WriteLine("Surchage Amount                     :"+ surchrg);
Console.WriteLine("Net Amount Paid By the Customer     :"+ netamt);