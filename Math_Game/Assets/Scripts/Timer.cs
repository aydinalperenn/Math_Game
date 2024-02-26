using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI text;
    public bool isCounting;
    public float timer;



    // Timer dolduðunda SetActive'leri false yapmak için
    public Button button;
    public Button buttonExit;

    public TextMeshProUGUI firstNumber;
    public TextMeshProUGUI secondNumber;
    public TextMeshProUGUI operation;
    public TextMeshProUGUI equal;
    public TextMeshProUGUI check;
    public TMP_InputField input;
    public Button newQuestion;

    public TextMeshProUGUI numTrue;
    public TextMeshProUGUI numFalse;



    void Start()
    {
        timer = 60;
        isCounting = false;
        text.text = "60";
        CountToggle();  
    }


    void Update()
    {
        if(isCounting)
        {
            Count();
        }
        
    }


    private void Count()
    {
               
        timer -= Time.deltaTime;
        int sec = Mathf.FloorToInt(timer % 60f);
        Display(sec);
        
        if(sec == 0)
        {
            CountToggle();

            button.gameObject.SetActive(true);
            buttonExit.gameObject.SetActive(true);

            firstNumber.gameObject.SetActive(false);
            secondNumber.gameObject.SetActive(false);
            operation.gameObject.SetActive(false);
            equal.gameObject.SetActive(false);
            check.gameObject.SetActive(false);
            input.gameObject.SetActive(false);
            newQuestion.gameObject.SetActive(false);
            
        }
        
    }

    private void Display(int s)
    {
        text.text = s.ToString();
    }

    public void CountToggle()
    {
        isCounting = !isCounting;
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitApp()
    {
        SceneManager.LoadScene(0);
    }
}
