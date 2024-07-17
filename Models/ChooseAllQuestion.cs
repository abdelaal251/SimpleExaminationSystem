using System;
using System.Collections.Generic;

namespace ExaminationSystem.Models
{
    public class ChooseAllQuestion : Question
    {
        public List<string> Options { get; set; }
        public List<string> CorrectAnswers { get; set; }

        public override void Display()
        {
            Console.WriteLine($"{Header} - {Body}");
            foreach (var option in Options)
            {
                Console.WriteLine(option);
            }
        }

        public override string GetCorrectAnswer()
        {
            return string.Join(", ", CorrectAnswers);
        }
    }
}
