// See https://aka.ms/new-console-template for more information
Console.WriteLine("\t \t \t \t \t \t \tAssignment-1");

//Console.WriteLine("Q1: Create a console application for your educational details and show output use minimum 3 datatypes. Show your results with" +
//    " concatenated form.");
//Console.WriteLine("\n");

//Console.WriteLine("Enter Full Name");
//string full_name = Console.ReadLine();

//Console.WriteLine("What are you Studing");
//string uni_name = Console.ReadLine();

//Console.WriteLine("Enter Student ID");
//int student_id = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Your scored marks in inter/D.A.E");
//float marks = float.Parse(Console.ReadLine());


//Console.WriteLine("\n==========================================\n");
//Console.WriteLine("Student name : " + full_name);
//Console.WriteLine("Student of : " + uni_name);
//Console.WriteLine("Student ID : " + student_id);
//Console.WriteLine("I have done my Matric form S.M Public Academy and completed my D.A.E form ALIGARH INSTITUTE of TECHNOLOGY scoring {0} Marks" , marks);

//Console.WriteLine("\n");

//Console.WriteLine("Q2: Formulate any 3 mathematical equations using double / float data type:");
//Console.WriteLine("\n");
//Console.WriteLine("FORMULA: (a+b)^2 = a^2 + b^2 + 2ab");
//Console.WriteLine("Enter First Number");
//float a = float.Parse(Console.ReadLine());
//Console.WriteLine("Enter Second Number");
//float b = float.Parse(Console.ReadLine());
//double c = a + b;
//double d = c * c;
//double e = a * a;
//double f = b * b;
//double g = e + f;
//double h = 2 * a * b;
//double i = g + h;
//Console.WriteLine("{0} = a^2 + b^2 + 2ab ", d);
//Console.WriteLine("{0} = {1}", d, i);
//Console.WriteLine("\n");
//Console.WriteLine("FORMULA: (a+b) * (a-b) = Result");
//float j = a - b;
//double result = c * j;
//Console.WriteLine("{0} * {1} = Result", c, j);
//Console.WriteLine(result);
//Console.WriteLine("\n");
//Console.WriteLine("FORMULA: (a-b)^2 = a^2 + b^2 - 2ab");
//double k = j * j;
//double l = g - h;
//Console.WriteLine("{0} = a^2 + b^2 - 2ab", k);
//Console.WriteLine("{0} = {1}", k, l);

//Console.WriteLine("\n");
//Console.WriteLine("Q3: Write a program that takes four numbers(value_1 , value_2, value_3, value_4) as input and print the output of");
//Console.WriteLine("(value_1 + value_2). Value_3 / value_4\r\nvalue_1. value_2 + value_2.value_3.\r\n Value_4/ value_1. value_2. value_3");
//Console.WriteLine("\n");
//Console.WriteLine("Enter value 1 :");
//float value_1 = float.Parse(Console.ReadLine());
//Console.WriteLine("Enter value 2 :");
//float value_2 = float.Parse(Console.ReadLine());
//Console.WriteLine("Enter value 3 :");
//float value_3 = float.Parse(Console.ReadLine());
//Console.WriteLine("Enter value 4 :");
//float value_4 = float.Parse(Console.ReadLine());
//Console.WriteLine("\n");
//float a = value_1 + value_2;
//float b = value_3 / value_4;
//float c = a * b;
//Console.WriteLine("(value_1 + value_2). Value_3 / value_4 \t = {0} * {1} = {2}", a, b, c);
//Console.WriteLine("\n---------------------------------------------------------------------\n");
//float d = value_1 * value_2;
//float e = value_2 * value_3;
//float f = d + e;
//Console.WriteLine("value_1. value_2 + value_2.value_3. \t = {0} + {1} = {2}", d, e, f);
//Console.WriteLine("\n---------------------------------------------------------------------\n");
//float g = value_4 / value_1;
//float h = g * e;
//Console.WriteLine("Value_4/ value_1. value_2. value_3 \t = {0} * {1} = {2}", g, e, h);

Console.WriteLine("\n");
Console.WriteLine("Q4: Write a program to print the result of the specified operations. " +
    "\r\n -1 + 4 * 6 \r\n(35+ 5) % 7 \r\n14 + -4 * 6 / 11 \r\n2 + 15 / 6 * 1 - 7 % 2 " +
    "\r\n3+3- [5*6]/100 \r\n" +
    "Use appropriate data types to get correct outputs and print all 5 outputs in one writeline " +
    "command in a tabular form on console.");
Console.WriteLine("\n-----------------------------------------------");
double a = -1 + 4 * 6;
double b = 35 + 5;
double c = b % 7;
double d = -4 + 14;
double e = d * 6 / 11;
double f = 2 + 15 / 6 * 1 - 7 % 2;
double g = 5 * 6;
double h = g / 100;
double i = 6 - h;
Console.WriteLine("| -1 + 4 * 6  \t \t | = {0} \n| (35+ 5) % 7         \t | = {1} \n| 14 + -4 * 6 / 11 \t | = {2} \n| " +
    "2 + 15 / 6 * 1 - 7 % 2 | = {3} \n| 3+3- [5*6]/100 \t | = {4} ", a, c, e, f, i);
