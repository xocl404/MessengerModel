using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities;

public abstract class Entity
{
    public virtual void ReceiveMessage(Message message)
    {
    }
}