using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizScript : MonoBehaviour
{

    List<Quiz> quizlist = new List<Quiz>();
    List<string> answers = new List<string>();
    int q_count = 0;
    public Text question;
    public Text[] choiceTexts;


    void Start()
    {
        string[,] data = CSVManager.ReadCsvFile("QuizData/QuizData.csv");
        for (int i = 1; i < 6; i++)
        {
            Quiz quiz = new Quiz(int.Parse(data[i, 0]), data[i, 1], data[i, 2], data[i, 3], data[i, 4], data[i, 5], data[i, 6]);
            quizlist.Add(quiz);
        }
        question.text = quizlist[0].question;
        choiceTexts[0].text = quizlist[0].slc1;
        choiceTexts[1].text = quizlist[0].slc2;
        choiceTexts[2].text = quizlist[0].slc3;
        choiceTexts[3].text = quizlist[0].slc4;
    }

    void buttonDealing()
    {
        q_count += 1;
        if (quizlist.ToArray().Length == q_count)
        {
            for (int i =0; i < q_count; i++)
            {
                Debug.Log(answers[i]);
            }
            return;
        }
        question.text = quizlist[q_count].question;
        choiceTexts[0].text = quizlist[q_count].slc1;
        choiceTexts[1].text = quizlist[q_count].slc2;
        choiceTexts[2].text = quizlist[q_count].slc3;
        choiceTexts[3].text = quizlist[q_count].slc4;
    }

    public void OnChoiceButtonDown(int i){
        answers.Add(choiceTexts[i].text);
        buttonDealing();
    }
}
