# Examination System


This repository contains a console-based Examination System built with C# and .NET. The project demonstrates key Object-Oriented Programming (OOP) principles through a flexible system for creating and administering different types of exams and questions.

## Features

*   **Dynamic Exam Creation**: Interactively create exams by specifying the type, duration, and number of questions via the console.
*   **Multiple Exam Types**:
    *   **Final Exam**: Calculates and displays the total grade after all questions are answered.
    *   **Practical Exam**: Provides immediate feedback by showing the correct answer after each question.
*   **Multiple Question Formats**:
    *   Multiple Choice Questions (MCQ) with four options.
    *   True/False (T/F) questions.
*   **Exam Timer**: Measures and displays the total time taken to complete an exam.
*   **OOP Design**: Utilizes abstraction, inheritance, and polymorphism for a modular and extensible structure.

## Core Concepts Illustrated

The project is a practical application of fundamental OOP concepts:

*   **Abstraction**: `Exam` and `QuestionBase` are abstract classes that define a common interface and shared functionality for all exam and question types, respectively.
*   **Inheritance**: `FinalExam` and `PracticalExam` inherit from the `Exam` class. Similarly, `MCQuestions` and `TFQuestion` inherit from the `QuestionBase` class, reusing code and establishing clear relationships.
*   **Polymorphism**: The `ShowExam()` method is implemented differently in the `FinalExam` and `PracticalExam` classes. The system calls the appropriate method at runtime based on the object's actual type.
*   **Encapsulation**: Each class encapsulates its data and behavior, hiding internal complexity. For example, the `Subject` class manages the logic for creating its associated `Exam`.

## Project Structure

The solution is organized into several classes, each with a specific responsibility:

| File              | Description                                                                          |
| ----------------- | ------------------------------------------------------------------------------------ |
| `Program.cs`      | The main entry point of the application. Orchestrates the exam creation and execution process. |
| `Subject.cs`      | Represents a subject and contains the logic (`CreateExam`) to build an exam.        |
| `Exam.cs`         | Abstract base class for all exam types.                                              |
| `FinalExam.cs`    | A concrete `Exam` implementation that grades the user at the end.                    |
| `PracticalExam.cs`| A concrete `Exam` implementation that provides answers after each question.          |
| `QuestionList.cs` | A container class that holds a list of `QuestionBase` objects for an exam.           |
| `QuestionBase.cs` | Abstract base class for all question types.                                          |
| `MCQuestions.cs`  | Represents a Multiple Choice Question.                                               |
| `TFQuestion.cs`   | Represents a True/False Question.                                                    |
| `Answers.cs`      | Represents a single answer option for a question.                                    |

## How to Run

1.  **Clone the repository:**
    ```sh
    git clone https://github.com/Arsany-Naim/Examination_System.git
    ```
2.  **Open the solution:**
    Navigate to the cloned directory and open the `Exam_02_OOP.sln` file in Visual Studio.

3.  **Build the project:**
    Build the solution by pressing `Ctrl+Shift+B` or from the `Build` menu.

4.  **Run the application:**
    Press `F5` or click the "Start" button to run the project.

5.  **Follow the prompts:**
    The console will guide you through the process of setting up and taking an exam. You will be asked to choose an exam type, set the time, and define each question and its correct answer.
