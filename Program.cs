// See https://aka.ms/new-console-template for more information
var collection = Console.ReadLine().Split(new char[] { ' ' }).Select(it => int.Parse(it)).ToArray();
var odd = collection.FirstOrDefault(c => c % 2 == 0, 3);
if (odd != 3)
{
    Console.WriteLine(odd);
}
else Console.WriteLine("четных чисел не имеется или список пуст");
