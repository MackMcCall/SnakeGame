﻿//Trying to make a snake game
using Snake;
using static System.Console;
WindowHeight = 20;
WindowWidth = 48;
Title = "Snake";
CursorVisible = false;
int x = WindowWidth / 2;
int y = WindowHeight / 2;


Border border = new Border();
border.MakeBorder();

TheSnake snake = new TheSnake();
Fruit f = new Fruit();


try
{
    while (true)
    {
        f.NewFruit(snake);

        ConsoleKeyInfo keyInfo = ReadKey();
        PlayGame.Play(keyInfo, snake, f, x, y, border);

        //if (keyInfo.Key == ConsoleKey.Escape)
        //{
        //    return;
        //}
    }
}
catch (ArgumentOutOfRangeException)
{
    GameOver.Lose(x, y, border);
}
