using System.ComponentModel.DataAnnotations;

namespace StudentTest.Models
{
    public class TestSubmission
    {
        public int QuestionId { get; set; }

        [Key]
        public int SelectedAnswerId { get; set; }

        public Question Question { get; set; }// navigation Property


    }
}