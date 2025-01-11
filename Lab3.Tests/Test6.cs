using Itmo.ObjectOrientedProgramming.Lab3.Builders;
using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.ForeignMessenger;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Moq;
using Xunit;

namespace Lab3.Tests;

public class Test6
{
    [Fact]
    public void CheckPrintMessage()
    {
        // Arrange
        var mock = new Mock<Messenger>();
        var messengerAdapter = new MessengerAdapter(mock.Object);
        var message = new Message("Labwork", "Hello World!", 1);
        Topic topic = new TopicBuilder()
            .SetName("topic")
            .AddRecipient(new RecipientBuilder()
                .SetEntity(messengerAdapter)
                .GetResult())
            .GetResult();

        // Act
        topic.SendMessage(message);
        messengerAdapter.PrintMessage();

        // Assert
        mock.Verify(messenger => messenger.PrintMessage(message), Times.Once());
    }
}