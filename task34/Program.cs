/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/
//Проверяем на число
int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Ввели некорректрое число");
        }
    }
    return result;
}

//Получаем массив заполненный случайными положительными трёхзначными числами
int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(100, 999);
    }
    return array;
}

//распечатать массив на консоль
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i] + " "}");
    }
    Console.WriteLine();
}



//Проверка на чётность
int GetParity(int[] array)
{    
    
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 ==  0)
        {
            count++;
        }
    }    
    return count;
}

int dimension = GetNumber("Введите размерность массива: ");
int[] array = InitArray(dimension);
PrintArray(array);
int count = GetParity(array);

Console.WriteLine($"Количество четных чисел в массиве: {count}");