using MessageBoard.Services.Interfaces;
using MessageBoard.Data.Interfaces;


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
    }
}
