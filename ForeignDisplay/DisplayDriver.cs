using System.Drawing;

namespace Itmo.ObjectOrientedProgramming.Lab3.ForeignDisplay;

public class DisplayDriver
{
    public string Text { get; set; } = string.Empty;

    public Color Color { get; set; }

    public void СonsolePrint()
    {
        Console.Clear();
        Console.WriteLine(Crayon.Output.Rgb(Color.R, Color.G, Color.B).Text(Text));
    }

    public void FilePrint(string fileName)
    {
        File.AppendAllText(fileName, Text);
    }
}