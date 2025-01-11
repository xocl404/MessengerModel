using Itmo.ObjectOrientedProgramming.Lab3.Builders;
using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Xunit;

namespace Lab3.Tests;

public class Test7
{
    [Fact]
    public void CheckImportanceFilter()
    {
        // Arrange
        var user = new User();
        var message = new Message("Labwork", "Hello World!", 10);
        Topic topic = new TopicBuilder()
            .SetName("topic")
            .AddRecipient(new RecipientBuilder()
                .SetEntity(user)
                .SetAcceptableImportanceLevel(1)
                .GetResult())
            .AddRecipient(new RecipientBuilder()
                .SetEntity(user)
                .GetResult())
            .GetResult();

        // Act
        topic.SendMessage(message);

        // Assert
        Assert.Equal(1, user.GetCountOfUnReadMessages());
    }
}