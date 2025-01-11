using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using System.Drawing;

namespace Itmo.ObjectOrientedProgramming.Lab3.ForeignDisplay;

public class Display
{
    private readonly DisplayDriver _driver = new();

    public void СonsolePrintColorMessage(Message message, Color color)
    {
        _driver.Text = message.Text;
        _driver.Color = color;
        _driver.СonsolePrint();
    }

    public void FilePrintMessage(Message message, string fileName)
    {
        _driver.Text = message.Text;
        _driver.FilePrint(fileName);
    }
}