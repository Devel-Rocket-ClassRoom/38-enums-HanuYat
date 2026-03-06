using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Console.WriteLine((int)Animal.Horse);
Console.WriteLine((int)Animal.Sheep);
Console.WriteLine((int)Animal.Monkey);
Console.WriteLine();

CharacterStatus status = CharacterStatus.Poison | CharacterStatus.Paralyzed;
Console.WriteLine(status);
Console.WriteLine();

CharacterStatus status1 = CharacterStatus.Poison | CharacterStatus.Confused;

if ((status1 & CharacterStatus.Poison) != 0)
{
    Console.WriteLine("캐릭터가 독에 걸렸습니다!");
}

if ((status1 & CharacterStatus.Paralyzed) != 0)
{
    Console.WriteLine("캐릭터가 마비되었습니다!");
}

else
{
    Console.WriteLine("마비 상태가 아닙니다.");
}
Console.WriteLine();

CharacterStatus status2 = CharacterStatus.Poison;
Console.WriteLine($"초기 상태: {status2}");

status2 |= CharacterStatus.Confused;
Console.WriteLine($"혼란 추가: {status2}");

status2 &= ~CharacterStatus.Poison;
Console.WriteLine($"독 제거: {status2}");

status2 ^= CharacterStatus.Invisible;
Console.WriteLine($"투명 토글: {status2}");
Console.WriteLine();

BuffStatus buff = BuffStatus.None;

void ApplyBuff(BuffStatus newBuff)
{
    buff |= newBuff;
    Console.WriteLine($"버프 적용: {newBuff}");
    Console.WriteLine($"현재 버프: {buff}");
}

void RemoveBuff(BuffStatus removeBuff)
{
    buff &= ~removeBuff;
    Console.WriteLine($"버프 제거: {removeBuff}");
    Console.WriteLine($"현재 버프: {buff}");
}

bool HasBuff(BuffStatus checkBuff)
{
    return (buff & checkBuff) != 0;
}

ApplyBuff(BuffStatus.AttackUp);
ApplyBuff(BuffStatus.SpeedUp);
Console.WriteLine($"공격력 버프 있음? {HasBuff(BuffStatus.AttackUp)}");
RemoveBuff(BuffStatus.AttackUp);
Console.WriteLine($"공격력 버프 있음? {HasBuff(BuffStatus.AttackUp)}");

enum Animal
{
    Horse,
    Sheep = 5,
    Monkey
}

[Flags]
enum CharacterStatus
{
    None = 0,
    Poison = 1,
    Paralyzed = 1 << 1,
    Confused = 1 << 2,
    Invisible = 1 << 3
}

[Flags]
enum BuffStatus
{
    None = 0,
    AttackUp = 1,
    DefenseUp = 1 << 1,
    SpeedUp = 1 << 2,

    All = AttackUp | DefenseUp | SpeedUp
}