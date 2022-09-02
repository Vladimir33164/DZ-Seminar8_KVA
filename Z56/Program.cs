//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки
//с наименьшей суммой элементов: 1 строка.


int m, n; // объявления переменных, размеры матрицы
int sum = 0, ind = 0, min = int.MaxValue; // переменные: сумма в строке, номер строки с наименьшей суммой и наим. сумма
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
    sum = 0; // обнуляем сумму текущей строки
    for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
        sum += matrix[i, j];
    if (sum < min) // если сумма чисел в строке меньше чем наш минимум, то
    {
        min = sum; // запоминаем сумму
        ind = i; // и запоминаем номер строки
    }

}

Console.WriteLine("Line number with the smallest amount = " + (ind + 1)); // выводим результат

