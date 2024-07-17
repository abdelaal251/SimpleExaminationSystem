using ExaminationSystem.Models;
using System;
using System.Collections.Generic;

namespace ExaminationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Exam Type: 1. Practice 2. Final");
            int choice = int.Parse(Console.ReadLine());

            Exam exam;
            if (choice == 1)
            {
                exam = new PracticeExam(60, 10); // 60 minutes, 10 questions
            }
            else
            {
                exam = new FinalExam(60, 10); // 60 minutes, 10 questions
            }

            Subject subject = new Subject("Mathematics", "MATH101");
            exam.Subject = subject;

            AddQuestions(exam);

            exam.ShowExam();
        }

        static void AddQuestions(Exam exam)
        {
            QuestionList questionList = new QuestionList($"exam_{exam.GetHashCode()}.txt");

            TrueFalseQuestion tfQuestion = new TrueFalseQuestion
            {
                Header = "Q1",
                Body = "Is the Earth round?",
                Marks = 1,
                CorrectAnswer = true
            };
            questionList.Add(tfQuestion);

            ChooseOneQuestion coQuestion = new ChooseOneQuestion
            {
                Header = "Q2",
                Body = "What is the capital of France?",
                Marks = 2,
                Options = new List<string> { "Paris", "London", "Berlin", "Madrid" },
                CorrectAnswer = "Paris"
            };
            questionList.Add(coQuestion);

            ChooseAllQuestion caQuestion = new ChooseAllQuestion
            {
                Header = "Q3",
                Body = "Which of the following are even numbers?",
                Marks = 3,
                Options = new List<string> { "2", "3", "4", "5" },
                CorrectAnswers = new List<string> { "2", "4" }
            };
            questionList.Add(caQuestion);

            exam.Questions = questionList;
        }
    }
}
