namespace ExaminationSystem.Models
{
    public abstract class Question
    {
        public string Body { get; set; }
        public int Marks { get; set; }
        public string Header { get; set; }
        public AnswerList Answers { get; set; } = new AnswerList();

        public abstract void Display();

        // Method to get the correct answer as a string
        public abstract string GetCorrectAnswer();
    }
}
