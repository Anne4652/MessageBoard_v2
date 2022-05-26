using MessageBoard.Models;
using MessageBoard.Data.Interfaces;

namespace MessageBoard.Data.Repositories
{
    public class MessageRepository : Repository<Message>, IMessageRepository
    {
        public MessageRepository(BoardDbContext context) : base(context)
        {
        }
    }
}
