using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Priority priority = Priority.High;

if (priority == Priority.High)
{
    Console.WriteLine("높은 우선순위");
}
Console.WriteLine();

Animal animal = Animal.Tiger;

Console.WriteLine(animal);
if (animal == Animal.Tiger)
{
    Console.WriteLine("호랑이");
}
Console.WriteLine();

int red = (int)Color.Red;
int green = (int)Color.Green;
int blue = (int)Color.Blue;

Console.WriteLine($"Red: {red}, Green: {green}, Blue: {blue}");
Console.WriteLine();

Console.WriteLine(sizeof(SmallEnum));
Console.WriteLine();

Type colorType = typeof(ConsoleColor);
string[] colors = Enum.GetNames(colorType);

Console.WriteLine("ConsoleColor 열거형의 색상들:");
foreach (string color in colors)
{
    Console.WriteLine(color);
}
Console.WriteLine();

string Red = "Red";

ConsoleColor redColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Red);
Console.ForegroundColor = redColor;
Console.WriteLine("빨간색 테스트");
Console.ResetColor();
Console.WriteLine("기본 색상 테스트");
Console.WriteLine();

string up = "Up";

if (Enum.TryParse(up, out Direction direction))
{
    Console.WriteLine($"변환 성공: {direction}");
}

else
{
    Console.WriteLine("변환 실패");
}

string invalid = "Forward";
if (Enum.TryParse(invalid, out Direction result))
{
    Console.WriteLine($"변환 성공: {result}");
}

else
{
    Console.WriteLine($"'{invalid}'은(는) 유효하지 않은 값");
}
Console.WriteLine();

bool isValid1 = Enum.IsDefined(typeof(Animal), 1);
bool isValid2 = Enum.IsDefined(typeof(Animal), 100);
bool isValid3 = Enum.IsDefined(typeof(Animal), "Tiger");

Console.WriteLine($"1은 유효한 Animal값인가? {isValid1}");
Console.WriteLine($"100은 유효한 Animal값인가? {isValid2}");
Console.WriteLine($"'Tiger'는 유효한 Animal값인가? {isValid3}");
Console.WriteLine();

int right = (int)Direction.Right;
Direction value = (Direction)2;

Console.WriteLine($"Right = {right}");
Console.WriteLine($"2 = {value}");
Console.WriteLine();

Animal animal1 = (Animal)100;
Console.WriteLine(animal1);

enum Priority
{
    High,
    Normal,
    Low
}

enum Animal
{
    Mouse,
    Cow,
    Tiger
}

enum Color
{
    Red = 10,
    Green,
    Blue = 20
}

enum SmallEnum : byte
{
    Left,
    Right,
    Top,
    Bottom
}

enum Direction
{
    Up,
    Down,
    Left,
    Right
}