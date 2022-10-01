Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n / 10000 == n % 10 && n % 10000 / 1000 == n % 100 / 10)
{
    Console.WriteLine("Yes");
}
else Console.WriteLine("No");