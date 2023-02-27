/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
Console.Clear();
int [] GetMass(int n)
{
    int []mass = new int [n];
    for (int i=0; i<n; i++)
    {
        mass[i] = new Random().Next(100, 1000);
    }
    return mass;
}
int []mass = GetMass(10); //Например будет 10 элементов

int Even (int []mass)
{
    int count=0;
    foreach (var element in mass)
    {
        count += element%2 == 0 ? 1:0;
    }
    return count;
}
Console.WriteLine($"[{string.Join(", ", mass)}] -> {Even(mass)}");