// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Clear(); //очистка терминала при запуске
Console.WriteLine("Привет, друг! Определим МАКСИМАЛЬНОЕ из трех чисел?");
Console.WriteLine("Начинаем? Приготовься придумать три целых числа и ввести их");
Console.WriteLine("Введите ПЕРВОЕ целое число: ");
int num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ВТОРОЕ целое число: ");
int num2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ТРЕТЬЕ целое число: ");
int num3=Convert.ToInt32(Console.ReadLine());

if (num1==num2&&num2==num3)
{
    Console.WriteLine("Все введенные вами числа равны, давай придумаем разные числа?))");
}
else
{int max = Math.Max(num1, Math.Max(num2, num3));
 Console.WriteLine("{0} наибольшее число из трех введенных", max);
}