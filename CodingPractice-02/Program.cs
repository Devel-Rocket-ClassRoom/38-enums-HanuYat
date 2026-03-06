using System;

// README.md를 읽고 아래에 코드를 작성하세요.

int num = (int)Animal.Dragon;
string dragon = Enum.GetName(typeof(Animal), num);
Console.WriteLine($"Animal.Dragon: {num}, {dragon}");
Console.WriteLine();

Array values = Enum.GetValues(typeof(Priority));

Console.WriteLine("Priority 열거형의 값들:");
foreach (Priority p in values)
{   
    Console.WriteLine($"{p} = {(int)p}");
}

enum Animal
{
    Rabbit,
    Dragon,
    Snake
}

enum Priority
{
    High = 1,
    Normal = 5,
    Low = 10
}