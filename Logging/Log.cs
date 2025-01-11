using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Logging;

public class Log
{
    public Message Message { get; }

    public Guid Id { get;  } = Guid.NewGuid();

    public DateTime DateTime { get; } = DateTime.Now;

    public Log(Message message)
    {
        Message = message;
    }
}