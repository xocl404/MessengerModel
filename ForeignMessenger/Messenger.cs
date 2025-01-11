using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.ForeignMessenger;

public class Messenger
{
    public virtual void PrintMessage(Message message)
    {
        Console.WriteLine("Messenger");
        Console.WriteLine(message.Header);
        Console.WriteLine(message.Text);
    }
}