/*Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


//Проверяем на число
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
            Console.WriteLine("Введи не число. Ввели некорректное число");
        }
    }
    return result;
}

//Получаем одномерный массив, заполненный случайными числами
int[] InitArray(int deminsion)
{
    int[] array = new int[deminsion];
    Random rnd = new Random();

    for (int i = 0; i < deminsion; i++)
    {
        array[i] = rnd.Next(-99, 99);
    }
    return array;
}

//Получаем массив в консоле
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i] + " "}");
    }
    Console.WriteLine();
}

//Находим сумму элементов, стоящих на нечётных позициях
int GetSummOddPositions(int[] array)
{
    int summ = 0;

    for (int i = 1; i < array.Length; i += 2)
    {
        summ += array[i];
    }
   return summ; 
}

int deminsion = GetNumber("Введите количество чисел в массиве");
int[] array = InitArray(deminsion);
PrintArray(array);
int summ = GetSummOddPositions(array);

Console.WriteLine($"Сумма нечётных позиций в массеве = {summ}");