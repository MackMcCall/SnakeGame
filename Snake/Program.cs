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

TheSnake snake = new TheSnake();


Random r = new Random();

try
{
    Fruit f = new Fruit();
    f.NewFruit();

    while (true)
    {
        ConsoleKeyInfo keyInfo = ReadKey();
        snake.Move(keyInfo);


        if (snake._bodySegments[0].xPos == f.FruitX && snake._bodySegments[0].yPos == f.FruitY)
        {
            f.NewFruit();
        }


        if (keyInfo.Key == ConsoleKey.Escape)
        {
            return;
        }
    }

}
catch
{
    Clear();
    Thread.Sleep(100);
    WriteLine("GAME OVER");
}
