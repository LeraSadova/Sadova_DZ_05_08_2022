// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Clear(); //очистка терминала при запуске
Console.WriteLine("Привет, друг! Определим какое из двух числе больше, а какое меньше? :)");
Console.WriteLine("Начинаем? Приготовься придумать два целых числа и ввести их");
Console.WriteLine("Введите ПЕРВОЕ целое число: ");
int num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ВТОРОЕ целое число: ");
int num2=Convert.ToInt32(Console.ReadLine());

if (num1>num2)
    {
       Console.WriteLine("{0} наибольшее число", num1);
    }
else if (num2>num1)
 
    {
        Console.WriteLine("{0} наибольшее число ", num2);
    }
else {Console.WriteLine("Введенные числа равны");}
