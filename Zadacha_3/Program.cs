// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

// Метод для заполнения массива случайными числами от 100 до 999.
int[] FillArray(int size)
{
    // Создание нового массива заданного размера.
    int[] array = new int[size];

    // Цикл по всем элементам массива.
    for (int i = 0; i < array.Length; i++)
    {
        // Заполнение текущего элемента массива случайным числом от 100 до 999.
        array[i] = new Random().Next(100, 1000);
    }

    // Возврат заполненного массива.
    return array;
}

// Метод для вывода элементов массива в консоль.
void PrintArray(int[] inputArray)
{
    // Перевод строки для лучшей читаемости вывода в консоль.
    Console.WriteLine();
    // Вывод заголовка перед выводом элементов массива.
    Console.Write("Массив с элементами: ");

    // Цикл по всем элементам массива.
    for (int i = 0; i < inputArray.Length; i++)
    {
        // Вывод текущего элемента массива в консоль, с пробелом после значения.
        Console.Write(inputArray[i] + " ");
    }
}

// Метод для переворачивания массива
void ReverseArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length / 2; i++)
    {
        // Обмен значениями между первым и последним элементами и так далее
        int temp = arr[i];
        arr[i] = arr[length - 1 - i];
        arr[length - 1 - i] = temp;
    }
}

int SizaArr = 15;
int[] Arr = FillArray(SizaArr);
PrintArray(Arr);
ReverseArray(Arr);
PrintArray(Arr);
