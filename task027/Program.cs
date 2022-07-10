/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
int SumNum(int num)//суммa цифр в числе
{
    int rezult = 0;
    int i = 0;
    int output = 0;
    while (num > 0)
    {
        rezult = num % 10;
        num = num / 10;
        output = output + rezult;
        i++;
    }
    return output;
}
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
    char[] charsToTrim = {'-','-', '-', ' ', ',', '.', '\'' };//Для Trim, что надо удалить в начале и в конце
    num = num.Trim(charsToTrim);
    num = num.Replace(",", ""); //заменяет внутри запятые на пустые
    return num;
}
Console.Clear();
Console.Write("Введите число : ");
string numbe = Console.ReadLine();
string number=TrRe(numbe);
while (true)
{
    if (!String.IsNullOrEmpty(number) && DeterminingNumber(number))//проверка на NULL && проверка введено ли число
    {
        break;
    }
    Console.Write("Неверный ввод, введите число: ");
    numbe = Console.ReadLine();
    number=TrRe(numbe);
}
int numb = Convert.ToInt32(number);
int rezult = SumNum(numb);
Console.WriteLine("{0} -> {1}", numbe, rezult);
