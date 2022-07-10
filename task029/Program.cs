/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов, заполненный псевдослучайными числами и выводит их на экран.

1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]*/


int [] ArrRand (int[] arr,int a,int b)//заполняет созданный массив псевдослучайными числами в интервале от a,b
{
    int[] newArr = new int [arr.Length];
    Random rnd = new Random();
for (int i=0;i<arr.Length;i++)
{
    int value = rnd.Next(a,b+1);
    newArr[i]=value;
}
    return newArr;
}

int[] array = new int[8];
array=ArrRand(array,0,100);
Console.WriteLine("[{0}]", string.Join(", ", array));
