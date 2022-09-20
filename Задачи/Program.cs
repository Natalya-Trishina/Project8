//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

{
    Console.Clear();
    Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива : ");
    Console.WriteLine("Введите размер массива m x n и диапазон случайных значений:");
    int m = InputNumbers("Введите m: ");
    int n = InputNumbers("Введите n: ");
    int range = InputNumbers("Введите диапазон: от 1 до ");

    int[,] array = new int[m, n];
    CreateArray(array);
    WriteArray(array);

    Console.WriteLine($"\nОтсортированный массив: ");
    OrderArrayLines(array);
    WriteArray(array);

    void OrderArrayLines(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(1) - 1; k++)
                {
                    if (array[i, k] < array[i, k + 1])
                    {
                        int temp = array[i, k + 1];
                        array[i, k + 1] = array[i, k];
                        array[i, k] = temp;
                    }
                }
            }
        }
    }

    int InputNumbers(string input)
    {
        Console.Write(input);
        int output = Convert.ToInt32(Console.ReadLine());
        return output;
    }

    void CreateArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(range);
            }
        }
    }

    void WriteArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

{
    Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов : ");
    int[,] table = new int[4, 4];
    FillArrayRandom(table);
    PrintArray(table);
    Console.WriteLine();
    NumberRowMinSumElements(table);

    void NumberRowMinSumElements(int[,] array)
    {
        int minRow = 0;
        int minSumRow = 0;
        int sumRow = 0;
        for (int i = 0; i < table.GetLength(1); i++)
        {
            minRow += table[0, i];
        }
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++) sumRow += table[i, j];
            if (sumRow < minRow)
            {
                minRow = sumRow;
                minSumRow = i;
            }
            sumRow = 0;
        }
        Console.Write($"{minSumRow + 1} строка");
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    void FillArrayRandom(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 10);
            }
        }
    }
}


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
{
    Console.WriteLine(" Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц:");
    int m = Input("Введите количество строк первой матрицы m: ");
    int n = Input("Введите количество столбцов первой матрицы n: ");
    int o = Input("Введите количество строк второй матрицы o: ");
    int p = Input("Введите количество столбцов второй матрицы p: ");

    int[,] oneArray = new int[m, n];
    FillArray(oneArray);
    Console.WriteLine("Первая матрица");
    PrintArray(oneArray);

    int[,] twoArray = new int[o, p];
    FillArray(twoArray);
    Console.WriteLine("Вторая матрица");
    PrintArray(twoArray);

    int[,] matrixSumm = Сomposition(oneArray, twoArray);
    PrintArray(matrixSumm);

    int[,] Сomposition(int[,] matrix1, int[,] matrix2)
    {
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            Console.WriteLine("Нет возможности найти произведение матриц");
            return matrix1;
        }
        int[,] matrixSumm = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    matrixSumm[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return matrixSumm;
    }

    int Input(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    void FillArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 10);
            }
        }
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

{
    Console.WriteLine("Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел :");
    Console.WriteLine($"Введите размер массива X x Y x Z: ");
    int x = InputNumbers("Введите X: ");
    int y = InputNumbers("Введите Y: ");
    int z = InputNumbers("Введите Z: ");
    Console.WriteLine($"");

    int[,,] array3D = new int[x, y, z];
    CreateArray(array3D);
    WriteArray(array3D);

    int InputNumbers(string input)
    {
        Console.Write(input);
        int output = Convert.ToInt32(Console.ReadLine());
        return output;
    }

    void WriteArray(int[,,] array3D)
    {
        for (int i = 0; i < array3D.GetLength(0); i++)
        {
            for (int j = 0; j < array3D.GetLength(1); j++)
            {
                Console.Write($"X({i}) Y({j}) ");
                for (int k = 0; k < array3D.GetLength(2); k++)
                {
                    Console.Write($"Z({k})={array3D[i, j, k]}; ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    void CreateArray(int[,,] array3D)
    {
        int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
        int number;
        for (int i = 0; i < temp.GetLength(0); i++)
        {
            temp[i] = new Random().Next(10, 100);
            number = temp[i];
            if (i >= 1)
            {
                for (int j = 0; j < i; j++)
                {
                    while (temp[i] == temp[j])
                    {
                        temp[i] = new Random().Next(10, 100);
                        j = 0;
                        number = temp[i];
                    }
                    number = temp[i];
                }
            }
        }
        int count = 0;
        for (int x = 0; x < array3D.GetLength(0); x++)
        {
            for (int y = 0; y < array3D.GetLength(1); y++)
            {
                for (int z = 0; z < array3D.GetLength(2); z++)
                {
                    array3D[x, y, z] = temp[count];
                    count++;
                }
            }
        }
    }
}

