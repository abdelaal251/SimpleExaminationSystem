namespace ExaminationSystem.Models
{
    public abstract class Question
    {
        public string Body { get; set; }
        public int Marks { get; set; }
        public string Header { get; set; }
        public AnswerList Answers { get; set; }

        public abstract void Display();
    }
}
