using Itmo.ObjectOrientedProgramming.Lab3.Builders;
using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Xunit;

namespace Lab3.Tests;

public class Test3
{
    [Fact]
    public void CheckReadMessageError()
    {
        // Arrange
        var user = new User();
        var message = new Message("Labwork", "Hello World!", 1);
        Topic topic = new TopicBuilder()
            .SetName("topic")
            .AddRecipient(new RecipientBuilder()
                .SetEntity(user)
                .GetResult())
            .GetResult();

        // Act
        topic.SendMessage(message);
        user.ReadMessage(message);

        // Assert
        Assert.False(user.ReadMessage(message));
    }
}