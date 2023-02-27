/*
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Clear();
// Я так понимаю, что вещественные числа - это дробные числа
double [] GetMass(int n)
{
    double []mass = new double [n];
    for (int i=0; i<n; i++)
    {
        mass[i] = new Random().Next(-100, 101); //Например такой диапазон для наглядности
    }
    return mass;
}
double []mass = GetMass(6); //Например такой размер для наглядности

double ResSumEl(double []mass)
{
    double max = mass[0];
    for (int i=1; i<mass.Length; i++)
    if (mass[i]>max)
    {
        max = mass[i];
    }
    double min = mass[0];
    for (int i=1; i<mass.Length; i++)
    if (mass[i]<min)
    {
        min = mass[i];
    }
    double result = max-min;
    return result;
}

Console.WriteLine($"[{String.Join(" ", mass)}] -> {ResSumEl(mass)}");
