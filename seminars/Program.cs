// Напишите программу которая на входе принимает два целых числа и проверяет
// является ли первое число квадратом

Console.Write("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 == number2 * number2)
{
    Console.WriteLine($"Квадрат числа {number2} равен {number1}");
}
else Console.WriteLine("Квадрат числа {0} не равен {1}", number1, number2);


string number3 = Convert.ToString(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine(number3);

int N = Convert.ToInt32(Console.ReadLine());
int notN = -N;

while (notN <= N)
{
    Console.Write($"{notN} ");
    notN++;
}
