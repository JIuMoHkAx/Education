Console.Title = "SkillBox Module 3";


while (true)
{
    Console.WriteLine("Задание 1");
    Console.Write("Введите число");
    string? vvod = Console.ReadLine();
    if (int.TryParse(vvod, out var number) == true)
    {
        if (number % 2 == 0) Console.WriteLine($"Число {number} - чётное");
        else Console.WriteLine("Введённое число не является чётным");
        break;
    }       
    else
    {
        Console.WriteLine("Введено не числовое значение");
    }
        
}
