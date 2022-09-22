using Algorithm;

Console.WriteLine("Welcome to the algorithm and data structure problems");
Console.WriteLine("Write a sentence");
string s = Console.ReadLine();
Console.WriteLine("Enter the word you want to search");
string search = Console.ReadLine();
string[] words = s.Split(' ');
Algo<string> obj = new Algo<string>();
obj.sortAndCall(words, search);
Console.WriteLine("Enter a sentence");
string S = Console.ReadLine();
string[] sentence = S.Split(' ');
Algo<string>.insertionSort(sentence);