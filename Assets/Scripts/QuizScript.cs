using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizScript : MonoBehaviour
{
    List<string> selectedAnswers = new List<string>();
    int qCount = 0;
    public Text question;
    public Text[] choiceTexts;

    void Start()
    {

        question.text = DataManager.instance.quizList[0].question;
        for (int i = 0; i < choiceTexts.Length; i++){
            choiceTexts[i].text = DataManager.instance.quizList[0].choises[i];
        }
    }

    void ButtonDealing()
    {
        qCount += 1;
        if (DataManager.instance.quizList.ToArray().Length == qCount)
        {
            Result();
            return;
        }
        question.text = DataManager.instance.quizList[qCount].question;
        for (int i = 0; i < choiceTexts.Length; i++)
        {
            choiceTexts[i].text = DataManager.instance.quizList[qCount].choises[i];
        }
    }


    void Result() {
        Destroy(question);
        for (int i = 0; i < choiceTexts.Length; i++)
        {
            Destroy(choiceTexts[i]);
        }
        int point = 0;
        for (int i = 0; i < qCount; i++)
        {
            string answer = DataManager.instance.quizList[i].answer;
            if (selectedAnswers[i] == answer)
            {
                point += 1;
                Debug.Log("○" + selectedAnswers[i]);
            }
            else
            {
                Debug.Log("×" + selectedAnswers[i] + " 正解：" + answer);
            }

        }
        Debug.Log("得点：" + point);
        return;
    }


    public void OnChoiceButtonDown(int i){
        selectedAnswers.Add(choiceTexts[i].text);
        ButtonDealing();
    }
}
