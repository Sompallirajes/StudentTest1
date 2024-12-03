using System.ComponentModel.DataAnnotations;

namespace StudentTest.Models
{
    public class Answer
    {
        [Key]
        public int AnswerId { get; set; }

        [Required]
        public string AnswerText { get; set; }

        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }

        public Question Question { get; set; } // Navigation property

    }
}
