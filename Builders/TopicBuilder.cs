using Itmo.ObjectOrientedProgramming.Lab3.Composite;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab3.Builders;

public class TopicBuilder
{
    private string? _name;

    private Collection<IComposite> _recipients = new();

    public TopicBuilder SetName(string name)
    {
        _name = name;
        return this;
    }

    public TopicBuilder SetRecipients(Collection<IComposite> recipients)
    {
        _recipients = recipients;
        return this;
    }

    public TopicBuilder AddRecipient(IComposite recipient)
    {
        _recipients.Add(recipient);
        return this;
    }

    public Topic GetResult()
    {
        if (_name == null) throw new Exception("Topic has no name");
        if (_recipients.Count == 0) throw new Exception("Topic has no recipients");
        return new Topic(_name, _recipients);
    }
}