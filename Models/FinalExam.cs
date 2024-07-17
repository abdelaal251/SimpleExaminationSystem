using System;

namespace ExaminationSystem.Models
{
    public class FinalExam : Exam
    {
        public FinalExam(int time, int numberOfQuestions)
            : base(time, numberOfQuestions)
        {
            Mode = ExamMode.Starting;
            OnExamModeChanged(Mode);
        }

        public override void ShowExam()
        {
            Console.WriteLine("Showing Final Exam");
            foreach (var question in Questions)
            {
                question.Display();
            }
            Mode = ExamMode.Finished;
            OnExamModeChanged(Mode);
            // Do not show correct answers
        }
    }
}
