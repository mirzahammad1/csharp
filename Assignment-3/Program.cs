// See https://aka.ms/new-console-template for more information
//----------------------------Q#1--------------------------------------
Console.WriteLine("---------------------------------Q # 1.---------------------------------");
string[] arr1= new string[3];
Console.WriteLine("Input elements for array");
for (int x = 0; x < arr1.Length; x++)
{
    Console.Write("index -- {0} " , x);
    arr1[x] = Console.ReadLine();
}
string arr2 = string.Concat(arr1);
Console.WriteLine(arr2);

//char[] charArr = arr2.ToCharArray();
Dictionary<char, int> dict = new Dictionary<char, int>();
foreach (char ch in arr2.Replace(" ", string.Empty))
{
    if (dict.ContainsKey(ch))
    {
        dict[ch] = dict[ch] + 1;
    }
    else
    {
        dict.Add(ch, 1);
    }
}
foreach (var item in dict.Keys)
{
    Console.WriteLine(item + " : " + dict[item]);
}
Console.WriteLine("\n");
//----------------------------Q#2--------------------------------------
int[] array3 = new int[200];
int a, b, c;
int i, j, k;

Console.WriteLine("---------------------------------Q # 2.---------------------------------");
Console.WriteLine("Input the number of indexes you want for 1st array :");
int[] array1 = new int[a=int.Parse(Console.ReadLine())];
Console.WriteLine("Input {0} elements in the array : ", a);
for (i = 0; i < array1.Length; i++)
{
    Console.Write("index -- {0} : ", i);
    array1[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Input the number of indexes you want for 1st array :");
int[] array2 = new int[b=int.Parse(Console.ReadLine())];
Console.WriteLine("Input {0} elements in the array : ", b);
for (i = 0; i < b; i++)
{
    Console.Write("index -- {0} : ", i);
    array2[i] = Convert.ToInt32(Console.ReadLine());
}

for (i = 0; i < a; i++)
{
    array3[i] = array1[i];
}
for (j = 0; j < b; j++)
{
    array3[i] = array2[j];
    i++;
}
c = a + b;

for (i = 0; i < c; i++)
{
    for (k = 0; k < c - 1; k++)
    {
        if (array3[k] <= array3[k + 1])
        {
            j = array3[k + 1];
            array3[k + 1] = array3[k];
            array3[k] = j;
        }
    }
}
Console.WriteLine("The merged array in descending order is :");
for (i = 0; i < c; i++)
{
    Console.Write(" {0} ",array3[i]);
}