using System.Collections.Generic;
using System.IO;

namespace ExaminationSystem.Models
{
    public class QuestionList : List<Question>
    {
        private readonly string _filePath;

        public QuestionList(string filePath)
        {
            _filePath = filePath;
        }

        public new void Add(Question question)
        {
            base.Add(question);
            LogQuestionToFile(question);
        }

        private void LogQuestionToFile(Question question)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine($"{question.Header}: {question.Body}");
            }
        }
    }
}
