using Itmo.ObjectOrientedProgramming.Lab3.ForeignMessenger;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities;

public class MessengerAdapter : Entity
{
    public Messenger Messenger { get; }

    private Message? _message;

    public MessengerAdapter(Messenger messenger)
    {
        Messenger = messenger;
    }

    public override void ReceiveMessage(Message message)
    {
        _message = message;
    }

    public bool PrintMessage()
    {
        if (_message == null) return false;
        Messenger.PrintMessage(_message);
        return true;
    }
}