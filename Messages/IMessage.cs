namespace Itmo.ObjectOrientedProgramming.Lab3.Messages;

public interface IMessage
{
    string Header { get; }

    string Text { get; }

    int ImportanceLevel { get; }
}