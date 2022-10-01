Console.Write("Введите число х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)));