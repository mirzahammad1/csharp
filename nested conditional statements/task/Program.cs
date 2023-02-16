// See https://aka.ms/new-console-template for more information
Console.WriteLine("LAB TASK 5");
Console.WriteLine("Write a program for librray");
Console.WriteLine("\n");
string b_1 = "book 1";
string b_2 = "book 2";
string a_1 = "article 1";
string a_2 = "article 2";
Console.WriteLine(" 1) {0} \n 2) {1} \n 3) {2} \n 4) {3}",b_1,b_2,a_1,a_2);
Console.WriteLine("\n");
string user_select = Console.ReadLine();
Console.WriteLine("\n");
if (user_select == b_1 || user_select == b_2 || user_select == a_1 || user_select == a_2)
{
    int p_1 = 100;
    int ibn_1 = 4444;
    int p_2 = 200;
    int ibn_2 = 4445;
    int p_3 = 300;
    int ibn_3 = 4446;
    int p_4 = 400;
    int ibn_4 = 4447;
    if (user_select == b_1)
    {
        Console.WriteLine("Price of the book/article is : {0} \n IBN NUMBER of book/article is : {1}",p_1,ibn_1);
    }
    if (user_select == b_2)
    {
        Console.WriteLine("Price of the book/article is : {0} \n IBN NUMBER of book/article is : {1}", p_2, ibn_2);
    }    
    if (user_select == a_1)
    {
        Console.WriteLine("Price of the book/article is : {0} \n IBN NUMBER of book/article is : {1}", p_3, ibn_3);
    }
    if (user_select == a_2)
    {
        Console.WriteLine("Price of the book/article is : {0} \n IBN NUMBER of book/article is : {1}", p_4, ibn_4);
    }
        
}
else
{
    Console.WriteLine(" BOOK/ ARTICLE does not exist");
}
Console.WriteLine("\n");
Console.WriteLine("Do you want another book/article ? ");
string ask = Console.ReadLine();
Console.WriteLine("\n");
if (ask == "yes")
{
    Console.WriteLine("Which Book/Article you need \n book 1 \n book 2 \n article 1");
}
else
{
    Console.WriteLine("Exit");
}