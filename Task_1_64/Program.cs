// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"




Console.WriteLine();

Console.Write("Ведите число: ");

int number = InputInt();

Console.WriteLine();

GetNatureNumbersNtoOne(number, 1);



// Метод вывода чисел от N до 1

void GetNatureNumbersNtoOne(int number, int finish = 1)
{
    if (number < finish)
    {
        return;
    }
    Console.Write($"{number} ");

    GetNatureNumbersNtoOne(number - 1, finish);

}



// Метод для приема чисел, вводимых через консоль

int InputInt()
{
    bool isNum = int.TryParse(Console.ReadLine(), out int num);

    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Введено некорректное значение.");
        return -1;
    }
}