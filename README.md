# Examination System

## Overview

This project is an Examination System built with .NET 5. It allows users to create, manage, and take different types of exams. The main functionalities include:

- **Exam Types**: Support for Practice Exams and Final Exams.
- **Question Types**: Includes True/False, Choose One, and Choose All question types.
- **Exam Management**: Add questions to exams, set exam modes (Starting, Queued, Finished), and notify students about exam statuses.
- **Answer Evaluation**: For Practice Exams, show correct answers after completion.

## Main Functionalities

1. **User Interface**:
   - Select the type of exam (Practice or Final).
   - Display exam questions to the user.
   
2. **Exam Management**:
   - Create and manage different types of exams.
   - Add various types of questions to the exams.
   - Track exam status and notify students.

3. **Question Types**:
   - True/False Questions
   - Choose One Question from multiple options
   - Choose All correct options from multiple choices

4. **Notification System**:
   - Notify students when the exam starts and finishes using events and delegates.

## Sequence Diagram

For a detailed sequence of the application flow, including initial data assumptions and the event and notification system, refer to the [Sequence Diagram PDF](Docs/ExaminationSystemproject.pdf).

## Running the Project

1. Ensure you have .NET 5 installed on your machine.
2. Clone the repository.
3. Build and run the project using your preferred IDE or command line.

```
dotnet build
dotnet run
```
