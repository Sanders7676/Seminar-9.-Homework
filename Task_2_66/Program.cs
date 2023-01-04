// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



Console.WriteLine();

Console.Write("Ведите число M: ");

int numberM = InputInt();

Console.WriteLine();

Console.Write("Ведите число N: ");

int numberN = InputInt();

Console.WriteLine();

GetSumFromNumberMToNumberN(numberM, numberN, 0);

Console.WriteLine();



///Метод нахождения суммы натуральных элементов в промежутке от M до N

void GetSumFromNumberMToNumberN (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N равна: {sum}"); 
        return;
    }
    sum = sum + (numberM++);

    GetSumFromNumberMToNumberN(numberM, numberN, sum);
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