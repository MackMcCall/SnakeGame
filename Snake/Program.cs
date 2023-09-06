//Trying to make a snake game
using static System.Console;
using Snake;
using Snake.Character;
using Snake.Fruits;
using Snake.Printing;
//Put here through 10 in a gamesettings class
WindowHeight = 20;
WindowWidth = 48;
Title = "Snake";
CursorVisible = false;
int x = WindowWidth / 2;
int y = WindowHeight / 2;


Border border = new Border();
border.MakeBorder();

ISnake snake = new GreenSnake();
Fruit fruit = new Fruit();

while (true)
{
    fruit.SpawnFruitBasedOnSnakeLocation(snake);

    //Want to implement a countdown or a start screen

    ConsoleKeyInfo keyInfo = new ConsoleKeyInfo(' ', ConsoleKey.DownArrow, false, false, false);
    PlayGame.Play(keyInfo, snake, fruit, x, y, border);
}

//Maybe put all this in a GameManager class with a GameManager.Run method
