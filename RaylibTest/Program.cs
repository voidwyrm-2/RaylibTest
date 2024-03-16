using Raylib_cs;
using System.ComponentModel;
using System.Drawing;

namespace HelloWorld;

class Program
{

    public static int screenWidth = 800;
    public static int screenHeight = 480;
    public static bool exitWindowRequested = false;
    public static bool exitWindow = false;


    public static void newscreenxy(int x, int y)
    {
        screenWidth = x;
        screenHeight = y;
    }


    public static void Main()
    {

        Raylib.InitWindow(screenWidth, screenHeight, "Window");

        while (!exitWindow)
        {
            if (Raylib.WindowShouldClose() || Raylib.IsKeyPressed(KeyboardKey.Escape)) exitWindowRequested = true;

            if (exitWindowRequested)
            {
                // A request for close window has been issued, we can save data before closing
                // or just show a message asking for confirmation

                if (Raylib.IsKeyPressed(KeyboardKey.Y)) exitWindow = true;
                else if (Raylib.IsKeyPressed(KeyboardKey.N)) exitWindow = false;
            }


            Raylib.BeginDrawing();
            Raylib.ClearBackground(Raylib_cs.Color.White);

            Raylib.ClearBackground(Raylib_cs.Color.White);

            if (exitWindowRequested)
            {
                Raylib.DrawRectangle(0, 100, screenWidth, 200, Raylib_cs.Color.Black);
                Raylib.DrawText("Are you sure you want to exit program? [Y/N]", 40, 180, 30, Raylib_cs.Color.White);
            }
            else Raylib.DrawText("Try to close the window to get confirmation message!", 120, 200, 20, Raylib_cs.Color.LightGray);

            Raylib.DrawText("Hello, world!", 12, 12, 20, Raylib_cs.Color.Black);
            Raylib.DrawCircle(50, 50, 20, Raylib_cs.Color.Black);

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}