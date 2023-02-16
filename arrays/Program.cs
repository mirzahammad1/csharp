// See https://aka.ms/new-console-template for more information
Console.WriteLine("LAB # 9");
//int[] class_ids = new int[4];
//int [] marks = new int[5];

//for (int c_id = 0; c_id < class_ids.Length; c_id++)
//{
//	Console.WriteLine("enter class id {0}",c_id);
//	class_ids[c_id] = int.Parse(Console.ReadLine());
//	for (int s_m = 0; s_m < marks.Length; s_m++)
//	{
//		Console.WriteLine("enter student {0} marks:",s_m);
//		marks[s_m] = int.Parse(Console.ReadLine());
//	}
//	int sum=0;
//	int avg = 0;
//	foreach (int id in marks)
//	{
//		sum += id;
//	}
//	avg = sum / marks.Length;
//	Console.WriteLine("avg of class id {0} is {1}", c_id, avg);
//}

// searching in array and replace an element on specific index
//string[] course_name= new string[5];

//int loop = 0;
//do
//{
//    Console.WriteLine("enter course name {0}", loop);
//    course_name[loop] = Console.ReadLine();
//    loop++;
//} while (loop < course_name.Length);

//Console.WriteLine("enter an element to be searched");
//string course_search = Console.ReadLine();
//int counter = 0;
//while (counter < course_name.Length)
//{
//    if (course_search == course_name[counter])
//    {
//        Console.WriteLine("element found at index {0}",counter);
//        course_name[counter] = Console.ReadLine();
//        Console.WriteLine(course_name[counter]);
//    }
//    counter++;
//}

//Console.WriteLine("test");
//int[] number = new int[2];
//int sum = 0;

//for (int i = 0; i < number.Length; i++)
//{
//    number[i] = int.Parse(Console.ReadLine());	
//	sum = sum +  number[i];


//}
//	if (sum >5 && sum <20)
//	{
//	//Array.Resize(ref number, number.Length + 1)
//	number = number.Append(sum).ToArray();
//	}


//foreach (var item in number)
//{
//	Console.WriteLine(item);
//}

int[] arr1 = new int[100];
int[] arr2 = new int[100];
int[] arr3 = new int[200];
int s1, s2, s3;
int i, j, k;


Console.Write("\n\nMerge two arrays of same size sorted in ascending order.\n");
Console.Write("------------------------------------------------------------\n");

Console.Write("Input the number of elements to be stored in the first array :");
s1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input {0} elements in the array :\n", s1);
for (i = 0; i < s1; i++)
{
    Console.Write("element - {0} : ", i);
    arr1[i] = Convert.ToInt32(Console.ReadLine());
}


Console.Write("Input the number of elements to be stored in the second array :");
s2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input {0} elements in the array :\n", s2);
for (i = 0; i < s2; i++)
{
    Console.Write("element - {0} : ", i);
    arr2[i] = Convert.ToInt32(Console.ReadLine());
}

/* size of merged array is size of first array and  size of second array */
s3 = s1 + s2;

/*----------------- insert in the third array------------------------------------*/
for (i = 0; i < s1; i++)
{
    arr3[i] = arr1[i];
}
for (j = 0; j < s2; j++)
{
    arr3[i] = arr2[j];
    i++;
}
/*----------------- sort the array in ascending order ---------------------------*/
for (i = 0; i < s3; i++)
{
    for (k = 0; k < s3 - 1; k++)
    {

        if (arr3[k] >= arr3[k + 1])
        {
            j = arr3[k + 1];
            arr3[k + 1] = arr3[k];
            arr3[k] = j;
        }
    }
}
for (i = 0; i < s3; i++)
{
    for (k = 0; k < s3 - 1; k++)
    {

        if (arr3[k] <= arr3[k + 1])
        {
            j = arr3[k + 1];
            arr3[k + 1] = arr3[k];
            arr3[k] = j;
        }
    }
}
/*--------------- Prints the merged array ------------------------------------*/
Console.Write("\nThe merged array in ascending order is :\n");
for (i = 0; i < s3; i++)
{
    Console.Write("{0} ", arr3[i]);
}
Console.Write("\n\n");


//int[] arr1 = new int[100];
//int[] arr2 = new int[100];
//int[] arr3 = new int[200];
//int s1, s2, s3;
//int i, j, k;


//Console.WriteLine("\n\nMerge two arrays of same size sorted in decending order.\n");
//Console.WriteLine("------------------------------------------------------------\n");

//Console.WriteLine("Input the number of elements to be stored in the first array :");
//s1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Input {0} elements in the array :\n", s1);
//for (i = 0; i < s1; i++)
//{
//    Console.WriteLine("element - {0} : ", i);
//    arr1[i] = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("Input the number of elements to be stored in the second array :");
//s2 = int.Parse(Console.ReadLine());

//Console.WriteLine("Input {0} elements in the array :\n", s2);
//for (i = 0; i < s2; i++)
//{
//    Console.WriteLine("element - {0} : ", i);
//    arr2[i] = int.Parse(Console.ReadLine());
//}

///* size of merged array is size of first array and  size of second array */
//s3 = s1 + s2;
///*----------------- insert in the third array------------------------------------*/
//for (i = 0; i < s1; i++)
//{
//    arr3[i] = arr1[i];
//}
//for (j = 0; j < s2; j++)
//{
//    arr3[i] = arr2[j];
//    i++;
//}
///*----------------- sort the array in decending order ---------------------------*/
//for (i = 0; i < s3; i++)
//{
//    for (k = 0; k < s3 - 1; k++)
//    {

//        if (arr3[k] <= arr3[k + 1])
//        {
//            j = arr3[k + 1];
//            arr3[k + 1] = arr3[k];
//            arr3[k] = j;
//        }
//    }
//}

///*--------------- Prints the merged array ------------------------------------*/
//Console.WriteLine("\nThe merged array in decending order is :\n");
//for (i = 0; i < s3; i++)
//{
//    Console.WriteLine("{0}", arr3[i]);
//}
