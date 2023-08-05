//Trying to make a snake game
using Snake;

Console.WindowHeight = 25;
Console.WindowWidth = 60;
Console.Title = "Snake";
Console.CursorVisible = false;
int x = Console.WindowWidth / 2;
int y = Console.WindowHeight / 2;

while (true)
{
    Console.Clear();
    Console.SetCursorPosition(x, y);
    Console.Write("#");
    ConsoleKeyInfo keyInfo = Console.ReadKey();


    while (keyInfo.Key == ConsoleKey.LeftArrow && x > 0)
    {
        Console.Clear();
        Console.SetCursorPosition(x, y);
        Console.Write("#");
        x--;
        Thread.Sleep(100);

        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo breakKey = Console.ReadKey(intercept: true);

            if (breakKey.Key != ConsoleKey.LeftArrow)
            {
                keyInfo = breakKey;
            }
        }
    }
    while (keyInfo.Key == ConsoleKey.RightArrow && x < Console.WindowWidth - 1)
    {
        Console.Clear();
        Console.SetCursorPosition(x, y);
        Console.Write("#");
        x++;
        Thread.Sleep(100);

        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo breakKey = Console.ReadKey(intercept: true);

            if (breakKey.Key != ConsoleKey.RightArrow)
            {
                keyInfo = breakKey;
            }
        }
    }
    while (keyInfo.Key == ConsoleKey.UpArrow && y > 0)
    {
        Console.Clear();
        Console.SetCursorPosition(x, y);
        Console.Write("#");
        y--;
        Thread.Sleep(150);
        
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo breakKey = Console.ReadKey(intercept: true);

            if (breakKey.Key != ConsoleKey.UpArrow)
            {
                keyInfo = breakKey;
            }
        }
    }
    while (keyInfo.Key == ConsoleKey.DownArrow && y < Console.WindowHeight - 1)
    {
        Console.Clear();
        Console.SetCursorPosition(x, y);
        Console.Write("#");
        y++;
        Thread.Sleep(150);

        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo breakKey = Console.ReadKey(intercept: true);

            if (breakKey.Key != ConsoleKey.DownArrow)
            {
                keyInfo = breakKey;
            }
        }
    }

    if (keyInfo.Key == ConsoleKey.Escape)
    {
        return;
    }
}
