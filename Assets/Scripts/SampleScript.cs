using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScript : MonoBehaviour {

    List<Quiz> quizlist = new List<Quiz>();


    void Start()
    {

        Quiz quiz = new Quiz("hoge","hogehoge",1);
        quiz.question = "fuga";
        Debug.Log(quiz.question);

        quizlist.Add(quiz);
        Debug.Log(quizlist[0].answerIndex);

    }
	
}
