/*
Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, которые 
являются делителями этого числа.

452 -> 6

82 -> 2

9012 -> 3
*/


Console.WriteLine("введите число");
int N = Convert.ToInt32(Console.ReadLine());


int LengthOfNumber(int val)
{
    int count = 0;
    while (val>0)
    {
        val = val / 10;
        count++;
    }
return count;
}


int length = LengthOfNumber(N);
int [] numbers = new int[length];
Console.WriteLine("длина: " + length);

int L = N;

for(int i=0; i<length; i++)
{
    numbers[i] = L % 10;
    L = L / 10;
}


int j = 0;
int sum = 0;
while(j<length)
{ 
    if (numbers[j] == 0)
    {
        sum = sum + 0;
    }
    else
    {
        if((N % numbers[j]) == 0)    
        {
            sum = sum + numbers[j];
        }
    }
j++;
}
Console.WriteLine("сумма цифр в числе, которые являются делителями: " + sum);