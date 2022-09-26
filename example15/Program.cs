/*Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

int Number = new Random().Next(1, 8);
string Holiday(int Number)
{
    string Holiday = "";
    if  (Number < 6)
    {
        Holiday = "Нет";
    }    
    else Holiday = "Да";
    return Holiday;
}
Console.WriteLine(Number);
string result = Holiday(Number);
Console.WriteLine(result);
