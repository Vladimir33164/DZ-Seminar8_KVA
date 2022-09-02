//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:

//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07



int n = 4; // размер матрицы
int[,] matrix = new int[n, n]; // создаем матрицу 4 на 4
int k = 1; // с помощью переменной k задаем числа внутри массива начиная с 1

// заполняем периметр массива по часовой стрелке
for (int y = 0; y < n; y++)
{
    matrix[0, y] = k;
    k++;
}
for (int x = 1; x < n; x++)
{
    matrix[x, n - 1] = k;
    k++;
}
for (int y = n - 2; y >= 0; y--)
{
    matrix[n - 1, y] = k;
    k++;
}
for (int x = n - 2; x > 0; x--)
{
    matrix[x, 0] = k;
    k++;
}

// продолжаем заполнять массив и задаём координаты ячейки, которую необходимо заполнить следующей.
int c = 1;
int d = 1;

while (k < n * n)
{
    // движемся вправо
    while (matrix[c, d + 1] == 0)
    {
        matrix[c, d] = k;
        k++;
        d++;
    }

    // движемся вниз
    while (matrix[c + 1, d] == 0)
    {
        matrix[c, d] = k;
        k++;
        c++;
    }

    // движемся влево
    while (matrix[c, d - 1] == 0)
    {
        matrix[c, d] = k;
        k++;
        d--;
    }

    // движемся вверх
    while (matrix[c - 1, d] == 0)
    {
        matrix[c, d] = k;
        k++;
        c--;
    }
}

//  в центре есть незаполненная ячейка, убираем ее
for (int x = 0; x < n; x++)
{
    for (int y = 0; y < n; y++)
    {
        if (matrix[x, y] == 0)
        {
            matrix[x, y] = k;
        }
    }
}

Console.WriteLine("The formed matrix:");
for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++) // проходимся в двойном цикле по строкам и столбцам
{
    for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
    {
        Console.Write(matrix[i, j] + " "); // выводим элементы матрицы через пробел
    }
    Console.WriteLine(); // осуществляем переход на новую строку
}