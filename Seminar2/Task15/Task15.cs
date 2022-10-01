int n = Convert.ToInt32(Console.ReadLine());
if (n > 1 && n < 6)
   Console.WriteLine("Будний день");
else if (n > 5 && n < 8) 
   Console.WriteLine("Выходной день");
else if (n < 1 || n > 7)
   Console.WriteLine("Попробуй еще раз");
   
   