// Console.WriteLine("Введите начальное число M:");
// int numberM = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите начальное число M:");
// int numberN = int.Parse(Console.ReadLine());
// void GapNumberSum (int numberM, int numberN, int sum)
// {
//     if (numberM > numberN) 
//     {
//         Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
//         return;
//     }
//     sum = sum + (numberM++);
//     GapNumberSum(numberM, numberN, sum);
// }
// GapNumberSum(numberM, numberN, 0);



// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");

// int functionAkkerman = Ack(m, n);

// Console.Write($"Функция Аккермана = {functionAkkerman} ");

// int Ack(int m, int n)
// {
//   if (m == 0) return n + 1;
//   else if (n == 0) return Ack(m - 1, 1);
//   else return Ack(m - 1, Ack(m, n - 1));
// }

// int InputNumbers(string input) 
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }