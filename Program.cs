// Task 1 : Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int TwoNumbers(int num1, int num2)
{
    int result = 1;
    for( int i = 0; i < num2; i++)
    result = result * num1;
    return result;
}
Console.Write("Input integer number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

if(secondNum > 0)
{
    int result = TwoNumbers(firstNum,secondNum);
    Console.WriteLine($"число {firstNum} в степени {secondNum} равно {result}");
}


// Task 2: : Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int  SumNum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
         num /= 10;
    }
    return sum;
}
Console.Write("Input integer number ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
number = number * (-1);
int sum = SumNum(number);
Console.WriteLine($"Сумма цифр числа { number} равна { sum } ");
*/

/*
// Task 3 : Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray; 
}
void PrintArray(int[] array){
    for(int i = 0; i < array.Length; i++)
         Console.Write(array[i]+ " ");
     Console.WriteLine();   
}
Console.Write("Введите размер  массива: ");
int size=Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите минимальное число диапазона цифр в массиве: ");
int minValue=Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите максимальное число диапазона цифр в массиве: ");
int maxValue=Convert.ToInt32(Console.ReadLine());

int[] ResultArray = CreateRandomArray(size, minValue, maxValue);
PrintArray(ResultArray);
*/