using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Logging;
using Itmo.ObjectOrientedProgramming.Lab3.Recipients;

namespace Itmo.ObjectOrientedProgramming.Lab3.Builders;

public class RecipientBuilder
{
    private Entity? _entity;

    private Logger? _logger;

    private int _acceptableImportanceLevel;

    public RecipientBuilder SetEntity(Entity entity)
    {
        _entity = entity;
        return this;
    }

    public RecipientBuilder SetLogger(Logger logger)
    {
        _logger = logger;
        return this;
    }

    public RecipientBuilder SetAcceptableImportanceLevel(int acceptableImportanceLevel)
    {
        _acceptableImportanceLevel = acceptableImportanceLevel;
        return this;
    }

    public Recipient GetResult()
    {
        if (_entity == null) throw new Exception("Recipient has no entity");
        if (_logger == null) _logger = new Logger();
        return new Recipient(_entity, _logger, _acceptableImportanceLevel);
    }
}