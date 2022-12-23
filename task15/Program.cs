int[] a = {1, 2, 3, 4, 5, 6, 7,};
int b;
Console.Write($"Введите число ");
int.TryParse(Console.ReadLine()!, out b);
if(b == 6 | b == 7)
{
    Console.Write($"Это выходной день");
}
else
{
    Console.Write($"Это не выходной день");
}










