using System;
using System.ComponentModel.DataAnnotations;

namespace ExpenseTrackerAPI.Models
{
    public class Expense
    {
        public int Id { get; set; }

        [Required]
        public required string Title { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public required string Category { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
