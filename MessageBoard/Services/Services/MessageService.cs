using MessageBoard.Services.Interfaces;
using MessageBoard.Data.Interfaces;
using MessageBoard.Models;

namespace MessageBoard.Services.Services
{
    public class MessageService : IMessageService
    {
        private readonly ILogger<MessageService> _logger;
        private readonly IMessageRepository _messageRepository;

        public MessageService(ILogger<MessageService> logger, IMessageRepository messageRepository)
        {
            _logger = logger;
            _messageRepository = messageRepository;
        }

        public async Task AddNewMessage(Message message)
        {
            await _messageRepository.CreateAsync(message);
            await _messageRepository.SaveAsync();
        }
    }
}
