// See https://aka.ms/new-console-template for more information
// NESTED IF-ELSE PROGRAM 1 LOG-IN  
//Console.WriteLine("ENTER YOUR USER NAME");
//string user_name = Console.ReadLine();
//string name = "mirza";
//string pass = "1234";
//if (user_name == name)
//{
//    Console.WriteLine("ENTER YOUR PASSWORD");
//    string password = Console.ReadLine();
//    if (password == pass)
//    {
//        Console.WriteLine("SUCCESSFULLY LOGIN........");
//    }
//    else
//        Console.WriteLine("INVALID PASSWORD");
//}
//else
//{
//    Console.WriteLine("INVALID USERNAME");
//}

// PROGRAM 2 
//Console.WriteLine("CLASS INFORMATION SYSTEM.......");
//Console.WriteLine("CLASS ID LIST");
//int id_1 = 1234;
//int id_2 = 5678;
//int id_3 = 9010;
////int id_1,id_2,id_3;       
//Console.WriteLine("ENTER YOUR CLASS ID");
//int user_id = int.Parse(Console.ReadLine());
//if (user_id == id_1)
//{
//    Console.WriteLine("your class is on monday at 9:00");
//    Console.WriteLine("PF");
//    Console.WriteLine("DO YOU WANT TO KNOW ABOUT SEMESTER PLANING");
//    string for_PF = Console.ReadLine();
//    if (for_PF == "yes")
//    {
//        Console.WriteLine("SEMESTER HAS BEEN PLAN FOR 4 MONTHS DURATION");
//        Console.WriteLine("DO YOU WANT TO KNOW ABOUT ASSESMENT");
//        string assesment_PF = Console.ReadLine();
//        if (assesment_PF == "yes")
//        {
//            Console.WriteLine("3 assignment");
//            Console.WriteLine("5 quiz");
//            Console.WriteLine("1 project");
//            Console.WriteLine("1 mid  and 1 final");
//        }
//    }
//}
//else if (user_id == id_2)
//{
//    Console.WriteLine("your class is on tuesday at 12:00");
//    Console.WriteLine("IICT"); 
//    Console.WriteLine("DO YOU WANT TO KNOW ABOUT SEMESTER PLANING");
//    string for_IICT = Console.ReadLine();
//    if (for_IICT == "yes")
//    {
//        Console.WriteLine("SEMESTER HAS BEEN PLAN FOR 4 MONTHS DURATION");
//        Console.WriteLine("DO YOU WANT TO KNOW ABOUT ASSESMENT");
//        string assesment_IICT = Console.ReadLine();
//        if (assesment_IICT == "yes")
//        {
//            Console.WriteLine("3 assignment");
//            Console.WriteLine("5 quiz");
//            Console.WriteLine("1 project");
//            Console.WriteLine("1 mid  and 1 final");
//        }
//    }
//}
//else if(user_id == id_3)
//{
//    Console.WriteLine("your class is on wednesday at 9:00");
//    Console.WriteLine("PIS");
//    Console.WriteLine("DO YOU WANT TO KNOW ABOUT SEMESTER PLANING");
//    string for_PIS = Console.ReadLine();
//    if (for_PIS == "yes")
//    {
//        Console.WriteLine("SEMESTER HAS BEEN PLAN FOR 4 MONTHS DURATION");
//        Console.WriteLine("DO YOU WANT TO KNOW ABOUT ASSESMENT");
//        string assesment_PIS = Console.ReadLine();
//        if (assesment_PIS == "yes")
//        {
//            Console.WriteLine("3 assignment");
//            Console.WriteLine("5 quiz");
//            Console.WriteLine("1 mid  and 1 final");
//        }
//    }
//}

//SWITCH CASE
Console.WriteLine("JOB EMPLOYMENT");
Console.WriteLine("ENTER YOUR AGE");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("ENTER YOUR GENDER");
string gen = Console.ReadLine();
switch (gen)
{
    case "male":
        switch (age)
        {
            case 18:
            case 19:
            case 20:
            case 21:
            case 22:
            case 23:
                Console.WriteLine("you can not apply for this job");
                break;
            default:
                Console.WriteLine("you can apply for the job");
                break ;
        }
        break;
    case "female":
        switch (age)
        {
            case 20:
            case 21:
            case 22:
            case 23:
            case 24:
            case 25:
                Console.WriteLine("you can not apply for this job");
                break;
            default:
                Console.WriteLine("you can apply for the job");
                break;
        }

        break;
}