/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int MP(int num, int p)
{
    int rezult = 1;
    for (int i = 1; i <= p; i++)
    {
        rezult = rezult * num;
    }
    return rezult;
}

Console.Write("Введите  число : ");
int numFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  степень, в которую возвести число, введенное ранее : ");
int numSecond = Convert.ToInt32(Console.ReadLine());
decimal rezult = MP(numFirst, numSecond);
Console.Write("{0}, {1} -> {2}", numFirst, numSecond, rezult);