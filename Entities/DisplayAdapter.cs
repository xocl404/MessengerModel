using Itmo.ObjectOrientedProgramming.Lab3.ForeignDisplay;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using System.Drawing;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities;

public class DisplayAdapter : Entity
{
    public Display Display { get; }

    private Message? _message;

    public DisplayAdapter(Display display)
    {
        Display = display;
    }

    public override void ReceiveMessage(Message message)
    {
        _message = message;
    }

    public void СonsolePrintColorMessage(Color color)
    {
        if (_message == null) return;
        Display.СonsolePrintColorMessage(_message, color);
    }

    public void FilePrintMessage(string fileName)
    {
        if (_message == null) return;
        Display.FilePrintMessage(_message, fileName);
    }
}