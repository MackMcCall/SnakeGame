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

//try
//{
    //Printing.PrintSegment(x, y);
    Fruit f = new Fruit(r);
    f.NewFruit();

    while (true)
    {
        ConsoleKeyInfo keyInfo = ReadKey();
        snake.Move(keyInfo);
        for (int i = 0; i < snake.Segments; i--)
        {
            Printing.PrintSegment(snake.BodyListX[0], snake.BodyListY[0]);
        }

        if (f.FruitX == snake.BodyListX[0] && f.FruitY == snake.BodyListY[0])
        {
            f.NewFruit();
        }


        if (keyInfo.Key == ConsoleKey.Escape)
        {
            return;
        }
    }

//}
//catch
//{
//    Clear();
//    Thread.Sleep(100);
//    WriteLine("GAME OVER");
//}
