﻿using SnakeGame;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;

const int BoardWidth = 80;
const int BoardHeight = 30;

const int ScorePanelTextPostion = 2;
const int BordersOffset = 4;

SetWindowProperties();

Position[] directions = new Position[]
{
    new Position(0, 2),
    new Position(0, -2),
    new Position(1, 0),
    new Position(-1, 0)
};

int playerPoints = 0;
int startingDirection = (int)Direction.Right;

DrawBorders();

Food food = null;
Snake snake = new Snake(BordersOffset, BoardHeight, BoardWidth);

//DrawNewFood();
//PlayGame();

DrawScorePanel();

void SetWindowProperties()
{
    Console.CursorVisible = false;

    Console.BufferHeight = Console.WindowHeight;
    Console.BufferWidth = Console.WindowWidth;
}

void DrawBorders()
{
    StringBuilder stringBuilder = new StringBuilder();

    Console.ForegroundColor = ConsoleColor.Cyan;

    char horizontalBordersPiece = '█';
    string verticalBordersPiece = "██";

    string horizontalSlide = new string(horizontalBordersPiece, BoardWidth - BordersOffset + 2);
    string emptyHorizontalSlide = new string(' ', BoardWidth - BordersOffset);

    stringBuilder.AppendLine($"{horizontalBordersPiece}{horizontalSlide}{horizontalBordersPiece}");

    for (int row = 0; row < BoardHeight - BordersOffset; row++)
    {
        stringBuilder.AppendLine($"{verticalBordersPiece}{emptyHorizontalSlide}{verticalBordersPiece}");
    }

    stringBuilder.AppendLine($"{horizontalBordersPiece}{horizontalSlide}{horizontalBordersPiece}");

    string borders = stringBuilder.ToString().TrimEnd();
    Console.WriteLine(borders);
}

void DrawScorePanel()
{
    StringBuilder stringBuilder = new StringBuilder();
    int reversedSnakeSpeed = snake.GetReversedSpeed();
    stringBuilder.AppendLine($"Score: {playerPoints}    Snake speed: {reversedSnakeSpeed}");

    string scorePanel = stringBuilder.ToString().TrimEnd();

    Console.SetCursorPosition(0, BoardHeight - ScorePanelTextPostion);
    Console.WriteLine(scorePanel);
}

