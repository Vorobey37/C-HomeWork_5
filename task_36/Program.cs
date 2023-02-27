/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.Clear();

int [] GetMass(int n)
{
    int []mass = new int [n];
    for (int i=0; i<n; i++)
    {
        mass[i] = new Random().Next(-100, 101); //Например из диапазона [-100, 100] для наглядности
    }
    return mass;
}
int []mass = GetMass(6); // Например из 6 значений, чтобы проще было проверять)))

int SumElements (int []mass)
{
    int sum = 0;
    // Я так понимаю, что нулевая позиция четная, первая нечетная и т.д.
    for (int i=1; i<mass.Length; i+=2)
    {
        sum = sum + mass[i];
    }
    return sum;
}

Console.WriteLine($"[{String.Join(", ", mass)}] -> {SumElements(mass)}");