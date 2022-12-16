/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/


int GetNumber(string message)
{
    int result = 0;
    
    while (true)
    {
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели некорректное число");
        }
    }
    return result;
}


int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(-30, 30);
    }
    return array;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i] + " "}");
    }
    Console.WriteLine();
}


(int,int) GetMaxAndMinNum(int[] array)
{
    int maxnumer = array[0];
    int minnumer = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] > maxnumer)
        {
            maxnumer = array[i];
        }
        if(array[i] < minnumer)
        {
            minnumer = array[i];
        }
    }
    return (maxnumer, minnumer);
}

int demension = GetNumber("Введите колчество чисел элементов массива: ");
int[] array = InitArray(demension);
PrintArray(array);
(int maxnum, int minnum) = GetMaxAndMinNum(array);

Console.WriteLine($"Разница между максимальным {maxnum} и минимальным элементом{minnum} равна: {maxnum - minnum}");