//Задача 58: Задайте две матрицы. Напишите программу,
//которая будет находить произведение двух матриц.

//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3

//Результирующая матрица будет:
//18 20
//15 18


int m1, n1, m2, n2; // объявления переменных, размеры матриц
Console.Write("Enter the number of rows in the 1st matrix: "); // ввод данных
m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns in the 1st matrix: ");
n1 = Convert.ToInt32(Console.ReadLine());
int[,] A = new int[m1, n1]; // создание 1-ой матрицы 
Console.Write("Enter the number of rows in the 2st matrix: "); // ввод данных
m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns in the 2st matrix: ");
n2 = Convert.ToInt32(Console.ReadLine());
int[,] B = new int[m2, n2]; // создание 2-ой матрицы 

if (n1 != m2) // если количество столбцов 1-ой матрицы не равно количество строк 2-ой, то выводим ошибку
{
    Console.WriteLine("Matrices cannot be multiplied (the number of columns of the 1st should be equal to the number of rows of the 2nd ...).");
                    // Матрицы невозможно перемножить (количество столбцов 1-ой должно быть равно количеству строк 2-ой...) (rus)
}
else
{
    Random rand = new Random(); // Random для случайного заполнения матрицы
    Console.WriteLine("Randomly filled matrix A: "); // "Случайно заполненная матрица A:"(rus)
    for (int i = 0; i < A.GetUpperBound(0) + 1; i++) // проходимся в двойном цикле по строкам и столбцам
    {
        for (int j = 0; j < A.GetUpperBound(1) + 1; j++)
        {
            A[i, j] = rand.Next(-10, 10); // заполняем матрицу A случайным целым числом
            Console.Write(A[i, j] + " "); // выводим элементы матрицы через пробел
        }
        Console.WriteLine(); // осуществляем переход на новую строку
    }

    Console.WriteLine("Randomly filled matrix B: "); //"Случайно заполненная матрица B:"(rus)
    for (int i = 0; i < B.GetUpperBound(0) + 1; i++) // проходимся в двойном цикле по строкам и столбцам
    {
        for (int j = 0; j < B.GetUpperBound(1) + 1; j++)
        {
            B[i, j] = rand.Next(-10, 10); // заполняем матрицу B случайным целым числом
            Console.Write(B[i, j] + " "); // выводим элементы матрицы через пробел
        }
        Console.WriteLine(); // осуществляем переход на новую строку
    }

    int[,] C = new int[m1, n2]; // создаем результирующую матрицу C
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < B.GetLength(1); j++)
        {
            for (int k = 0; k < B.GetLength(0); k++)
            {
                C[i, j] += A[i, k] * B[k, j]; // перемножаем элементы
            }
        }
    }

    // вывод результата произведения матриц
    Console.WriteLine("Product of matrices = :"); // "Произведение матриц (rus)"
    for (int i = 0; i < C.GetUpperBound(0) + 1; i++) // проходимся в двойном цикле по строкам и столбцам
    {
        for (int j = 0; j < C.GetUpperBound(1) + 1; j++)
        {
            Console.Write(C[i, j] + " "); // выводим элементы матрицы C через пробел
        }
        Console.WriteLine(); // осуществляем переход на новую строку
    }
}