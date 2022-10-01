Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;

if (a > b){
    max = a;
    Console.WriteLine(max);
}
else {
    max = b;
    Console.WriteLine(max);
}