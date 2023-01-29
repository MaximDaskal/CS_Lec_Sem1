
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Task2. Determining the maximum and the minimum number");
Console.Write("Input your first number: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your second number: ");
int second = Convert.ToInt32(Console.ReadLine());

if(first > second)
{
    Console.Write($"Max = {first}; Min = {second}");
}
else
{
    Console.Write($"Max = {second}; Min = {first}");
}


/*
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Task4. Determining the maximum number out of three numbers");
Console.Write("Input your first number: ");
int first4 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your second number: ");
int second4 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your third number: ");
int third4 = Convert.ToInt32(Console.ReadLine());

int num;

if(first4 > second4)
{
    num = first4;
}
else
{
    num = second4;
}

if(num > third4)
{
    Console.Write($"Maximum number is: {num}");
}
else
{
     Console.Write($"Maximum number is: {third4}");
}
*/

/*
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Task6. Determining the number is even or odd");
Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

int num2 = number % 2;

if(num2 == 0)
{
    Console.Write($"Number {number} is even");
}
else
{
    Console.Write($"Number {number} is odd");
}
*/

/*
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Task8. Put all even nubers from 1 to  the input number");
Console.Write("Input your number: ");
int number8 = Convert.ToInt32(Console.ReadLine());

int numV = 2;

while (numV <= number8)
{
   Console.Write($"{numV} ");
    numV = numV + 2;
}
*/




