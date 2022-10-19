/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());


void printRange(int M, int N, int sum)
{
    if (M > N)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + M++;  
    printRange(M, N, sum);   
}

printRange(M, N, 0);


    




// Console.WriteLine("Введите начальное число M:");
// int numberM = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите начальное число M:");
// int numberN = int.Parse(Console.ReadLine());

// ///Метод нахождения суммы натуральных элементов в промежутке от M до N
// void GapNumberSum(int numberM, int numberN, int sum)
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

