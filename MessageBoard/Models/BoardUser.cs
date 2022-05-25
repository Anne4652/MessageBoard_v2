﻿using System.ComponentModel.DataAnnotations;

namespace MessageBoard.Models
{
    public class BoardUser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }
}
