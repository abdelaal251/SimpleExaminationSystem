using System;
using System.Collections.Generic;

namespace ExaminationSystem.Models
{
    public enum ExamMode
    {
        Starting,
        Queued,
        Finished
    }

    public abstract class Exam : ICloneable, IComparable<Exam>
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Dictionary<Question, Answer> QuestionAnswerDictionary { get; set; } = new();
        public ExamMode Mode { get; set; }
        public Subject Subject { get; set; }
        public QuestionList Questions { get; set; }

        // Constructor that takes time and numberOfQuestions as parameters
        protected Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
        }

        public delegate void ExamModeChangedEventHandler(object sender, ExamMode mode);
        public event ExamModeChangedEventHandler ExamModeChanged;

        protected void OnExamModeChanged(ExamMode mode)
        {
            ExamModeChanged?.Invoke(this, mode);
        }

        public abstract void ShowExam();

        public object Clone()
        {
            Exam clone = (Exam)this.MemberwiseClone();
            clone.QuestionAnswerDictionary = new Dictionary<Question, Answer>(this.QuestionAnswerDictionary);
            return clone;
        }

        public int CompareTo(Exam other)
        {
            if (other == null) return 1;
            int timeComparison = this.Time.CompareTo(other.Time);
            if (timeComparison != 0) return timeComparison;
            return this.NumberOfQuestions.CompareTo(other.NumberOfQuestions);
        }

        public override string ToString()
        {
            return $"Exam with {NumberOfQuestions} questions and duration of {Time} minutes.";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Exam other = (Exam)obj;
            return this.Time == other.Time && this.NumberOfQuestions == other.NumberOfQuestions;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Time, NumberOfQuestions);
        }
    }
}
