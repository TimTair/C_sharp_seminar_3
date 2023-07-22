// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str = number.ToString();
int[] array = new int[str.Length];

for (int i = 0; i < str.Length; i++)
{
    array[i] = int.Parse(str[i].ToString());
}

if(number > 9999 && number < 100000)
{
    if(array[0] == array[4] && array[1] == array[3])
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
}
else
{
    Console.WriteLine("Введите пятизначное число повторно");
}




