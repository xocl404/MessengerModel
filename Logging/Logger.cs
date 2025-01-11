using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Logging;

public class Logger
{
    public Dictionary<Message, Log> Logs { get; } = new();

    public virtual void AddLog(Message message)
    {
        Logs.TryAdd(message, new Log(message));
    }
}