using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputScript : MonoBehaviour
{
  /*
    
    public List<QuestionOrderScript> QuestionOrder;
    public GameObject[] options;
    public int currentQuestion;

    public Sprite QuestionImage;

    void Start()
    {
        QuestionGenerator();
    }




    void QuestionAnswer()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetComponent<Sprite>.sprite = QuestionOrder[currentQuestion].Answer[i];

            if(QuestionOrder[currentQuestion].CorrentAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }

    void QuestionGenerator()
    {
        currentQuestion = Random.Range(0, QuestionOrder.Count);

        QuestionImage.sprite = QuestionOrder[currentQuestion].Question;

        SetAnswers();

        QuestionOrder.RemoveAt(currentQuestion);
    }

   





}
