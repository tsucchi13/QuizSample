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
            for (int i =0; i < qCount; i++)
            {
                Debug.Log(selectedAnswers[i]);
            }
            return;
        }
        question.text = DataManager.instance.quizList[qCount].question;
        for (int i = 0; i < choiceTexts.Length; i++)
        {
            choiceTexts[i].text = DataManager.instance.quizList[qCount].choises[i];
        }
    }

    public void OnChoiceButtonDown(int i){
        selectedAnswers.Add(choiceTexts[i].text);
        ButtonDealing();
    }
}
