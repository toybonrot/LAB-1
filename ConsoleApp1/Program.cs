List<int> n = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int x;
foreach (int e in n)
{
    Console.Write(e + " ");
}
Console.WriteLine();
x = int.Parse(Console.ReadLine());
int k = n.IndexOf(x);
if (k == -1)
{
    Console.WriteLine("Немає");
}
else
{
    n.Reverse(0, k);
    n.Reverse(k + 1, n.Count - k - 1);
    foreach (int e in n)
    {
        Console.Write(e + " ");
    }
}


//using System;
//using System.Text.Json;


//Dictionary<int, string> k = new Dictionary<int, string>() { { 1, "one" }, { 2, "two" }, { 3, "three" }, { 4, "four" }, { 5, "five" } };
//Dictionary<int, string> l = new Dictionary<int, string>();
//Console.WriteLine("Ведіть число: ");
//try
//{
//    int x = int.Parse(Console.ReadLine());
//    if (k.ContainsKey(x))
//    {
//        foreach (var e in k)
//        {
//            if (e.Key >= x)
//            {
//                l.Add(e.Key, e.Value);
//            }
//        }
//        foreach (var e in l)
//        {
//            Console.WriteLine(e.Key + " " + e.Value);
//        }
//        string st = JsonSerializer.Serialize(l), FilePath = "C:\\Программирование\\JSON.txt";
//        File.WriteAllText(FilePath, st);
//        Console.WriteLine(st);
//    }
//    else
//    {
//        Console.WriteLine("null");
//    }
//}
//catch (Exception a)
//{
//    Console.WriteLine(a.Message);
//}


//List<int> A = new List<int>() {-2, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 , 11, 13, 15, 25, 45, 25, 15};
//Console.WriteLine("Ведіть число: ");
//try
//{
//    int D = int.Parse(Console.ReadLine());
//    var sD = A.Where(e => e > 0 && e % 10 == D)
//        .Reverse()
//        .Distinct()
//        .Reverse();
//    foreach (var e in sD)
//    {
//        Console.Write(e + " ");
//    }
//}
//catch (Exception a)
//{
//    Console.WriteLine(a.Message);
//}
