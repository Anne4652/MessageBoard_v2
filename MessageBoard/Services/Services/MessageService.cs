using MessageBoard.Services.Interfaces;
using MessageBoard.Data.Interfaces;
using MessageBoard.Data.Repositories;
using MessageBoard.Models;
using MessageBoard.Data;

namespace MessageBoard.Services.Services
{
    public class MessageService : IMessageService
    {
        private readonly ILogger<MessageService> _logger;
        private readonly IMessageRepository _messageRepository;

        public MessageService()
        {
          
            _messageRepository = new MessageRepository(new BoardDbContext());
        }

        public async Task AddNewMessage(Message message)
        {
            await _messageRepository.CreateAsync(message);
            await _messageRepository.SaveAsync();
        }

        public async Task RemoveMessage(Message message)
        {
            _messageRepository.Delete(message);
            await _messageRepository.SaveAsync();

        }
    }
}
