// Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Введите первое число");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int b = Convert.ToInt32(Console.ReadLine());

// if(a > b)
// {
//     Console.Write(a);
//     Console.Write(" - большее число, ");
//     Console.Write(b);
//     Console.Write(" - меньшее число");
// }

// else
// {
//     Console.Write(a);
//     Console.Write(" - меньшее число, ");
//     Console.Write(b);
//     Console.Write(" - большее число");
// }



//  Напишите программу, которая принимает на вход три числа
//  и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите первое число");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите третье число");
// int c = Convert.ToInt32(Console.ReadLine());

// int max = a;

// if(a > max) max = a;
// if(b > max) max = b;
// if(c > max) max = c;

// Console.Write("максимальное число - ");
// Console.Write(max);



// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if((number % 2) == 0)
{
    Console.Write(number);
    Console.Write(" - четное");
}
else
{
    Console.Write(number);
    Console.Write(" - нечетное");
}