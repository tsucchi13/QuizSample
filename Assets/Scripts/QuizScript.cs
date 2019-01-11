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
    public Text slc1;
    public Text slc2;
    public Text slc3;
    public Text slc4;


    void Start()
    {
        string[,] data = CSVManager.ReadCsvFile("quizData/quizData.csv");
        for (int i = 1; i < 6; i++)
        {
            Quiz quiz = new Quiz(int.Parse(data[i, 0]), data[i, 1], data[i, 2], data[i, 3], data[i, 4], data[i, 5], data[i, 6]);
            quizlist.Add(quiz);
        }
        question.text = quizlist[0].question;
        slc1.text = quizlist[0].slc1;
        slc2.text = quizlist[0].slc2;
        slc3.text = quizlist[0].slc3;
        slc4.text = quizlist[0].slc4;
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
        slc1.text = quizlist[q_count].slc1;
        slc2.text = quizlist[q_count].slc2;
        slc3.text = quizlist[q_count].slc3;
        slc4.text = quizlist[q_count].slc4;
    }

    public void slc1Button()
    {
        answers.Add(slc1.text);
        buttonDealing();
    }
    public void slc2Button()
    {
        answers.Add(slc2.text);
        buttonDealing();
    }
    public void slc3Button()
    {
        answers.Add(slc3.text);
        buttonDealing();
    }
    public void slc4Button()
    {
        answers.Add(slc4.text);
        buttonDealing();
    }
}
