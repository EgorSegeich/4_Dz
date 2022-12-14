/*
Назовём число «интересным» если его произведение цифр делится на их сумму. 
Напишите программу, которая заполняет массив на 10 «интересных» случайных целых чисел от 10 до 1000. 
(каждый эл-т массива – сгенерирован случайно)

[591, 532, 189, 523, 333, 546, 527, 275, 456, 264]
*/


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


int u = 0;
int [] array = new int[10];

Console.Write("[");

while (u < array.Length)
{   
    int N = new Random().Next(1, 1000);



    int length = LengthOfNumber(N);
    int [] numbers = new int[length];
   
    int L = N;

    for(int i=0; i<length; i++)
    {
        numbers[i] = L % 10;
        L = L / 10;
    }


    int j = 0;
    int sum = 0;
    int proiz = 1;
    while(j<length)
    { 
        sum = sum + numbers[j];
        proiz = proiz * numbers[j];
        j++;
    }


    if(proiz>0)
    {
        if(proiz % sum == 0)
        {
        array[u] = N;
        Console.Write(array[u]+ ", ");
        u++;
        }  
    }
}
Console.Write("]");