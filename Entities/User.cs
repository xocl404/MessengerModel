using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities;

public class User : Entity
{
    private readonly Collection<Message> _messages = new();

    private readonly Collection<bool> _isReadMessages = new();

    public override void ReceiveMessage(Message message)
    {
        _messages.Add(message);
        _isReadMessages.Add(false);
    }

    public bool CheckIsHaveMessage(Message message)
    {
        for (int i = 0; i < _messages.Count; ++i)
        {
            if (_messages[i] == message)
            {
                return true;
            }
        }

        return false;
    }

    public bool CheckIsReadMessage(Message message)
    {
        for (int i = 0; i < _messages.Count; ++i)
        {
            if (_messages[i] == message)
            {
                return _isReadMessages[i];
            }
        }

        return false;
    }

    public int GetCountOfUnReadMessages()
    {
        int count = 0;
        for (int i = 0; i < _isReadMessages.Count; ++i)
        {
            if (!_isReadMessages[i]) count++;
        }

        return count;
    }

    public bool ReadMessage(Message message)
    {
        for (int i = 0; i < _messages.Count; ++i)
        {
            if (_messages[i] == message)
            {
                if (_isReadMessages[i]) return false;
                _isReadMessages[i] = true;
                return true;
            }
        }

        return false;
    }
}