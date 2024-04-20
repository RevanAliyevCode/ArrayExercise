// See https://aka.ms/new-console-template for more information
using static System.Console;

MakePowTwo();

void PrintArr()
{
    int[] arr = { 1, 5, 6, 7, 8 };

    foreach (int i in arr) Write($"{i} "); 
}

void SumOfArray()
{
    int[] arr = { 1, 5, 6, 7, 8 };
    int num = 0;

    foreach (int i in arr) num+= i;

    Write(num);
}

void ReverseArray()
{
    int[] arr = { 1, 5, 6, 7, 8 };
    int start = 0;
    int end = arr.Length - 1;

    while (start < end)
    {
        int temp = arr[start];
        arr[start] = arr[end];
        arr[end] = temp;
        start++;
        end--;
    }

    foreach (int i in arr) Write($"{i} ");
}

void RevresePrint()
{
    int[] arr = { 1, 5, 6, 7, 8 };

    for (int i = arr.Length - 1; i >= 0; i--)
    {
        Write($"{arr[i]} ");
    }
}

void FindMax()
{
    int[] arr = { 1, 5, 6, 7, 8 };
    int max = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max )
            max = arr[i];
    }

    WriteLine(max);
}

void FindLength()
{
    int[] arr = { 1, 5, 6, 7, 8 };
    int length = 0;

    for (int i = 0; i < arr.Length; i++, length++) ;

    WriteLine(length);
}

void SortArr()
{
    int[] arr = {6 ,3, 6, 8, 9, 15, 64, 3 };

    for (int i = 0; i < arr.Length - 1; i++)
    {
        int min = i;

        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[min])
                min = j;

            if (min != i)
            {
                int tmp = arr[i];
                arr[i] = arr[min];
                arr[min] = tmp;
            }
        }
    }

    foreach (int i in arr) Write($"{i} ");
}

void FindZeros()
{
    int[] arr = { 0, 5, 6, 7, 0, 8 };
    int numbreOfZeros = 0;

    foreach (int i in arr)
    {
        if (i == 0) numbreOfZeros++;
    }

    WriteLine(numbreOfZeros);
}


void FindNegatives()
{
    int[] arr = { 0, -5, 6, -7, 0, 8 };
    int numbreOfNegative = 0;

    foreach (int i in arr)
    {
        if (i < 0) numbreOfNegative++;
    }

    WriteLine(numbreOfNegative);
}


void FindSumPositives()
{
    int[] arr = { 0, -5, 6, -7, 0, 8 };
    int sum = 0;

    foreach (int i in arr)
    {
        if (i > 0) sum += i;
    }

    WriteLine(sum);
}


void MakePowTwo()
{
    int[] arr = { 0, -5, 6, -7, 0, 8 };

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * arr[i];
    }

    foreach (int i in arr) Write($"{i} ");
}

void SortRevreseArr()
{
    int[] arr = [7, 4, 8, 10];

    for (int i = 0; i < arr.Length - 1; i++)
    {
        int max = i;

        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] > arr[max])
                max = j;


                int tmp = arr[i];
                arr[i] = arr[max];
                arr[max] = tmp;
        }
    }

    foreach (int i in arr) Write($"{i} ");
}
