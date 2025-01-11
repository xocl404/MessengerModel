using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Logging;
using Itmo.ObjectOrientedProgramming.Lab3.Recipients;
using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab3.Builders;

public class RecipientGroupBuilder
{
    private Collection<Entity> _entities = new();

    private Logger? _logger;

    private int _acceptableImportanceLevel;

    public RecipientGroupBuilder SetEntities(Collection<Entity> entities)
    {
        _entities = entities;
        return this;
    }

    public RecipientGroupBuilder AddEntity(Entity entity)
    {
        _entities.Add(entity);
        return this;
    }

    public RecipientGroupBuilder SetLogger(Logger logger)
    {
        _logger = logger;
        return this;
    }

    public RecipientGroupBuilder SetAcceptableImportanceLevel(int acceptableImportanceLevel)
    {
        _acceptableImportanceLevel = acceptableImportanceLevel;
        return this;
    }

    public RecipientGroup GetResult()
    {
        if (_entities.Count == 0) throw new Exception("Recipient group has no entities");
        if (_logger == null) _logger = new Logger();
        return new RecipientGroup(_entities, _logger, _acceptableImportanceLevel);
    }
}