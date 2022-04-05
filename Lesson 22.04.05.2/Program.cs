// See https://aka.ms/new-console-template for more information
Console.Write("************\n" +
              "*          *\n" +
              "*          *\n" +
              "*          *\n" +
              "*          *\n" +
              "*          *\n" +
              "*          *\n" +
              "*          *\n" +
              "*          *\n" +
              "************");

int x = 0, y = 0;
int shiftX = 5, shiftY = 5;
Console.SetCursorPosition(x + shiftX, y + shiftY);
Console.Write("@");

while (true)
{
    ConsoleKeyInfo move = Console.ReadKey(true);
    Console.SetCursorPosition(x + shiftX, y + shiftY);
    Console.Write(" ");
    switch (move.Key)
    {
        case ConsoleKey.W:
            if(y > -4)
                y--;

            break;
        case ConsoleKey.A:
            if (x > -4)
                x--;
            break;
        case ConsoleKey.S:
            if (y < 3)
                y++;
            break;
        case ConsoleKey.D:
            if (x < 4)
                x++;
            break;
    }
    Console.SetCursorPosition(x + shiftX, y + shiftY);
    Console.Write("@");   

}

