int n = Convert.ToInt32(Console.ReadLine());

if (n / 100 == 0)
   Console.WriteLine("Нет третьей цифры");
else {
    while (true) {
        if (n / 100 > 10) n /= 10;
        else {
            Console.WriteLine(n % 10);
            break;
        }
    }
}

