using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataLoader {
    public List<Quiz> LoadQuiz() {
        List<Quiz> quizList = new List<Quiz>();
        string[,] data = CSVManager.ReadCsvFile("QuizData/QuizData.csv");
        for (int i = 1; i < 6; i++)
        {
            int id = int.Parse(data[i, 0]);
            string question = data[i, 1];
            string[] choices = new string[] { data[i, 2], data[i, 3], data[i, 4], data[i, 5] };
            string answer = data[i, 6];
            Quiz quiz = new Quiz(id, question, choices, answer);
            quizList.Add(quiz);
        }
        return quizList;
    }
}
