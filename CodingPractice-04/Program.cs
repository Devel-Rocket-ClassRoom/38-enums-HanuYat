using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Animal animal = Animal.Dog;

switch (animal)
{
    case Animal.Chicken:
        Console.WriteLine("닭");
        break;
    case Animal.Dog:
        Console.WriteLine("개");
        break;
    case Animal.Pig:
        Console.WriteLine("돼지");
        break;
    default:
        Console.WriteLine("없는 동물입니다.");
        break;
}
Console.WriteLine();

CharacterState state = CharacterState.Idle;

void Update()
{
    switch (state)
    {
        case CharacterState.Idle:
            Console.WriteLine("대기 애니메이션 재생");
            break;
        case CharacterState.Walking:
            Console.WriteLine("걷기 애니메이션 재생");
            break;
        case CharacterState.Running:
            Console.WriteLine("달리기 애니메이션 재생");
            break;
        case CharacterState.Jumping:
            Console.WriteLine("점프 애니메이션 재생");
            break;
        case CharacterState.Attacking:
            Console.WriteLine("공격 애니메이션 재생");
            break;
        case CharacterState.Dead:
            Console.WriteLine("사망 애니메이션 재생");
            break;
        default:
            Console.WriteLine("알 수 없는 상태입니다.");
            break;
    }
}
state = CharacterState.Attacking;
Update();
Console.WriteLine();

void PrintItemInfo(string itemName, ItemRarity rarity)
{
    Console.WriteLine($"아이템: {itemName}");
    Console.WriteLine($"등급: {rarity}");
}
PrintItemInfo("전설의 검", ItemRarity.Legendary);
Console.WriteLine();

void Move(Direction direction)
{
    switch (direction)
    {
        case Direction.Up:
            Console.WriteLine("위로 이동 (y + 1)");
            break;
        case Direction.Down:
            Console.WriteLine("아래로 이동 (y - 1)");
            break;
        case Direction.Left:
            Console.WriteLine("왼쪽으로 이동 (x - 1)");
            break;
        case Direction.Right:
            Console.WriteLine("오른쪽으로 이동 (x + 1)");
            break;
        default:
            Console.WriteLine("알 수 없는 방향입니다.");
            break;
    }
}
Move(Direction.Up);
Move(Direction.Right);

enum Animal
{
    Chicken,
    Dog,
    Pig
}

enum CharacterState
{
    Idle,
    Walking,
    Running,
    Jumping,
    Attacking,
    Dead
}

enum ItemRarity
{
    Common,
    Uncommon,
    Rare,
    Epic,
    Legendary
}

enum Direction
{
    Up,
    Down,
    Left,
    Right,
}