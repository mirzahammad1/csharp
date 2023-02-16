// See https://aka.ms/new-console-template for more information
//int val1 = 10;
//int val2 = 20;
//int val3 = 10;

//bool both_are_equal = val1 == val3;
//Console.WriteLine("val1 and val3 are equal :" + both_are_equal);
//// concatinate with +
//bool bothareequal = val1 == val2;
//Console.WriteLine("val1 and val2 are equal : {0}" , bothareequal);
//// space seq
//Console.WriteLine("{0} = val1 {1} = val2 {2} = val3" , val1 , val2 , val3);
//Console.WriteLine("Values of var are {0} , {1} and {2}", val1, val2, val3);
//bool response = (val1 == val3) || (val2 == val3) && (val1 == val2);
//Console.WriteLine(response);
//int counter = 0;
//counter++;
//Console.WriteLine("update 1 : {0}" , counter);
//counter++;
//Console.WriteLine("update 2 : {0}", counter);
//counter--;
//Console.WriteLine("decrement : {0}", counter);
//bool compare_counter = counter > 0;
//Console.WriteLine("counter value {0} is greater than {1}" , counter , 0);

// marks of course
//int eng = 90;
//int math = 80;
//int prog = 70;
//Console.WriteLine("Course list....");
//Console.WriteLine("english \n math \n programming");
//Console.WriteLine("which course marks do you want to know");
//string course_name = Console.ReadLine();
//bool course_eng = course_name.ToUpper() == "ENGLISH";
//bool final_result_1 = course_eng == true;
//Console.WriteLine("your {0} course marks are : {1}" ,course_name, eng);
//bool highest_marks = (eng > math) && (math > prog) && (eng > prog);
//Console.WriteLine("your enlisgh marks are highest : " + highest_marks);

int a = 5;
int b = 10;
a += b;
Console.WriteLine(a);

int c = 5;
int d = 10;
c -= d;
Console.WriteLine(c);

int e = 5;
int f = 10;
e *= f;
Console.WriteLine(e);

int g = 5;
int h = 10;
g /= h;
Console.WriteLine(g);
Console.ReadKey();
