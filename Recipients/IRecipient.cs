using Itmo.ObjectOrientedProgramming.Lab3.Composite;
using Itmo.ObjectOrientedProgramming.Lab3.Logging;

namespace Itmo.ObjectOrientedProgramming.Lab3.Recipients;

public interface IRecipient : IComposite
{
    Logger Logger { get; }

    int AcceptableImportanceLevel { get; }
}