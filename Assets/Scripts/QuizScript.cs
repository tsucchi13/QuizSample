using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizScript : MonoBehaviour
{

    List<Quiz> quizlist = new List<Quiz>();
    List<string> answers = new List<string>();
    int qCount = 0;
    public Text question;
    public Text[] choiceTexts;


    void Start()
    {
        string[,] data = CSVManager.ReadCsvFile("QuizData/QuizData.csv");
        for (int i = 1; i < 6; i++)
        {
            int id = int.Parse(data[i, 0]);
            string question = data[i, 1];
            string[] choices = new string[] { data[i, 2], data[i, 3], data[i, 4], data[i, 5] };
            string answer = data[i, 6];
            Quiz quiz = new Quiz(id, question, choices, answer);
            quizlist.Add(quiz);
        }
        question.text = quizlist[0].question;
        for (int i = 0; i < choiceTexts.Length; i++){
            choiceTexts[i].text = quizlist[0].choises[i];
        }
    }

    void ButtonDealing()
    {
        qCount += 1;
        if (quizlist.ToArray().Length == qCount)
        {
            for (int i =0; i < qCount; i++)
            {
                Debug.Log(answers[i]);
            }
            return;
        }
        question.text = quizlist[qCount].question;
        for (int i = 0; i < choiceTexts.Length; i++)
        {
            choiceTexts[i].text = quizlist[qCount].choises[i];
        }
    }

    public void OnChoiceButtonDown(int i){
        answers.Add(choiceTexts[i].text);
        ButtonDealing();
    }
}
