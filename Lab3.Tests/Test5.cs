using Itmo.ObjectOrientedProgramming.Lab3.Builders;
using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.ForeignDisplay;
using Itmo.ObjectOrientedProgramming.Lab3.Logging;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Moq;
using Xunit;

namespace Lab3.Tests;

public class Test5
{
    [Fact]
    public void CheckLogging()
    {
        // Arrange
        var mock = new Mock<Logger>();
        var message = new Message("Labwork", "Hello World!", 1);
        Topic topic = new TopicBuilder()
            .SetName("topic")
            .AddRecipient(new RecipientBuilder()
                .SetEntity(new DisplayAdapter(new Display()))
                .SetLogger(mock.Object)
                .GetResult())
            .GetResult();

        // Act
        topic.SendMessage(message);

        // Assert
        mock.Verify(logger => logger.AddLog(message), Times.Once());
    }
}