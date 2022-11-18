// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Например: 0, 7, 8, -2, -2 -> 2;  -1, -7, 567, 89, 223-> 3

int[] FillArrayReadNum(int size)
{
    int[] array = new int[size];
    Console.WriteLine($"Введите эллементы массива в количестве {size}:");
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
int CountNrgativNumInArr(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) count +=1;
    }
    return count;
}

Console.WriteLine("Введите размер массива:");
int m = Convert.ToInt32(Console.ReadLine());
int [] myArray = FillArrayReadNum(m);
PrintArray(myArray);
int res = CountNrgativNumInArr(myArray);
Console.WriteLine($"В заданном массиве содержится отрицательных чисел: {res}");
