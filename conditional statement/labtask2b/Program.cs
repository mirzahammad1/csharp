// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Q. A");
//Console.WriteLine("Enter your Name :");
//string name = Console.ReadLine();
//Console.WriteLine("Enter your student id :");
//int st_id = int.Parse (Console.ReadLine());
//Console.WriteLine("Enter your Program :");

//string prog = Console.ReadLine();

//string course_1 = "PF";
//string course_2 = "IICT";


//if ((name == "hammad") && (st_id == 65331) && (prog == "BSCS"))
//{
//    Console.WriteLine("welcome");
//    Console.WriteLine("\n");
//    Console.WriteLine("Enter 1st course :");
//    string std_course_1 = Console.ReadLine();
//    Console.WriteLine("Enter 2nd course :");
//    string std_course_2 = Console.ReadLine();

//    if(course_1 == std_course_1 && course_2 == std_course_2)
//    {
//        Console.WriteLine("Which course you want to update?\n\t\t" + std_course_1 + " or " + std_course_2);
//        Console.ReadLine();
//        Console.WriteLine("Update to :");
//        std_course_1 = Console.ReadLine();

//        Console.WriteLine("Updated Course: {0}", std_course_1);

//    }
//}
//else
//{
//    Console.WriteLine("try again");
//}

Console.WriteLine("Q . B");
Console.WriteLine("Programming Competition");
Console.WriteLine("\n");
Console.WriteLine("Select Your Year : \n \t junior \t OR \t  senior ");
string y_1 = Console.ReadLine();
if (y_1 == "junior")
{
    Console.WriteLine("Q 1 : what is the symbol of increment ?");
    string a = " == ";
    string b = " ++ ";
    string c = " -- ";
    Console.WriteLine(" a) {0} \n b) {1} \n c) {2}", a ,b , c);
    Console.WriteLine(" Select any one option :");
    string ans = Console.ReadLine();
    if(ans == "b" )
    {
        Console.WriteLine("your answers is correct");
    }
    else
    {
        Console.WriteLine("your answer is wrong");
    }
} 
else
{
    Console.WriteLine("Q 1 : what is the symbol of decrement ?");
    string a = " == ";
    string b = " ++ ";
    string c = " -- ";
    Console.WriteLine(" a) {0} \n b) {1} \n c) {2}", a, b, c);
    Console.WriteLine(" Select any one option :");
    string ans = Console.ReadLine();
    if (ans == "c")
    {
        Console.WriteLine("your answers is correct");
    }
    else
    {
        Console.WriteLine("your answer is wrong");
    }
}