using MessageBoard.Models;

namespace MessageBoard.Services.Interfaces
{
    public interface IMessageService
    {
        Task AddNewMessage(Message message);
    }
}
