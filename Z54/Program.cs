// Задача 54: Задайте двумерный массив.
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.



int m, n; // объявления переменных, размеры матрицы
Console.Write("Enter the number of rows in the matrix: "); // ввод данных
m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns in the matrix: ");
n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n]; // создание матрицы 
Random rand = new Random(); // Random для случайного заполнения матрицы
Console.WriteLine("Randomly filled matrix: ");
for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++) // проходимся в двойном цикле по строкам и столбцам
{
    for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
    {
        matrix[i, j] = rand.Next(-10, 10); // заполняем матрицу случайным целым числом
        Console.Write(matrix[i, j] + " "); // выводим элементы матрицы через пробел
    }
    Console.WriteLine(); // осуществляем переход на новую строку
}

for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++) // проходимся в двойном цикле по строкам
{
    for (int j = 0; j < matrix.GetUpperBound(1); j++)
        if (matrix[i, j] < matrix[i, j + 1]) // если текущий элемент меньше своего правого соседа, то
        {
            int tmp = matrix[i, j]; // меняем их местами с помощью вспомогательной переменной
            matrix[i, j] = matrix[i, j + 1];
            matrix[i, j + 1] = tmp;
        }
}
Console.WriteLine("Sorted Matrix: ");
// выводим отсортированную по убыванию матрицу по строкам на экран
for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++) // проходимся в двойном цикле по строкам и столбцам
{
    for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
    {
        Console.Write(matrix[i, j] + " "); // выводим элементы матрицы через пробел
    }
    Console.WriteLine(); // осуществляем переход на новую строку
}