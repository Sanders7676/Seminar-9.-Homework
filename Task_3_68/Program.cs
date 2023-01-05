// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



Console.WriteLine();

Console.Write("Ведите число M: ");

int numberM = InputInt();

Console.WriteLine();

Console.Write("Ведите число N: ");

int numberN = InputInt();

Console.WriteLine();

Console.WriteLine($"Значение Функции Аккермана A({numberM},{numberN}) равно: {GetValueAckermannFunction(numberM, numberN)}");

Console.WriteLine();



// Метод вычисления функции Аккермана

int GetValueAckermannFunction (int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    
    if (numberM != 0 && numberN == 0) 
    {
        return GetValueAckermannFunction(numberM - 1, 1);
    }
    
    if (numberM > 0 && numberN > 0) 
    {
        return GetValueAckermannFunction(numberM - 1, GetValueAckermannFunction(numberM, numberN - 1));
    }
    
    return GetValueAckermannFunction(numberM, numberN);
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