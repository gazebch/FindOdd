// See https://aka.ms/new-console-template for more information
var collection = Console.ReadLine().Split(new char[] { ' ' }).Select(it => int.Parse(it)).ToArray();
var odd = from c in collection
          where c % 2 == 0
          select c;
if (odd.Count() != 0)
{
    foreach (int i in odd)
    {
        Console.WriteLine(i);
        break;
    }
}
else Console.WriteLine("четных чисел не имеется или список пуст");
