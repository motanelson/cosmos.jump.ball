using System;
class balls {
    public static int w=79;
    public static int h = 23;
    public static int y = 2;
    public static int x = 2;
    public static int movx=1;
    public static int movy=1;

    public static void Writer(int xx, int yy,String s)
    {
        Console.CursorLeft = xx;
        Console.CursorTop = yy;
        Console.WriteLine(s);
    }
    public static void nexts() 
    {
        Writer(x, y, " ");
        x = x + movx;
        y = y + movy;
        if (x < 1 || x>w) movx = -movx;
        if (y < 1 || y>h) movy = -movy;
        Writer(x, y, "O");

    }
    
    public static void ballsLoop(int xx, int yy)
    {
        if (xx > 1) w = xx;
        if (yy > 1) h = yy;
        while (true)

        {
            nexts();
            System.Threading.Thread.Sleep(500);
            if (Console.KeyAvailable)
            {
                break;
            }
        }
    
    }

}




class ball
{
    public static void Main()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        balls.ballsLoop(Console.WindowWidth - 3, Console.WindowHeight - 3);
    }

}

