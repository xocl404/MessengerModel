using Itmo.ObjectOrientedProgramming.Lab3.Builders;
using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Moq;
using Xunit;

namespace Lab3.Tests;

public class Test4
{
    [Fact]
    public void CheckImportanceFilter()
    {
        // Arrange
        var mock = new Mock<User>();
        var message = new Message("Labwork", "Hello World!", 10);
        Topic topic = new TopicBuilder()
            .SetName("topic")
            .AddRecipient(new RecipientBuilder()
                .SetEntity(mock.Object)
                .SetAcceptableImportanceLevel(1)
                .GetResult())
            .GetResult();

        // Act
        topic.SendMessage(message);

        // Assert
        mock.Verify(user => user.ReceiveMessage(message), Times.Never);
    }
}