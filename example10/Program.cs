/* Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

int number = new Random().Next(100, 1000);
int getShowTwoDigitFromNumber(int number)
{
    
    int twoNumber = ((number / 10) % 10);
    return (twoNumber);
}
Console.WriteLine(number);
int result = getShowTwoDigitFromNumber(number);
Console.WriteLine(result);
