namespace ExaminationSystem.Models
{
    public class Subject
    {
        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }

        public Subject(string name, string code)
        {
            SubjectName = name;
            SubjectCode = code;
        }

        public override string ToString()
        {
            return $"{SubjectName} ({SubjectCode})";
        }
    }
}
