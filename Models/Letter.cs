using System;
using System.ComponentModel.DataAnnotations;

namespace LetterManagement.Models
{
    public class Letter
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Subject { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Sender { get; set; }

        [Required]
        public string Receiver { get; set; }

        public bool IsOutgoing { get; set; }
    }
}