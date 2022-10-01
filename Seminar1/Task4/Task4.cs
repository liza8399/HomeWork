Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (a > b && a > c) {
    max = a;
    Console.WriteLine(max);
}
else if (b > a && b > c) {
    max = b;
    Console.WriteLine(max);
}
else if (c > b && c > a) {
    max = c;
    Console.WriteLine(max);
}