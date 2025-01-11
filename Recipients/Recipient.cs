using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Logging;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Recipients;

public class Recipient : IRecipient
{
    private readonly Entity _entity;

    public Logger Logger { get; set; }

    public int AcceptableImportanceLevel { get; set; }

    public Recipient(Entity entity, Logger logger, int acceptableImportanceLevel)
    {
        _entity = entity;
        Logger = logger;
        AcceptableImportanceLevel = acceptableImportanceLevel;
    }

    public void SendMessage(Message message)
    {
        Logger.AddLog(message);
        if (message.ImportanceLevel > AcceptableImportanceLevel && AcceptableImportanceLevel != 0) return;
        _entity.ReceiveMessage(message);
    }
}