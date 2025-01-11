using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Composite;

public interface IComposite
{
    void SendMessage(Message message);
}