using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizScript : MonoBehaviour
{

    List<Quiz> quizlist = new List<Quiz>();

    void Start()
    {
        string[,] data = CSVManager.ReadCsvFile("quizData/quizData.csv");
        for (int i = 1; i < 6; i++)
        {
            Quiz quiz = new Quiz(int.Parse(data[i, 0]), data[i, 1], data[i, 2], data[i, 3], data[i, 4], data[i, 5], data[i, 6]);
            quizlist.Add(quiz);
        }
        //for (int i = 0; i < 5; i++)
        //{
        //    Debug.Log(quizlist[i].question);
        //}
    }
}
