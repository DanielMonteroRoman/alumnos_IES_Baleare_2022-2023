using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnswerData : MonoBehaviour
{
    public TMP_Text answerText;
    public string text;

    public bool itsCorrect;

    private void Awake()
    {
        answerText = GetComponentInChildren<TMP_Text>();

        answerText.text = text;


    }

}
