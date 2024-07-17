using System;

namespace ExaminationSystem.Models
{
    public class PracticeExam : Exam
    {
        public PracticeExam(int time, int numberOfQuestions)
            : base(time, numberOfQuestions)
        {
            Mode = ExamMode.Starting;
            OnExamModeChanged(Mode);
        }

        public override void ShowExam()
        {
            Console.WriteLine("Showing Practice Exam");
            foreach (var question in Questions)
            {
                question.Display();
            }
            Mode = ExamMode.Finished;
            OnExamModeChanged(Mode);
            // Show correct answers after completion
            foreach (var kvp in QuestionAnswerDictionary)
            {
                Console.WriteLine($"Question: {kvp.Key.Body}, Correct Answer: {kvp.Value.AnswerText}");
            }
        }
    }
}
