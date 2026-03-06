using System;

// README.md를 읽고 아래에 코드를 작성하세요.

CharacterState currentState = CharacterState.Idle;
Console.WriteLine("=== 캐릭터 상태 관리 ===");
Console.WriteLine($"현재 상태: {currentState}");
Console.WriteLine();

while (true)
{
    Console.WriteLine("1. 상태 변경");
    Console.WriteLine("2. 상태 목록 보기");
    Console.WriteLine("3. 현재 행동 보기");
    Console.WriteLine("4. 종료");
    Console.Write("선택: ");
    int input = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (input == 4)
    {
        Console.WriteLine("프로그램을 종료합니다.");
        break;
    }

    switch (input)
    {
        case 1:
            Console.Write("변경할 상태 번호 입력 (0~5): ");
            CharacterState stateInput = (CharacterState)(int.Parse(Console.ReadLine()));

            if (Enum.IsDefined(typeof(CharacterState), stateInput))
            {
                currentState = stateInput;
                Console.WriteLine($"상태가 {stateInput}(으)로 변경되었습니다.");
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("잘못된 입력입니다.");
                Console.WriteLine();
                continue;
            }
            break;

        case 2:
            Console.WriteLine("=== 상태 목록 ===");
            foreach (var state in Enum.GetValues(typeof(CharacterState)))
            {
                Console.WriteLine($"{state} = {(int)state}");
            }

            Console.WriteLine();
            break;

        case 3:
            Act(currentState);
            Console.WriteLine();
            break;
    }

    Console.WriteLine($"현재 상태: {currentState}");
    Console.WriteLine();
}

void Act(CharacterState state)
{
    Console.Write("[행동] ");
    switch (state)
    {
        case CharacterState.Idle:
            Console.WriteLine("대기 상태입니다.");
            break;
        case CharacterState.Walking:
            Console.WriteLine("걷기 상태입니다.");
            break;
        case CharacterState.Running:
            Console.WriteLine("달리기 상태입니다.");
            break;
        case CharacterState.Jumping:
            Console.WriteLine("점프하고 있습니다.");
            break;
        case CharacterState.Attacking:
            Console.WriteLine("적을 공격합니다!");
            break;
        case CharacterState.Dead:
            Console.WriteLine("사망 상태입니다. 행동할 수 없습니다.");
            break;
    }
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