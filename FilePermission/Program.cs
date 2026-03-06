using System;

// README.md를 읽고 코드를 작성하세요.

FilePermission defaultPermission = FilePermission.None;

Console.WriteLine("=== 파일 권환 관리 ===");
Console.WriteLine($"현재 권한: {defaultPermission}");
Console.WriteLine();

Console.WriteLine("[권한 추가]");
AddPermission(FilePermission.Read);
AddPermission(FilePermission.Write);
AddPermission(FilePermission.Execute);
Console.WriteLine();

Console.WriteLine("[권한 확인]");
Console.WriteLine($"Read 권한: {HasFlag(FilePermission.Read)}");
Console.WriteLine($"Write 권한: {HasFlag(FilePermission.Write)}");
Console.WriteLine($"Execute 권한: {HasFlag(FilePermission.Execute)}");
Console.WriteLine();

Console.WriteLine("[권한 제거]");
RemovePermission(FilePermission.Write);
Console.WriteLine();

Console.WriteLine("[제거 후 확인]");
Console.WriteLine($"Read 권한: {HasFlag(FilePermission.Read)}");
Console.WriteLine($"Write 권한: {HasFlag(FilePermission.Write)}");
Console.WriteLine($"Execute 권한: {HasFlag(FilePermission.Execute)}");

void AddPermission(FilePermission permission)
{
    defaultPermission |= permission;
    Console.WriteLine($"+ {permission} 추가: {defaultPermission}");
}

void RemovePermission(FilePermission permission)
{
    defaultPermission &= ~permission;
    Console.WriteLine($"- {permission} 제거: {defaultPermission}");
}

bool HasFlag(FilePermission permission)
{
    return (defaultPermission & permission) != 0;
}

[Flags]
enum FilePermission
{
    None = 0,
    Read = 1,
    Write = 2,
    Execute = 4
}