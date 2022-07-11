/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

double MP(int num, int p)// возведение в степень
{
    double rezult = 1;
    int pNew = Math.Abs(p);
    for (int i = 1; i <= pNew; i++)
    {
        rezult = rezult * num;
    }
    return p < 0 ? 1 / rezult : rezult;
}
int CheckingNumberInput(string numNew)// проверка введено ли число выводит int
{
    bool DeterminingNumber(string num)//проверка введены ли числа
    {
        foreach (var item in num)
        {
            if (!char.IsDigit(item))
                return false;
        }
        return true;
    }
    string TrRe(string num)// удаляет в начале и в конце строки (-),( ),(,),(.) и внутри меняет запятую на String.Empty
    {
        char[] charsToTrim = { '-', '-', '-', ' ', '\'' };//Для Trim, что надо удалить в начале и в конце
        num = num.Trim(charsToTrim);
        return num;
    }
    string num = TrRe(numNew);
    while (true)
    {
        if (!String.IsNullOrEmpty(num) && DeterminingNumber(num))//проверка на NULL && проверка введено ли число
        {
            break;
        }
        Console.Write("Неверный ввод, попробуйте еще раз: ");
        num = Console.ReadLine();
        numNew = num;
    }
    return Convert.ToInt32(numNew);

}
Console.Clear();
Console.Write("Введите  число : ");
string numFirst = Console.ReadLine();
int numFirstNew = CheckingNumberInput(numFirst);
Console.Write("Введите  степень, в которую возвести число, введенное ранее : ");
string numSecond = Console.ReadLine();
int numSecondNew = CheckingNumberInput(numSecond);
double rezult = MP(numFirstNew, numSecondNew);
if (numFirstNew == 0 && numSecondNew == 0) Console.Write("{0}, {1} -> значение не определено", numFirstNew, numSecondNew);
else Console.Write("{0}, {1} -> {2}", numFirstNew, numSecondNew, rezult);

