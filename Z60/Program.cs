//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)


int x, y, z; // объявления переменных, размеры матрицы
SortedSet<int> set_nums = new SortedSet<int>(); // создаем множество чисел, чтобы не было повторений в матрице
Console.WriteLine("Enter the dimensions of the three-dimensional matrix x * y * z : "); // ввод данных
Console.Write("z: ");
x = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
y = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
z = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = new int[x, y, z]; // создание трехмерной матрицы 
Random rand = new Random(); // Random для случайного заполнения матрицы

Console.WriteLine("Formed three-dimensional matrix:"); // выводим результат

for (int i = 0; i < matrix.GetLength(0); i++) // тройной цикл, так как матрица трехмерная
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            int num = rand.Next(10, 100); // случайно генерируем двузначное число

            while (set_nums.Contains(num)) // пока число уже занято, то пробуем еще раз случайно сгенерировать другое
            {
                num = rand.Next(10, 100);
            }
            set_nums.Add(num); // добавляем во множество
            matrix[i, j, k] = num; // записываем в матрицу
            Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) "); // выводим на экран

        }
        Console.WriteLine();
    }
}