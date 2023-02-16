// See https://aka.ms/new-console-template for more information
Console.WriteLine("\t\t LAB TASK # 6 A");
Console.WriteLine("ENTER 1ST ITEM.....");
string item_1 = Console.ReadLine();
int counter = 0;
counter++;
Console.WriteLine("PRICE OF 1ST ITEM.....");
int p_1 = int.Parse(Console.ReadLine());
Console.WriteLine("ENTER 2nd ITEM.....");
string item_2 = Console.ReadLine();
counter++;
Console.WriteLine("PRICE OF 2nd ITEM.....");
int p_2 = int.Parse(Console.ReadLine());
Console.WriteLine("ENTER 3rd ITEM.....");
string item_3 = Console.ReadLine();
counter++;
Console.WriteLine("PRICE OF 3rd ITEM.....");
int p_3 = int.Parse(Console.ReadLine());
Console.WriteLine("ENTER 4th ITEM.....");
string item_4 = Console.ReadLine();
counter++;
Console.WriteLine("PRICE OF 4th ITEM.....");
int p_4 = int.Parse(Console.ReadLine());
Console.WriteLine("\n");
int sum = p_1 + p_2 + p_3 + p_4;
int discount = sum * 20 / 100;
switch (sum)
{
    case 2000:
    case 4000:
        Console.WriteLine("your amount is..."+sum);
        break;

    case 8000:
        Console.WriteLine("your amount is ...."+sum);
        Console.WriteLine("20% discount is {0} \t ",discount);
        int total = sum - discount;
        Console.WriteLine("YOUR TOTAL AMOUNT AFTER DISCOUNT WILL BE ........" + total);
        break;
}

//if (sum == 2000)
//{
//    Console.WriteLine("Your total amount is {0} \t and your total number items are {1} ", sum, counter);
//    Console.WriteLine("Would like to add more item  ???" +
//        "Type y for yes and n for no");
//    string yes = Console.ReadLine();
//    if (yes == "y")
//    {
//        string item_5 = Console.ReadLine();
//        counter++;
//        Console.WriteLine("PRICE OF 5th ITEM.....");
//        int p_5 = int.Parse(Console.ReadLine());
//        sum = p_1 + p_2 + p_3 + p_4 + p_5;
//        Console.WriteLine("Your total amount is {0} \t and your total number items are {1} ", sum, counter);
//    }
//    else
//    {
//        Console.WriteLine("THANK YOU");
//    }
//}
//else if (sum == 4000)
//{
//    Console.WriteLine("Your total amount is {0} \t and your total number items are {1} ", sum, counter);
//    Console.WriteLine("Would like to add more item  ???" +
//        "Type y for yes and n for no");
//    string yes = Console.ReadLine();
//    if (yes == "y")
//    {
//        string item_5 = Console.ReadLine();
//        counter++;
//        Console.WriteLine("PRICE OF 5th ITEM.....");
//        int p_5 = int.Parse(Console.ReadLine());
//        sum = p_1 + p_2 + p_3 + p_4 + p_5;
//        Console.WriteLine("Your total amount is {0} \t and your total number items are {1} ", sum, counter);
//    }
//    else
//    {
//        Console.WriteLine("THANK YOU");

//    }
//}
//else if (sum >= 8000)
//{
//    Console.WriteLine("Your total amount is {0} \t and your total number items are {1} ", sum, counter);
//    int discount = sum * 20 / 100;
//    Console.WriteLine("20% discount is {0} \t ",discount);
//    int total = sum - discount;
//    Console.WriteLine("YOUR TOTAL AMOUNT AFTER DISCOUNT WILL BE ........" + total);
//    Console.WriteLine("Would like to add more item  ???" +
//        "Type y for yes and n for no");
//    string yes = Console.ReadLine();
//    if (yes == "y")
//    {
//        string item_5 = Console.ReadLine();
//        counter++;
//        Console.WriteLine("PRICE OF 5th ITEM.....");
//        int p_5 = int.Parse(Console.ReadLine());
//        sum = p_1 + p_2 + p_3 + p_4 + p_5;
//        Console.WriteLine("Your total amount is {0} \t and your total number items are {1} ", sum, counter);
//    }
//    else
//    {
//        Console.WriteLine("THANK YOU");

//    }
//}