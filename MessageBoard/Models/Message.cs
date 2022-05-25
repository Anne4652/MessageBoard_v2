using System.ComponentModel.DataAnnotations;
using MessageBoard.Data.Enums;

namespace MessageBoard.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public MessageCategory Category { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }
        public virtual BoardUser User { get; set; } 
    }
}
