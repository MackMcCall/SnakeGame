//Trying to make a snake game
using Snake;
using static System.Console;
WindowHeight = 25;
WindowWidth = 60;
Title = "Snake";
CursorVisible = false;
int x = WindowWidth / 2;
int y = WindowHeight / 2;


Border border = new Border();
border.MakeBorder();


try
{
    TheSnake snake = new TheSnake();
    ConsoleKeyInfo keyInfo = ReadKey();
    Printing.PrintSegment(x, y);
    snake.Move(x, y, keyInfo);

    if (keyInfo.Key == ConsoleKey.Escape)
    {
        return;
    }
}
catch
{
    Clear();
    Thread.Sleep(100);
    WriteLine("GAME OVER");
}
