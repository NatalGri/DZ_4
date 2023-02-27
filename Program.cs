//Задача 25: 
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Degree(int num1, int num2)
{
    int deg = num1;
    for (int current = 1; current <= num2; current++)
    {
        deg *= num1; 
    }
    return deg;
}

Console.Write("Input number A: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int res;

if (numB > 0)
{
    res = Degree(numA, numB);
    Console.WriteLine($"The result is: {res}");
}
else if (numB == 0)
{
    res = 1;
    Console.WriteLine($"The result is: {res}");
}
    else
    {
        Console.WriteLine($"Impossible value");
    }
*/

//Задача 27: 
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int FindSumm(int num)
{
    int summ = 0;
    num = Math.Abs(num);
    while (num >= 10)
    {
        int num_count = num % 10;
        num = num / 10;
        summ = summ + num_count;
    }
    summ = summ + num;
    return summ;
}

Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Summ of count in number {number} is {FindSumm(number)}");
*/

//Задача 29: 
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] creat_array (int size_array)
{
    int [] random_array = new int [size_array];
    for (int i = 0; i < size_array; i++)
    {
        random_array[i] = new Random().Next();
    }
    return random_array;
}

void show_creat_array (int [] array)
{
    Console.WriteLine($"Your array is: ");
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int [] array_new = creat_array(8);
show_creat_array(array_new);