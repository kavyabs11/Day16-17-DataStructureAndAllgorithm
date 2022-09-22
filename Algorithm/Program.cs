using Algorithm;

Console.WriteLine("Hello, to the algorithm and data structure problems");
Console.WriteLine("Enter a sentence");
String s = Console.ReadLine();
String[] array = s.Split(' ');
Console.WriteLine();
string[] newArray = Algo.MergeSort(array, 0, array.Length - 1);
Console.WriteLine("New Array -");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(newArray[i] + " ");
}