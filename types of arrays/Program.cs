// See https://aka.ms/new-console-template for more information
Console.WriteLine("----------------------------LAB # 10----------------------------");
Console.WriteLine("--------------------MULTI-DIMENTIONAL--ARRAY--------------------");
// 2 dimentional array
int[,] two_dimentional = new int[2, 3];
two_dimentional[0,0] = 1;
two_dimentional[0,1] = 2;
two_dimentional[0,2] = 3;
two_dimentional[1,1] = 3;
two_dimentional[1,0] = 9;
two_dimentional[1,2] = 2;
foreach (int i in two_dimentional)
{
    Console.WriteLine(i);
}

int[,] _2_dimentional = new int[2, 3];
for (int row = 0; row < _2_dimentional.GetLength(0); row++) //row
{
	for (int col = 0; col < _2_dimentional.GetLength(1); col++)//col
	{
		Console.WriteLine("enter value at row {0} and {1} ",row,col);
		_2_dimentional[row, col] = int.Parse(Console.ReadLine());
	}
}
// print 2 d array using for each
foreach (var item in _2_dimentional)
{
	Console.Write(item + " ");
}
// using for
string[] header = { "roll#1", "roll#2", "roll#3" };
Console.WriteLine();
for (int i = 0; i < header.Length; i++)
{
	Console.Write(header[i] + "  | ");
}
Console.WriteLine();
for (int i = 0; i < _2_dimentional.GetLength(0); i++)
{
	for (int j = 0; j < _2_dimentional.GetLength(1); j++)
	{
		Console.Write(_2_dimentional[i, j] + "       | ");
	}
	Console.WriteLine();
}