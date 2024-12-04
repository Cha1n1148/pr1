Console.Write("Введите количество строк m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов n: ");
int n = int.Parse(Console.ReadLine());

Random random = new Random();

double[,] matrix = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = random.Next(10);
    }
}

Console.WriteLine("\nСгенерированная матрица:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

// Поиск первого нулевого элемента, обходя матрицу по столбцам
bool zero = false;
for (int j = 0; j < n; j++)
{
    for (int i = 0; i < m; i++)
    {
        if (matrix[i, j] == 0)
        {
            Console.WriteLine($"Первый нулевой элемент найден на позиции: ({i + 1}, {j + 1})");
            zero = true;
            break;
        }
    }
    if (zero) break;
}

if (!zero)
{
    Console.WriteLine("\nНулевых элементов в матрице нет.");
}