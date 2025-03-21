using System;
using SixLabors.ImageSharp;
using Spectre.Console;

namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                CanvasImage image = new CanvasImage($"{args[0]}");
                int size = int.Parse(args[1]);

                image.MaxWidth(size);
                AnsiConsole.Write(image);
            }

            else
            {
                CanvasImage image = new CanvasImage("tux.jpg");
                image.MaxWidth(24);
                AnsiConsole.Write(image); 
            }
        }
    }
}
