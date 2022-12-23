int a;
Console.Write($"Введите трёхзначное число ");
int.TryParse(Console.ReadLine()!, out a);
Console.WriteLine($"Второе число-> {a / 100 + 1}");

