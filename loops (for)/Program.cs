// See https://aka.ms/new-console-template for more information
//Console.WriteLine("LAB # 7");
////loop
////FOR LOOP
//Console.WriteLine("enter a number");
//int num = int.Parse(Console.ReadLine());
//for (int i = 1; i < 11; i++)
//{
//    Console.WriteLine(num + "*" + i + "=" + num*i );

//}
//Console.WriteLine("enter lower");
//int lower = int.Parse(Console.ReadLine());
//Console.WriteLine("enter upper");
//int upper = int.Parse(Console.ReadLine());
//for (int counter = lower; counter <= upper; counter++)
//{
//    Console.WriteLine("loop count " + counter);
//}

////WHILE LOOP
//int count = 1;
//while (count<10)
//{
//    Console.WriteLine("this is while");
//    Console.WriteLine("next loop");
//    count++;
//}
////DO WHILE LOOP
//int loop_count = 1;
//do
//{
//    Console.WriteLine(loop_count);
//    loop_count++;
//} while (loop_count<10);
////FOR EACH LOOP just to get data
//ARRAY
//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
//foreach (int no in numbers)
//{

//Console.WriteLine(no);
//}

string[] names = new string[3];
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine("enter names " + i);
    names[i] = Console.ReadLine();
}
