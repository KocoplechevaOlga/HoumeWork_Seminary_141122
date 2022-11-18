// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// Например: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// k1*x + b1 = k2*x + b2 => x(k1-k2) = b2-b1 => x = (b2-b1)/ (k1-k2) 
// прямые не пересекаются если k1-k2 (уравнение не имеет решения, деление на 0)
// прямые равны или уравнение имеет более 1 решения

double[] FillArray(int size)
{
    double[] array = new double [size];
    Console.WriteLine($"Введите заданные координаты b1, k1, b2 и k2:");
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}
void PrintArray (double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
double [] FindCoordinatesIntersecLine(double [] arr) 
// содержание массива: b1, k1, b2, k2(заданные координаты прямых)
{
    double [] array = new double [2];
    double [] arrayNothing = new double [1];
    double [] arrayAll = new double [4];
    if (arr[1] == arr[3]) return arrayNothing;
    if ((arr[2]-arr[0]) == (arr[1]-arr[3])) return arrayAll;
    double x = (arr[2]-arr[0])/ (arr[1]-arr[3]);
    array[0] = x;
    array[1] = arr[1] * x + arr[0];
    return array;
}
void PrintResIntersectLine(double [] array)
{
    string res = " ";
    if (array.Length == 1) res = "Прямые не пересекаются";
    if (array.Length > 2)  res = "Прямые равны, координат точек пересечения бесконечное количество";
    if (array.Length == 2)  res = $"[{array[0]}, {array[1]}]";
    Console.WriteLine(res);
}
double[] myArray = FillArray(4);
PrintArray(myArray);
double [] res = FindCoordinatesIntersecLine(myArray);
PrintResIntersectLine(res);