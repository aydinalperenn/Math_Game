using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;

public class DortIslem : MonoBehaviour
{
    
    public TextMeshProUGUI firstNumber;
    public TextMeshProUGUI secondNumber;
    public TextMeshProUGUI operation;
    public TextMeshProUGUI check;
    public TextMeshProUGUI numTrue;
    public TextMeshProUGUI numFalse;
    public TextMeshProUGUI puan;
    public TMP_InputField input;
    public Button btnNewQuestion;

    int number1;
    int number2;
    int numT;
    int numF;
    int op;
    int res;
    int numPuan = 0;

    bool isAnswered = false;


    void Start()
    {
        puan.text = "0";
        btnNewQuestion.interactable = false;
        NewQuestion();
    }   


    public void checkAnswer()
    {
        if(isAnswered == false)
        {
            if((input.text == null) || (input.text == ""))    // kullanýcý sayý girmeden enter basarsa hata vermesini önlemek için
            {
                return;
            }

            if (int.Parse(input.text) == res)
            {
                check.text = "True";

                numT++;
                numTrue.text = numT.ToString();

                numPuan += 10;
                puan.text = numPuan.ToString();
            }
            else
            {
                check.text = "False";

                numF++;
                numFalse.text = numF.ToString();

                numPuan -= 5;
                puan.text = numPuan.ToString();
            }
            isAnswered = true;
            btnNewQuestion.interactable = true;
        }
        
    }


    public void NewQuestion()
    {
        isAnswered= false;
        input.text = "";
        check.text = "";
        number1 = Random.Range(1, 20);     // birinci sayý için
        number2 = Random.Range(1, 20);     // ikinci için
        op = Random.Range(1, 5);            // iþlem için

        switch (op)     // operation text atamasý
        {
            case 1:
                operation.text = "+";
                res = number1 + number2;
                break;

            case 2:
                operation.text = "-";
                res = number1 - number2;
                break;

            case 3:
                operation.text = "x";
                res = number1 * number2;
                break;

            case 4:
                operation.text = "/";
                res = number1 / number2;
                break;
        }

        firstNumber.text = number1.ToString();      // sayý 1 atamasý
        secondNumber.text = number2.ToString();     // sayý 2 atamasý

        btnNewQuestion.interactable = false;        // yeni soru butonu inaktif olsun
    }
}
