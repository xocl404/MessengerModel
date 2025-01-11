using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Logging;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab3.Recipients;

public class RecipientGroup : IRecipient
{
    private readonly Collection<Entity> _entities;

    public Logger Logger { get; }

    public int AcceptableImportanceLevel { get; }

    public RecipientGroup(Collection<Entity> entities, Logger logger, int acceptableImportanceLevel)
    {
        _entities = entities;
        Logger = logger;
        AcceptableImportanceLevel = acceptableImportanceLevel;
    }

    public void SendMessage(Message message)
    {
        foreach (Entity entity in _entities)
        {
            Logger.AddLog(message);
            if (message.ImportanceLevel > AcceptableImportanceLevel && AcceptableImportanceLevel != 0) continue;
            entity.ReceiveMessage(message);
        }
    }
}