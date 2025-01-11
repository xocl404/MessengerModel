using Itmo.ObjectOrientedProgramming.Lab3.Composite;
using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messages;

public class Topic : IComposite
{
    public string Name { get; }

    private readonly Collection<IComposite> _recipients;

    public Topic(string name, Collection<IComposite> recipients)
    {
        Name = name;
        _recipients = recipients;
    }

    public void SendMessage(Message message)
    {
        for (int i = 0; i < _recipients.Count; ++i)
        {
            _recipients[i].SendMessage(message);
        }
    }
}