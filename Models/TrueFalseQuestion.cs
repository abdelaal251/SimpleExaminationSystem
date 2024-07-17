using System;

namespace ExaminationSystem.Models
{
    public class TrueFalseQuestion : Question
    {
        public bool CorrectAnswer { get; set; }

        public override void Display()
        {
            Console.WriteLine($"{Header} - {Body} (True/False)");
        }

        public override string GetCorrectAnswer()
        {
            return CorrectAnswer.ToString();
        }
    }
}
