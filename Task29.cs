/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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

int GetAkkNamber(int numberA,int numberB)
{
    
    if (numberA == 0)
    return numberB + 1;
    else if(numberB == 0)
    {
        return GetAkkNamber(numberA-1, 1);
    }
    else return GetAkkNamber(numberA-1, GetAkkNamber(numberA, numberB-1));   


}

int numberA = GetNumber("Введите число A: ");
int numberB = GetNumber("Введите число B: ");
Console.WriteLine($"Функция Аккермана({numberA},{numberB}) = {GetAkkNamber(numberA,numberB)}");

