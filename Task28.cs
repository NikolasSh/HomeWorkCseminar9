/*
Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result >=1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод");
        }
    }

    return result;
}


int GetSumNambers(int numberM,int numberN, int sum)
{
    
    if (numberM == numberN+1)
    return sum;
    else
    {
        sum += numberM;
        numberM++;
        return GetSumNambers(numberM, numberN, sum);
    }
    


}

int numberM = GetNumber("Введите число M: ");
int numberN = GetNumber("Введите число N: ");
int sum = 0;
Console.WriteLine($"Сумма натуральных элементов между {numberM} и {numberN} = {GetSumNambers(numberM,numberN,sum)}");

