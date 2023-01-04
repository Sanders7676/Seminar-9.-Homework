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

int SumFromNumberMToNumberN = GetSumFromNumberMToNumberN(numberM, numberN);

Console.WriteLine(SumFromNumberMToNumberN);

Console.WriteLine();



// Метод вывода чисел от N до 1

int GetSumFromNumberMToNumberN(int numberM, int numberN, int sum = 0, int count = 1)
{
    if (count <= (numberN - numberM))
    {
        sum = sum + numberM;

        sum = GetSumFromNumberMToNumberN(numberM, numberN, sum + (numberM + 1), count + 1);
    }
    return sum;
}



// int GetSumFromNumberMToNumberN(int numberM, int numberN, int sum = 0, int count = 1)
// {
//     if (count <= (numberN - numberM))
//     {
//         sum = sum + GetSumFromNumberMToNumberN(numberM, numberN, sum + (numberM +1), count + 1);
//     }
//     return sum;
// }


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